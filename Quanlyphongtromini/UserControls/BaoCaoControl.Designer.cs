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
            this.pnlLoc = new System.Windows.Forms.Panel();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.tlpCards = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTongThu = new System.Windows.Forms.Panel();
            this.lblTongThu = new System.Windows.Forms.Label();
            this.lblTongThuTitle = new System.Windows.Forms.Label();
            this.pnlDaThu = new System.Windows.Forms.Panel();
            this.lblDaThu = new System.Windows.Forms.Label();
            this.lblDaThuTitle = new System.Windows.Forms.Label();
            this.pnlConNo = new System.Windows.Forms.Panel();
            this.lblConNo = new System.Windows.Forms.Label();
            this.lblConNoTitle = new System.Windows.Forms.Label();
            this.pnlBang = new System.Windows.Forms.Panel();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.colMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThangNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhiDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLoc.SuspendLayout();
            this.tlpCards.SuspendLayout();
            this.pnlTongThu.SuspendLayout();
            this.pnlDaThu.SuspendLayout();
            this.pnlConNo.SuspendLayout();
            this.pnlBang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            //
            // pnlLoc
            //
            this.pnlLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLoc.BackColor = System.Drawing.Color.White;
            this.pnlLoc.Controls.Add(this.lblPhong);
            this.pnlLoc.Controls.Add(this.cboPhong);
            this.pnlLoc.Controls.Add(this.lblTrangThai);
            this.pnlLoc.Controls.Add(this.cboTrangThai);
            this.pnlLoc.Controls.Add(this.btnXem);
            this.pnlLoc.Location = new System.Drawing.Point(19, 17);
            this.pnlLoc.Name = "pnlLoc";
            this.pnlLoc.Size = new System.Drawing.Size(805, 56);
            this.pnlLoc.TabIndex = 0;
            //
            // lblPhong
            //
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhong.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblPhong.Location = new System.Drawing.Point(14, 19);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.TabIndex = 0;
            this.lblPhong.Text = "Phòng";
            //
            // cboPhong
            //
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Items.AddRange(new object[] {
            "Tất cả phòng"});
            this.cboPhong.Location = new System.Drawing.Point(62, 15);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(150, 23);
            this.cboPhong.TabIndex = 1;
            //
            // lblTrangThai
            //
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThai.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblTrangThai.Location = new System.Drawing.Point(236, 19);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.TabIndex = 2;
            this.lblTrangThai.Text = "Trạng thái";
            //
            // cboTrangThai
            //
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Tất cả", "Đã thu", "Chưa thu"});
            this.cboTrangThai.Location = new System.Drawing.Point(304, 15);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(120, 23);
            this.cboTrangThai.TabIndex = 3;
            //
            // btnXem
            //
            this.btnXem.BackColor = System.Drawing.ColorTranslator.FromHtml("#244691");
            this.btnXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXem.FlatAppearance.BorderSize = 0;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(446, 11);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(130, 32);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "Xem báo cáo";
            this.btnXem.UseVisualStyleBackColor = false;
            //
            // tlpCards
            //
            this.tlpCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCards.BackColor = System.Drawing.Color.Transparent;
            this.tlpCards.ColumnCount = 3;
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpCards.Controls.Add(this.pnlTongThu, 0, 0);
            this.tlpCards.Controls.Add(this.pnlDaThu, 1, 0);
            this.tlpCards.Controls.Add(this.pnlConNo, 2, 0);
            this.tlpCards.Location = new System.Drawing.Point(19, 85);
            this.tlpCards.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCards.Name = "tlpCards";
            this.tlpCards.RowCount = 1;
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCards.Size = new System.Drawing.Size(805, 56);
            this.tlpCards.TabIndex = 1;
            //
            // pnlTongThu
            //
            this.pnlTongThu.BackColor = System.Drawing.Color.White;
            this.pnlTongThu.Controls.Add(this.lblTongThu);
            this.pnlTongThu.Controls.Add(this.lblTongThuTitle);
            this.pnlTongThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTongThu.Margin = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.pnlTongThu.Name = "pnlTongThu";
            this.pnlTongThu.TabIndex = 0;
            //
            // lblTongThuTitle
            //
            this.lblTongThuTitle.AutoSize = true;
            this.lblTongThuTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTongThuTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblTongThuTitle.Location = new System.Drawing.Point(12, 8);
            this.lblTongThuTitle.Name = "lblTongThuTitle";
            this.lblTongThuTitle.TabIndex = 0;
            this.lblTongThuTitle.Text = "Tổng doanh thu";
            //
            // lblTongThu
            //
            this.lblTongThu.AutoSize = true;
            this.lblTongThu.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTongThu.ForeColor = System.Drawing.ColorTranslator.FromHtml("#111827");
            this.lblTongThu.Location = new System.Drawing.Point(10, 24);
            this.lblTongThu.Name = "lblTongThu";
            this.lblTongThu.TabIndex = 1;
            this.lblTongThu.Text = "6.13tr";
            //
            // pnlDaThu
            //
            this.pnlDaThu.BackColor = System.Drawing.Color.White;
            this.pnlDaThu.Controls.Add(this.lblDaThu);
            this.pnlDaThu.Controls.Add(this.lblDaThuTitle);
            this.pnlDaThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDaThu.Margin = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.pnlDaThu.Name = "pnlDaThu";
            this.pnlDaThu.TabIndex = 1;
            //
            // lblDaThuTitle
            //
            this.lblDaThuTitle.AutoSize = true;
            this.lblDaThuTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDaThuTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblDaThuTitle.Location = new System.Drawing.Point(12, 8);
            this.lblDaThuTitle.Name = "lblDaThuTitle";
            this.lblDaThuTitle.TabIndex = 0;
            this.lblDaThuTitle.Text = "Đã thu";
            //
            // lblDaThu
            //
            this.lblDaThu.AutoSize = true;
            this.lblDaThu.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblDaThu.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0F766E");
            this.lblDaThu.Location = new System.Drawing.Point(10, 24);
            this.lblDaThu.Name = "lblDaThu";
            this.lblDaThu.TabIndex = 1;
            this.lblDaThu.Text = "4.50tr";
            //
            // pnlConNo
            //
            this.pnlConNo.BackColor = System.Drawing.Color.White;
            this.pnlConNo.Controls.Add(this.lblConNo);
            this.pnlConNo.Controls.Add(this.lblConNoTitle);
            this.pnlConNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConNo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlConNo.Name = "pnlConNo";
            this.pnlConNo.TabIndex = 2;
            //
            // lblConNoTitle
            //
            this.lblConNoTitle.AutoSize = true;
            this.lblConNoTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblConNoTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblConNoTitle.Location = new System.Drawing.Point(12, 8);
            this.lblConNoTitle.Name = "lblConNoTitle";
            this.lblConNoTitle.TabIndex = 0;
            this.lblConNoTitle.Text = "Còn nợ";
            //
            // lblConNo
            //
            this.lblConNo.AutoSize = true;
            this.lblConNo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblConNo.ForeColor = System.Drawing.ColorTranslator.FromHtml("#B91C1C");
            this.lblConNo.Location = new System.Drawing.Point(10, 24);
            this.lblConNo.Name = "lblConNo";
            this.lblConNo.TabIndex = 1;
            this.lblConNo.Text = "1.63tr";
            //
            // pnlBang
            //
            this.pnlBang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBang.BackColor = System.Drawing.Color.White;
            this.pnlBang.Controls.Add(this.dgvBaoCao);
            this.pnlBang.Location = new System.Drawing.Point(19, 153);
            this.pnlBang.Name = "pnlBang";
            this.pnlBang.Padding = new System.Windows.Forms.Padding(8);
            this.pnlBang.Size = new System.Drawing.Size(805, 420);
            this.pnlBang.TabIndex = 2;
            //
            // dgvBaoCao
            //
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AllowUserToDeleteRows = false;
            this.dgvBaoCao.AllowUserToResizeRows = false;
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCao.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#244691");
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#244691");
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBaoCao.ColumnHeadersHeight = 32;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBaoCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHoaDon,
            this.colPhong,
            this.colNguoiThue,
            this.colThangNam,
            this.colDien,
            this.colNuoc,
            this.colPhiDV,
            this.colTongTien,
            this.colTrangThai});
            this.dgvBaoCao.DefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#DBE4F5");
            this.dgvBaoCao.DefaultCellStyle.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#111827");
            this.dgvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCao.EnableHeadersVisualStyles = false;
            this.dgvBaoCao.GridColor = System.Drawing.ColorTranslator.FromHtml("#E5E7EB");
            this.dgvBaoCao.Location = new System.Drawing.Point(8, 8);
            this.dgvBaoCao.MultiSelect = false;
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.ReadOnly = true;
            this.dgvBaoCao.RowHeadersVisible = false;
            this.dgvBaoCao.RowTemplate.Height = 28;
            this.dgvBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCao.Size = new System.Drawing.Size(789, 404);
            this.dgvBaoCao.TabIndex = 0;
            //
            // colMaHoaDon
            //
            this.colMaHoaDon.FillWeight = 11F;
            this.colMaHoaDon.HeaderText = "Mã hóa đơn";
            this.colMaHoaDon.Name = "colMaHoaDon";
            this.colMaHoaDon.ReadOnly = true;
            //
            // colPhong
            //
            this.colPhong.FillWeight = 8F;
            this.colPhong.HeaderText = "Phòng";
            this.colPhong.Name = "colPhong";
            this.colPhong.ReadOnly = true;
            //
            // colNguoiThue
            //
            this.colNguoiThue.FillWeight = 19F;
            this.colNguoiThue.HeaderText = "Người thuê";
            this.colNguoiThue.Name = "colNguoiThue";
            this.colNguoiThue.ReadOnly = true;
            //
            // colThangNam
            //
            this.colThangNam.FillWeight = 11F;
            this.colThangNam.HeaderText = "Tháng/Năm";
            this.colThangNam.Name = "colThangNam";
            this.colThangNam.ReadOnly = true;
            //
            // colDien
            //
            this.colDien.FillWeight = 9F;
            this.colDien.HeaderText = "Điện (kWh)";
            this.colDien.Name = "colDien";
            this.colDien.ReadOnly = true;
            //
            // colNuoc
            //
            this.colNuoc.FillWeight = 9F;
            this.colNuoc.HeaderText = "Nước (m³)";
            this.colNuoc.Name = "colNuoc";
            this.colNuoc.ReadOnly = true;
            //
            // colPhiDV
            //
            this.colPhiDV.FillWeight = 10F;
            this.colPhiDV.HeaderText = "Phí DV";
            this.colPhiDV.Name = "colPhiDV";
            this.colPhiDV.ReadOnly = true;
            //
            // colTongTien
            //
            this.colTongTien.FillWeight = 13F;
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            //
            // colTrangThai
            //
            this.colTrangThai.FillWeight = 10F;
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            //
            // BaoCaoControl
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F4F8");
            this.Controls.Add(this.pnlBang);
            this.Controls.Add(this.tlpCards);
            this.Controls.Add(this.pnlLoc);
            this.Name = "BaoCaoControl";
            this.Size = new System.Drawing.Size(843, 600);
            this.pnlLoc.ResumeLayout(false);
            this.pnlLoc.PerformLayout();
            this.tlpCards.ResumeLayout(false);
            this.pnlTongThu.ResumeLayout(false);
            this.pnlTongThu.PerformLayout();
            this.pnlDaThu.ResumeLayout(false);
            this.pnlDaThu.PerformLayout();
            this.pnlConNo.ResumeLayout(false);
            this.pnlConNo.PerformLayout();
            this.pnlBang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);
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