using Quanlyphongtromini.Services;
using System;
using System.Windows.Forms;

namespace Quanlyphongtromini
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chkHienMatKhau.Checked ? '\0' : '●';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                lblThongBao.Text = "Vui lòng nhập tên đăng nhập.";
                return;
            }
            if (txtMatKhau.Text.Length == 0)
            {
                lblThongBao.Text = "Vui lòng nhập mật khẩu.";
                return;
            }

            string loi = AuthService.Login(txtTenDangNhap.Text, txtMatKhau.Text);

            if (loi != null)
            {
                lblThongBao.Text = loi;
                txtMatKhau.Clear();
                txtMatKhau.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK; // Program.cs sẽ mở MainForm
            this.Close();
        }

        private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            string tenMoi = null;
            using (var frm = new RegisterForm())
            {
                if (frm.ShowDialog() == DialogResult.OK) tenMoi = frm.TenDangNhapMoi;
            }
            this.Show();

            if (tenMoi != null)
            {
                // Đăng ký xong: điền sẵn tên đăng nhập, người dùng chỉ cần nhập mật khẩu
                txtTenDangNhap.Text = tenMoi;
                txtMatKhau.Clear();
                lblThongBao.Text = "";
                txtMatKhau.Focus();
            }
        }
    }
}