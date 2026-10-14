namespace Quanlyphongtromini
{
    partial class LoginForm
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.chkHienMatKhau = new System.Windows.Forms.CheckBox();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lnkDangKy = new System.Windows.Forms.LinkLabel();
            this.pnlContent.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlContent (nền xám nhạt giống MainForm)
            //
            this.pnlContent.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F4F8");
            this.pnlContent.Controls.Add(this.pnlCard);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(520, 405);
            this.pnlContent.TabIndex = 0;
            //
            // pnlCard (khối trắng chứa form)
            //
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblSub);
            this.pnlCard.Controls.Add(this.lblTenDangNhap);
            this.pnlCard.Controls.Add(this.txtTenDangNhap);
            this.pnlCard.Controls.Add(this.lblMatKhau);
            this.pnlCard.Controls.Add(this.txtMatKhau);
            this.pnlCard.Controls.Add(this.chkHienMatKhau);
            this.pnlCard.Controls.Add(this.lblThongBao);
            this.pnlCard.Controls.Add(this.btnDangNhap);
            this.pnlCard.Controls.Add(this.lnkDangKy);
            this.pnlCard.Location = new System.Drawing.Point(30, 30);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(460, 345);
            this.pnlCard.TabIndex = 0;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#244691");
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Đăng nhập";
            //
            // lblSub
            //
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7385");
            this.lblSub.Location = new System.Drawing.Point(32, 58);
            this.lblSub.Name = "lblSub";
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Chào mừng quay lại Phòng trọ mini";
            //
            // lblTenDangNhap
            //
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTenDangNhap.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3A4256");
            this.lblTenDangNhap.Location = new System.Drawing.Point(30, 92);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.TabIndex = 2;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            //
            // txtTenDangNhap
            //
            this.txtTenDangNhap.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F4F8");
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenDangNhap.Location = new System.Drawing.Point(30, 113);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(400, 25);
            this.txtTenDangNhap.TabIndex = 3;
            //
            // lblMatKhau
            //
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMatKhau.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3A4256");
            this.lblMatKhau.Location = new System.Drawing.Point(30, 148);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.TabIndex = 4;
            this.lblMatKhau.Text = "Mật khẩu";
            //
            // txtMatKhau
            //
            this.txtMatKhau.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F4F8");
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhau.Location = new System.Drawing.Point(30, 169);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.Size = new System.Drawing.Size(400, 25);
            this.txtMatKhau.TabIndex = 5;
            //
            // chkHienMatKhau
            //
            this.chkHienMatKhau.AutoSize = true;
            this.chkHienMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHienMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkHienMatKhau.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7385");
            this.chkHienMatKhau.Location = new System.Drawing.Point(30, 204);
            this.chkHienMatKhau.Name = "chkHienMatKhau";
            this.chkHienMatKhau.TabIndex = 6;
            this.chkHienMatKhau.Text = "Hiện mật khẩu";
            this.chkHienMatKhau.UseVisualStyleBackColor = true;
            this.chkHienMatKhau.CheckedChanged += new System.EventHandler(this.chkHienMatKhau_CheckedChanged);
            //
            // lblThongBao (báo lỗi)
            //
            this.lblThongBao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThongBao.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D64545");
            this.lblThongBao.Location = new System.Drawing.Point(30, 230);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(400, 20);
            this.lblThongBao.TabIndex = 7;
            //
            // btnDangNhap
            //
            this.btnDangNhap.BackColor = System.Drawing.ColorTranslator.FromHtml("#244691");
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#2F55A8");
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(30, 256);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(400, 40);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            //
            // lnkDangKy
            //
            this.lnkDangKy.ActiveLinkColor = System.Drawing.ColorTranslator.FromHtml("#2F55A8");
            this.lnkDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkDangKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkDangKy.LinkColor = System.Drawing.ColorTranslator.FromHtml("#244691");
            this.lnkDangKy.Location = new System.Drawing.Point(30, 310);
            this.lnkDangKy.Name = "lnkDangKy";
            this.lnkDangKy.Size = new System.Drawing.Size(400, 20);
            this.lnkDangKy.TabIndex = 9;
            this.lnkDangKy.TabStop = true;
            this.lnkDangKy.Text = "Chưa có tài khoản? Đăng ký";
            this.lnkDangKy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDangKy_LinkClicked);
            //
            // LoginForm
            //
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 405);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập - Phòng trọ mini";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.LinkLabel lnkDangKy;
    }
}