namespace Quanlyphongtromini.UserControls
{
    partial class HoaDonControl
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
            System.Windows.Forms.DataGridViewCellStyle dgvThangNamStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvPhiDichVuStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvTongTienStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.colMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThangNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienTieuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNuocTieuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhiDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.tlpThongTin = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.lblThangNam = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.dtpThangNam = new System.Windows.Forms.DateTimePicker();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblMaHopDong = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.cboMaHopDong = new System.Windows.Forms.ComboBox();
            this.lblDienCu = new System.Windows.Forms.Label();
            this.lblDienMoi = new System.Windows.Forms.Label();
            this.txtDienCu = new System.Windows.Forms.TextBox();
            this.txtDienMoi = new System.Windows.Forms.TextBox();
            this.lblNuocCu = new System.Windows.Forms.Label();
            this.lblNuocMoi = new System.Windows.Forms.Label();
            this.txtNuocCu = new System.Windows.Forms.TextBox();
            this.txtNuocMoi = new System.Windows.Forms.TextBox();
            this.lblPhiDichVu = new System.Windows.Forms.Label();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.txtPhiDichVu = new System.Windows.Forms.TextBox();
            this.txtTongCong = new System.Windows.Forms.TextBox();
            this.flpNut = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnDaThuTien = new System.Windows.Forms.Button();
            this.btnLapHoaDon = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
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
            this.tlpMain.Controls.Add(this.dgvHoaDon, 0, 1);
            this.tlpMain.Controls.Add(this.pnlThongTin, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(19, 17);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 320F));
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
            this.txtTimKiem.PlaceholderText = "Mã phòng, tháng/năm...";
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
            // dgvHoaDon
            //
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AllowUserToResizeRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvHeaderStyle.BackColor = System.Drawing.Color.White;
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            dgvHeaderStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dgvHeaderStyle.SelectionBackColor = System.Drawing.Color.White;
            dgvHeaderStyle.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            dgvHeaderStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvHoaDon.ColumnHeadersHeight = 34;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHoaDon,
            this.colMaHopDong,
            this.colPhong,
            this.colThangNam,
            this.colDienTieuThu,
            this.colNuocTieuThu,
            this.colPhiDichVu,
            this.colTongTien,
            this.colTrangThai});
            dgvCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvCellStyle.BackColor = System.Drawing.Color.White;
            dgvCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#111827");
            dgvCellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dgvCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#E8ECF8");
            dgvCellStyle.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#111827");
            dgvCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dgvCellStyle;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.GridColor = System.Drawing.ColorTranslator.FromHtml("#E5E7EB");
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 46);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowTemplate.Height = 32;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(805, 188);
            this.dgvHoaDon.TabIndex = 1;
            //
            // colMaHoaDon
            //
            this.colMaHoaDon.DataPropertyName = "MaHoaDon";
            this.colMaHoaDon.HeaderText = "MÃ HÓA ĐƠN";
            this.colMaHoaDon.Name = "colMaHoaDon";
            this.colMaHoaDon.ReadOnly = true;
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
            this.colPhong.DataPropertyName = "MaPhong";
            this.colPhong.HeaderText = "PHÒNG";
            this.colPhong.Name = "colPhong";
            this.colPhong.ReadOnly = true;
            //
            // colThangNam
            //
            dgvThangNamStyle.Format = "MM/yyyy";
            this.colThangNam.DataPropertyName = "ThangNam";
            this.colThangNam.DefaultCellStyle = dgvThangNamStyle;
            this.colThangNam.HeaderText = "THÁNG/NĂM";
            this.colThangNam.Name = "colThangNam";
            this.colThangNam.ReadOnly = true;
            //
            // colDienTieuThu
            //
            this.colDienTieuThu.DataPropertyName = "DienTieuThu";
            this.colDienTieuThu.HeaderText = "ĐIỆN TIÊU THỤ";
            this.colDienTieuThu.Name = "colDienTieuThu";
            this.colDienTieuThu.ReadOnly = true;
            //
            // colNuocTieuThu
            //
            this.colNuocTieuThu.DataPropertyName = "NuocTieuThu";
            this.colNuocTieuThu.HeaderText = "NƯỚC TIÊU THỤ";
            this.colNuocTieuThu.Name = "colNuocTieuThu";
            this.colNuocTieuThu.ReadOnly = true;
            //
            // colPhiDichVu
            //
            dgvPhiDichVuStyle.Format = "N0";
            this.colPhiDichVu.DataPropertyName = "PhiDichVu";
            this.colPhiDichVu.DefaultCellStyle = dgvPhiDichVuStyle;
            this.colPhiDichVu.HeaderText = "PHÍ DV";
            this.colPhiDichVu.Name = "colPhiDichVu";
            this.colPhiDichVu.ReadOnly = true;
            //
            // colTongTien
            //
            dgvTongTienStyle.Format = "N0";
            this.colTongTien.DataPropertyName = "TongTien";
            this.colTongTien.DefaultCellStyle = dgvTongTienStyle;
            this.colTongTien.HeaderText = "TỔNG TIỀN";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
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
            this.pnlThongTin.Location = new System.Drawing.Point(0, 246);
            this.pnlThongTin.Margin = new System.Windows.Forms.Padding(0);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlThongTin.Size = new System.Drawing.Size(805, 320);
            this.pnlThongTin.TabIndex = 2;
            //
            // tlpThongTin
            //
            this.tlpThongTin.ColumnCount = 2;
            this.tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpThongTin.Controls.Add(this.lblMaHoaDon, 0, 0);
            this.tlpThongTin.Controls.Add(this.lblThangNam, 1, 0);
            this.tlpThongTin.Controls.Add(this.txtMaHoaDon, 0, 1);
            this.tlpThongTin.Controls.Add(this.dtpThangNam, 1, 1);
            this.tlpThongTin.Controls.Add(this.lblPhong, 0, 2);
            this.tlpThongTin.Controls.Add(this.lblMaHopDong, 1, 2);
            this.tlpThongTin.Controls.Add(this.cboPhong, 0, 3);
            this.tlpThongTin.Controls.Add(this.cboMaHopDong, 1, 3);
            this.tlpThongTin.Controls.Add(this.lblDienCu, 0, 4);
            this.tlpThongTin.Controls.Add(this.lblDienMoi, 1, 4);
            this.tlpThongTin.Controls.Add(this.txtDienCu, 0, 5);
            this.tlpThongTin.Controls.Add(this.txtDienMoi, 1, 5);
            this.tlpThongTin.Controls.Add(this.lblNuocCu, 0, 6);
            this.tlpThongTin.Controls.Add(this.lblNuocMoi, 1, 6);
            this.tlpThongTin.Controls.Add(this.txtNuocCu, 0, 7);
            this.tlpThongTin.Controls.Add(this.txtNuocMoi, 1, 7);
            this.tlpThongTin.Controls.Add(this.lblPhiDichVu, 0, 8);
            this.tlpThongTin.Controls.Add(this.lblTongCong, 1, 8);
            this.tlpThongTin.Controls.Add(this.txtPhiDichVu, 0, 9);
            this.tlpThongTin.Controls.Add(this.txtTongCong, 1, 9);
            this.tlpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpThongTin.Location = new System.Drawing.Point(12, 8);
            this.tlpThongTin.Name = "tlpThongTin";
            this.tlpThongTin.RowCount = 10;
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpThongTin.Size = new System.Drawing.Size(781, 260);
            this.tlpThongTin.TabIndex = 0;
            //
            // lblMaHoaDon
            //
            this.lblMaHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMaHoaDon.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.TabIndex = 0;
            this.lblMaHoaDon.Text = "Mã hóa đơn";
            this.lblMaHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // lblThangNam
            //
            this.lblThangNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThangNam.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblThangNam.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblThangNam.Name = "lblThangNam";
            this.lblThangNam.TabIndex = 1;
            this.lblThangNam.Text = "Tháng/Năm";
            this.lblThangNam.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // txtMaHoaDon
            //
            this.txtMaHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(0, 3, 12, 3);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.TabIndex = 2;
            //
            // dtpThangNam
            //
            this.dtpThangNam.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpThangNam.CustomFormat = "MM/yyyy";
            this.dtpThangNam.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpThangNam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangNam.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.dtpThangNam.Name = "dtpThangNam";
            this.dtpThangNam.TabIndex = 3;
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
            // lblMaHopDong
            //
            this.lblMaHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaHopDong.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMaHopDong.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblMaHopDong.Name = "lblMaHopDong";
            this.lblMaHopDong.TabIndex = 5;
            this.lblMaHopDong.Text = "Mã hợp đồng";
            this.lblMaHopDong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
            // cboMaHopDong
            //
            this.cboMaHopDong.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboMaHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMaHopDong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMaHopDong.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.cboMaHopDong.Name = "cboMaHopDong";
            this.cboMaHopDong.TabIndex = 7;
            //
            // lblDienCu
            //
            this.lblDienCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDienCu.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDienCu.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblDienCu.Name = "lblDienCu";
            this.lblDienCu.TabIndex = 8;
            this.lblDienCu.Text = "Điện cũ";
            this.lblDienCu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // lblDienMoi
            //
            this.lblDienMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDienMoi.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDienMoi.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblDienMoi.Name = "lblDienMoi";
            this.lblDienMoi.TabIndex = 9;
            this.lblDienMoi.Text = "Điện mới";
            this.lblDienMoi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // txtDienCu
            //
            this.txtDienCu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDienCu.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDienCu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDienCu.Margin = new System.Windows.Forms.Padding(0, 3, 12, 3);
            this.txtDienCu.Name = "txtDienCu";
            this.txtDienCu.TabIndex = 10;
            //
            // txtDienMoi
            //
            this.txtDienMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDienMoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDienMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDienMoi.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.txtDienMoi.Name = "txtDienMoi";
            this.txtDienMoi.TabIndex = 11;
            //
            // lblNuocCu
            //
            this.lblNuocCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNuocCu.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNuocCu.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblNuocCu.Name = "lblNuocCu";
            this.lblNuocCu.TabIndex = 12;
            this.lblNuocCu.Text = "Nước cũ";
            this.lblNuocCu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // lblNuocMoi
            //
            this.lblNuocMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNuocMoi.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNuocMoi.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblNuocMoi.Name = "lblNuocMoi";
            this.lblNuocMoi.TabIndex = 13;
            this.lblNuocMoi.Text = "Nước mới";
            this.lblNuocMoi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // txtNuocCu
            //
            this.txtNuocCu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNuocCu.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNuocCu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNuocCu.Margin = new System.Windows.Forms.Padding(0, 3, 12, 3);
            this.txtNuocCu.Name = "txtNuocCu";
            this.txtNuocCu.TabIndex = 14;
            //
            // txtNuocMoi
            //
            this.txtNuocMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNuocMoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNuocMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNuocMoi.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.txtNuocMoi.Name = "txtNuocMoi";
            this.txtNuocMoi.TabIndex = 15;
            //
            // lblPhiDichVu
            //
            this.lblPhiDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhiDichVu.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPhiDichVu.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblPhiDichVu.Name = "lblPhiDichVu";
            this.lblPhiDichVu.TabIndex = 16;
            this.lblPhiDichVu.Text = "Phí dịch vụ";
            this.lblPhiDichVu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // lblTongCong
            //
            this.lblTongCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongCong.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTongCong.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.TabIndex = 17;
            this.lblTongCong.Text = "Tổng cộng (tự tính)";
            this.lblTongCong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // txtPhiDichVu
            //
            this.txtPhiDichVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhiDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPhiDichVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhiDichVu.Margin = new System.Windows.Forms.Padding(0, 3, 12, 3);
            this.txtPhiDichVu.Name = "txtPhiDichVu";
            this.txtPhiDichVu.TabIndex = 18;
            //
            // txtTongCong
            //
            this.txtTongCong.BackColor = System.Drawing.Color.White;
            this.txtTongCong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTongCong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTongCong.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.ReadOnly = true;
            this.txtTongCong.TabIndex = 19;
            //
            // flpNut
            //
            this.flpNut.Controls.Add(this.btnInHoaDon);
            this.flpNut.Controls.Add(this.btnDaThuTien);
            this.flpNut.Controls.Add(this.btnLapHoaDon);
            this.flpNut.Controls.Add(this.btnTinhTien);
            this.flpNut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpNut.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpNut.Location = new System.Drawing.Point(12, 268);
            this.flpNut.Name = "flpNut";
            this.flpNut.Size = new System.Drawing.Size(781, 44);
            this.flpNut.TabIndex = 1;
            this.flpNut.WrapContents = false;
            //
            // btnInHoaDon
            //
            this.btnInHoaDon.BackColor = System.Drawing.Color.White;
            this.btnInHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInHoaDon.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#D1D5DB");
            this.btnInHoaDon.FlatAppearance.BorderSize = 1;
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.btnInHoaDon.ForeColor = System.Drawing.ColorTranslator.FromHtml("#111827");
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(8, 6, 0, 0);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(110, 34);
            this.btnInHoaDon.TabIndex = 3;
            this.btnInHoaDon.Text = "🖨 In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            //
            // btnDaThuTien
            //
            this.btnDaThuTien.BackColor = System.Drawing.ColorTranslator.FromHtml("#F21520");
            this.btnDaThuTien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDaThuTien.FlatAppearance.BorderSize = 0;
            this.btnDaThuTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaThuTien.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.btnDaThuTien.ForeColor = System.Drawing.Color.White;
            this.btnDaThuTien.Margin = new System.Windows.Forms.Padding(8, 6, 0, 0);
            this.btnDaThuTien.Name = "btnDaThuTien";
            this.btnDaThuTien.Size = new System.Drawing.Size(112, 34);
            this.btnDaThuTien.TabIndex = 2;
            this.btnDaThuTien.Text = "✔ Đã thu tiền";
            this.btnDaThuTien.UseVisualStyleBackColor = false;
            //
            // btnLapHoaDon
            //
            this.btnLapHoaDon.BackColor = System.Drawing.ColorTranslator.FromHtml("#244691");
            this.btnLapHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapHoaDon.FlatAppearance.BorderSize = 0;
            this.btnLapHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapHoaDon.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.btnLapHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnLapHoaDon.Margin = new System.Windows.Forms.Padding(8, 6, 0, 0);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(120, 34);
            this.btnLapHoaDon.TabIndex = 1;
            this.btnLapHoaDon.Text = "+ Lập hóa đơn";
            this.btnLapHoaDon.UseVisualStyleBackColor = false;
            //
            // btnTinhTien
            //
            this.btnTinhTien.BackColor = System.Drawing.Color.White;
            this.btnTinhTien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinhTien.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#D1D5DB");
            this.btnTinhTien.FlatAppearance.BorderSize = 1;
            this.btnTinhTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhTien.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.btnTinhTien.ForeColor = System.Drawing.ColorTranslator.FromHtml("#111827");
            this.btnTinhTien.Margin = new System.Windows.Forms.Padding(8, 6, 0, 0);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(104, 34);
            this.btnTinhTien.TabIndex = 0;
            this.btnTinhTien.Text = "🧮 Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            //
            // ucHoaDon
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F4F8");
            this.Controls.Add(this.tlpMain);
            this.Name = "ucHoaDon";
            this.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.Size = new System.Drawing.Size(843, 600);
            this.tlpMain.ResumeLayout(false);
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThangNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienTieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNuocTieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhiDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.TableLayoutPanel tlpThongTin;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Label lblThangNam;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.DateTimePicker dtpThangNam;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblMaHopDong;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.ComboBox cboMaHopDong;
        private System.Windows.Forms.Label lblDienCu;
        private System.Windows.Forms.Label lblDienMoi;
        private System.Windows.Forms.TextBox txtDienCu;
        private System.Windows.Forms.TextBox txtDienMoi;
        private System.Windows.Forms.Label lblNuocCu;
        private System.Windows.Forms.Label lblNuocMoi;
        private System.Windows.Forms.TextBox txtNuocCu;
        private System.Windows.Forms.TextBox txtNuocMoi;
        private System.Windows.Forms.Label lblPhiDichVu;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.TextBox txtPhiDichVu;
        private System.Windows.Forms.TextBox txtTongCong;
        private System.Windows.Forms.FlowLayoutPanel flpNut;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnDaThuTien;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Button btnTinhTien;
    }
}
