using Quanlyphongtromini.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quanlyphongtromini
{
    public partial class MainForm : Form
    {
        private readonly Color _normal = ColorTranslator.FromHtml("#244691");
        private readonly Color _active = ColorTranslator.FromHtml("#3B5BC0");
        private Button _current;

        public MainForm()
        {
            InitializeComponent();
            _current = btnTongQuan;
            LoadPage(new DashboardControl());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn == _current) return;

            // bỏ tô sáng nút cũ, tô sáng nút mới
            _current.BackColor = _normal;
            _current.Font = new Font(_current.Font, FontStyle.Regular);
            _current.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#2F55A8");

            btn.BackColor = _active;
            btn.Font = new Font(btn.Font, FontStyle.Bold);
            btn.FlatAppearance.MouseOverBackColor = _active;
            _current = btn;

            switch (btn.Tag.ToString())
            {
                 case "TongQuan":  LoadPage(new DashboardControl());  break;
                 case "PhongTro":  LoadPage(new PhongTroControl());  break;
                 case "NguoiThue": LoadPage(new NguoiThueControl()); break;
                 case "HopDong":   LoadPage(new HopDongControl());   break;
                 case "HoaDon":    LoadPage(new HoaDonControl());    break;
            }
        }

        private void LoadPage(UserControl page)
        {
            pnlContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
        }
    }
}