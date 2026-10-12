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
    public partial class HopDongControl : UserControl
    {
        private const string connectionString =
            @"Data Source=LAPTOP-71REBECI;Initial Catalog=QLPhongTro;Integrated Security=True;TrustServerCertificate=True";
        public HopDongControl()
        {
            InitializeComponent();
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
            string sql = "SELECT hd.* " +
                "FROM HopDong hd " +
                "JOIN NguoiThue nt ON hd.MaNguoi = nt.MaNguoi " +
                "WHERE nt.Hoten LIKE N'%' + @tukhoa + N'%' " +
                "OR hd.MaPhong LIKE N'%' + @tukhoa + N'%' ";


            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@tukhoa", SqlDbType.NVarChar, 50).Value = tukhoa;

            //b3 tao doi tuong dataadapter de chuyen du lieu ra ngoai DB
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand = cmd;

            //b4 tao doi tuong dataset/table de nhan du lieu tu dataadapter
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            conn.Close();

            //b5 do du lieu tu dataset/table vao datagridview
            dgvHopDong.DataSource = tb;
            dgvHopDong.Refresh();

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

                //b2 lay du lieu tu bang nguoi thue
                SqlDataAdapter daNguoi = new SqlDataAdapter("SELECT MaNguoi FROM NguoiThue", conn);
                DataTable tbNguoi = new DataTable();
                daNguoi.Fill(tbNguoi);

                cboNguoiThue.DataSource = tbNguoi;
                cboNguoiThue.DisplayMember = "MaNguoi";
                cboNguoiThue.ValueMember = "MaNguoi";
                cboNguoiThue.SelectedIndex = -1;
            }      
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //b1 lay du lieu
            string maHD = txtMaHopDong.Text.Trim();
            string trangThai = cboTrangThai.Text.Trim();
            string phong = cboPhong.SelectedValue?.ToString() ?? "";              //gán giá trị rỗng
            string nguoiThue = cboNguoiThue.SelectedValue?.ToString() ?? "";      //gán giá trị rỗng
            DateTime nbd = dtpNgayBatDau.Value.Date;
            DateTime nkt = dtpNgayKetThuc.Value.Date;
            string tienCoc = txtTienCoc.Text.Trim();

            //b2 kiem tra du lieu
            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Vui lòng nhập mã hợp đồng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHopDong.Focus();
                return;
            }

            if (string.IsNullOrEmpty(phong) || string.IsNullOrEmpty(nguoiThue))
            {
                MessageBox.Show("Vui lòng chọn phòng và người thuê!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (trangThai != "Còn hạn" && trangThai != "Hết hạn")
            {
                MessageBox.Show("Trạng thái phải là 'Còn hạn' hoặc 'Hết hạn'!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTrangThai.Focus();
                return;
            }

            if (nkt <= nbd)
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(tienCoc))
            {
                MessageBox.Show("Vui lòng nhập tiền cọc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienCoc.Focus();
                return;
            }

            if (!decimal.TryParse(tienCoc, out decimal tc) || tc < 0)
            {
                MessageBox.Show("Tiền cọc phải là số và không âm!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienCoc.Focus();
                return;
            }

            //b3 ket noi database
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            //b4 tao command de thuc hien lenh sql
            string sql = "INSERT INTO HopDong (MaHD,MaPhong,MaNguoi,DayStart,DayEnd,TrangThai,TienCoc) " +
                "VALUES(@MaHD,@MaPhong,@MaNguoi,@DayStart,@DayEnd,@TrangThai,@TienCoc)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@MaHD", maHD);
            cmd.Parameters.AddWithValue("@MaPhong", phong);
            cmd.Parameters.AddWithValue("@MaNguoi", nguoiThue);
            cmd.Parameters.AddWithValue("@DayStart", nbd);
            cmd.Parameters.AddWithValue("@DayEnd", nkt);
            cmd.Parameters.AddWithValue("@TrangThai", trangThai);
            cmd.Parameters.AddWithValue("@TienCoc", tc);

            cmd.ExecuteNonQuery();

            LoadDuLieu("");
        }

        private void HopDongControl_Load(object sender, EventArgs e)
        {
            LoadDuLieu("");
            LoadComboBox();
        }
        private string maHDCu = "";
        private void btnSua_Click(object sender, EventArgs e)
        {
            //b1 lay du lieu
            string maHD = txtMaHopDong.Text.Trim();
            string trangThai = cboTrangThai.Text.Trim();
            string phong = cboPhong.SelectedValue?.ToString() ?? "";            //gán giá trị rỗng
            string nguoiThue = cboNguoiThue.SelectedValue?.ToString() ?? "";    //gán giá trị rỗng
            DateTime nbd = dtpNgayBatDau.Value.Date;
            DateTime nkt = dtpNgayKetThuc.Value.Date;
            string tienCoc = txtTienCoc.Text.Trim();
            //b2 ket noi database
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            //b3 tao command de thuc hien lenh sql
            string sql = "UPDATE HopDong SET MaHD=@maMoi,MaPhong=@phong,MaNguoi=@nguoiThue,DayStart=@nbd,DayEnd=@nkt,TrangThai=@trangThai,TienCoc=@tienCoc where MaHD=@maCu";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@maMoi", SqlDbType.NVarChar, 50).Value = maHD;     // <-- SỬA (thay dòng @maHD)
            cmd.Parameters.Add("@maCu", SqlDbType.NVarChar, 50).Value = maHDCu;
            cmd.Parameters.Add("@phong", SqlDbType.NVarChar, 50).Value = phong;
            cmd.Parameters.Add("@nguoiThue", SqlDbType.NVarChar, 50).Value = nguoiThue;
            cmd.Parameters.Add("@nbd", SqlDbType.Date).Value = nbd;
            cmd.Parameters.Add("@nkt", SqlDbType.Date).Value = nkt;
            cmd.Parameters.Add("@trangThai", SqlDbType.NVarChar, 20).Value = trangThai;
            string tiencoc = txtTienCoc.Text.Replace(",", "").Replace(".", "").Trim();
            if (!decimal.TryParse(tiencoc, out decimal tc))
            {
                MessageBox.Show("Tiền cọc phải là số!");
                return;
            }
            var p = cmd.Parameters.Add("@tienCoc", SqlDbType.Decimal);
            p.Precision = 18; p.Scale = 0;
            p.Value = tc;

            cmd.ExecuteNonQuery();
            //giai phong tai nguyen
            cmd.Dispose();
            conn.Close();

            MessageBox.Show("sửa thành công");
            LoadDuLieu("");

        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            //b1 lay du lieu
            string maHD = txtMaHopDong.Text.Trim();
            //b2 ket noi database
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            //b3 tao command de thuc hien lenh sql
            string sql = "DELETE FROM HopDong where MaHD=@maHD";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@maHD", SqlDbType.NVarChar, 50).Value = maHD;

            cmd.ExecuteNonQuery();
            //giai phong tai nguyen
            cmd.Dispose();
            conn.Close();

            //thong bao
            if (MessageBox.Show("Bạn có chắc muốn xóa hợp đồng này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            LoadDuLieu("");
        }

        private void dgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvHopDong.Rows[e.RowIndex];

            maHDCu = row.Cells["colMaHopDong"].Value?.ToString()?.Trim() ?? "";

            txtMaHopDong.Text = row.Cells["colMaHopDong"].Value?.ToString();
            cboPhong.SelectedValue = row.Cells["colPhong"].Value?.ToString();
            cboNguoiThue.SelectedValue = row.Cells["colNguoiThue"].Value?.ToString();
            dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["colNgayBatDau"].Value);
            dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells["colNgayKetThuc"].Value);
            txtTienCoc.Text = Convert.ToDecimal(row.Cells["colTienCoc"].Value).ToString("0");
            cboTrangThai.Text = row.Cells["colTrangThai"].Value?.ToString()?.Trim();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHopDong.Clear();
            txtTienCoc.Clear();
            cboPhong.SelectedIndex = -1;
            cboNguoiThue.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today;
            txtMaHopDong.Enabled = true;

            txtTimKiem.Clear();

            LoadDuLieu("");
            dgvHopDong.ClearSelection();

            txtMaHopDong.Focus();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //b1 lay tu khoa tim kiem
            string tukhoa = txtTimKiem.Text.Trim();

            LoadDuLieu(tukhoa);

            //neu ko tim thay
            if (dgvHopDong.Rows.Count==0)
            {
                MessageBox.Show("Không tìm thấy hợp đồng nào phù hợp!", "Thông báo", MessageBoxButtons.OK);
            }

            dgvHopDong.ClearSelection();

        }
    }
}


