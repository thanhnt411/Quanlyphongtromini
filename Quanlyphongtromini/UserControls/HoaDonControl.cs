using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Quanlyphongtromini.UserControls
{
    public partial class HoaDonControl : UserControl
    {
        private const string connectionString =
            @"Server=localhost\SQLEXPRESS;Database=QLPhongTro;Trusted_Connection=True;TrustServerCertificate=True;";

        public HoaDonControl()
        {
            InitializeComponent();
        }

        // ================= LOAD DỮ LIỆU =================

        private void HoaDonControl_Load(object sender, EventArgs e)
        {
            // Không truy cập DB khi đang mở ở chế độ Design
            if (this.DesignMode) return;

            dgvHoaDon.AutoGenerateColumns = false;
            LoadDuLieu("");
            LoadComboBox();
            LoadDichVu();
        }

        private void LoadDuLieu(string tukhoa)
        {
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

            DataTable tb = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@tukhoa", tukhoa);
                da.Fill(tb);
            }
            dgvHoaDon.DataSource = tb;
        }

        private void LoadComboBox()
        {
            DataTable tbPhong = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaPhong FROM PhongTro", conn);
                da.Fill(tbPhong);
            }
            cboPhong.BindingContext = new BindingContext();
            cboPhong.DataSource = tbPhong;
            cboPhong.DisplayMember = "MaPhong";
            cboPhong.ValueMember = "MaPhong";
            cboPhong.SelectedIndex = -1;

            LoadNguoiThue("", "");
        }

        private void LoadNguoiThue(string maHDCanChon, string maPhong)
        {
            string sql = "SELECT h.MaHD, n.Hoten FROM HopDong h " +
                "JOIN NguoiThue n ON h.MaNguoi = n.MaNguoi " +
                "WHERE h.MaHD = @maHDCanChon " +
                "OR (h.TrangThai = N'Còn hạn' AND (@maPhong = N'' OR h.MaPhong = @maPhong)) " +
                "ORDER BY n.Hoten";

            DataTable tb = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@maHDCanChon", maHDCanChon);
                da.SelectCommand.Parameters.AddWithValue("@maPhong", maPhong);
                da.Fill(tb);
            }
            cboNguoiThue.BindingContext = new BindingContext();
            cboNguoiThue.DataSource = tb;
            cboNguoiThue.DisplayMember = "Hoten";
            cboNguoiThue.ValueMember = "MaHD";
            cboNguoiThue.SelectedIndex = -1;
        }

        private void LoadDichVu()
        {
            string sql = "SELECT MaDV, DonGia, " +
                "TenDV + N' - ' + FORMAT(DonGia, 'N0') + N'đ' AS HienThi " +
                "FROM DichVu WHERE MaDV NOT IN ('DIEN', 'NUOC') ORDER BY TenDV";

            DataTable tb = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(tb);
            }
            clbDichVu.DataSource = tb;
            clbDichVu.DisplayMember = "HienThi";
            clbDichVu.ValueMember = "MaDV";
        }

        // ================= LIÊN KẾT HAI COMBOBOX =================

        // Chọn phòng -> hiện người thuê của hợp đồng còn hạn của phòng đó
        private void cboPhong_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string phong = "";
            if (cboPhong.SelectedValue != null)
            {
                phong = cboPhong.SelectedValue.ToString();
            }

            object kq;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT TOP 1 MaHD FROM HopDong " +
                    "WHERE MaPhong = @phong AND TrangThai = N'Còn hạn' " +
                    "ORDER BY DayStart DESC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@phong", phong);
                kq = cmd.ExecuteScalar();
            }

            LoadNguoiThue("", phong);
            if (kq == null)
            {
                cboNguoiThue.SelectedIndex = -1;
                MessageBox.Show("Phòng này chưa có hợp đồng còn hạn!");
            }
            else
            {
                cboNguoiThue.SelectedValue = kq.ToString();
            }
        }

        // Chọn người thuê -> hiện mã phòng của hợp đồng đó
        private void cboNguoiThue_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboNguoiThue.SelectedValue == null) return;
            string maHD = cboNguoiThue.SelectedValue.ToString();

            object kq;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MaPhong FROM HopDong WHERE MaHD = @maHD", conn);
                cmd.Parameters.AddWithValue("@maHD", maHD);
                kq = cmd.ExecuteScalar();
            }

            if (kq != null)
            {
                string phong = kq.ToString();
                cboPhong.SelectedValue = phong;
                LoadNguoiThue(maHD, phong);
                cboNguoiThue.SelectedValue = maHD;
            }
        }


        // ================= TÌM KIẾM =================

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDuLieu(txtTimKiem.Text.Trim());

            if (dgvHoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn nào phù hợp!");
            }
            dgvHoaDon.ClearSelection();
        }

        // ================= CLICK 1 DÒNG TRÊN BẢNG =================

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView dong = (DataRowView)dgvHoaDon.Rows[e.RowIndex].DataBoundItem;
            string maHoaDon = dong["MaHoaDon"].ToString();
            string maHD = dong["MaHopDong"].ToString();
            string maPhong = dong["MaPhong"].ToString();

            txtMaHoaDon.Text = maHoaDon;
            cboPhong.SelectedValue = maPhong;
            LoadNguoiThue(maHD, maPhong);
            cboNguoiThue.SelectedValue = maHD;
            dtpThangNam.Value = Convert.ToDateTime(dong["ThangNam"]);
            txtDienCu.Text = dong["DienCu"].ToString();
            txtDienMoi.Text = dong["DienMoi"].ToString();
            txtNuocCu.Text = dong["NuocCu"].ToString();
            txtNuocMoi.Text = dong["NuocMoi"].ToString();
            TichDichVuCuaHoaDon(maHoaDon);
            txtTongCong.Text = Convert.ToDecimal(dong["TongTien"]).ToString("N0");
        }

        // ================= DỊCH VỤ TÍCH CHỌN =================

        private decimal TinhPhiDV()
        {
            decimal s = 0;
            foreach (DataRowView dv in clbDichVu.CheckedItems)
            {
                s = s + Convert.ToDecimal(dv["DonGia"]);
            }
            return s;
        }

        // Tích lại các dịch vụ đã lưu của 1 hóa đơn
        private void TichDichVuCuaHoaDon(string maHoaDon)
        {
            DataTable tb = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT MaDV FROM ChiTietDichVu WHERE MaHoaDon = @ma", conn);
                da.SelectCommand.Parameters.AddWithValue("@ma", maHoaDon);
                da.Fill(tb);
            }

            for (int i = 0; i < clbDichVu.Items.Count; i++)
            {
                DataRowView dv = (DataRowView)clbDichVu.Items[i];
                DataRow[] kq = tb.Select("MaDV = '" + dv["MaDV"].ToString() + "'");
                clbDichVu.SetItemChecked(i, kq.Length > 0);
            }
        }

        private void BoTichDichVu()
        {
            for (int i = 0; i < clbDichVu.Items.Count; i++)
            {
                clbDichVu.SetItemChecked(i, false);
            }
        }

        // Xóa chi tiết cũ rồi ghi lại 
        private void LuuChiTietDichVu(SqlConnection conn, SqlTransaction tran, string maHoaDon)
        {
            SqlCommand del = new SqlCommand("DELETE FROM ChiTietDichVu WHERE MaHoaDon = @ma", conn, tran);
            del.Parameters.AddWithValue("@ma", maHoaDon);
            del.ExecuteNonQuery();

            foreach (DataRowView dv in clbDichVu.CheckedItems)
            {
                SqlCommand ins = new SqlCommand(
                    "INSERT INTO ChiTietDichVu (MaHoaDon, MaDV, DonGia) VALUES (@ma, @dv, @gia)", conn, tran);
                ins.Parameters.AddWithValue("@ma", maHoaDon);
                ins.Parameters.AddWithValue("@dv", dv["MaDV"].ToString());
                ins.Parameters.AddWithValue("@gia", Convert.ToDecimal(dv["DonGia"]));
                ins.ExecuteNonQuery();
            }
        }

        // ================= TÍNH TIỀN =================

        // Lấy đơn giá 1 dịch vụ theo mã
        private decimal LayDonGia(string maDV)
        {
            object kq;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DonGia FROM DichVu WHERE MaDV = @ma", conn);
                cmd.Parameters.AddWithValue("@ma", maDV);
                kq = cmd.ExecuteScalar();
            }
            if (kq == null || kq == DBNull.Value) return -1;
            return Convert.ToDecimal(kq);
        }

        private decimal LayGiaPhong(string maPhong)
        {
            object kq;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT GiaPhong FROM PhongTro WHERE MaPhong = @phong", conn);
                cmd.Parameters.AddWithValue("@phong", maPhong);
                kq = cmd.ExecuteScalar();
            }
            if (kq == null || kq == DBNull.Value) return 0;
            return Convert.ToDecimal(kq);
        }

        // Kiểm tra mã hóa đơn đã có trong DB chưa
        private bool TonTaiHoaDon(string maHoaDon)
        {
            int soDong;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM HoaDon WHERE MaHoaDon = @ma", conn);
                cmd.Parameters.AddWithValue("@ma", maHoaDon);
                soDong = (int)cmd.ExecuteScalar();
            }
            return soDong > 0;
        }

        // Kiểm tra dữ liệu nhập
        private bool KiemTraDuLieu()
        {
            if (LayDonGia("DIEN") < 0 || LayDonGia("NUOC") < 0)
            {
                MessageBox.Show("Chưa có giá Điện/Nước! Vào trang Dịch vụ thêm 2 dịch vụ có mã DIEN và NUOC.");
                return false;
            }

            if (cboPhong.SelectedValue == null || cboNguoiThue.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phòng và người thuê!");
                return false;
            }

            int dienCu, dienMoi, nuocCu, nuocMoi;

            if (!int.TryParse(txtDienCu.Text.Trim(), out dienCu) || !int.TryParse(txtDienMoi.Text.Trim(), out dienMoi)
                || dienCu < 0 || dienMoi < 0)
            {
                MessageBox.Show("Số điện cũ và mới phải là số không âm!");
                return false;
            }

            if (!int.TryParse(txtNuocCu.Text.Trim(), out nuocCu) || !int.TryParse(txtNuocMoi.Text.Trim(), out nuocMoi)
                || nuocCu < 0 || nuocMoi < 0)
            {
                MessageBox.Show("Số nước cũ và mới phải là số không âm!");
                return false;
            }

            if (dienMoi < dienCu)
            {
                MessageBox.Show("Số điện mới phải lớn hơn hoặc bằng số điện cũ!");
                txtDienMoi.Focus();
                return false;
            }

            if (nuocMoi < nuocCu)
            {
                MessageBox.Show("Số nước mới phải lớn hơn hoặc bằng số nước cũ!");
                txtNuocMoi.Focus();
                return false;
            }

            return true;
        }

        // Tổng = tiền phòng + tiền điện + tiền nước + tiền dịch vụ đã tích
        private decimal TinhTong()
        {
            decimal tienPhong = LayGiaPhong(cboPhong.SelectedValue.ToString());
            decimal tienDien = (int.Parse(txtDienMoi.Text) - int.Parse(txtDienCu.Text)) * LayDonGia("DIEN");
            decimal tienNuoc = (int.Parse(txtNuocMoi.Text) - int.Parse(txtNuocCu.Text)) * LayDonGia("NUOC");

            return tienPhong + tienDien + tienNuoc + TinhPhiDV();
        }

        // ================= LẬP HÓA ĐƠN =================

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtMaHoaDon.Text.Trim();
            if (maHoaDon == "")
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!");
                txtMaHoaDon.Focus();
                return;
            }

            if (TonTaiHoaDon(maHoaDon))
            {
                MessageBox.Show("Mã hóa đơn này đã tồn tại!");
                return;
            }

            if (!KiemTraDuLieu()) return;

            try
            {
                string maHD = cboNguoiThue.SelectedValue.ToString();
                string phong = cboPhong.SelectedValue.ToString();
                decimal tong = TinhTong();
                txtTongCong.Text = tong.ToString("N0");

                // luôn lưu ngày 1 của tháng
                DateTime thoiGian = new DateTime(dtpThangNam.Value.Year, dtpThangNam.Value.Month, 1);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();

                    string sql = "INSERT INTO HoaDon (MaHoaDon,MaHD,MaPhong,ThoiGian,DienCu,DienMoi,PhiDV,NuocCu,NuocMoi,Tong,TrangThai) " +
                        "VALUES(@MaHoaDon,@MaHD,@MaPhong,@ThoiGian,@DienCu,@DienMoi,@PhiDV,@NuocCu,@NuocMoi,@Tong,@TrangThai)";
                    SqlCommand cmd = new SqlCommand(sql, conn, tran);
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

                    LuuChiTietDichVu(conn, tran, maHoaDon);
                    tran.Commit();
                }

                MessageBox.Show("Lập hóa đơn thành công!");
                LoadDuLieu("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // ================= SỬA HÓA ĐƠN =================

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtMaHoaDon.Text.Trim();
            if (maHoaDon == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trong bảng để sửa!");
                return;
            }

            if (!TonTaiHoaDon(maHoaDon))
            {
                MessageBox.Show("Không tìm thấy hóa đơn có mã này để sửa!");
                return;
            }

            if (!KiemTraDuLieu()) return;

            try
            {
                string maHD = cboNguoiThue.SelectedValue.ToString();
                string phong = cboPhong.SelectedValue.ToString();
                decimal tong = TinhTong();
                txtTongCong.Text = tong.ToString("N0");

                DateTime thoiGian = new DateTime(dtpThangNam.Value.Year, dtpThangNam.Value.Month, 1);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();

                    string sql = "UPDATE HoaDon SET MaHD=@MaHD, MaPhong=@MaPhong, ThoiGian=@ThoiGian, " +
                        "DienCu=@DienCu, DienMoi=@DienMoi, PhiDV=@PhiDV, NuocCu=@NuocCu, NuocMoi=@NuocMoi, Tong=@Tong " +
                        "WHERE MaHoaDon=@MaHoaDon";
                    SqlCommand cmd = new SqlCommand(sql, conn, tran);
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
                    cmd.ExecuteNonQuery();

                    LuuChiTietDichVu(conn, tran, maHoaDon);
                    tran.Commit();
                }

                MessageBox.Show("Sửa hóa đơn thành công!");
                LoadDuLieu("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // ================= ĐÃ THU TIỀN =================

        private void btnDaThuTien_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtMaHoaDon.Text.Trim();
            if (maHoaDon == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trong bảng!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE HoaDon SET TrangThai = N'Đã thu' WHERE MaHoaDon = @ma", conn);
                    cmd.Parameters.AddWithValue("@ma", maHoaDon);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Đã cập nhật: đã thu tiền!");
                LoadDuLieu("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // ================= XÓA HÓA ĐƠN =================

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            string maHoaDon = txtMaHoaDon.Text.Trim();
            if (maHoaDon == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trong bảng!");
                return;
            }

            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // bảng ChiTietDichVu tự xóa theo nhờ ON DELETE CASCADE
                    SqlCommand cmd = new SqlCommand("DELETE FROM HoaDon WHERE MaHoaDon = @ma", conn);
                    cmd.Parameters.AddWithValue("@ma", maHoaDon);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Đã xóa hóa đơn!");
                XoaTrangForm();
                LoadDuLieu("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // ================= LÀM MỚI =================

        private void XoaTrangForm()
        {
            txtMaHoaDon.Clear();
            txtDienCu.Clear();
            txtDienMoi.Clear();
            txtNuocCu.Clear();
            txtNuocMoi.Clear();
            txtTongCong.Clear();
            cboPhong.SelectedIndex = -1;
            LoadNguoiThue("", "");
            LoadComboBox();
            LoadDichVu();
            BoTichDichVu();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaTrangForm();
            dtpThangNam.Value = DateTime.Today;
            txtTimKiem.Clear();
            LoadDuLieu("");
            dgvHoaDon.ClearSelection();
            txtMaHoaDon.Focus();
        }

        // ================= IN HÓA ĐƠN =================
        private string noiDungIn = "";
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trong bảng!");
                return;
            }

            // ghép tên các dịch vụ đã tích
            string dsDichVu = "";
            foreach (DataRowView dv in clbDichVu.CheckedItems)
            {
                dsDichVu = dsDichVu + dv["HienThi"].ToString() + "; ";
            }
            if (dsDichVu == "") dsDichVu = "(không có)";

            noiDungIn =
                "HÓA ĐƠN PHÒNG TRỌ\n" +
                "-----------------------------\n" +
                "Mã hóa đơn : " + txtMaHoaDon.Text + "\n" +
                "Tháng/Năm  : " + dtpThangNam.Text + "\n" +
                "Phòng      : " + cboPhong.Text + "\n" +
                "Người thuê : " + cboNguoiThue.Text + "\n\n" +
                "Điện: " + txtDienCu.Text + " -> " + txtDienMoi.Text + "\n" +
                "Nước: " + txtNuocCu.Text + " -> " + txtNuocMoi.Text + "\n" +
                "Dịch vụ: " + dsDichVu + "\n" +
                "-----------------------------\n" +
                "TỔNG CỘNG: " + txtTongCong.Text + " đồng";

            PrintDocument tuIn = new PrintDocument();
            tuIn.PrintPage += new PrintPageEventHandler(tuIn_PrintPage);

            PrintPreviewDialog xemTruoc = new PrintPreviewDialog();
            xemTruoc.Document = tuIn;
            xemTruoc.ShowDialog();
        }

        private void tuIn_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(noiDungIn, new Font("Segoe UI", 12), Brushes.Black, 50, 50);
        }
    }
}