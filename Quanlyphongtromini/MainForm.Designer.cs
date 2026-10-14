namespace Quanlyphongtromini
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            btnDangXuat = new Button();
            lblNguoiDung = new Label();
            btnBaoCao = new Button();
            btnDichVu = new Button();
            btnHoaDon = new Button();
            btnHopDong = new Button();
            btnNguoiThue = new Button();
            btnPhongTro = new Button();
            btnTongQuan = new Button();
            lblLogo = new Label();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(36, 70, 145);
            pnlSidebar.Controls.Add(btnDangXuat);
            pnlSidebar.Controls.Add(lblNguoiDung);
            pnlSidebar.Controls.Add(btnBaoCao);
            pnlSidebar.Controls.Add(btnDichVu);
            pnlSidebar.Controls.Add(btnHoaDon);
            pnlSidebar.Controls.Add(btnHopDong);
            pnlSidebar.Controls.Add(btnNguoiThue);
            pnlSidebar.Controls.Add(btnPhongTro);
            pnlSidebar.Controls.Add(btnTongQuan);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(4, 5, 4, 5);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(224, 1000);
            pnlSidebar.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDangXuat.BackColor = Color.FromArgb(36, 70, 145);
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 85, 168);
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI Emoji", 9F);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Location = new Point(7, 922);
            btnDangXuat.Margin = new Padding(4, 5, 4, 5);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(11, 0, 0, 0);
            btnDangXuat.Size = new Size(210, 53);
            btnDangXuat.TabIndex = 7;
            btnDangXuat.Text = "🚪  Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // lblNguoiDung
            // 
            lblNguoiDung.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblNguoiDung.AutoEllipsis = true;
            lblNguoiDung.Font = new Font("Segoe UI Emoji", 9F);
            lblNguoiDung.ForeColor = Color.FromArgb(201, 213, 242);
            lblNguoiDung.Location = new Point(0, 863);
            lblNguoiDung.Margin = new Padding(4, 0, 4, 0);
            lblNguoiDung.Name = "lblNguoiDung";
            lblNguoiDung.Padding = new Padding(17, 0, 6, 0);
            lblNguoiDung.Size = new Size(224, 50);
            lblNguoiDung.TabIndex = 6;
            lblNguoiDung.Text = "👤 Người dùng";
            lblNguoiDung.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBaoCao
            // 
            btnBaoCao.BackColor = Color.FromArgb(36, 70, 145);
            btnBaoCao.Cursor = Cursors.Hand;
            btnBaoCao.FlatAppearance.BorderSize = 0;
            btnBaoCao.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 85, 168);
            btnBaoCao.FlatStyle = FlatStyle.Flat;
            btnBaoCao.Font = new Font("Segoe UI Emoji", 9F);
            btnBaoCao.ForeColor = Color.White;
            btnBaoCao.Location = new Point(7, 409);
            btnBaoCao.Margin = new Padding(4, 5, 4, 5);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Padding = new Padding(11, 0, 0, 0);
            btnBaoCao.Size = new Size(210, 53);
            btnBaoCao.TabIndex = 9;
            btnBaoCao.Tag = "BaoCao";
            btnBaoCao.Text = "\U0001f4ca  Báo cáo";
            btnBaoCao.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCao.UseVisualStyleBackColor = false;
            btnBaoCao.Click += btnMenu_Click;
            // 
            // btnDichVu
            // 
            btnDichVu.BackColor = Color.FromArgb(36, 70, 145);
            btnDichVu.Cursor = Cursors.Hand;
            btnDichVu.FlatAppearance.BorderSize = 0;
            btnDichVu.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 85, 168);
            btnDichVu.FlatStyle = FlatStyle.Flat;
            btnDichVu.Font = new Font("Segoe UI Emoji", 9F);
            btnDichVu.ForeColor = Color.White;
            btnDichVu.Location = new Point(7, 352);
            btnDichVu.Margin = new Padding(4, 5, 4, 5);
            btnDichVu.Name = "btnDichVu";
            btnDichVu.Padding = new Padding(11, 0, 0, 0);
            btnDichVu.Size = new Size(210, 53);
            btnDichVu.TabIndex = 8;
            btnDichVu.Tag = "DichVu";
            btnDichVu.Text = "\U0001f4a1  Dịch vụ";
            btnDichVu.TextAlign = ContentAlignment.MiddleLeft;
            btnDichVu.UseVisualStyleBackColor = false;
            btnDichVu.Click += btnMenu_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.FromArgb(36, 70, 145);
            btnHoaDon.Cursor = Cursors.Hand;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 85, 168);
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Segoe UI Emoji", 9F);
            btnHoaDon.ForeColor = Color.White;
            btnHoaDon.Location = new Point(7, 295);
            btnHoaDon.Margin = new Padding(4, 5, 4, 5);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(11, 0, 0, 0);
            btnHoaDon.Size = new Size(210, 53);
            btnHoaDon.TabIndex = 5;
            btnHoaDon.Tag = "HoaDon";
            btnHoaDon.Text = "\U0001f9fe  Hóa đơn";
            btnHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnMenu_Click;
            // 
            // btnHopDong
            // 
            btnHopDong.BackColor = Color.FromArgb(36, 70, 145);
            btnHopDong.Cursor = Cursors.Hand;
            btnHopDong.FlatAppearance.BorderSize = 0;
            btnHopDong.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 85, 168);
            btnHopDong.FlatStyle = FlatStyle.Flat;
            btnHopDong.Font = new Font("Segoe UI Emoji", 9F);
            btnHopDong.ForeColor = Color.White;
            btnHopDong.Location = new Point(7, 238);
            btnHopDong.Margin = new Padding(4, 5, 4, 5);
            btnHopDong.Name = "btnHopDong";
            btnHopDong.Padding = new Padding(11, 0, 0, 0);
            btnHopDong.Size = new Size(210, 53);
            btnHopDong.TabIndex = 4;
            btnHopDong.Tag = "HopDong";
            btnHopDong.Text = "📄  Hợp đồng";
            btnHopDong.TextAlign = ContentAlignment.MiddleLeft;
            btnHopDong.UseVisualStyleBackColor = false;
            btnHopDong.Click += btnMenu_Click;
            // 
            // btnNguoiThue
            // 
            btnNguoiThue.BackColor = Color.FromArgb(36, 70, 145);
            btnNguoiThue.Cursor = Cursors.Hand;
            btnNguoiThue.FlatAppearance.BorderSize = 0;
            btnNguoiThue.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 85, 168);
            btnNguoiThue.FlatStyle = FlatStyle.Flat;
            btnNguoiThue.Font = new Font("Segoe UI Emoji", 9F);
            btnNguoiThue.ForeColor = Color.White;
            btnNguoiThue.Location = new Point(7, 182);
            btnNguoiThue.Margin = new Padding(4, 5, 4, 5);
            btnNguoiThue.Name = "btnNguoiThue";
            btnNguoiThue.Padding = new Padding(11, 0, 0, 0);
            btnNguoiThue.Size = new Size(210, 53);
            btnNguoiThue.TabIndex = 3;
            btnNguoiThue.Tag = "NguoiThue";
            btnNguoiThue.Text = "👤  Người thuê";
            btnNguoiThue.TextAlign = ContentAlignment.MiddleLeft;
            btnNguoiThue.UseVisualStyleBackColor = false;
            btnNguoiThue.Click += btnMenu_Click;
            // 
            // btnPhongTro
            // 
            btnPhongTro.BackColor = Color.FromArgb(36, 70, 145);
            btnPhongTro.Cursor = Cursors.Hand;
            btnPhongTro.FlatAppearance.BorderSize = 0;
            btnPhongTro.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 85, 168);
            btnPhongTro.FlatStyle = FlatStyle.Flat;
            btnPhongTro.Font = new Font("Segoe UI Emoji", 9F);
            btnPhongTro.ForeColor = Color.White;
            btnPhongTro.Location = new Point(7, 125);
            btnPhongTro.Margin = new Padding(4, 5, 4, 5);
            btnPhongTro.Name = "btnPhongTro";
            btnPhongTro.Padding = new Padding(11, 0, 0, 0);
            btnPhongTro.Size = new Size(210, 53);
            btnPhongTro.TabIndex = 2;
            btnPhongTro.Tag = "PhongTro";
            btnPhongTro.Text = "🏢  Phòng trọ";
            btnPhongTro.TextAlign = ContentAlignment.MiddleLeft;
            btnPhongTro.UseVisualStyleBackColor = false;
            btnPhongTro.Click += btnMenu_Click;
            // 
            // btnTongQuan
            // 
            btnTongQuan.BackColor = Color.FromArgb(59, 91, 192);
            btnTongQuan.Cursor = Cursors.Hand;
            btnTongQuan.FlatAppearance.BorderSize = 0;
            btnTongQuan.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 91, 192);
            btnTongQuan.FlatStyle = FlatStyle.Flat;
            btnTongQuan.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnTongQuan.ForeColor = Color.White;
            btnTongQuan.Location = new Point(7, 68);
            btnTongQuan.Margin = new Padding(4, 5, 4, 5);
            btnTongQuan.Name = "btnTongQuan";
            btnTongQuan.Padding = new Padding(11, 0, 0, 0);
            btnTongQuan.Size = new Size(210, 53);
            btnTongQuan.TabIndex = 1;
            btnTongQuan.Tag = "TongQuan";
            btnTongQuan.Text = "▦  Tổng quan";
            btnTongQuan.TextAlign = ContentAlignment.MiddleLeft;
            btnTongQuan.UseVisualStyleBackColor = false;
            btnTongQuan.Click += btnMenu_Click;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Margin = new Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Padding = new Padding(17, 0, 0, 0);
            lblLogo.Size = new Size(224, 63);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "🏠 Phòng trọ mini";
            lblLogo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(242, 244, 248);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(224, 0);
            pnlContent.Margin = new Padding(4, 5, 4, 5);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1205, 1000);
            pnlContent.TabIndex = 1;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 1000);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1276, 796);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phòng trọ mini";
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        // ===== Giao diện menu: màu và trạng thái nút đang chọn =====
        private readonly System.Drawing.Color _normal = System.Drawing.ColorTranslator.FromHtml("#244691");
        private readonly System.Drawing.Color _hover = System.Drawing.ColorTranslator.FromHtml("#2F55A8");
        private readonly System.Drawing.Color _active = System.Drawing.ColorTranslator.FromHtml("#3B5BC0");
        private System.Windows.Forms.Button _current; // nút menu đang được chọn

        // Nút cũ về màu thường, nút mới sang màu đậm + chữ đậm
        private void SetActiveButton(System.Windows.Forms.Button btn)
        {
            if (_current != null)
            {
                _current.BackColor = _normal;
                _current.Font = new System.Drawing.Font(_current.Font, System.Drawing.FontStyle.Regular);
                _current.FlatAppearance.MouseOverBackColor = _hover;
            }
            btn.BackColor = _active;
            btn.Font = new System.Drawing.Font(btn.Font, System.Drawing.FontStyle.Bold);
            btn.FlatAppearance.MouseOverBackColor = _active;
            _current = btn;
        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnTongQuan;
        private System.Windows.Forms.Button btnPhongTro;
        private System.Windows.Forms.Button btnNguoiThue;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Button btnHoaDon;

        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.Button btnDangXuat;

        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnBaoCao;

        private System.Windows.Forms.Panel pnlContent;
    }
}