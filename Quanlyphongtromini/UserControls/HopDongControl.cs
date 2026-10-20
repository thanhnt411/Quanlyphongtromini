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
        //@"Server=LAPTOP-71REBECI;Database=QlPhongTro;Trusted_Connection=True;TrustServerCertificate=True;";
        @"Server=localhost\SQLEXPRESS;Database=QlPhongTro;Trusted_Connection=True;TrustServerCertificate=True;";

        private string maHDCu = "";      // mã hợp đồng gốc của dòng đang chọn (dùng để tìm dòng khi Sửa/Xóa)
        private string phongCu = "";     // phòng gốc của dòng đang chọn (dùng khi Sửa/Xóa)

        public HopDongControl()
        {
            InitializeComponent();
        }


        public void LamMoiDuLieu()
        {
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

        
        private void LoadComboBox(string maPhongDangChon = null)
        {
            //b1 ket noi database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                //b2 lay du lieu ve tu bang phong tro (chi lay phong Trong, cong them phong cua hop dong dang chon)
                string sqlPhong = @"SELECT MaPhong FROM PhongTro
                                    WHERE RTRIM(TrangThai) = N'Trống' OR MaPhong = @maPhong";
                SqlDataAdapter daPhong = new SqlDataAdapter(sqlPhong, conn);
                daPhong.SelectCommand.Parameters.Add("@maPhong", SqlDbType.NVarChar, 50).Value =
                    (object)maPhongDangChon ?? DBNull.Value;
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

        // doi trang thai phong trong phong tro
        private void CapNhatTrangThaiPhong(string maPhong, string trangThai)
        {
            if (string.IsNullOrEmpty(maPhong)) return;

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand("UPDATE PhongTro SET TrangThai=@tt WHERE MaPhong=@ma", conn))
            {
                cmd.Parameters.Add("@tt", SqlDbType.NVarChar, 20).Value = trangThai;
                cmd.Parameters.Add("@ma", SqlDbType.NVarChar, 50).Value = maPhong;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // xoa trang o nhap
        private void XoaForm()
        {
            maHDCu = "";
            phongCu = "";
            txtMaHopDong.Clear();
            txtTienCoc.Clear();
            cboPhong.SelectedIndex = -1;
            cboNguoiThue.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today;
        }


        private decimal? TinhTienCoc(string maPhong)
        {
            if (string.IsNullOrEmpty(maPhong)) return null;

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(
                "SELECT GiaPhong, HienTai FROM PhongTro WHERE MaPhong=@ma", conn))
            {
                cmd.Parameters.Add("@ma", SqlDbType.NVarChar, 50).Value = maPhong;
                conn.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    if (!rd.Read()) return null;
                    if (rd.IsDBNull(0) || rd.IsDBNull(1)) return null;

                    decimal gia = Convert.ToDecimal(rd["GiaPhong"]);
                    int soNguoi = Convert.ToInt32(rd["HienTai"]);
                    if (soNguoi <= 0) soNguoi = 1;          //ko co ai thi tinh 1 ng

                    return Math.Round(gia / soNguoi, 0);    // cot TienCoc scale = 0
                }
            }
        }


        
        private void cboPhong_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string phong = (cboPhong.SelectedItem as DataRowView)?["MaPhong"]?.ToString() ?? "";
            decimal? tc = TinhTienCoc(phong);

            if (tc == null)
            {
                txtTienCoc.Clear();
                MessageBox.Show("Phòng này chưa có giá phòng hoặc số người ở (phải > 0) nên không tính được tiền cọc!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtTienCoc.Text = tc.Value.ToString("0");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //b1 lay du lieu
            string maHD = txtMaHopDong.Text.Trim();
            string trangThai = cboTrangThai.Text.Trim();
            string phong = cboPhong.SelectedValue?.ToString() ?? "";              //gan gia tri rong
            string nguoiThue = cboNguoiThue.SelectedValue?.ToString() ?? "";      //gan gia tri rong
            DateTime nbd = dtpNgayBatDau.Value.Date;
            DateTime nkt = dtpNgayKetThuc.Value.Date;


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


            decimal? tcTinh = TinhTienCoc(phong);
            if (tcTinh == null)
            {
                MessageBox.Show("Không tính được tiền cọc: phòng thiếu giá phòng hoặc số người ở phải > 0!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal tc = tcTinh.Value;

            //b3 + b4 ket noi database va thuc hien lenh sql
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO HopDong (MaHD,MaPhong,MaNguoi,DayStart,DayEnd,TrangThai,TienCoc) " +
                    "VALUES(@MaHD,@MaPhong,@MaNguoi,@DayStart,@DayEnd,@TrangThai,@TienCoc)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.Parameters.AddWithValue("@MaPhong", phong);
                    cmd.Parameters.AddWithValue("@MaNguoi", nguoiThue);
                    cmd.Parameters.AddWithValue("@DayStart", nbd);
                    cmd.Parameters.AddWithValue("@DayEnd", nkt);
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                    cmd.Parameters.AddWithValue("@TienCoc", tc);
                    cmd.ExecuteNonQuery();
                }
            }

            // hop dong con han thi chuyen qua dang thue
            if (trangThai == "Còn hạn")
                CapNhatTrangThaiPhong(phong, "Đang thuê");

            MessageBox.Show("Thêm hợp đồng thành công!");
            XoaForm();
            LoadDuLieu("");
            LoadComboBox();
        }

        private void HopDongControl_Load(object sender, EventArgs e)
        {
            LoadDuLieu("");
            LoadComboBox();
        }

        
        private void btnSua_Click(object sender, EventArgs e)
        {
            //b1 lay du lieu
            string maHD = txtMaHopDong.Text.Trim();
            string trangThai = cboTrangThai.Text.Trim();
            string phong = cboPhong.SelectedValue?.ToString() ?? "";            //gan gia tri rong
            string nguoiThue = cboNguoiThue.SelectedValue?.ToString() ?? "";    //gan gia tri rong
            DateTime nbd = dtpNgayBatDau.Value.Date;
            DateTime nkt = dtpNgayKetThuc.Value.Date;

            // ktra trc khi chay sql
            if (string.IsNullOrEmpty(maHDCu))
            {
                MessageBox.Show("Hãy click chọn một hợp đồng trên lưới trước!");
                return;
            }
            if (string.IsNullOrEmpty(maHD) || string.IsNullOrEmpty(phong) || string.IsNullOrEmpty(nguoiThue))
            {
                MessageBox.Show("Vui lòng nhập mã hợp đồng, chọn phòng và người thuê!");
                return;
            }
            if (trangThai != "Còn hạn" && trangThai != "Hết hạn")
            {
                MessageBox.Show("Vui lòng chọn trạng thái 'Còn hạn' hoặc 'Hết hạn'!");
                return;
            }
            if (nkt <= nbd)
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu!");
                return;
            }


            decimal tc;
            if (phong == phongCu)
            {
                if (!decimal.TryParse(txtTienCoc.Text, out tc))
                {
                    MessageBox.Show("Tiền cọc không hợp lệ!");
                    return;
                }
            }
            else
            {
                decimal? tcTinh = TinhTienCoc(phong);
                if (tcTinh == null)
                {
                    MessageBox.Show("Không tính được tiền cọc: phòng thiếu giá phòng hoặc số người ở phải > 0!");
                    return;
                }
                tc = tcTinh.Value;
                txtTienCoc.Text = tc.ToString("0");
            }

            //b2 + b3 ket noi database va thuc hien lenh sql
            int rows;

            try                                                    
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE HopDong SET MaHD=@maMoi,MaPhong=@phong,MaNguoi=@nguoiThue,DayStart=@nbd,DayEnd=@nkt,TrangThai=@trangThai,TienCoc=@tienCoc where MaHD=@maCu";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@maMoi", SqlDbType.NVarChar, 50).Value = maHD;
                        cmd.Parameters.Add("@maCu", SqlDbType.NVarChar, 50).Value = maHDCu;
                        cmd.Parameters.Add("@phong", SqlDbType.NVarChar, 50).Value = phong;
                        cmd.Parameters.Add("@nguoiThue", SqlDbType.NVarChar, 50).Value = nguoiThue;
                        cmd.Parameters.Add("@nbd", SqlDbType.Date).Value = nbd;
                        cmd.Parameters.Add("@nkt", SqlDbType.Date).Value = nkt;
                        cmd.Parameters.Add("@trangThai", SqlDbType.NVarChar, 20).Value = trangThai;
                        var p = cmd.Parameters.Add("@tienCoc", SqlDbType.Decimal);
                        p.Precision = 18; p.Scale = 0;
                        p.Value = tc;

                        rows = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)   // trung maHD
            {
                MessageBox.Show("Mã hợp đồng '" + maHD + "' đã tồn tại, hãy chọn mã khác!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (SqlException ex) when (ex.Number == 547)                         // vuong khoa ngoai
            {
                MessageBox.Show("Không thể đổi mã hợp đồng này vì đã có hóa đơn liên quan.\n" +
                                "Hãy giữ nguyên mã hợp đồng và chỉ sửa các thông tin khác.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (SqlException ex)                                                 // loi khac
            {
                MessageBox.Show("Không sửa được hợp đồng: " + ex.Message);
                return;
            }

            if (rows == 0)
            {
                MessageBox.Show("Không tìm thấy hợp đồng, hãy click chọn 1 dòng trên lưới trước!");
                return;
            }

            // dong bo trang thai phong
            if (!string.IsNullOrEmpty(phongCu) && phongCu != phong)
                CapNhatTrangThaiPhong(phongCu, "Trống");
            CapNhatTrangThaiPhong(phong, trangThai == "Còn hạn" ? "Đang thuê" : "Trống");

            MessageBox.Show("sửa thành công");
            XoaForm();
            LoadDuLieu("");
            LoadComboBox();
        }

        
        private void btnXoaHD_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(maHDCu))
            {
                MessageBox.Show("Hãy click chọn một hợp đồng trên lưới trước!");
                return;
            }

            // hoi xac nhan
            if (MessageBox.Show("Bạn có chắc muốn xóa hợp đồng này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            //b2 + b3 ket noi database va thuc hien lenh sql
            try                                                    
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM HopDong where MaHD=@maHD";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@maHD", SqlDbType.NVarChar, 50).Value = maHDCu;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex) when (ex.Number == 547)         // hop dong da co hoa don
            {
                MessageBox.Show("Không thể xóa hợp đồng này vì đã có hóa đơn liên quan.\n" +
                                "Hãy xóa hóa đơn trước, hoặc đổi trạng thái hợp đồng sang 'Hết hạn'.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;                                             // return de phong ko bi doi thanh trong
            }
            catch (SqlException ex)                                 // loi khac
            {
                MessageBox.Show("Không xóa được hợp đồng: " + ex.Message);
                return;
            }

            // hop dong bi xoa thi phong tro thanh trong
            CapNhatTrangThaiPhong(phongCu, "Trống");

            XoaForm();
            LoadDuLieu("");
            LoadComboBox();
        }

        private void dgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvHopDong.Rows[e.RowIndex];

            maHDCu = row.Cells["colMaHopDong"].Value?.ToString()?.Trim() ?? "";
            phongCu = row.Cells["colPhong"].Value?.ToString()?.Trim() ?? "";

            // nap lai combobox
            LoadComboBox(phongCu);

            txtMaHopDong.Text = row.Cells["colMaHopDong"].Value?.ToString();
            cboPhong.SelectedValue = phongCu;
            cboNguoiThue.SelectedValue = row.Cells["colNguoiThue"].Value?.ToString();
            dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["colNgayBatDau"].Value);
            dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells["colNgayKetThuc"].Value);
            txtTienCoc.Text = Convert.ToDecimal(row.Cells["colTienCoc"].Value).ToString("0");
            cboTrangThai.Text = row.Cells["colTrangThai"].Value?.ToString()?.Trim();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaForm();
            txtMaHopDong.Enabled = true;

            txtTimKiem.Clear();

            LoadDuLieu("");
            LoadComboBox();                 // nap lai phong trong
            dgvHopDong.ClearSelection();

            txtMaHopDong.Focus();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //b1 lay tu khoa tim kiem
            string tukhoa = txtTimKiem.Text.Trim();

            LoadDuLieu(tukhoa);

            //neu ko tim thay
            if (dgvHopDong.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hợp đồng nào phù hợp!", "Thông báo", MessageBoxButtons.OK);
            }

            dgvHopDong.ClearSelection();

        }
    }
}