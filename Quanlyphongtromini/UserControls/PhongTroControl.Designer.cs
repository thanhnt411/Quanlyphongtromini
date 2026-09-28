namespace Quanlyphongtromini.UserControls
{
    partial class PhongTroControl
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
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvDienTichStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvGiaThueStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvToiDaStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvPhongTro = new System.Windows.Forms.DataGridView();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.tlpThongTin = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.lblGiaThue = new System.Windows.Forms.Label();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.lblToiDa = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtToiDa = new System.Windows.Forms.TextBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.flpNut = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTro)).BeginInit();
            this.pnlThongTin.SuspendLayout();
            this.tlpThongTin.SuspendLayout();
            this.flpNut.SuspendLayout();
            this.SuspendLayout();
            //
            // tlpMain
            //
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.pnlTimKiem, 0, 0);
            this.tlpMain.Controls.Add(this.dgvPhongTro, 0, 1);
            this.tlpMain.Controls.Add(this.pnlThongTin, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(19, 17);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tlpMain.Size = new System.Drawing.Size(805, 566);
            this.tlpMain.TabIndex = 0;
            //
            // pnlTimKiem
            //
            this.pnlTimKiem.Controls.Add(this.txtTimKiem);
            this.pnlTimKiem.Controls.Add(this.btnTim);
            this.pnlTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimKiem.Location = new System.Drawing.Point(0, 0);
            this.pnlTimKiem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pnlTimKiem.Name = "pnlTimKiem";
            this.pnlTimKiem.Size = new System.Drawing.Size(805, 34);
            this.pnlTimKiem.TabIndex = 0;
            //
            // txtTimKiem
            //
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.Location = new System.Drawing.Point(0, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Nhập tên phòng...";
            this.txtTimKiem.Size = new System.Drawing.Size(693, 25);
            this.txtTimKiem.TabIndex = 0;
            //
            // btnTim
            //
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.BackColor = System.Drawing.ColorTranslator.FromHtml("#244691");
            this.btnTim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(701, 0);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(104, 34);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "🔍 Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            //
            // dgvPhongTro
            //
            this.dgvPhongTro.AllowUserToAddRows = false;
            this.dgvPhongTro.AllowUserToDeleteRows = false;
            this.dgvPhongTro.AllowUserToResizeRows = false;
            this.dgvPhongTro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongTro.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhongTro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhongTro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhongTro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvHeaderStyle.BackColor = System.Drawing.Color.White;
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            dgvHeaderStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dgvHeaderStyle.SelectionBackColor = System.Drawing.Color.White;
            dgvHeaderStyle.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            dgvHeaderStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhongTro.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvPhongTro.ColumnHeadersHeight = 34;
            this.dgvPhongTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhongTro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhong,
            this.colTenPhong,
            this.colDienTich,
            this.colGiaThue,
            this.colToiDa,
            this.colTrangThai});
            dgvCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvCellStyle.BackColor = System.Drawing.Color.White;
            dgvCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#111827");
            dgvCellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dgvCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#E8ECF8");
            dgvCellStyle.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#111827");
            dgvCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhongTro.DefaultCellStyle = dgvCellStyle;
            this.dgvPhongTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhongTro.EnableHeadersVisualStyles = false;
            this.dgvPhongTro.GridColor = System.Drawing.ColorTranslator.FromHtml("#E5E7EB");
            this.dgvPhongTro.Location = new System.Drawing.Point(0, 46);
            this.dgvPhongTro.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.dgvPhongTro.MultiSelect = false;
            this.dgvPhongTro.Name = "dgvPhongTro";
            this.dgvPhongTro.ReadOnly = true;
            this.dgvPhongTro.RowHeadersVisible = false;
            this.dgvPhongTro.RowTemplate.Height = 32;
            this.dgvPhongTro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongTro.Size = new System.Drawing.Size(805, 268);
            this.dgvPhongTro.TabIndex = 1;
            //
            // colMaPhong
            //
            this.colMaPhong.DataPropertyName = "MaPhong";
            this.colMaPhong.HeaderText = "MÃ PHÒNG";
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.ReadOnly = true;
            //
            // colTenPhong
            //
            this.colTenPhong.DataPropertyName = "TenPhong";
            this.colTenPhong.HeaderText = "TÊN PHÒNG";
            this.colTenPhong.Name = "colTenPhong";
            this.colTenPhong.ReadOnly = true;
            //
            // colDienTich
            //
            dgvDienTichStyle.Format = "0 \"m²\"";
            this.colDienTich.DataPropertyName = "DienTich";
            this.colDienTich.DefaultCellStyle = dgvDienTichStyle;
            this.colDienTich.HeaderText = "DIỆN TÍCH";
            this.colDienTich.Name = "colDienTich";
            this.colDienTich.ReadOnly = true;
            //
            // colGiaThue
            //
            dgvGiaThueStyle.Format = "N0";
            this.colGiaThue.DataPropertyName = "GiaThue";
            this.colGiaThue.DefaultCellStyle = dgvGiaThueStyle;
            this.colGiaThue.HeaderText = "GIÁ THUÊ";
            this.colGiaThue.Name = "colGiaThue";
            this.colGiaThue.ReadOnly = true;
            //
            // colToiDa
            //
            dgvToiDaStyle.Format = "0 \"người\"";
            this.colToiDa.DataPropertyName = "ToiDa";
            this.colToiDa.DefaultCellStyle = dgvToiDaStyle;
            this.colToiDa.HeaderText = "TỐI ĐA";
            this.colToiDa.Name = "colToiDa";
            this.colToiDa.ReadOnly = true;
            //
            // colTrangThai
            //
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "TRẠNG THÁI";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            //
            // pnlThongTin
            //
            this.pnlThongTin.BackColor = System.Drawing.Color.White;
            this.pnlThongTin.Controls.Add(this.tlpThongTin);
            this.pnlThongTin.Controls.Add(this.flpNut);
            this.pnlThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTin.Location = new System.Drawing.Point(0, 326);
            this.pnlThongTin.Margin = new System.Windows.Forms.Padding(0);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlThongTin.Size = new System.Drawing.Size(805, 240);
            this.pnlThongTin.TabIndex = 2;
            //
            // tlpThongTin
            //
            this.tlpThongTin.ColumnCount = 2;
            this.tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpThongTin.Controls.Add(this.lblMaPhong, 0, 0);
            this.tlpThongTin.Controls.Add(this.lblTenPhong, 1, 0);
            this.tlpThongTin.Controls.Add(this.txtMaPhong, 0, 1);
            this.tlpThongTin.Controls.Add(this.txtTenPhong, 1, 1);
            this.tlpThongTin.Controls.Add(this.lblDienTich, 0, 2);
            this.tlpThongTin.Controls.Add(this.lblGiaThue, 1, 2);
            this.tlpThongTin.Controls.Add(this.txtDienTich, 0, 3);
            this.tlpThongTin.Controls.Add(this.txtGiaThue, 1, 3);
            this.tlpThongTin.Controls.Add(this.lblToiDa, 0, 4);
            this.tlpThongTin.Controls.Add(this.lblTrangThai, 1, 4);
            this.tlpThongTin.Controls.Add(this.txtToiDa, 0, 5);
            this.tlpThongTin.Controls.Add(this.cboTrangThai, 1, 5);
            this.tlpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpThongTin.Location = new System.Drawing.Point(12, 8);
            this.tlpThongTin.Name = "tlpThongTin";
            this.tlpThongTin.RowCount = 6;
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpThongTin.Size = new System.Drawing.Size(781, 180);
            this.tlpThongTin.TabIndex = 0;
            //
            // lblMaPhong
            //
            this.lblMaPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaPhong.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMaPhong.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.TabIndex = 0;
            this.lblMaPhong.Text = "Mã phòng";
            this.lblMaPhong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // lblTenPhong
            //
            this.lblTenPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenPhong.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTenPhong.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.TabIndex = 1;
            this.lblTenPhong.Text = "Tên phòng";
            this.lblTenPhong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // txtMaPhong
            //
            this.txtMaPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMaPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(0, 3, 12, 3);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.TabIndex = 2;
            //
            // txtTenPhong
            //
            this.txtTenPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTenPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.TabIndex = 3;
            //
            // lblDienTich
            //
            this.lblDienTich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDienTich.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDienTich.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.TabIndex = 4;
            this.lblDienTich.Text = "Diện tích (m²)";
            this.lblDienTich.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // lblGiaThue
            //
            this.lblGiaThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGiaThue.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblGiaThue.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblGiaThue.Name = "lblGiaThue";
            this.lblGiaThue.TabIndex = 5;
            this.lblGiaThue.Text = "Giá thuê";
            this.lblGiaThue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // txtDienTich
            //
            this.txtDienTich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDienTich.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDienTich.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDienTich.Margin = new System.Windows.Forms.Padding(0, 3, 12, 3);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.TabIndex = 6;
            //
            // txtGiaThue
            //
            this.txtGiaThue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiaThue.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGiaThue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGiaThue.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.TabIndex = 7;
            //
            // lblToiDa
            //
            this.lblToiDa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToiDa.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblToiDa.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblToiDa.Name = "lblToiDa";
            this.lblToiDa.TabIndex = 8;
            this.lblToiDa.Text = "Tối đa (người)";
            this.lblToiDa.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // lblTrangThai
            //
            this.lblTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTrangThai.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.TabIndex = 9;
            this.lblTrangThai.Text = "Trạng thái";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // txtToiDa
            //
            this.txtToiDa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToiDa.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtToiDa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtToiDa.Margin = new System.Windows.Forms.Padding(0, 3, 12, 3);
            this.txtToiDa.Name = "txtToiDa";
            this.txtToiDa.TabIndex = 10;
            //
            // cboTrangThai
            //
            this.cboTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTrangThai.Items.AddRange(new object[] {
            "Đang thuê",
            "Trống",
            "Bảo trì"});
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.TabIndex = 11;
            //
            // flpNut
            //
            this.flpNut.Controls.Add(this.btnLamMoi);
            this.flpNut.Controls.Add(this.btnXoa);
            this.flpNut.Controls.Add(this.btnSua);
            this.flpNut.Controls.Add(this.btnThem);
            this.flpNut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpNut.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpNut.Location = new System.Drawing.Point(12, 188);
            this.flpNut.Name = "flpNut";
            this.flpNut.Size = new System.Drawing.Size(781, 44);
            this.flpNut.TabIndex = 1;
            this.flpNut.WrapContents = false;
            //
            // btnLamMoi
            //
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#D1D5DB");
            this.btnLamMoi.FlatAppearance.BorderSize = 1;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.ColorTranslator.FromHtml("#111827");
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(8, 6, 0, 0);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 34);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "↻ Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            //
            // btnXoa
            //
            this.btnXoa.BackColor = System.Drawing.ColorTranslator.FromHtml("#F21520");
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Margin = new System.Windows.Forms.Padding(8, 6, 0, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 34);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "🗑 Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            //
            // btnSua
            //
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#D1D5DB");
            this.btnSua.FlatAppearance.BorderSize = 1;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.ColorTranslator.FromHtml("#111827");
            this.btnSua.Margin = new System.Windows.Forms.Padding(8, 6, 0, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(74, 34);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "✎ Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            //
            // btnThem
            //
            this.btnThem.BackColor = System.Drawing.ColorTranslator.FromHtml("#244691");
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Margin = new System.Windows.Forms.Padding(8, 6, 0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 34);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "+ Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            //
            // ucPhongTro
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F4F8");
            this.Controls.Add(this.tlpMain);
            this.Name = "ucPhongTro";
            this.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.Size = new System.Drawing.Size(843, 600);
            this.tlpMain.ResumeLayout(false);
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongTro)).EndInit();
            this.pnlThongTin.ResumeLayout(false);
            this.tlpThongTin.ResumeLayout(false);
            this.tlpThongTin.PerformLayout();
            this.flpNut.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel pnlTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvPhongTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.TableLayoutPanel tlpThongTin;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.Label lblGiaThue;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Label lblToiDa;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtToiDa;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.FlowLayoutPanel flpNut;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}
