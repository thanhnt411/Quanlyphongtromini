using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Quanlyphongtromini.UserControls
{
    public partial class NguoiThueControl : UserControl
    {
        // Chuỗi kết nối DB (thay cho đúng máy của bạn)
        string connectionString = @"Data Source=DESKTOP-GNHSIT6\SQLEXPRESS;Initial Catalog=QuanLyPhongTroMini;Integrated Security=True;TrustServerCertificate=True";

        // Đối tượng kết nối dùng chung cho cả form
        SqlConnection con;

        // Lưu mã người thuê gốc của dòng đang chọn (để còn sửa được cả mã)
        string maCu = "";

        public NguoiThueControl()
        {
            InitializeComponent();
            con = new SqlConnection(connectionString);
            load_dgvNguoiThue();

            // Click vào dòng trong bảng thì hiện dữ liệu lên các ô nhập
            dgvNguoiThue.CellClick += dgvNguoiThue_CellClick;
        }

        // ============ BẮT LỖI TRỐNG THÔNG TIN ============
        // Trả về true nếu có lỗi (còn ô trống)
        private bool batLoiThongTin()
        {
            if (txtMaNguoi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã người thuê!");
                txtMaNguoi.Focus();
                return true;
            }
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return true;
            }
            if (txtSdt.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!");
                txtSdt.Focus();
                return true;
            }
            if (txtCCCD.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập CCCD!");
                txtCCCD.Focus();
                return true;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ!");
                txtDiaChi.Focus();
                return true;
            }
            return false;
        }

        // ============ HIỂN THỊ DỮ LIỆU LÊN BẢNG ============
        private void load_dgvNguoiThue()
        {
            // Không cho grid tự sinh cột, dùng đúng các cột đã thiết kế
            dgvNguoiThue.AutoGenerateColumns = false;

            // Gắn từng cột thiết kế với cột trong DB (theo tên tiêu đề)
            foreach (DataGridViewColumn col in dgvNguoiThue.Columns)
            {
                string h = (col.HeaderText ?? "").Trim().ToUpper();

                if (h == "MÃ") col.DataPropertyName = "MaNguoi";
                else if (h == "HỌ TÊN") col.DataPropertyName = "Hoten";
                else if (h == "SĐT") col.DataPropertyName = "Sdt";
                else if (h == "CCCD") col.DataPropertyName = "Cccd";
                else if (h == "ĐỊA CHỈ") col.DataPropertyName = "DiaChi";
            }

            if (con.State == ConnectionState.Closed) con.Open();

            string sql = "SELECT MaNguoi, Hoten, Sdt, Cccd, DiaChi FROM NguoiThue";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvNguoiThue.DataSource = dt;

            da.Dispose();
            con.Close();
        }

        // ============ CLICK VÀO DÒNG -> HIỆN LÊN Ô NHẬP ============
        private void dgvNguoiThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView drv = dgvNguoiThue.Rows[e.RowIndex].DataBoundItem as DataRowView;
            if (drv == null) return;

            txtMaNguoi.Text = drv["MaNguoi"].ToString();
            txtHoTen.Text = drv["Hoten"].ToString();
            txtSdt.Text = drv["Sdt"].ToString();
            txtCCCD.Text = drv["Cccd"].ToString();
            txtDiaChi.Text = drv["DiaChi"].ToString();

            // Nhớ mã gốc để lúc sửa biết đang sửa dòng nào
            maCu = txtMaNguoi.Text.Trim();
        }

        // ============ NÚT THÊM ============
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Bắt lỗi trống thông tin
            if (batLoiThongTin())
            {
                return;
            }

            // B1: lấy dữ liệu của control đưa vào biến
            string p_MaNguoi = txtMaNguoi.Text.Trim();
            string p_HoTen = txtHoTen.Text.Trim();
            string p_Sdt = txtSdt.Text.Trim();
            string p_Cccd = txtCCCD.Text.Trim();
            string p_DiaChi = txtDiaChi.Text.Trim();

            try
            {
                // B2: kết nối đến DB
                if (con.State == ConnectionState.Closed) con.Open();

                // B3: tạo đối tượng command để thêm dữ liệu vào bảng NguoiThue và thực thi nó
                string sql = "INSERT INTO NguoiThue (MaNguoi, Hoten, Sdt, Cccd, DiaChi) " +
                             "VALUES (@MaNguoi, @Hoten, @Sdt, @Cccd, @DiaChi)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaNguoi", p_MaNguoi);
                cmd.Parameters.AddWithValue("@Hoten", p_HoTen);
                cmd.Parameters.AddWithValue("@Sdt", p_Sdt);
                cmd.Parameters.AddWithValue("@Cccd", p_Cccd);
                cmd.Parameters.AddWithValue("@DiaChi", p_DiaChi);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                maCu = p_MaNguoi;
                load_dgvNguoiThue();
                MessageBox.Show("Thêm thông tin người thuê thành công!");
            }
            catch (SqlException ex)
            {
                con.Close(); // đóng kết nối khi có lỗi
                MessageBox.Show("Không thêm được: " + ex.Message);
            }
        }

        // ============ NÚT SỬA (sửa được cả mã) ============
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Chưa chọn dòng nào
            if (maCu == "")
            {
                MessageBox.Show("Vui lòng chọn một dòng cần sửa!");
                return;
            }

            // Bắt lỗi trống thông tin
            if (batLoiThongTin())
            {
                return;
            }

            // B1: lấy dữ liệu của control đưa vào biến (p_MaMoi là mã sau khi sửa)
            string p_MaMoi = txtMaNguoi.Text.Trim();
            string p_HoTen = txtHoTen.Text.Trim();
            string p_Sdt = txtSdt.Text.Trim();
            string p_Cccd = txtCCCD.Text.Trim();
            string p_DiaChi = txtDiaChi.Text.Trim();

            try
            {
                // B2: kết nối đến DB
                if (con.State == ConnectionState.Closed) con.Open();

                // B3: tạo đối tượng command để sửa dữ liệu của bảng NguoiThue và thực thi nó
                // Gán mã mới (SET MaNguoi = @MaMoi), tìm dòng bằng mã cũ (WHERE MaNguoi = @MaCu)
                string sql = "UPDATE NguoiThue " +
                             "SET MaNguoi = @MaMoi, Hoten = @Hoten, Sdt = @Sdt, " +
                             "Cccd = @Cccd, DiaChi = @DiaChi " +
                             "WHERE MaNguoi = @MaCu";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaMoi", p_MaMoi);
                cmd.Parameters.AddWithValue("@Hoten", p_HoTen);
                cmd.Parameters.AddWithValue("@Sdt", p_Sdt);
                cmd.Parameters.AddWithValue("@Cccd", p_Cccd);
                cmd.Parameters.AddWithValue("@DiaChi", p_DiaChi);
                cmd.Parameters.AddWithValue("@MaCu", maCu);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                maCu = p_MaMoi; // cập nhật lại mã gốc sau khi sửa thành công
                load_dgvNguoiThue();
                MessageBox.Show("Sửa thông tin người thuê thành công !");
            }
            catch (SqlException ex)
            {
                con.Close();
                // Lỗi thường gặp: mã mới bị trùng, hoặc mã đang được bảng khác dùng
                MessageBox.Show("Không sửa được: " + ex.Message);
            }
        }

        // ============ NÚT XÓA ============
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // B1: lấy mã cần xóa (mã gốc của dòng đã chọn)
            if (maCu == "")
            {
                MessageBox.Show("Vui lòng chọn một dòng cần xóa!");
                return;
            }

            // Hỏi xác nhận trước khi xóa
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa người thuê " + maCu + " không?",
                                              "Xác nhận", MessageBoxButtons.YesNo);
            if (kq != DialogResult.Yes) return;

            try
            {
                // B2: kết nối đến DB
                if (con.State == ConnectionState.Closed) con.Open();

                // B3: tạo đối tượng command để xóa dữ liệu của bảng NguoiThue và thực thi nó
                string sql = "DELETE FROM NguoiThue WHERE MaNguoi = @MaNguoi";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@MaNguoi", maCu);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                load_dgvNguoiThue();
                XoaTrangONhap();
                MessageBox.Show("Xóa thông tin người thuê thành công!");
            }
            catch (SqlException ex)
            {
                con.Close();
                // Lỗi thường gặp: người thuê đang có hợp đồng (khóa ngoại)
                MessageBox.Show("Không xóa được: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            XoaTrangONhap();
            load_dgvNguoiThue();
            dgvNguoiThue.ClearSelection();
            txtMaNguoi.Focus();
        }

        // Hàm dùng chung: xóa trắng các ô nhập
        private void XoaTrangONhap()
        {
            txtMaNguoi.Clear();
            txtHoTen.Clear();
            txtSdt.Clear();
            txtCCCD.Clear();
            txtDiaChi.Clear();
            maCu = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string p_MaNguoi = txtMaNguoi.Text.Trim();
            string p_HoTen = txtHoTen.Text.Trim();
            string p_DiaChi = txtDiaChi.Text.Trim();
            string p_Cccd = txtCCCD.Text.Trim();
            string p_Sdt = txtSdt.Text.Trim();

            try
            {
                // B2: kết nối đến DB
                if (con.State == ConnectionState.Closed) con.Open();

                // B3: tạo câu truy vấn, dùng LIKE để tìm gần đúng
                // ISNULL(cột, '') để dòng có giá trị NULL vẫn được tìm thấy khi ô tìm kiếm để trống
                string query = "SELECT MaNguoi, Hoten, Sdt, Cccd, DiaChi FROM NguoiThue WHERE " +
                               "MaNguoi LIKE @MaNguoi " +
                               "AND Hoten LIKE @Hoten " +
                               "AND ISNULL(DiaChi, '') LIKE @DiaChi " +
                               "AND ISNULL(Cccd, '') LIKE @Cccd " +
                               "AND ISNULL(Sdt, '') LIKE @Sdt";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MaNguoi", "%" + p_MaNguoi + "%");
                cmd.Parameters.AddWithValue("@Hoten", "%" + p_HoTen + "%");
                cmd.Parameters.AddWithValue("@DiaChi", "%" + p_DiaChi + "%");
                cmd.Parameters.AddWithValue("@Cccd", "%" + p_Cccd + "%");
                cmd.Parameters.AddWithValue("@Sdt", "%" + p_Sdt + "%");

                // B4: tạo đối tượng dataAdapter để lấy dữ liệu từ cmd
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                // B5: đổ dữ liệu vào DataTable rồi hiển thị lên bảng
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNguoiThue.DataSource = dt;

                da.Dispose();
                cmd.Dispose();
                con.Close();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy người thuê nào phù hợp!");
                }
            }
            catch (SqlException ex)
            {
                con.Close();
                MessageBox.Show("Không tìm kiếm được: " + ex.Message);
            }
        }
    }
}