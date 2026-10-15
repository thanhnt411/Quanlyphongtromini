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
    public partial class DichVuControl : UserControl
    {
        private const string connectionString =
           @"Data Source=DESKTOP-GNHSIT6\SQLEXPRESS;Initial Catalog=QuanLyPhongTroMini3;Integrated Security=True;Trust Server Certificate=True";

        // Mã của dòng đang chọn (null = chưa chọn dòng nào)
        private string maCu = null;

        public DichVuControl()
        {
            InitializeComponent();
            Load += DichVuControl_Load;

            // Gỡ trước rồi gắn lại để mỗi sự kiện chỉ chạy đúng 1 lần
            dgvDichVu.CellClick -= dgvDichVu_CellClick;
            dgvDichVu.CellClick += dgvDichVu_CellClick;

            btnSua.Click -= btnSua_Click;
            btnSua.Click += btnSua_Click;

            btnTim.Click -= btnTim_Click;
            btnTim.Click += btnTim_Click;

            // Nhấn Enter trong ô tìm kiếm cũng tìm luôn
            txtTimKiem.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    btnTim_Click(s, e);
                }
            };
        }

        private void DichVuControl_Load(object sender, EventArgs e)
        {
            // Không truy cập DB khi đang mở ở chế độ Design
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            dgvDichVu.ReadOnly = true;
            dgvDichVu.AllowUserToAddRows = false;
            dgvDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDichVu.MultiSelect = false;

            LoadData();
        }

        // Xóa 3 ô nhập và bỏ nhớ dòng đang chọn
        private void XoaOnhap()
        {
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtGia.Clear();
            maCu = null;
        }

        // Đọc danh sách dịch vụ rồi đổ lên bảng (có lọc theo từ khóa; rỗng = lấy tất cả)
        private void LoadData(string tuKhoa = "")
        {
            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                using var cmd = new SqlCommand(
                    @"SELECT MaDV, TenDV, Gia FROM DichVu3
                      WHERE MaDV LIKE @kw OR TenDV LIKE @kw
                      ORDER BY MaDV", conn);
                cmd.Parameters.AddWithValue("@kw", "%" + tuKhoa + "%");
                using var r = cmd.ExecuteReader();

                if (dgvDichVu.Columns.Count == 0)
                {
                    dgvDichVu.Columns.Add("MaDV", "MÃ DV");
                    dgvDichVu.Columns.Add("TenDV", "TÊN DỊCH VỤ");
                    dgvDichVu.Columns.Add("Gia", "GIÁ (VNĐ)");
                }
                dgvDichVu.Columns[2].DefaultCellStyle.Format = "N0";

                dgvDichVu.Rows.Clear();
                while (r.Read())
                {
                    // TenDV, Gia có thể NULL nên kiểm tra trước khi đọc
                    string ten = r.IsDBNull(1) ? "" : r.GetString(1);
                    decimal gia = r.IsDBNull(2) ? 0 : r.GetDecimal(2);
                    dgvDichVu.Rows.Add(r.GetString(0), ten, gia);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // Bấm vào dòng nào thì đổ dữ liệu dòng đó xuống 3 ô nhập
        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvDichVu.Rows[e.RowIndex];
            txtMaDV.Text = row.Cells[0].Value?.ToString();
            txtTenDV.Text = row.Cells[1].Value?.ToString();
            txtGia.Text = Convert.ToDecimal(row.Cells[2].Value).ToString("0");
            maCu = txtMaDV.Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaDV.Text.Trim();
            string ten = txtTenDV.Text.Trim();

            if (ma == "" || ten == "")
            {
                MessageBox.Show("Vui lòng nhập mã và tên dịch vụ.");
                return;
            }
            if (!decimal.TryParse(txtGia.Text.Trim(), out decimal gia) || gia < 0)
            {
                MessageBox.Show("Giá phải là số không âm (ví dụ: 3500).");
                return;
            }

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                using var cmd = new SqlCommand(
                    "INSERT INTO DichVu3 (MaDV, TenDV, Gia) VALUES (@ma, @ten, @gia)", conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@gia", gia);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm dịch vụ thành công.");
                XoaOnhap();
                txtTimKiem.Clear();
                txtMaDV.Focus();

                LoadData();
            }
            catch (SqlException ex) when (ex.Number == 2627) // trùng mã
            {
                MessageBox.Show("Mã dịch vụ đã tồn tại.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Sửa đúng 1 dịch vụ đang chọn (tìm theo mã cũ, cho phép đổi cả mã)
        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaDV.Text.Trim();
            string ten = txtTenDV.Text.Trim();

            if (maCu == null)
            {
                MessageBox.Show("Hãy chọn một dịch vụ trong danh sách để sửa.");
                return;
            }
            if (ma == "" || ten == "")
            {
                MessageBox.Show("Vui lòng nhập mã và tên dịch vụ.");
                return;
            }
            if (!decimal.TryParse(txtGia.Text.Trim(), out decimal gia) || gia < 0)
            {
                MessageBox.Show("Giá phải là số không âm (ví dụ: 3500).");
                return;
            }

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                using var cmd = new SqlCommand(
                    "UPDATE DichVu3 SET MaDV = @maMoi, TenDV = @ten, Gia = @gia WHERE MaDV = @maCu", conn);
                cmd.Parameters.AddWithValue("@maMoi", ma);
                cmd.Parameters.AddWithValue("@maCu", maCu);
                cmd.Parameters.AddWithValue("@ten", ten);
                cmd.Parameters.AddWithValue("@gia", gia);

                if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Không tìm thấy dịch vụ này để sửa.");
                    return;
                }

                MessageBox.Show("Sửa dịch vụ thành công.");
                XoaOnhap();
                txtTimKiem.Clear();

                LoadData();
            }
            catch (SqlException ex) when (ex.Number == 2627) // mã mới trùng dịch vụ khác
            {
                MessageBox.Show("Mã dịch vụ mới đã tồn tại.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maCu == null)
            {
                MessageBox.Show("Hãy chọn một dịch vụ trong danh sách để xóa.");
                return;
            }

            var hoi = MessageBox.Show(
                $"Bạn có chắc muốn xóa dịch vụ \"{txtTenDV.Text.Trim()}\" (mã {maCu}) không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (hoi != DialogResult.Yes) return;

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                using var cmd = new SqlCommand("DELETE FROM DichVu3 WHERE MaDV = @maCu", conn);
                cmd.Parameters.AddWithValue("@maCu", maCu);

                if (cmd.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Không tìm thấy dịch vụ này để xóa.");
                    return;
                }

                MessageBox.Show("Xóa dịch vụ thành công.");
                XoaOnhap();
                txtTimKiem.Clear();

                LoadData();
            }
            catch (SqlException ex) when (ex.Number == 547) // đang được bảng khác tham chiếu
            {
                MessageBox.Show("Không thể xóa vì dịch vụ này đang được sử dụng ở nơi khác (ví dụ: hóa đơn).");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaOnhap();
            txtTimKiem.Clear();

            LoadData();
            dgvDichVu.ClearSelection();
            txtMaDV.Focus();
        }

        // Tìm theo mã hoặc tên dịch vụ (gần đúng)
        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (tuKhoa == "")
            {
                MessageBox.Show("Vui lòng nhập mã hoặc tên dịch vụ cần tìm.");
                txtTimKiem.Focus();
                return;
            }

            LoadData(tuKhoa);

            if (dgvDichVu.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy dịch vụ nào phù hợp.");
                return;
            }

            // Bỏ chọn dòng và xóa ô nhập, tránh sửa/xóa nhầm dịch vụ cũ
            XoaOnhap();
            dgvDichVu.ClearSelection();
        }
    }
}