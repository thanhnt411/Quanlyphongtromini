using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlyphongtromini.UserControls
{
    public partial class HoaDonControl : UserControl
    {
        private const string connectionString =
        //@"Server=LAPTOP-71REBECI;Database=QlPhongTro;Trusted_Connection=True;TrustServerCertificate=True;";
        @"Server=localhost\SQLEXPRESS;Database=QLPhongTro;Trusted_Connection=True;TrustServerCertificate=True;";

        // Mã dịch vụ Điện, Nước trong bảng DichVu: giá điện/nước lấy từ 2 dòng này
        // (đổi giá ở trang Dịch vụ). Nếu bảng DichVu của bạn dùng mã khác thì sửa 2 dòng dưới cho khớp.
        private const string MA_DV_DIEN = "DIEN";
        private const string MA_DV_NUOC = "NUOC";

        private decimal? giaDien;    // null = chưa có dòng Điện trong bảng DichVu
        private decimal? giaNuoc;    // null = chưa có dòng Nước trong bảng DichVu

        // true khi đang nạp dữ liệu bằng code (bấm dòng bảng, nạp lại danh sách...)
        // để các sự kiện tự tính / tự điền không chạy chen vào
        private bool dangNapForm = false;

        // Giá phòng đã tra, tránh truy vấn lại DB mỗi lần gõ phím
        private readonly Dictionary<string, decimal> cacheGiaPhong = new Dictionary<string, decimal>();

        // Một dòng trong danh sách tích chọn dịch vụ
        private class DichVuItem
        {
            public string MaDV;
            public string TenDV;
            public decimal DonGia;
            public override string ToString() => $"{TenDV} - {DonGia:N0}đ";
        }

        public HoaDonControl()
        {
            InitializeComponent();

            // Tổng cộng tự cập nhật khi gõ chỉ số
            EventHandler capNhat = (s, e) => CapNhatTong();
            txtDienCu.TextChanged += capNhat;
            txtDienMoi.TextChanged += capNhat;
            txtNuocCu.TextChanged += capNhat;
            txtNuocMoi.TextChanged += capNhat;

            clbDichVu.ItemCheck += clbDichVu_ItemCheck;
            dtpThangNam.ValueChanged += (s, e) => TuDienChiSoCu();

            // Mỗi lần quay lại trang Hóa đơn thì nạp lại giá dịch vụ / giá phòng mới nhất
            VisibleChanged += (s, e) =>
            {
                if (Visible && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
                    LoadDichVu();
            };
        }

        // ================= LOAD DỮ LIỆU =================

        private void HoaDonControl_Load(object sender, EventArgs e)
        {
            // Không truy cập DB khi đang mở ở chế độ Design
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            dgvHoaDon.AutoGenerateColumns = false;
            LoadDuLieu("");
            LoadComboBox();
            LoadDichVu();
        }

        private void LoadDuLieu(string tukhoa)
        {
            //b1 ket noi database
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            //b2 tao doi tuong command de thuc hien cau lenh sql
            // (dung AS de doi ten cot cho khop voi DataPropertyName trong Designer)
            // JOIN HopDong + NguoiThue de lay ten nguoi thue hien tren bang
            string sql = "SELECT hd.MaHoaDon, hd.MaHD AS MaHopDong, n.Hoten AS HoTen, hd.MaPhong, " +
                "hd.ThoiGian AS ThangNam, " +
                "hd.DienMoi - hd.DienCu AS DienTieuThu, " +
                "hd.NuocMoi - hd.NuocCu AS NuocTieuThu, " +
                "hd.PhiDV AS PhiDichVu, hd.Tong AS TongTien, hd.TrangThai, " +
                "hd.DienCu, hd.DienMoi, hd.NuocCu, hd.NuocMoi " +
                "FROM HoaDon hd " +
                "LEFT JOIN HopDong h ON hd.MaHD = h.MaHD " +
                "LEFT JOIN NguoiThue n ON h.MaNguoi = n.MaNguoi " +
                "WHERE hd.MaHoaDon LIKE N'%' + @tukhoa + N'%' " +
                "OR hd.MaHD LIKE N'%' + @tukhoa + N'%' " +
                "OR n.Hoten LIKE N'%' + @tukhoa + N'%' " +
                "OR hd.MaPhong LIKE N'%' + @tukhoa + N'%' " +
                "OR FORMAT(hd.ThoiGian, 'MM/yyyy') LIKE N'%' + @tukhoa + N'%' " +
                "ORDER BY hd.ThoiGian DESC";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@tukhoa", SqlDbType.NVarChar, 50).Value = tukhoa;

            //b3 tao doi tuong dataadapter de chuyen du lieu ra ngoai DB
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //b4 tao doi tuong datatable de nhan du lieu tu dataadapter
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            conn.Close();

            //b5 do du lieu tu datatable vao datagridview
            dgvHoaDon.DataSource = tb;
            dgvHoaDon.Refresh();
        }

        private void LoadComboBox()
        {
            //b1 ket noi database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                //b2 lay du lieu ve tu bang phong tro
                SqlDataAdapter daPhong = new SqlDataAdapter("SELECT MaPhong FROM PhongTro", conn);
                DataTable tbPhong = new DataTable();
                daPhong.Fill(tbPhong);

                cboPhong.DataSource = tbPhong;
                cboPhong.DisplayMember = "MaPhong";
                cboPhong.ValueMember = "MaPhong";
                cboPhong.SelectedIndex = -1;
            }

            //b3 do du lieu vao combobox nguoi thue
            LoadNguoiThue("");
        }

        // Đổ người thuê của các hợp đồng "Còn hạn" vào cboNguoiThue
        // (hiện Họ tên, giá trị thật là MaHD nên phần lưu DB không đổi)
        // maHDCanChon: mã hợp đồng của hóa đơn đang xem (có thể đã "Hết hạn" nhưng vẫn phải có trong list,
        // nếu không combobox sẽ không hiện được người thuê của hóa đơn cũ). Không cần thì truyền "".
        // maPhong: khác rỗng thì CHỈ liệt kê người thuê của phòng đó (không hiện người của phòng khác);
        // để rỗng thì liệt kê tất cả người thuê đang còn hợp đồng.
        private void LoadNguoiThue(string maHDCanChon, string maPhong = "")
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT h.MaHD, n.Hoten FROM HopDong h " +
                "JOIN NguoiThue n ON h.MaNguoi = n.MaNguoi " +
                "WHERE h.MaHD = @maHDCanChon " +
                "OR (h.TrangThai = N'Còn hạn' AND (@maPhong = N'' OR h.MaPhong = @maPhong)) " +
                "ORDER BY n.Hoten";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@maHDCanChon", SqlDbType.NVarChar, 50).Value = maHDCanChon;
            cmd.Parameters.Add("@maPhong", SqlDbType.NVarChar, 50).Value = maPhong;

            DataTable tb = new DataTable();
            new SqlDataAdapter(cmd).Fill(tb);

            cboNguoiThue.DataSource = tb;
            cboNguoiThue.DisplayMember = "Hoten";
            cboNguoiThue.ValueMember = "MaHD";
            cboNguoiThue.SelectedIndex = -1;
        }

        // Chọn mã phòng -> tự hiện người thuê của hợp đồng "Còn hạn" của phòng đó
        // (dung SelectionChangeCommitted: chi chay khi NGUOI DUNG chon, nen khong bi lap vo han)
        private void cboPhong_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //b1 lay du lieu
            string phong = cboPhong.SelectedValue?.ToString() ?? "";

            //b2 ket noi database
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            //b3 lay hop dong con han moi nhat cua phong
            string sql = "SELECT TOP 1 MaHD FROM HopDong " +
                "WHERE MaPhong = @phong AND TrangThai = N'Còn hạn' " +
                "ORDER BY DayStart DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@phong", SqlDbType.NVarChar, 50).Value = phong;

            object kq = cmd.ExecuteScalar();
            cmd.Dispose();
            conn.Close();

            //b4 chi liet ke nguoi thue cua phong nay (khong hien nguoi cua phong khac), roi chon nguoi do
            LoadNguoiThue("", phong);
            if (kq == null)
            {
                cboNguoiThue.SelectedIndex = -1;
                MessageBox.Show("Phòng này chưa có hợp đồng còn hạn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cboNguoiThue.SelectedValue = kq.ToString();
            }

            //b5 tu dien so dien/nuoc cu theo hoa don truoc cua phong
            TuDienChiSoCu();
        }

        // Chọn người thuê -> tự hiện mã phòng của hợp đồng đó
        private void cboNguoiThue_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //b1 lay du lieu (gia tri cua combobox la MaHD)
            string maHD = cboNguoiThue.SelectedValue?.ToString() ?? "";

            //b2 ket noi database
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            //b3 lay ma phong cua hop dong
            string sql = "SELECT MaPhong FROM HopDong WHERE MaHD = @maHD";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@maHD", SqlDbType.NVarChar, 50).Value = maHD;

            object kq = cmd.ExecuteScalar();
            cmd.Dispose();
            conn.Close();

            //b4 hien len combobox phong
            if (kq != null)
            {
                string phong = kq.ToString();
                cboPhong.SelectedValue = phong;
                LoadNguoiThue(maHD, phong);          // danh sach chi con nguoi cua phong nay
                cboNguoiThue.SelectedValue = maHD;   // nap lai danh sach nen phai chon lai
                TuDienChiSoCu();
            }
        }

        // ================= DỊCH VỤ (TÍCH CHỌN) =================

        // Đổ danh sách dịch vụ từ bảng DichVu vào CheckedListBox
        // Nhớ các dịch vụ đang tích để tích lại sau khi nạp
        private void LoadDichVu()
        {
            bool cu = dangNapForm;
            dangNapForm = true;
            try
            {
                var daTich = new HashSet<string>();
                foreach (DichVuItem dv in clbDichVu.CheckedItems) daTich.Add(dv.MaDV);

                clbDichVu.Items.Clear();
                cacheGiaPhong.Clear();   // nạp lại luôn giá phòng cho chắc
                giaDien = null;
                giaNuoc = null;

                using var conn = new SqlConnection(connectionString);
                conn.Open();
                using var cmd = new SqlCommand("SELECT MaDV, TenDV, DonGia FROM DichVu ORDER BY TenDV", conn);
                using var r = cmd.ExecuteReader();
                while (r.Read())
                {
                    string ma = r.GetString(0).Trim();
                    decimal gia = r.IsDBNull(2) ? 0 : r.GetDecimal(2);

                    // Điện/Nước tính riêng theo chỉ số công tơ nên không đưa vào danh sách tích
                    if (string.Equals(ma, MA_DV_DIEN, StringComparison.OrdinalIgnoreCase)) { giaDien = gia; continue; }
                    if (string.Equals(ma, MA_DV_NUOC, StringComparison.OrdinalIgnoreCase)) { giaNuoc = gia; continue; }

                    int idx = clbDichVu.Items.Add(new DichVuItem
                    {
                        MaDV = ma,
                        TenDV = r.IsDBNull(1) ? "" : r.GetString(1),
                        DonGia = gia
                    });
                    if (daTich.Contains(ma)) clbDichVu.SetItemChecked(idx, true);
                }
            }
            finally
            {
                dangNapForm = cu;
            }
        }

        // Tổng tiền các dịch vụ đang được tích
        private decimal TinhPhiDV()
        {
            decimal s = 0;
            foreach (DichVuItem dv in clbDichVu.CheckedItems) s += dv.DonGia;
            return s;
        }

        private void BoTichDichVu()
        {
            for (int i = 0; i < clbDichVu.Items.Count; i++) clbDichVu.SetItemChecked(i, false);
        }

        // Tích lại các dịch vụ của 1 hóa đơn khi bấm vào dòng trên bảng
        private void TichDichVuCuaHoaDon(string maHoaDon)
        {
            BoTichDichVu();
            using var conn = new SqlConnection(connectionString);
            conn.Open();
            using var cmd = new SqlCommand("SELECT MaDV FROM ChiTietDichVu WHERE MaHoaDon = @ma", conn);
            cmd.Parameters.Add("@ma", SqlDbType.NVarChar, 50).Value = maHoaDon;
            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                string maDV = r.GetString(0);
                for (int i = 0; i < clbDichVu.Items.Count; i++)
                    if (((DichVuItem)clbDichVu.Items[i]).MaDV == maDV)
                        clbDichVu.SetItemChecked(i, true);
            }
        }

        // Ghi chi tiết dịch vụ: xóa cũ rồi ghi lại (dùng chung transaction với HoaDon)
        private void LuuChiTietDichVu(SqlConnection conn, SqlTransaction tran, string maHoaDon)
        {
            using (var del = new SqlCommand("DELETE FROM ChiTietDichVu WHERE MaHoaDon = @ma", conn, tran))
            {
                del.Parameters.Add("@ma", SqlDbType.NVarChar, 50).Value = maHoaDon;
                del.ExecuteNonQuery();
            }
            foreach (DichVuItem dv in clbDichVu.CheckedItems)
            {
                using var ins = new SqlCommand(
                    "INSERT INTO ChiTietDichVu (MaHoaDon, MaDV, DonGia) VALUES (@ma, @dv, @gia)", conn, tran);
                ins.Parameters.Add("@ma", SqlDbType.NVarChar, 50).Value = maHoaDon;
                ins.Parameters.Add("@dv", SqlDbType.NVarChar, 50).Value = dv.MaDV;
                ins.Parameters.Add("@gia", SqlDbType.Decimal).Value = dv.DonGia;
                ins.ExecuteNonQuery();
            }
        }

        // ItemCheck chạy TRƯỚC khi trạng thái tích đổi, nên hoãn việc tính tổng đến sau đó
        private void clbDichVu_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (dangNapForm || !IsHandleCreated) return;
            BeginInvoke(new Action(CapNhatTong));
        }

        // ================= TÌM KIẾM =================

        private void btnTim_Click(object sender, EventArgs e)
        {
            //b1 lay tu khoa tim kiem
            string tukhoa = txtTimKiem.Text.Trim();

            LoadDuLieu(tukhoa);

            //neu ko tim thay
            if (dgvHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn nào phù hợp!", "Thông báo", MessageBoxButtons.OK);
            }

            dgvHoaDon.ClearSelection();
        }

        // ================= CLICK 1 DÒNG TRÊN BẢNG =================

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int i = e.RowIndex;

            // Cot 1 tren bang gio hien TEN nguoi thue, con MaHD + 4 cot DienCu, DienMoi, NuocCu, NuocMoi
            // khong hien tren bang nen lay tu dong du lieu goc (DataBoundItem) cua dong dang chon
            DataRowView dong = (DataRowView)dgvHoaDon.Rows[i].DataBoundItem;
            string maHD = dong["MaHopDong"].ToString();
            string maHoaDon = dgvHoaDon.Rows[i].Cells[0].Value.ToString();

            // Bật cờ để việc nạp form không kích hoạt tự điền chỉ số cũ / tự tính lại tổng
            // (giữ nguyên số liệu và tổng tiền đã lưu của hóa đơn)
            dangNapForm = true;
            try
            {
                txtMaHoaDon.Text = maHoaDon;
                cboPhong.SelectedValue = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
                // chi liet ke nguoi cua phong nay; van them hop dong cua hoa don vao list (neu da het han)
                LoadNguoiThue(maHD, dgvHoaDon.Rows[i].Cells[2].Value.ToString());
                cboNguoiThue.SelectedValue = maHD;
                dtpThangNam.Value = Convert.ToDateTime(dgvHoaDon.Rows[i].Cells[3].Value);
                txtDienCu.Text = dong["DienCu"].ToString();
                txtDienMoi.Text = dong["DienMoi"].ToString();
                txtNuocCu.Text = dong["NuocCu"].ToString();
                txtNuocMoi.Text = dong["NuocMoi"].ToString();
                TichDichVuCuaHoaDon(maHoaDon);
                txtTongCong.Text = Convert.ToDecimal(dgvHoaDon.Rows[i].Cells[7].Value).ToString("N0");
            }
            finally
            {
                dangNapForm = false;
            }
        }

        // ================= TỰ ĐIỀN CHỈ SỐ CŨ + TÍNH TIỀN =================

        // Điện/nước cũ = chỉ số mới của hóa đơn gần nhất trước tháng đang chọn, cùng phòng
        // (phòng chưa có hóa đơn nào trước đó thì để trống cho tự nhập)
        private void TuDienChiSoCu()
        {
            if (dangNapForm) return;

            string phong = cboPhong.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(phong)) return;

            DateTime dauThang = new DateTime(dtpThangNam.Value.Year, dtpThangNam.Value.Month, 1);

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                using var cmd = new SqlCommand(
                    "SELECT TOP 1 DienMoi, NuocMoi FROM HoaDon " +
                    "WHERE MaPhong = @phong AND ThoiGian < @thang " +
                    "ORDER BY ThoiGian DESC", conn);
                cmd.Parameters.Add("@phong", SqlDbType.NVarChar, 50).Value = phong;
                cmd.Parameters.Add("@thang", SqlDbType.DateTime).Value = dauThang;

                using var r = cmd.ExecuteReader();
                if (r.Read())
                {
                    txtDienCu.Text = r.IsDBNull(0) ? "" : r.GetInt32(0).ToString();
                    txtNuocCu.Text = r.IsDBNull(1) ? "" : r.GetInt32(1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy chỉ số cũ: " + ex.Message);
            }

            CapNhatTong();
        }

        // Kiểm tra dữ liệu nhập: đúng thì trả về true
        private bool KiemTraDuLieu()
        {
            if (giaDien == null || giaNuoc == null)
            {
                MessageBox.Show("Chưa có giá Điện/Nước! Vào trang Dịch vụ thêm 2 dịch vụ có mã " +
                    MA_DV_DIEN + " và " + MA_DV_NUOC + ".", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboPhong.SelectedValue == null || cboNguoiThue.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phòng và người thuê!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtDienCu.Text.Trim(), out int dienCu) || dienCu < 0 ||
                !int.TryParse(txtDienMoi.Text.Trim(), out int dienMoi) || dienMoi < 0)
            {
                MessageBox.Show("Số điện cũ và mới phải là số không âm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtNuocCu.Text.Trim(), out int nuocCu) || nuocCu < 0 ||
                !int.TryParse(txtNuocMoi.Text.Trim(), out int nuocMoi) || nuocMoi < 0)
            {
                MessageBox.Show("Số nước cũ và mới phải là số không âm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dienMoi < dienCu)
            {
                MessageBox.Show("Số điện mới phải lớn hơn hoặc bằng số điện cũ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienMoi.Focus();
                return false;
            }

            if (nuocMoi < nuocCu)
            {
                MessageBox.Show("Số nước mới phải lớn hơn hoặc bằng số nước cũ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNuocMoi.Focus();
                return false;
            }

            return true;
        }

        private decimal LayGiaPhong(string maPhong)
        {
            if (cacheGiaPhong.TryGetValue(maPhong, out decimal g)) return g;

            using var conn = new SqlConnection(connectionString);
            conn.Open();
            using var cmd = new SqlCommand("SELECT GiaPhong FROM PhongTro WHERE MaPhong = @phong", conn);
            cmd.Parameters.Add("@phong", SqlDbType.NVarChar, 50).Value = maPhong;
            object kq = cmd.ExecuteScalar();

            g = (kq == null || kq == DBNull.Value) ? 0 : Convert.ToDecimal(kq);
            cacheGiaPhong[maPhong] = g;
            return g;
        }

        // Tổng = tiền phòng + tiền điện + tiền nước + tiền các dịch vụ đã tích
        private decimal TinhTong()
        {
            decimal tienPhong = LayGiaPhong(cboPhong.SelectedValue.ToString());
            decimal tienDien = (int.Parse(txtDienMoi.Text) - int.Parse(txtDienCu.Text)) * giaDien.Value;
            decimal tienNuoc = (int.Parse(txtNuocMoi.Text) - int.Parse(txtNuocCu.Text)) * giaNuoc.Value;

            return tienPhong + tienDien + tienNuoc + TinhPhiDV();
        }

        // Tính tổng "im lặng" (không báo lỗi): thiếu hoặc sai dữ liệu thì để trống ô tổng
        private void CapNhatTong()
        {
            if (dangNapForm) return;

            if (cboPhong.SelectedValue == null || giaDien == null || giaNuoc == null ||
                !int.TryParse(txtDienCu.Text.Trim(), out int dc) ||
                !int.TryParse(txtDienMoi.Text.Trim(), out int dm) ||
                !int.TryParse(txtNuocCu.Text.Trim(), out int nc) ||
                !int.TryParse(txtNuocMoi.Text.Trim(), out int nm) ||
                dm < dc || nm < nc)
            {
                txtTongCong.Clear();
                return;
            }

            try
            {
                txtTongCong.Text = TinhTong().ToString("N0");
            }
            catch
            {
                txtTongCong.Clear();   // lỗi kết nối DB khi đang gõ thì bỏ qua, không hiện hộp thoại
            }
        }

        // ================= LẬP HÓA ĐƠN =================

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            //b1 lay du lieu
            string maHoaDon = txtMaHoaDon.Text.Trim();
            string maHD = cboNguoiThue.SelectedValue?.ToString() ?? "";
            string phong = cboPhong.SelectedValue?.ToString() ?? "";

            //b2 kiem tra du lieu
            if (string.IsNullOrEmpty(maHoaDon))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHoaDon.Focus();
                return;
            }

            LoadDichVu();   // lay gia dich vu moi nhat truoc khi chot hoa don

            if (!KiemTraDuLieu()) return;

            decimal tong = TinhTong();
            txtTongCong.Text = tong.ToString("N0");

            // luon luu ngay 1 cua thang cho gon
            DateTime thoiGian = new DateTime(dtpThangNam.Value.Year, dtpThangNam.Value.Month, 1);

            //b3 ket noi database + transaction (HoaDon va ChiTietDichVu cung thanh cong hoac cung huy)
            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                using var tran = conn.BeginTransaction();

                //b4 tao command de thuc hien lenh sql
                string sql = "INSERT INTO HoaDon (MaHoaDon,MaHD,MaPhong,ThoiGian,DienCu,DienMoi,PhiDV,NuocCu,NuocMoi,Tong,TrangThai) " +
                    "VALUES(@MaHoaDon,@MaHD,@MaPhong,@ThoiGian,@DienCu,@DienMoi,@PhiDV,@NuocCu,@NuocMoi,@Tong,@TrangThai)";
                using (var cmd = new SqlCommand(sql, conn, tran))
                {
                    cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.Parameters.AddWithValue("@MaPhong", phong);
                    cmd.Parameters.AddWithValue("@ThoiGian", thoiGian);
                    cmd.Parameters.AddWithValue("@DienCu", int.Parse(txtDienCu.Text));
                    cmd.Parameters.AddWithValue("@DienMoi", int.Parse(txtDienMoi.Text));
                    cmd.Parameters.AddWithValue("@PhiDV", (int)TinhPhiDV());
                    cmd.Parameters.AddWithValue("@NuocCu", int.Parse(txtNuocCu.Text));
                    cmd.Parameters.AddWithValue("@NuocMoi", int.Parse(txtNuocMoi.Text));
                    cmd.Parameters.AddWithValue("@Tong", tong);
                    cmd.Parameters.AddWithValue("@TrangThai", "Chưa thu");
                    cmd.ExecuteNonQuery();
                }

                LuuChiTietDichVu(conn, tran, maHoaDon);
                tran.Commit();
            }
            catch (SqlException ex) when (ex.Number == 2627)   // trung khoa chinh
            {
                MessageBox.Show("Mã hóa đơn này đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return;
            }

            MessageBox.Show("Lập hóa đơn thành công!");
            LoadDuLieu("");
        }

        // ================= SỬA HÓA ĐƠN =================

        private void btnSua_Click(object sender, EventArgs e)
        {
            //b1 lay du lieu (ma hoa don la khoa chinh nen khong sua, chi dung de tim hoa don can sua)
            string maHoaDon = txtMaHoaDon.Text.Trim();
            string maHD = cboNguoiThue.SelectedValue?.ToString() ?? "";
            string phong = cboPhong.SelectedValue?.ToString() ?? "";

            //b2 kiem tra du lieu
            if (string.IsNullOrEmpty(maHoaDon))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trong bảng để sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadDichVu();   // lay gia dich vu moi nhat truoc khi chot hoa don

            if (!KiemTraDuLieu()) return;

            // tinh lai tong tien theo so lieu moi
            decimal tong = TinhTong();
            txtTongCong.Text = tong.ToString("N0");

            // luon luu ngay 1 cua thang cho gon
            DateTime thoiGian = new DateTime(dtpThangNam.Value.Year, dtpThangNam.Value.Month, 1);

            //b3 ket noi database + transaction
            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                using var tran = conn.BeginTransaction();

                //b4 tao command de thuc hien lenh sql
                string sql = "UPDATE HoaDon SET MaHD=@MaHD, MaPhong=@MaPhong, ThoiGian=@ThoiGian, " +
                    "DienCu=@DienCu, DienMoi=@DienMoi, PhiDV=@PhiDV, NuocCu=@NuocCu, NuocMoi=@NuocMoi, Tong=@Tong " +
                    "WHERE MaHoaDon=@MaHoaDon";
                int soDong;
                using (var cmd = new SqlCommand(sql, conn, tran))
                {
                    cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.Parameters.AddWithValue("@MaPhong", phong);
                    cmd.Parameters.AddWithValue("@ThoiGian", thoiGian);
                    cmd.Parameters.AddWithValue("@DienCu", int.Parse(txtDienCu.Text));
                    cmd.Parameters.AddWithValue("@DienMoi", int.Parse(txtDienMoi.Text));
                    cmd.Parameters.AddWithValue("@PhiDV", (int)TinhPhiDV());
                    cmd.Parameters.AddWithValue("@NuocCu", int.Parse(txtNuocCu.Text));
                    cmd.Parameters.AddWithValue("@NuocMoi", int.Parse(txtNuocMoi.Text));
                    cmd.Parameters.AddWithValue("@Tong", tong);

                    // ExecuteNonQuery tra ve so dong bi sua: = 0 nghia la khong co hoa don nao co ma nay
                    soDong = cmd.ExecuteNonQuery();
                }

                if (soDong == 0)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn có mã này để sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;   // transaction tu rollback khi dispose
                }

                LuuChiTietDichVu(conn, tran, maHoaDon);
                tran.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return;
            }

            MessageBox.Show("Sửa hóa đơn thành công!");
            LoadDuLieu("");
        }

        // ================= ĐÃ THU TIỀN =================

        private void btnDaThuTien_Click(object sender, EventArgs e)
        {
            //b1 lay du lieu
            string maHoaDon = txtMaHoaDon.Text.Trim();

            //b2 kiem tra du lieu
            if (string.IsNullOrEmpty(maHoaDon))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trong bảng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //b3 ket noi database
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            //b4 tao command de thuc hien lenh sql
            string sql = "UPDATE HoaDon SET TrangThai = N'Đã thu' WHERE MaHoaDon = @maHoaDon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@maHoaDon", SqlDbType.NVarChar, 50).Value = maHoaDon;

            cmd.ExecuteNonQuery();
            //giai phong tai nguyen
            cmd.Dispose();
            conn.Close();

            MessageBox.Show("Đã cập nhật: đã thu tiền!");
            LoadDuLieu("");
        }

        // ================= XÓA HÓA ĐƠN =================

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            //b1 lay du lieu
            string maHoaDon = txtMaHoaDon.Text.Trim();

            //b2 kiem tra du lieu
            if (string.IsNullOrEmpty(maHoaDon))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trong bảng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // hoi lai truoc khi xoa
            if (MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            //b3 ket noi database
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            //b4 tao command de thuc hien lenh sql
            // (bang ChiTietDichVu tu xoa theo nho ON DELETE CASCADE)
            string sql = "DELETE FROM HoaDon WHERE MaHoaDon = @maHoaDon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@maHoaDon", SqlDbType.NVarChar, 50).Value = maHoaDon;

            cmd.ExecuteNonQuery();
            //giai phong tai nguyen
            cmd.Dispose();
            conn.Close();

            //xoa trang form
            txtMaHoaDon.Clear();
            txtDienCu.Clear();
            txtDienMoi.Clear();
            txtNuocCu.Clear();
            txtNuocMoi.Clear();
            BoTichDichVu();
            txtTongCong.Clear();
            cboPhong.SelectedIndex = -1;
            LoadNguoiThue("");

            MessageBox.Show("Đã xóa hóa đơn!");
            LoadDuLieu("");
        }

        // ================= LÀM MỚI =================

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Clear();
            txtDienCu.Clear();
            txtDienMoi.Clear();
            txtNuocCu.Clear();
            txtNuocMoi.Clear();
            LoadDichVu();       // nap lai gia dich vu moi nhat
            BoTichDichVu();
            txtTongCong.Clear();
            cboPhong.SelectedIndex = -1;
            LoadNguoiThue("");
            dtpThangNam.Value = DateTime.Today;

            txtTimKiem.Clear();

            LoadDuLieu("");
            dgvHoaDon.ClearSelection();

            txtMaHoaDon.Focus();
        }

        // ================= IN HÓA ĐƠN =================

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHoaDon.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trong bảng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dsDichVu = clbDichVu.CheckedItems.Count == 0
                ? "(không có)"
                : string.Join(", ", clbDichVu.CheckedItems.Cast<DichVuItem>().Select(d => d.TenDV));

            string noiDung =
                "HÓA ĐƠN PHÒNG TRỌ\n" +
                "-----------------------------\n" +
                "Mã hóa đơn : " + txtMaHoaDon.Text + "\n" +
                "Tháng/Năm  : " + dtpThangNam.Text + "\n" +
                "Phòng      : " + cboPhong.Text + "\n" +
                "Người thuê : " + cboNguoiThue.Text + "\n\n" +
                "Điện: " + txtDienCu.Text + " -> " + txtDienMoi.Text + "\n" +
                "Nước: " + txtNuocCu.Text + " -> " + txtNuocMoi.Text + "\n" +
                "Dịch vụ: " + dsDichVu + " (" + TinhPhiDV().ToString("N0") + ")\n" +
                "-----------------------------\n" +
                "TỔNG CỘNG: " + txtTongCong.Text + " đồng";

            PrintDocument tuIn = new PrintDocument();
            tuIn.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawString(noiDung, new Font("Segoe UI", 12), Brushes.Black, 50, 50);
            };

            PrintPreviewDialog xemTruoc = new PrintPreviewDialog();
            xemTruoc.Document = tuIn;
            xemTruoc.ShowDialog();
        }
    }
}