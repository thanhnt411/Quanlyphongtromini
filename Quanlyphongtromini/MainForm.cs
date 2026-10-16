using Quanlyphongtromini.Services;
using Quanlyphongtromini.UserControls;
using System;
using System.Windows.Forms;

namespace Quanlyphongtromini
{
    public partial class MainForm : Form
    {
        // Program.cs đọc: true = quay lại màn đăng nhập, false = thoát chương trình
        public bool DangXuat { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            lblNguoiDung.Text = "👤 " + AuthService.TenDangNhap;
            _current = btnTongQuan; // trạng thái ban đầu (màu đã đặt sẵn trong Designer)
            LoadPage(new DashboardControl());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn == _current) return;

            SetActiveButton(btn); // phần màu sắc nằm trong MainForm.Designer.cs

            switch (btn.Tag.ToString())
            {
                 case "TongQuan":  LoadPage(new DashboardControl());  break;
                 case "PhongTro":  LoadPage(new PhongTroControl());  break;
                 case "NguoiThue": LoadPage(new NguoiThueControl()); break;
                 case "HopDong":   LoadPage(new HopDongControl());   break;
                 case "HoaDon":    LoadPage(new HoaDonControl());    break;
                 case "DichVu":    LoadPage(new DichVuControl()); break;
                 case "BaoCao":    LoadPage(new BaoCaoControl()); break;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var kq = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Phòng trọ mini",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq != DialogResult.Yes) return;

            AuthService.Logout();
            DangXuat = true;
            this.Close();
        }

        private void LoadPage(UserControl page)
        {
            pnlContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}