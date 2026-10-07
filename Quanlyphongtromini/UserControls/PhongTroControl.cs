using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

    namespace Quanlyphongtromini.UserControls
    {
        public partial class PhongTroControl : UserControl
        {
            // Chuỗi kết nối tới SQL Server (dùng chung cho mọi nút)
            private string connectionString = @"Data Source=localhost;Initial Catalog=QLPhongTro;User ID=sa;password = 123456;Trust Server Certificate=True;";

            public PhongTroControl()
            {
                InitializeComponent();
        }

        // Đọc dữ liệu từ bảng PhongTro trong DB rồi hiển thị lên dgvPhongTro.
        // keyword rỗng => lấy tất cả; có keyword => chỉ lấy các dòng khớp (tìm trực tiếp trong DB)
        private void LoadDuLieu(string keyword = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM PhongTro";
                if (keyword != "")
                {
                    sql += @" WHERE MaPhong LIKE @kw
                              OR TenPhong LIKE @kw
                              OR CONVERT(NVARCHAR(50), DienTich) LIKE @kw
                              OR CONVERT(NVARCHAR(50), GiaPhong) LIKE @kw
                              OR CONVERT(NVARCHAR(50), ToiDa) LIKE @kw
                              OR TrangThai LIKE @kw";
                }
                sql += " ORDER BY MaPhong";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                if (keyword != "")
                    adapter.SelectCommand.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvPhongTro.AutoGenerateColumns = false;
                dgvPhongTro.DataSource = table;
            }
        }

        // Kiểm tra các ô nhập đã đầy đủ và đúng định dạng chưa
        private bool KiemTraDuLieu()
        {
            if (txtMaPhong.Text.Trim() == "" || txtTenPhong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã phòng và tên phòng!");
                return false;
            }
            if (!decimal.TryParse(txtDienTich.Text.Trim(), out decimal dienTich) || dienTich <= 0)
            {
                MessageBox.Show("Diện tích phải là số lớn hơn 0!");
                return false;
            }
            if (!decimal.TryParse(txtGiaPhong.Text.Trim(), out decimal giaPhong) || giaPhong < 0)
            {
                MessageBox.Show("Giá phòng phải là số không âm!");
                return false;
            }
            if (!int.TryParse(txtToiDa.Text.Trim(), out int toiDa) || toiDa <= 0)
            {
                MessageBox.Show("Số người tối đa phải là số nguyên lớn hơn 0!");
                return false;
            }
            if (cboTrangThai.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn trạng thái!");
                return false;
            }
            return true;
        }

        // Xóa trắng các ô nhập liệu
        private void XoaONhap()
        {
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            txtDienTich.Clear();
            txtGiaPhong.Clear();
            txtToiDa.Clear();
            cboTrangThai.SelectedIndex = -1;
            txtMaPhong.Focus();
        }

        private void PhongTroControl_Load(object sender, EventArgs e)
        {
            // Đảm bảo ComboBox có đủ 3 trạng thái giống DB
            if (cboTrangThai.Items.Count == 0)
                cboTrangThai.Items.AddRange(new object[] { "Trống", "Đang thuê", "Bảo trì" });

            // Mở trang là hiển thị luôn dữ liệu từ DB lên dgv
            LoadDuLieu();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            LoadDuLieu(keyword);

            if (dgvPhongTro.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phòng trọ phù hợp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu()) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"INSERT INTO PhongTro (MaPhong, TenPhong, DienTich, GiaPhong, ToiDa, TrangThai)
                                   VALUES (@MaPhong, @TenPhong, @DienTich, @GiaPhong, @ToiDa, @TrangThai)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenPhong", txtTenPhong.Text.Trim());
                        cmd.Parameters.AddWithValue("@DienTich", decimal.Parse(txtDienTich.Text.Trim()));
                        cmd.Parameters.AddWithValue("@GiaPhong", decimal.Parse(txtGiaPhong.Text.Trim()));
                        cmd.Parameters.AddWithValue("@ToiDa", int.Parse(txtToiDa.Text.Trim()));
                        cmd.Parameters.AddWithValue("@TrangThai", cboTrangThai.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm phòng trọ thành công!");
                XoaONhap();
                LoadDuLieu();   // dữ liệu mới từ DB hiển thị ra dgv
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("Mã phòng đã tồn tại!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa trong danh sách!");
                return;
            }
            if (!KiemTraDuLieu()) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"UPDATE PhongTro
                                   SET TenPhong = @TenPhong, DienTich = @DienTich, GiaPhong = @GiaPhong,
                                       ToiDa = @ToiDa, TrangThai = @TrangThai
                                   WHERE MaPhong = @MaPhong";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenPhong", txtTenPhong.Text.Trim());
                        cmd.Parameters.AddWithValue("@DienTich", decimal.Parse(txtDienTich.Text.Trim()));
                        cmd.Parameters.AddWithValue("@GiaPhong", decimal.Parse(txtGiaPhong.Text.Trim()));
                        cmd.Parameters.AddWithValue("@ToiDa", int.Parse(txtToiDa.Text.Trim()));
                        cmd.Parameters.AddWithValue("@TrangThai", cboTrangThai.Text.Trim());

                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("Không tìm thấy phòng cần sửa (không được đổi mã phòng)!");
                            return;
                        }
                    }
                }

                MessageBox.Show("Sửa phòng trọ thành công!");
                LoadDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text.Trim();
            if (maPhong == "")
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa trong danh sách!");
                return;
            }

            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng " + maPhong + "?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM PhongTro WHERE MaPhong = @MaPhong", conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Xóa phòng trọ thành công!");
                XoaONhap();
                LoadDuLieu();
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("Không thể xóa: phòng này đang được dùng trong Hợp đồng/Hóa đơn!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaONhap();
            txtTimKiem.Clear();
            LoadDuLieu();
        }

        // Đổ dữ liệu từ dòng được chọn trên DataGridView xuống các ô nhập liệu bên dưới
        private void dgvPhongTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
          
            txtMaPhong.Text = dgvPhongTro.Rows[i].Cells[0].Value.ToString();
            txtTenPhong.Text = dgvPhongTro.Rows[i].Cells[1].Value.ToString();
            txtDienTich.Text = dgvPhongTro.Rows[i].Cells[2].Value.ToString();
            txtGiaPhong.Text = dgvPhongTro.Rows[i].Cells[3].Value.ToString();
            txtToiDa.Text = dgvPhongTro.Rows[i].Cells[4].Value.ToString();
            cboTrangThai.Text = dgvPhongTro.Rows[i].Cells[5].Value.ToString();
        }
    }
}
