namespace Quanlyphongtromini.UserControls
{
    partial class BaoCaoControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlLoc = new Panel();
            lblPhong = new Label();
            cboPhong = new ComboBox();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            btnXem = new Button();
            tlpCards = new TableLayoutPanel();
            pnlTongThu = new Panel();
            lblTongThu = new Label();
            lblTongThuTitle = new Label();
            pnlDaThu = new Panel();
            lblDaThu = new Label();
            lblDaThuTitle = new Label();
            pnlConNo = new Panel();
            lblConNo = new Label();
            lblConNoTitle = new Label();
            pnlBang = new Panel();
            dgvBaoCao = new DataGridView();
            colMaHoaDon = new DataGridViewTextBoxColumn();
            colPhong = new DataGridViewTextBoxColumn();
            colNguoiThue = new DataGridViewTextBoxColumn();
            colThangNam = new DataGridViewTextBoxColumn();
            colDien = new DataGridViewTextBoxColumn();
            colNuoc = new DataGridViewTextBoxColumn();
            colPhiDV = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            pnlLoc.SuspendLayout();
            tlpCards.SuspendLayout();
            pnlTongThu.SuspendLayout();
            pnlDaThu.SuspendLayout();
            pnlConNo.SuspendLayout();
            pnlBang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            SuspendLayout();
            // 
            // pnlLoc
            // 
            pnlLoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLoc.BackColor = Color.White;
            pnlLoc.Controls.Add(lblPhong);
            pnlLoc.Controls.Add(cboPhong);
            pnlLoc.Controls.Add(lblTrangThai);
            pnlLoc.Controls.Add(cboTrangThai);
            pnlLoc.Controls.Add(btnXem);
            pnlLoc.Location = new Point(27, 28);
            pnlLoc.Margin = new Padding(4, 5, 4, 5);
            pnlLoc.Name = "pnlLoc";
            pnlLoc.Size = new Size(1150, 93);
            pnlLoc.TabIndex = 0;
            // 
            // lblPhong
            // 
            lblPhong.AutoSize = true;
            lblPhong.Font = new Font("Segoe UI", 9F);
            lblPhong.ForeColor = Color.FromArgb(107, 114, 128);
            lblPhong.Location = new Point(20, 32);
            lblPhong.Margin = new Padding(4, 0, 4, 0);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new Size(64, 25);
            lblPhong.TabIndex = 0;
            lblPhong.Text = "Phòng";
            // 
            // cboPhong
            // 
            cboPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhong.Font = new Font("Segoe UI", 9F);
            cboPhong.FormattingEnabled = true;
            cboPhong.Items.AddRange(new object[] { "Tất cả phòng" });
            cboPhong.Location = new Point(89, 25);
            cboPhong.Margin = new Padding(4, 5, 4, 5);
            cboPhong.Name = "cboPhong";
            cboPhong.Size = new Size(213, 33);
            cboPhong.TabIndex = 1;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 9F);
            lblTrangThai.ForeColor = Color.FromArgb(107, 114, 128);
            lblTrangThai.Location = new Point(337, 32);
            lblTrangThai.Margin = new Padding(4, 0, 4, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(89, 25);
            lblTrangThai.TabIndex = 2;
            lblTrangThai.Text = "Trạng thái";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Segoe UI", 9F);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Tất cả", "Đã thu", "Chưa thu" });
            cboTrangThai.Location = new Point(434, 25);
            cboTrangThai.Margin = new Padding(4, 5, 4, 5);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(170, 33);
            cboTrangThai.TabIndex = 3;
            // 
            // btnXem
            // 
            btnXem.BackColor = Color.FromArgb(36, 70, 145);
            btnXem.Cursor = Cursors.Hand;
            btnXem.FlatAppearance.BorderSize = 0;
            btnXem.FlatStyle = FlatStyle.Flat;
            btnXem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXem.ForeColor = Color.White;
            btnXem.Location = new Point(637, 18);
            btnXem.Margin = new Padding(4, 5, 4, 5);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(186, 53);
            btnXem.TabIndex = 4;
            btnXem.Text = "Xem báo cáo";
            btnXem.UseVisualStyleBackColor = false;
            // 
            // tlpCards
            // 
            tlpCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpCards.BackColor = Color.Transparent;
            tlpCards.ColumnCount = 3;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tlpCards.Controls.Add(pnlTongThu, 0, 0);
            tlpCards.Controls.Add(pnlDaThu, 1, 0);
            tlpCards.Controls.Add(pnlConNo, 2, 0);
            tlpCards.Location = new Point(27, 142);
            tlpCards.Margin = new Padding(0);
            tlpCards.Name = "tlpCards";
            tlpCards.RowCount = 1;
            tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCards.Size = new Size(1150, 93);
            tlpCards.TabIndex = 1;
            // 
            // pnlTongThu
            // 
            pnlTongThu.BackColor = Color.White;
            pnlTongThu.Controls.Add(lblTongThu);
            pnlTongThu.Controls.Add(lblTongThuTitle);
            pnlTongThu.Dock = DockStyle.Fill;
            pnlTongThu.Location = new Point(0, 0);
            pnlTongThu.Margin = new Padding(0, 0, 16, 0);
            pnlTongThu.Name = "pnlTongThu";
            pnlTongThu.Size = new Size(367, 93);
            pnlTongThu.TabIndex = 0;
            // 
            // lblTongThu
            // 
            lblTongThu.AutoSize = true;
            lblTongThu.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTongThu.ForeColor = Color.FromArgb(17, 24, 39);
            lblTongThu.Location = new Point(14, 40);
            lblTongThu.Margin = new Padding(4, 0, 4, 0);
            lblTongThu.Name = "lblTongThu";
            lblTongThu.Size = new Size(87, 36);
            lblTongThu.TabIndex = 1;
            lblTongThu.Text = "6.13tr";
            // 
            // lblTongThuTitle
            // 
            lblTongThuTitle.AutoSize = true;
            lblTongThuTitle.Font = new Font("Segoe UI", 8F);
            lblTongThuTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblTongThuTitle.Location = new Point(17, 13);
            lblTongThuTitle.Margin = new Padding(4, 0, 4, 0);
            lblTongThuTitle.Name = "lblTongThuTitle";
            lblTongThuTitle.Size = new Size(120, 21);
            lblTongThuTitle.TabIndex = 0;
            lblTongThuTitle.Text = "Tổng doanh thu";
            // 
            // pnlDaThu
            // 
            pnlDaThu.BackColor = Color.White;
            pnlDaThu.Controls.Add(lblDaThu);
            pnlDaThu.Controls.Add(lblDaThuTitle);
            pnlDaThu.Dock = DockStyle.Fill;
            pnlDaThu.Location = new Point(383, 0);
            pnlDaThu.Margin = new Padding(0, 0, 16, 0);
            pnlDaThu.Name = "pnlDaThu";
            pnlDaThu.Size = new Size(367, 93);
            pnlDaThu.TabIndex = 1;
            // 
            // lblDaThu
            // 
            lblDaThu.AutoSize = true;
            lblDaThu.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDaThu.ForeColor = Color.FromArgb(15, 118, 110);
            lblDaThu.Location = new Point(14, 40);
            lblDaThu.Margin = new Padding(4, 0, 4, 0);
            lblDaThu.Name = "lblDaThu";
            lblDaThu.Size = new Size(87, 36);
            lblDaThu.TabIndex = 1;
            lblDaThu.Text = "4.50tr";
            // 
            // lblDaThuTitle
            // 
            lblDaThuTitle.AutoSize = true;
            lblDaThuTitle.Font = new Font("Segoe UI", 8F);
            lblDaThuTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblDaThuTitle.Location = new Point(17, 13);
            lblDaThuTitle.Margin = new Padding(4, 0, 4, 0);
            lblDaThuTitle.Name = "lblDaThuTitle";
            lblDaThuTitle.Size = new Size(56, 21);
            lblDaThuTitle.TabIndex = 0;
            lblDaThuTitle.Text = "Đã thu";
            // 
            // pnlConNo
            // 
            pnlConNo.BackColor = Color.White;
            pnlConNo.Controls.Add(lblConNo);
            pnlConNo.Controls.Add(lblConNoTitle);
            pnlConNo.Dock = DockStyle.Fill;
            pnlConNo.Location = new Point(766, 0);
            pnlConNo.Margin = new Padding(0);
            pnlConNo.Name = "pnlConNo";
            pnlConNo.Size = new Size(384, 93);
            pnlConNo.TabIndex = 2;
            // 
            // lblConNo
            // 
            lblConNo.AutoSize = true;
            lblConNo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblConNo.ForeColor = Color.FromArgb(185, 28, 28);
            lblConNo.Location = new Point(14, 40);
            lblConNo.Margin = new Padding(4, 0, 4, 0);
            lblConNo.Name = "lblConNo";
            lblConNo.Size = new Size(87, 36);
            lblConNo.TabIndex = 1;
            lblConNo.Text = "1.63tr";
            // 
            // lblConNoTitle
            // 
            lblConNoTitle.AutoSize = true;
            lblConNoTitle.Font = new Font("Segoe UI", 8F);
            lblConNoTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblConNoTitle.Location = new Point(17, 13);
            lblConNoTitle.Margin = new Padding(4, 0, 4, 0);
            lblConNoTitle.Name = "lblConNoTitle";
            lblConNoTitle.Size = new Size(61, 21);
            lblConNoTitle.TabIndex = 0;
            lblConNoTitle.Text = "Còn nợ";
            // 
            // pnlBang
            // 
            pnlBang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlBang.BackColor = Color.White;
            pnlBang.Controls.Add(dgvBaoCao);
            pnlBang.Location = new Point(27, 255);
            pnlBang.Margin = new Padding(4, 5, 4, 5);
            pnlBang.Name = "pnlBang";
            pnlBang.Padding = new Padding(11, 13, 11, 13);
            pnlBang.Size = new Size(1150, 700);
            pnlBang.TabIndex = 2;
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.AllowUserToAddRows = false;
            dgvBaoCao.AllowUserToDeleteRows = false;
            dgvBaoCao.AllowUserToResizeRows = false;
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaoCao.BackgroundColor = Color.White;
            dgvBaoCao.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(36, 70, 145);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(36, 70, 145);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBaoCao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBaoCao.ColumnHeadersHeight = 32;
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBaoCao.Columns.AddRange(new DataGridViewColumn[] { colMaHoaDon, colPhong, colNguoiThue, colThangNam, colDien, colNuoc, colPhiDV, colTongTien, colTrangThai });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(219, 228, 245);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBaoCao.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBaoCao.Dock = DockStyle.Fill;
            dgvBaoCao.EnableHeadersVisualStyles = false;
            dgvBaoCao.GridColor = Color.FromArgb(229, 231, 235);
            dgvBaoCao.Location = new Point(11, 13);
            dgvBaoCao.Margin = new Padding(4, 5, 4, 5);
            dgvBaoCao.MultiSelect = false;
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.ReadOnly = true;
            dgvBaoCao.RowHeadersVisible = false;
            dgvBaoCao.RowHeadersWidth = 62;
            dgvBaoCao.RowTemplate.Height = 28;
            dgvBaoCao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBaoCao.Size = new Size(1128, 674);
            dgvBaoCao.TabIndex = 0;

            // 
            // colMaHoaDon
            // 
            colMaHoaDon.FillWeight = 11F;
            colMaHoaDon.HeaderText = "Mã hóa đơn";
            colMaHoaDon.MinimumWidth = 8;
            colMaHoaDon.Name = "colMaHoaDon";
            colMaHoaDon.ReadOnly = true;
            // 
            // colPhong
            // 
            colPhong.FillWeight = 8F;
            colPhong.HeaderText = "Phòng";
            colPhong.MinimumWidth = 8;
            colPhong.Name = "colPhong";
            colPhong.ReadOnly = true;
            // 
            // colNguoiThue
            // 
            colNguoiThue.FillWeight = 19F;
            colNguoiThue.HeaderText = "Người thuê";
            colNguoiThue.MinimumWidth = 8;
            colNguoiThue.Name = "colNguoiThue";
            colNguoiThue.ReadOnly = true;
            // 
            // colThangNam
            // 
            colThangNam.FillWeight = 11F;
            colThangNam.HeaderText = "Tháng/Năm";
            colThangNam.MinimumWidth = 8;
            colThangNam.Name = "colThangNam";
            colThangNam.ReadOnly = true;
            // 
            // colDien
            // 
            colDien.FillWeight = 9F;
            colDien.HeaderText = "Điện (kWh)";
            colDien.MinimumWidth = 8;
            colDien.Name = "colDien";
            colDien.ReadOnly = true;
            // 
            // colNuoc
            // 
            colNuoc.FillWeight = 9F;
            colNuoc.HeaderText = "Nước (m³)";
            colNuoc.MinimumWidth = 8;
            colNuoc.Name = "colNuoc";
            colNuoc.ReadOnly = true;
            // 
            // colPhiDV
            // 
            colPhiDV.FillWeight = 10F;
            colPhiDV.HeaderText = "Phí DV";
            colPhiDV.MinimumWidth = 8;
            colPhiDV.Name = "colPhiDV";
            colPhiDV.ReadOnly = true;
            // 
            // colTongTien
            // 
            colTongTien.FillWeight = 13F;
            colTongTien.HeaderText = "Tổng tiền";
            colTongTien.MinimumWidth = 8;
            colTongTien.Name = "colTongTien";
            colTongTien.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.FillWeight = 10F;
            colTrangThai.HeaderText = "Trạng thái";
            colTrangThai.MinimumWidth = 8;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // BaoCaoControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 248);
            Controls.Add(pnlBang);
            Controls.Add(tlpCards);
            Controls.Add(pnlLoc);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BaoCaoControl";
            Size = new Size(1204, 1000);
            pnlLoc.ResumeLayout(false);
            pnlLoc.PerformLayout();
            tlpCards.ResumeLayout(false);
            pnlTongThu.ResumeLayout(false);
            pnlTongThu.PerformLayout();
            pnlDaThu.ResumeLayout(false);
            pnlDaThu.PerformLayout();
            pnlConNo.ResumeLayout(false);
            pnlConNo.PerformLayout();
            pnlBang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlLoc;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TableLayoutPanel tlpCards;
        private System.Windows.Forms.Panel pnlTongThu;
        private System.Windows.Forms.Label lblTongThu;
        private System.Windows.Forms.Label lblTongThuTitle;
        private System.Windows.Forms.Panel pnlDaThu;
        private System.Windows.Forms.Label lblDaThu;
        private System.Windows.Forms.Label lblDaThuTitle;
        private System.Windows.Forms.Panel pnlConNo;
        private System.Windows.Forms.Label lblConNo;
        private System.Windows.Forms.Label lblConNoTitle;
        private System.Windows.Forms.Panel pnlBang;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThangNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhiDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}
