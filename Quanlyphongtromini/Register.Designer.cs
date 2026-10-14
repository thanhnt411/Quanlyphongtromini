namespace Quanlyphongtromini
{
    partial class RegisterForm
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblXacNhan = new System.Windows.Forms.Label();
            this.txtXacNhan = new System.Windows.Forms.TextBox();
            this.chkHienMatKhau = new System.Windows.Forms.CheckBox();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.lnkDangNhap = new System.Windows.Forms.LinkLabel();
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
            this.pnlContent.Size = new System.Drawing.Size(520, 575);
            this.pnlContent.TabIndex = 0;
            //
            // pnlCard (khối trắng chứa form)
            //
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.lblTitle);
            this.pnlCard.Controls.Add(this.lblSub);
            this.pnlCard.Controls.Add(this.lblTenDangNhap);
            this.pnlCard.Controls.Add(this.txtTenDangNhap);
            this.pnlCard.Controls.Add(this.lblEmail);
            this.pnlCard.Controls.Add(this.txtEmail);
            this.pnlCard.Controls.Add(this.lblSoDienThoai);
            this.pnlCard.Controls.Add(this.txtSoDienThoai);
            this.pnlCard.Controls.Add(this.lblMatKhau);
            this.pnlCard.Controls.Add(this.txtMatKhau);
            this.pnlCard.Controls.Add(this.lblXacNhan);
            this.pnlCard.Controls.Add(this.txtXacNhan);
            this.pnlCard.Controls.Add(this.chkHienMatKhau);
            this.pnlCard.Controls.Add(this.lblThongBao);
            this.pnlCard.Controls.Add(this.btnDangKy);
            this.pnlCard.Controls.Add(this.lnkDangNhap);
            this.pnlCard.Location = new System.Drawing.Point(30, 30);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(460, 515);
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
            this.lblTitle.Text = "Tạo tài khoản";
            //
            // lblSub
            //
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSub.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7385");
            this.lblSub.Location = new System.Drawing.Point(32, 58);
            this.lblSub.Name = "lblSub";
            this.lblSub.TabIndex = 1;
            this.lblSub.Text = "Điền thông tin để bắt đầu quản lý phòng trọ";
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
            // lblEmail
            //
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3A4256");
            this.lblEmail.Location = new System.Drawing.Point(30, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            //
            // txtEmail
            //
            this.txtEmail.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F4F8");
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(30, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 25);
            this.txtEmail.TabIndex = 5;
            //
            // lblSoDienThoai
            //
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSoDienThoai.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3A4256");
            this.lblSoDienThoai.Location = new System.Drawing.Point(30, 204);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.TabIndex = 6;
            this.lblSoDienThoai.Text = "Số điện thoại";
            //
            // txtSoDienThoai
            //
            this.txtSoDienThoai.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F4F8");
            this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoDienThoai.Location = new System.Drawing.Point(30, 225);
            this.txtSoDienThoai.MaxLength = 11;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(400, 25);
            this.txtSoDienThoai.TabIndex = 7;
            //
            // lblMatKhau
            //
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMatKhau.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3A4256");
            this.lblMatKhau.Location = new System.Drawing.Point(30, 260);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.TabIndex = 8;
            this.lblMatKhau.Text = "Mật khẩu";
            //
            // txtMatKhau
            //
            this.txtMatKhau.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F4F8");
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhau.Location = new System.Drawing.Point(30, 281);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.Size = new System.Drawing.Size(400, 25);
            this.txtMatKhau.TabIndex = 9;
            //
            // lblXacNhan
            //
            this.lblXacNhan.AutoSize = true;
            this.lblXacNhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblXacNhan.ForeColor = System.Drawing.ColorTranslator.FromHtml("#3A4256");
            this.lblXacNhan.Location = new System.Drawing.Point(30, 316);
            this.lblXacNhan.Name = "lblXacNhan";
            this.lblXacNhan.TabIndex = 10;
            this.lblXacNhan.Text = "Xác nhận mật khẩu";
            //
            // txtXacNhan
            //
            this.txtXacNhan.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F4F8");
            this.txtXacNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXacNhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtXacNhan.Location = new System.Drawing.Point(30, 337);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.PasswordChar = '●';
            this.txtXacNhan.Size = new System.Drawing.Size(400, 25);
            this.txtXacNhan.TabIndex = 11;
            //
            // chkHienMatKhau
            //
            this.chkHienMatKhau.AutoSize = true;
            this.chkHienMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHienMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkHienMatKhau.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7385");
            this.chkHienMatKhau.Location = new System.Drawing.Point(30, 372);
            this.chkHienMatKhau.Name = "chkHienMatKhau";
            this.chkHienMatKhau.TabIndex = 12;
            this.chkHienMatKhau.Text = "Hiện mật khẩu";
            this.chkHienMatKhau.UseVisualStyleBackColor = true;
            this.chkHienMatKhau.CheckedChanged += new System.EventHandler(this.chkHienMatKhau_CheckedChanged);
            //
            // lblThongBao (báo lỗi validate)
            //
            this.lblThongBao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThongBao.ForeColor = System.Drawing.ColorTranslator.FromHtml("#D64545");
            this.lblThongBao.Location = new System.Drawing.Point(30, 398);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(400, 20);
            this.lblThongBao.TabIndex = 13;
            //
            // btnDangKy
            //
            this.btnDangKy.BackColor = System.Drawing.ColorTranslator.FromHtml("#244691");
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#2F55A8");
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(30, 424);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(400, 40);
            this.btnDangKy.TabIndex = 14;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            //
            // lnkDangNhap
            //
            this.lnkDangNhap.ActiveLinkColor = System.Drawing.ColorTranslator.FromHtml("#2F55A8");
            this.lnkDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkDangNhap.LinkColor = System.Drawing.ColorTranslator.FromHtml("#244691");
            this.lnkDangNhap.Location = new System.Drawing.Point(30, 478);
            this.lnkDangNhap.Name = "lnkDangNhap";
            this.lnkDangNhap.Size = new System.Drawing.Size(400, 20);
            this.lnkDangNhap.TabIndex = 15;
            this.lnkDangNhap.TabStop = true;
            this.lnkDangNhap.Text = "Đã có tài khoản? Đăng nhập";
            this.lnkDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkDangNhap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDangNhap_LinkClicked);
            //
            // RegisterForm
            //
            this.AcceptButton = this.btnDangKy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 575);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký - Phòng trọ mini";
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
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblXacNhan;
        private System.Windows.Forms.TextBox txtXacNhan;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.LinkLabel lnkDangNhap;
    }
}