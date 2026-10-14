using Quanlyphongtromini.Services;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Quanlyphongtromini
{
    public partial class RegisterForm : Form
    {
        // LoginForm đọc để điền sẵn sau khi đăng ký xong
        public string TenDangNhapMoi { get; private set; }

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            char c = chkHienMatKhau.Checked ? '\0' : '●';
            txtMatKhau.PasswordChar = c;
            txtXacNhan.PasswordChar = c;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string loi = KiemTraDuLieu();
            if (loi != null)
            {
                lblThongBao.Text = loi;
                return;
            }
            lblThongBao.Text = "";

            loi = AuthService.Register(txtTenDangNhap.Text, txtEmail.Text, txtSoDienThoai.Text, txtMatKhau.Text);

            if (loi != null)
            {
                lblThongBao.Text = loi;
                return;
            }

            TenDangNhapMoi = txtTenDangNhap.Text.Trim();
            MessageBox.Show("Đăng ký thành công! Bạn có thể đăng nhập ngay.", "Phòng trọ mini",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Trả về thông báo lỗi đầu tiên, hoặc null nếu hợp lệ
        private string KiemTraDuLieu()
        {
            if (txtTenDangNhap.Text.Trim().Length < 4) return "Tên đăng nhập tối thiểu 4 ký tự.";
            if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) return "Email không hợp lệ.";
            if (!Regex.IsMatch(txtSoDienThoai.Text.Trim(), @"^0\d{9}$")) return "Số điện thoại phải gồm 10 số, bắt đầu bằng 0.";
            if (txtMatKhau.Text.Length < 6) return "Mật khẩu tối thiểu 6 ký tự.";
            if (txtMatKhau.Text != txtXacNhan.Text) return "Mật khẩu xác nhận không khớp.";
            return null;
        }

        private void lnkDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // quay lại form đăng nhập
            this.Close();
        }
    }
}