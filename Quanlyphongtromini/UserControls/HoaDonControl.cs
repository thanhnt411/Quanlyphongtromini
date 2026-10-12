using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace Quanlyphongtromini.UserControls
{
    public partial class HoaDonControl : UserControl
    {
        private const string connectionString =
            @"Server=localhost\SQLEXPRESS;Database=QLPhongTro;Trusted_Connection=True;TrustServerCertificate=True;";

        private const decimal GIA_DIEN = 3500; 
        private const decimal GIA_NUOC = 15000;

        public HoaDonControl()
        {
            InitializeComponent();
        }

        // ================= LOAD DỮ LIỆU =================

        private void HoaDonControl_Load(object sender, EventArgs e)
        {
            dgvHoaDon.AutoGenerateColumns = false;
            LoadDuLieu("");
            LoadComboBox();
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
            string sql = "SELECT MaHoaDon, MaHD AS MaHopDong, MaPhong, ThoiGian AS ThangNam, " +
                "DienMoi - DienCu AS DienTieuThu, " +
                "NuocMoi - NuocCu AS NuocTieuThu, " +
                "PhiDV AS PhiDichVu, Tong AS TongTien, TrangThai, " +
                "DienCu, DienMoi, NuocCu, NuocMoi " +
                "FROM HoaDon " +
                "WHERE MaHoaDon LIKE N'%' + @tukhoa + N'%' " +
                "OR MaHD LIKE N'%' + @tukhoa + N'%' " +
                "OR MaPhong LIKE N'%' + @tukhoa + N'%' " +
                "OR FORMAT(ThoiGian, 'MM/yyyy') LIKE N'%' + @tukhoa + N'%' " +
                "ORDER BY ThoiGian DESC";

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

            //b3 do du lieu vao combobox ma hop dong
            LoadHopDong("");
        }

        // Đổ tất cả hợp đồng "Còn hạn" vào cboMaHopDong
        // maHDCanChon: mã hợp đồng của hóa đơn đang xem (có thể đã "Hết hạn" nhưng vẫn phải có trong list,
        // nếu không combobox sẽ không hiện được mã hợp đồng của hóa đơn cũ). Không cần thì truyền "".
        private void LoadHopDong(string maHDCanChon)
        {
            //b1 ket noi database
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            //b2 tao command
            string sql = "SELECT MaHD FROM HopDong " +
                "WHERE TrangThai = N'Còn hạn' OR MaHD = @maHDCanChon";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@maHDCanChon", SqlDbType.NVarChar, 50).Value = maHDCanChon;

            //b3 do du lieu vao datatable
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            conn.Close();

            //b4 do vao combobox
            cboMaHopDong.DataSource = tb;
            cboMaHopDong.DisplayMember = "MaHD";
            cboMaHopDong.ValueMember = "MaHD";
            cboMaHopDong.SelectedIndex = -1;
        }

        // Chọn mã phòng -> tự hiện mã hợp đồng "Còn hạn" của phòng đó
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

            //b4 hien len combobox hop dong
            if (kq == null)
            {
                cboMaHopDong.SelectedIndex = -1;
                MessageBox.Show("Phòng này chưa có hợp đồng còn hạn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cboMaHopDong.SelectedValue = kq.ToString();
            }
        }

        // Chọn mã hợp đồng -> tự hiện mã phòng của hợp đồng đó
        private void cboMaHopDong_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //b1 lay du lieu
            string maHD = cboMaHopDong.SelectedValue?.ToString() ?? "";

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
                cboPhong.SelectedValue = kq.ToString();
            }
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

            // 4 cot DienCu, DienMoi, NuocCu, NuocMoi khong hien tren bang
            // nen lay tu dong du lieu goc (DataBoundItem) cua dong dang chon
            DataRowView dong = (DataRowView)dgvHoaDon.Rows[i].DataBoundItem;

            string maHD = dgvHoaDon.Rows[i].Cells[1].Value.ToString();

            txtMaHoaDon.Text = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
            cboPhong.SelectedValue = dgvHoaDon.Rows[i].Cells[2].Value.ToString();
            LoadHopDong(maHD);                      // them hop dong cua hoa don nay vao list (neu da het han)
            cboMaHopDong.SelectedValue = maHD;
            dtpThangNam.Value = Convert.ToDateTime(dgvHoaDon.Rows[i].Cells[3].Value);
            txtDienCu.Text = dong["DienCu"].ToString();
            txtDienMoi.Text = dong["DienMoi"].ToString();
            txtNuocCu.Text = dong["NuocCu"].ToString();
            txtNuocMoi.Text = dong["NuocMoi"].ToString();
            txtPhiDichVu.Text = dgvHoaDon.Rows[i].Cells[6].Value.ToString();
            txtTongCong.Text = Convert.ToDecimal(dgvHoaDon.Rows[i].Cells[7].Value).ToString("N0");
        }

        // ================= TÍNH TIỀN =================

        // Kiểm tra dữ liệu nhập: đúng thì trả về true
        private bool KiemTraDuLieu()
        {
            if (cboPhong.SelectedValue == null || cboMaHopDong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phòng và mã hợp đồng!", "Thông báo",
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

            if (!int.TryParse(txtPhiDichVu.Text.Trim(), out int phiDV) || phiDV < 0)
            {
                MessageBox.Show("Phí dịch vụ phải là số không âm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhiDichVu.Focus();
                return false;
            }

            return true;
        }

        // Tổng = tiền phòng + tiền điện + tiền nước + phí dịch vụ
        private decimal TinhTong()
        {
            //b1 ket noi database de lay gia phong
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            //b2 tao command
            string sql = "SELECT GiaPhong FROM PhongTro WHERE MaPhong = @phong";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@phong", SqlDbType.NVarChar, 50).Value = cboPhong.SelectedValue.ToString();

            //b3 lay 1 gia tri
            decimal tienPhong = Convert.ToDecimal(cmd.ExecuteScalar());
            cmd.Dispose();
            conn.Close();

            //b4 tinh tien
            decimal tienDien = (int.Parse(txtDienMoi.Text) - int.Parse(txtDienCu.Text)) * GIA_DIEN;
            decimal tienNuoc = (int.Parse(txtNuocMoi.Text) - int.Parse(txtNuocCu.Text)) * GIA_NUOC;
            decimal phiDV = int.Parse(txtPhiDichVu.Text);

            return tienPhong + tienDien + tienNuoc + phiDV;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;

            txtTongCong.Text = TinhTong().ToString("N0");
        }

        // ================= LẬP HÓA ĐƠN =================

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            //b1 lay du lieu
            string maHoaDon = txtMaHoaDon.Text.Trim();
            string maHD = cboMaHopDong.SelectedValue?.ToString() ?? "";
            string phong = cboPhong.SelectedValue?.ToString() ?? "";

            //b2 kiem tra du lieu
            if (string.IsNullOrEmpty(maHoaDon))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHoaDon.Focus();
                return;
            }

            if (!KiemTraDuLieu()) return;

            decimal tong = TinhTong();
            txtTongCong.Text = tong.ToString("N0");

            // luon luu ngay 1 cua thang cho gon
            DateTime thoiGian = new DateTime(dtpThangNam.Value.Year, dtpThangNam.Value.Month, 1);

            //b3 ket noi database
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            //b4 tao command de thuc hien lenh sql
            string sql = "INSERT INTO HoaDon (MaHoaDon,MaHD,MaPhong,ThoiGian,DienCu,DienMoi,PhiDV,NuocCu,NuocMoi,Tong,TrangThai) " +
                "VALUES(@MaHoaDon,@MaHD,@MaPhong,@ThoiGian,@DienCu,@DienMoi,@PhiDV,@NuocCu,@NuocMoi,@Tong,@TrangThai)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
            cmd.Parameters.AddWithValue("@MaHD", maHD);
            cmd.Parameters.AddWithValue("@MaPhong", phong);
            cmd.Parameters.AddWithValue("@ThoiGian", thoiGian);
            cmd.Parameters.AddWithValue("@DienCu", int.Parse(txtDienCu.Text));
            cmd.Parameters.AddWithValue("@DienMoi", int.Parse(txtDienMoi.Text));
            cmd.Parameters.AddWithValue("@PhiDV", int.Parse(txtPhiDichVu.Text));
            cmd.Parameters.AddWithValue("@NuocCu", int.Parse(txtNuocCu.Text));
            cmd.Parameters.AddWithValue("@NuocMoi", int.Parse(txtNuocMoi.Text));
            cmd.Parameters.AddWithValue("@Tong", tong);
            cmd.Parameters.AddWithValue("@TrangThai", "Chưa thu");

            cmd.ExecuteNonQuery();
            //giai phong tai nguyen
            cmd.Dispose();
            conn.Close();

            MessageBox.Show("Lập hóa đơn thành công!");
            LoadDuLieu("");
        }

        // ================= SỬA HÓA ĐƠN =================

        private void btnSua_Click(object sender, EventArgs e)
        {
            //b1 lay du lieu (ma hoa don la khoa chinh nen khong sua, chi dung de tim hoa don can sua)
            string maHoaDon = txtMaHoaDon.Text.Trim();
            string maHD = cboMaHopDong.SelectedValue?.ToString() ?? "";
            string phong = cboPhong.SelectedValue?.ToString() ?? "";

            //b2 kiem tra du lieu
            if (string.IsNullOrEmpty(maHoaDon))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trong bảng để sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!KiemTraDuLieu()) return;

            // tinh lai tong tien theo so lieu moi
            decimal tong = TinhTong();
            txtTongCong.Text = tong.ToString("N0");

            // luon luu ngay 1 cua thang cho gon
            DateTime thoiGian = new DateTime(dtpThangNam.Value.Year, dtpThangNam.Value.Month, 1);

            //b3 ket noi database
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            //b4 tao command de thuc hien lenh sql
            string sql = "UPDATE HoaDon SET MaHD=@MaHD, MaPhong=@MaPhong, ThoiGian=@ThoiGian, " +
                "DienCu=@DienCu, DienMoi=@DienMoi, PhiDV=@PhiDV, NuocCu=@NuocCu, NuocMoi=@NuocMoi, Tong=@Tong " +
                "WHERE MaHoaDon=@MaHoaDon";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
            cmd.Parameters.AddWithValue("@MaHD", maHD);
            cmd.Parameters.AddWithValue("@MaPhong", phong);
            cmd.Parameters.AddWithValue("@ThoiGian", thoiGian);
            cmd.Parameters.AddWithValue("@DienCu", int.Parse(txtDienCu.Text));
            cmd.Parameters.AddWithValue("@DienMoi", int.Parse(txtDienMoi.Text));
            cmd.Parameters.AddWithValue("@PhiDV", int.Parse(txtPhiDichVu.Text));
            cmd.Parameters.AddWithValue("@NuocCu", int.Parse(txtNuocCu.Text));
            cmd.Parameters.AddWithValue("@NuocMoi", int.Parse(txtNuocMoi.Text));
            cmd.Parameters.AddWithValue("@Tong", tong);

            // ExecuteNonQuery tra ve so dong bi sua: = 0 nghia la khong co hoa don nao co ma nay
            int soDong = cmd.ExecuteNonQuery();
            //giai phong tai nguyen
            cmd.Dispose();
            conn.Close();

            if (soDong == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn có mã này để sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtPhiDichVu.Clear();
            txtTongCong.Clear();
            cboPhong.SelectedIndex = -1;
            LoadHopDong("");

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
            txtPhiDichVu.Clear();
            txtTongCong.Clear();
            cboPhong.SelectedIndex = -1;
            LoadHopDong("");
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

            string noiDung =
                "HÓA ĐƠN PHÒNG TRỌ\n" +
                "-----------------------------\n" +
                "Mã hóa đơn : " + txtMaHoaDon.Text + "\n" +
                "Tháng/Năm  : " + dtpThangNam.Text + "\n" +
                "Phòng      : " + cboPhong.Text + "\n" +
                "Mã hợp đồng: " + cboMaHopDong.Text + "\n\n" +
                "Điện: " + txtDienCu.Text + " -> " + txtDienMoi.Text + "\n" +
                "Nước: " + txtNuocCu.Text + " -> " + txtNuocMoi.Text + "\n" +
                "Phí dịch vụ: " + txtPhiDichVu.Text + "\n" +
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