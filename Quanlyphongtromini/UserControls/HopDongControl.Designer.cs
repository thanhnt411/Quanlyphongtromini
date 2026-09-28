namespace Quanlyphongtromini.UserControls
{
    partial class HopDongControl
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
            System.Windows.Forms.DataGridViewCellStyle dgvNgayBatDauStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvNgayKetThucStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvTienCocStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.colMaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.tlpThongTin = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaHopDong = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblNguoiThue = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.cboNguoiThue = new System.Windows.Forms.ComboBox();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblTienCoc = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.flpNut = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnKetThucHD = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
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
            this.tlpMain.Controls.Add(this.dgvHopDong, 0, 1);
            this.tlpMain.Controls.Add(this.pnlThongTin, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(19, 17);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 290F));
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
            this.txtTimKiem.PlaceholderText = "Tên người thuê hoặc mã phòng...";
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
            // dgvHopDong
            //
            this.dgvHopDong.AllowUserToAddRows = false;
            this.dgvHopDong.AllowUserToDeleteRows = false;
            this.dgvHopDong.AllowUserToResizeRows = false;
            this.dgvHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHopDong.BackgroundColor = System.Drawing.Color.White;
            this.dgvHopDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHopDong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHopDong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvHeaderStyle.BackColor = System.Drawing.Color.White;
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            dgvHeaderStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dgvHeaderStyle.SelectionBackColor = System.Drawing.Color.White;
            dgvHeaderStyle.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            dgvHeaderStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHopDong.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvHopDong.ColumnHeadersHeight = 34;
            this.dgvHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHopDong,
            this.colPhong,
            this.colNguoiThue,
            this.colNgayBatDau,
            this.colNgayKetThuc,
            this.colTienCoc,
            this.colTrangThai});
            dgvCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvCellStyle.BackColor = System.Drawing.Color.White;
            dgvCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#111827");
            dgvCellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dgvCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#E8ECF8");
            dgvCellStyle.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#111827");
            dgvCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHopDong.DefaultCellStyle = dgvCellStyle;
            this.dgvHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHopDong.EnableHeadersVisualStyles = false;
            this.dgvHopDong.GridColor = System.Drawing.ColorTranslator.FromHtml("#E5E7EB");
            this.dgvHopDong.Location = new System.Drawing.Point(0, 46);
            this.dgvHopDong.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.dgvHopDong.MultiSelect = false;
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.ReadOnly = true;
            this.dgvHopDong.RowHeadersVisible = false;
            this.dgvHopDong.RowTemplate.Height = 32;
            this.dgvHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHopDong.Size = new System.Drawing.Size(805, 218);
            this.dgvHopDong.TabIndex = 1;
            //
            // colMaHopDong
            //
            this.colMaHopDong.DataPropertyName = "MaHopDong";
            this.colMaHopDong.HeaderText = "MÃ HĐ";
            this.colMaHopDong.Name = "colMaHopDong";
            this.colMaHopDong.ReadOnly = true;
            //
            // colPhong
            //
            this.colPhong.DataPropertyName = "TenPhong";
            this.colPhong.HeaderText = "PHÒNG";
            this.colPhong.Name = "colPhong";
            this.colPhong.ReadOnly = true;
            //
            // colNguoiThue
            //
            this.colNguoiThue.DataPropertyName = "TenNguoiThue";
            this.colNguoiThue.HeaderText = "NGƯỜI THUÊ";
            this.colNguoiThue.Name = "colNguoiThue";
            this.colNguoiThue.ReadOnly = true;
            //
            // colNgayBatDau
            //
            dgvNgayBatDauStyle.Format = "dd/MM/yyyy";
            this.colNgayBatDau.DataPropertyName = "NgayBatDau";
            this.colNgayBatDau.DefaultCellStyle = dgvNgayBatDauStyle;
            this.colNgayBatDau.HeaderText = "NGÀY BẮT ĐẦU";
            this.colNgayBatDau.Name = "colNgayBatDau";
            this.colNgayBatDau.ReadOnly = true;
            //
            // colNgayKetThuc
            //
            dgvNgayKetThucStyle.Format = "dd/MM/yyyy";
            this.colNgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.colNgayKetThuc.DefaultCellStyle = dgvNgayKetThucStyle;
            this.colNgayKetThuc.HeaderText = "NGÀY KẾT THÚC";
            this.colNgayKetThuc.Name = "colNgayKetThuc";
            this.colNgayKetThuc.ReadOnly = true;
            //
            // colTienCoc
            //
            dgvTienCocStyle.Format = "N0";
            this.colTienCoc.DataPropertyName = "TienCoc";
            this.colTienCoc.DefaultCellStyle = dgvTienCocStyle;
            this.colTienCoc.HeaderText = "TIỀN CỌC";
            this.colTienCoc.Name = "colTienCoc";
            this.colTienCoc.ReadOnly = true;
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
            this.pnlThongTin.Location = new System.Drawing.Point(0, 276);
            this.pnlThongTin.Margin = new System.Windows.Forms.Padding(0);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlThongTin.Size = new System.Drawing.Size(805, 290);
            this.pnlThongTin.TabIndex = 2;
            //
            // tlpThongTin
            //
            this.tlpThongTin.ColumnCount = 2;
            this.tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpThongTin.Controls.Add(this.lblMaHopDong, 0, 0);
            this.tlpThongTin.Controls.Add(this.lblTrangThai, 1, 0);
            this.tlpThongTin.Controls.Add(this.txtMaHopDong, 0, 1);
            this.tlpThongTin.Controls.Add(this.cboTrangThai, 1, 1);
            this.tlpThongTin.Controls.Add(this.lblPhong, 0, 2);
            this.tlpThongTin.Controls.Add(this.lblNguoiThue, 1, 2);
            this.tlpThongTin.Controls.Add(this.cboPhong, 0, 3);
            this.tlpThongTin.Controls.Add(this.cboNguoiThue, 1, 3);
            this.tlpThongTin.Controls.Add(this.lblNgayBatDau, 0, 4);
            this.tlpThongTin.Controls.Add(this.lblNgayKetThuc, 1, 4);
            this.tlpThongTin.Controls.Add(this.dtpNgayBatDau, 0, 5);
            this.tlpThongTin.Controls.Add(this.dtpNgayKetThuc, 1, 5);
            this.tlpThongTin.Controls.Add(this.lblTienCoc, 0, 6);
            this.tlpThongTin.Controls.Add(this.txtTienCoc, 0, 7);
            this.tlpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpThongTin.Location = new System.Drawing.Point(12, 8);
            this.tlpThongTin.Name = "tlpThongTin";
            this.tlpThongTin.RowCount = 8;
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpThongTin.Size = new System.Drawing.Size(781, 230);
            this.tlpThongTin.TabIndex = 0;
            //
            // lblMaHopDong
            //
            this.lblMaHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaHopDong.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMaHopDong.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblMaHopDong.Name = "lblMaHopDong";
            this.lblMaHopDong.TabIndex = 0;
            this.lblMaHopDong.Text = "Mã hợp đồng";
            this.lblMaHopDong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // lblTrangThai
            //
            this.lblTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTrangThai.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.TabIndex = 1;
            this.lblTrangThai.Text = "Trạng thái";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // txtMaHopDong
            //
            this.txtMaHopDong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHopDong.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMaHopDong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaHopDong.Margin = new System.Windows.Forms.Padding(0, 3, 12, 3);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.TabIndex = 2;
            //
            // cboTrangThai
            //
            this.cboTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTrangThai.Items.AddRange(new object[] {
            "Còn hạn",
            "Hết hạn"});
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.TabIndex = 3;
            //
            // lblPhong
            //
            this.lblPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhong.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPhong.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.TabIndex = 4;
            this.lblPhong.Text = "Phòng";
            this.lblPhong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // lblNguoiThue
            //
            this.lblNguoiThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNguoiThue.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNguoiThue.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblNguoiThue.Name = "lblNguoiThue";
            this.lblNguoiThue.TabIndex = 5;
            this.lblNguoiThue.Text = "Người thuê";
            this.lblNguoiThue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // cboPhong
            //
            this.cboPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPhong.Margin = new System.Windows.Forms.Padding(0, 3, 12, 3);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.TabIndex = 6;
            //
            // cboNguoiThue
            //
            this.cboNguoiThue.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboNguoiThue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNguoiThue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNguoiThue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNguoiThue.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.cboNguoiThue.Name = "cboNguoiThue";
            this.cboNguoiThue.TabIndex = 7;
            //
            // lblNgayBatDau
            //
            this.lblNgayBatDau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNgayBatDau.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.TabIndex = 8;
            this.lblNgayBatDau.Text = "Ngày bắt đầu";
            this.lblNgayBatDau.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // lblNgayKetThuc
            //
            this.lblNgayKetThuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNgayKetThuc.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.TabIndex = 9;
            this.lblNgayKetThuc.Text = "Ngày kết thúc";
            this.lblNgayKetThuc.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // dtpNgayBatDau
            //
            this.dtpNgayBatDau.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Margin = new System.Windows.Forms.Padding(0, 3, 12, 3);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.TabIndex = 10;
            //
            // dtpNgayKetThuc
            //
            this.dtpNgayKetThuc.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.TabIndex = 11;
            //
            // lblTienCoc
            //
            this.tlpThongTin.SetColumnSpan(this.lblTienCoc, 2);
            this.lblTienCoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTienCoc.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTienCoc.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblTienCoc.Name = "lblTienCoc";
            this.lblTienCoc.TabIndex = 12;
            this.lblTienCoc.Text = "Tiền cọc";
            this.lblTienCoc.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // txtTienCoc
            //
            this.txtTienCoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpThongTin.SetColumnSpan(this.txtTienCoc, 2);
            this.txtTienCoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTienCoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTienCoc.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.TabIndex = 13;
            //
            // flpNut
            //
            this.flpNut.Controls.Add(this.btnLamMoi);
            this.flpNut.Controls.Add(this.btnKetThucHD);
            this.flpNut.Controls.Add(this.btnSua);
            this.flpNut.Controls.Add(this.btnThem);
            this.flpNut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpNut.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpNut.Location = new System.Drawing.Point(12, 238);
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
            // btnKetThucHD
            //
            this.btnKetThucHD.BackColor = System.Drawing.ColorTranslator.FromHtml("#F21520");
            this.btnKetThucHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKetThucHD.FlatAppearance.BorderSize = 0;
            this.btnKetThucHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetThucHD.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.btnKetThucHD.ForeColor = System.Drawing.Color.White;
            this.btnKetThucHD.Margin = new System.Windows.Forms.Padding(8, 6, 0, 0);
            this.btnKetThucHD.Name = "btnKetThucHD";
            this.btnKetThucHD.Size = new System.Drawing.Size(110, 34);
            this.btnKetThucHD.TabIndex = 2;
            this.btnKetThucHD.Text = "■ Kết thúc HĐ";
            this.btnKetThucHD.UseVisualStyleBackColor = false;
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
            // ucHopDong
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F4F8");
            this.Controls.Add(this.tlpMain);
            this.Name = "ucHopDong";
            this.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.Size = new System.Drawing.Size(843, 600);
            this.tlpMain.ResumeLayout(false);
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.TableLayoutPanel tlpThongTin;
        private System.Windows.Forms.Label lblMaHopDong;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblNguoiThue;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.ComboBox cboNguoiThue;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label lblTienCoc;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.FlowLayoutPanel flpNut;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnKetThucHD;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}
