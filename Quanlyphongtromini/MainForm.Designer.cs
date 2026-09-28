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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.btnNguoiThue = new System.Windows.Forms.Button();
            this.btnPhongTro = new System.Windows.Forms.Button();
            this.btnTongQuan = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlSidebar
            //
            this.pnlSidebar.BackColor = System.Drawing.ColorTranslator.FromHtml("#244691");
            this.pnlSidebar.Controls.Add(this.btnHoaDon);
            this.pnlSidebar.Controls.Add(this.btnHopDong);
            this.pnlSidebar.Controls.Add(this.btnNguoiThue);
            this.pnlSidebar.Controls.Add(this.btnPhongTro);
            this.pnlSidebar.Controls.Add(this.btnTongQuan);
            this.pnlSidebar.Controls.Add(this.lblLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(157, 600);
            this.pnlSidebar.TabIndex = 0;
            //
            // lblLogo
            //
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblLogo.Size = new System.Drawing.Size(157, 38);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "🏠 Phòng trọ mini";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // btnTongQuan (đang được chọn)
            //
            this.btnTongQuan.BackColor = System.Drawing.ColorTranslator.FromHtml("#3B5BC0");
            this.btnTongQuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTongQuan.FlatAppearance.BorderSize = 0;
            this.btnTongQuan.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#3B5BC0");
            this.btnTongQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongQuan.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.btnTongQuan.ForeColor = System.Drawing.Color.White;
            this.btnTongQuan.Location = new System.Drawing.Point(5, 41);
            this.btnTongQuan.Name = "btnTongQuan";
            this.btnTongQuan.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnTongQuan.Size = new System.Drawing.Size(147, 32);
            this.btnTongQuan.TabIndex = 1;
            this.btnTongQuan.Tag = "TongQuan";
            this.btnTongQuan.Text = "▦  Tổng quan";
            this.btnTongQuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTongQuan.UseVisualStyleBackColor = false;
            this.btnTongQuan.Click += new System.EventHandler(this.btnMenu_Click);
            //
            // btnPhongTro
            //
            this.btnPhongTro.BackColor = System.Drawing.ColorTranslator.FromHtml("#244691");
            this.btnPhongTro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhongTro.FlatAppearance.BorderSize = 0;
            this.btnPhongTro.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#2F55A8");
            this.btnPhongTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhongTro.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.btnPhongTro.ForeColor = System.Drawing.Color.White;
            this.btnPhongTro.Location = new System.Drawing.Point(5, 75);
            this.btnPhongTro.Name = "btnPhongTro";
            this.btnPhongTro.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnPhongTro.Size = new System.Drawing.Size(147, 32);
            this.btnPhongTro.TabIndex = 2;
            this.btnPhongTro.Tag = "PhongTro";
            this.btnPhongTro.Text = "🏢  Phòng trọ";
            this.btnPhongTro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhongTro.UseVisualStyleBackColor = false;
            this.btnPhongTro.Click += new System.EventHandler(this.btnMenu_Click);
            //
            // btnNguoiThue
            //
            this.btnNguoiThue.BackColor = System.Drawing.ColorTranslator.FromHtml("#244691");
            this.btnNguoiThue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNguoiThue.FlatAppearance.BorderSize = 0;
            this.btnNguoiThue.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#2F55A8");
            this.btnNguoiThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNguoiThue.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.btnNguoiThue.ForeColor = System.Drawing.Color.White;
            this.btnNguoiThue.Location = new System.Drawing.Point(5, 109);
            this.btnNguoiThue.Name = "btnNguoiThue";
            this.btnNguoiThue.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnNguoiThue.Size = new System.Drawing.Size(147, 32);
            this.btnNguoiThue.TabIndex = 3;
            this.btnNguoiThue.Tag = "NguoiThue";
            this.btnNguoiThue.Text = "👤  Người thuê";
            this.btnNguoiThue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNguoiThue.UseVisualStyleBackColor = false;
            this.btnNguoiThue.Click += new System.EventHandler(this.btnMenu_Click);
            //
            // btnHopDong
            //
            this.btnHopDong.BackColor = System.Drawing.ColorTranslator.FromHtml("#244691");
            this.btnHopDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHopDong.FlatAppearance.BorderSize = 0;
            this.btnHopDong.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#2F55A8");
            this.btnHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopDong.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.btnHopDong.ForeColor = System.Drawing.Color.White;
            this.btnHopDong.Location = new System.Drawing.Point(5, 143);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnHopDong.Size = new System.Drawing.Size(147, 32);
            this.btnHopDong.TabIndex = 4;
            this.btnHopDong.Tag = "HopDong";
            this.btnHopDong.Text = "📄  Hợp đồng";
            this.btnHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHopDong.UseVisualStyleBackColor = false;
            this.btnHopDong.Click += new System.EventHandler(this.btnMenu_Click);
            //
            // btnHoaDon
            //
            this.btnHoaDon.BackColor = System.Drawing.ColorTranslator.FromHtml("#244691");
            this.btnHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#2F55A8");
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Location = new System.Drawing.Point(5, 177);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(147, 32);
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Tag = "HoaDon";
            this.btnHoaDon.Text = "🧾  Hóa đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnMenu_Click);
            //
            // pnlContent (nơi chứa các UserControl)
            //
            this.pnlContent.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F4F8");
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(157, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(843, 600);
            this.pnlContent.TabIndex = 1;
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phòng trọ mini";
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnTongQuan;
        private System.Windows.Forms.Button btnPhongTro;
        private System.Windows.Forms.Button btnNguoiThue;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Panel pnlContent;
    }
}