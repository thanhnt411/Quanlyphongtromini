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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tlpMain = new TableLayoutPanel();
            pnlTimKiem = new Panel();
            txtTimKiem = new TextBox();
            btnTim = new Button();
            dgvHoaDon = new DataGridView();
            colMaHoaDon = new DataGridViewTextBoxColumn();
            colMaHopDong = new DataGridViewTextBoxColumn();
            colPhong = new DataGridViewTextBoxColumn();
            colThangNam = new DataGridViewTextBoxColumn();
            colDienTieuThu = new DataGridViewTextBoxColumn();
            colNuocTieuThu = new DataGridViewTextBoxColumn();
            colPhiDichVu = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            pnlThongTin = new Panel();
            tlpThongTin = new TableLayoutPanel();
            lblMaHoaDon = new Label();
            lblThangNam = new Label();
            txtMaHoaDon = new TextBox();
            dtpThangNam = new DateTimePicker();
            lblPhong = new Label();
            lblMaHopDong = new Label();
            cboPhong = new ComboBox();
            cboMaHopDong = new ComboBox();
            lblDienCu = new Label();
            lblDienMoi = new Label();
            txtDienCu = new TextBox();
            txtDienMoi = new TextBox();
            lblNuocCu = new Label();
            lblNuocMoi = new Label();
            txtNuocCu = new TextBox();
            txtNuocMoi = new TextBox();
            lblPhiDichVu = new Label();
            lblTongCong = new Label();
            txtPhiDichVu = new TextBox();
            txtTongCong = new TextBox();
            flpNut = new FlowLayoutPanel();
            btnLamMoi = new Button();
            btnXoaHoaDon = new Button();
            btnInHoaDon = new Button();
            btnDaThuTien = new Button();
            btnSua = new Button();
            btnLapHoaDon = new Button();
            btnTinhTien = new Button();
            tlpMain.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            pnlThongTin.SuspendLayout();
            tlpThongTin.SuspendLayout();
            flpNut.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlTimKiem, 0, 0);
            tlpMain.Controls.Add(dgvHoaDon, 0, 1);
            tlpMain.Controls.Add(pnlThongTin, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(27, 28);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 533F));
            tlpMain.Size = new Size(1150, 944);
            tlpMain.TabIndex = 0;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(btnTim);
            pnlTimKiem.Dock = DockStyle.Fill;
            pnlTimKiem.Location = new Point(0, 0);
            pnlTimKiem.Margin = new Padding(0, 0, 0, 20);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(1150, 57);
            pnlTimKiem.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 10F);
            txtTimKiem.Location = new Point(0, 7);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Mã phòng, tháng/năm...";
            txtTimKiem.Size = new Size(989, 34);
            txtTimKiem.TabIndex = 0;
            // 
            // btnTim
            // 
            btnTim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTim.BackColor = Color.FromArgb(36, 70, 145);
            btnTim.Cursor = Cursors.Hand;
            btnTim.FlatAppearance.BorderSize = 0;
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnTim.ForeColor = Color.White;
            btnTim.Location = new Point(1001, 0);
            btnTim.Margin = new Padding(4, 5, 4, 5);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(149, 57);
            btnTim.TabIndex = 1;
            btnTim.Text = "🔍 Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AllowUserToResizeRows = false;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.BackgroundColor = Color.White;
            dgvHoaDon.BorderStyle = BorderStyle.None;
            dgvHoaDon.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHoaDon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle1.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHoaDon.ColumnHeadersHeight = 34;
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { colMaHoaDon, colMaHopDong, colPhong, colThangNam, colDienTieuThu, colNuocTieuThu, colPhiDichVu, colTongTien, colTrangThai });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(232, 236, 248);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle5;
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.EnableHeadersVisualStyles = false;
            dgvHoaDon.GridColor = Color.FromArgb(229, 231, 235);
            dgvHoaDon.Location = new Point(0, 77);
            dgvHoaDon.Margin = new Padding(0, 0, 0, 20);
            dgvHoaDon.MultiSelect = false;
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.ReadOnly = true;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 62;
            dgvHoaDon.RowTemplate.Height = 32;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.Size = new Size(1150, 314);
            dgvHoaDon.TabIndex = 1;
            dgvHoaDon.CellClick += dgvHoaDon_CellClick;
            // 
            // colMaHoaDon
            // 
            colMaHoaDon.DataPropertyName = "MaHoaDon";
            colMaHoaDon.HeaderText = "MÃ HÓA ĐƠN";
            colMaHoaDon.MinimumWidth = 8;
            colMaHoaDon.Name = "colMaHoaDon";
            colMaHoaDon.ReadOnly = true;
            // 
            // colMaHopDong
            // 
            colMaHopDong.DataPropertyName = "MaHopDong";
            colMaHopDong.HeaderText = "MÃ HĐ";
            colMaHopDong.MinimumWidth = 8;
            colMaHopDong.Name = "colMaHopDong";
            colMaHopDong.ReadOnly = true;
            // 
            // colPhong
            // 
            colPhong.DataPropertyName = "MaPhong";
            colPhong.HeaderText = "PHÒNG";
            colPhong.MinimumWidth = 8;
            colPhong.Name = "colPhong";
            colPhong.ReadOnly = true;
            // 
            // colThangNam
            // 
            colThangNam.DataPropertyName = "ThangNam";
            dataGridViewCellStyle2.Format = "MM/yyyy";
            colThangNam.DefaultCellStyle = dataGridViewCellStyle2;
            colThangNam.HeaderText = "THÁNG/NĂM";
            colThangNam.MinimumWidth = 8;
            colThangNam.Name = "colThangNam";
            colThangNam.ReadOnly = true;
            // 
            // colDienTieuThu
            // 
            colDienTieuThu.DataPropertyName = "DienTieuThu";
            colDienTieuThu.HeaderText = "ĐIỆN TIÊU THỤ";
            colDienTieuThu.MinimumWidth = 8;
            colDienTieuThu.Name = "colDienTieuThu";
            colDienTieuThu.ReadOnly = true;
            // 
            // colNuocTieuThu
            // 
            colNuocTieuThu.DataPropertyName = "NuocTieuThu";
            colNuocTieuThu.HeaderText = "NƯỚC TIÊU THỤ";
            colNuocTieuThu.MinimumWidth = 8;
            colNuocTieuThu.Name = "colNuocTieuThu";
            colNuocTieuThu.ReadOnly = true;
            // 
            // colPhiDichVu
            // 
            colPhiDichVu.DataPropertyName = "PhiDichVu";
            dataGridViewCellStyle3.Format = "N0";
            colPhiDichVu.DefaultCellStyle = dataGridViewCellStyle3;
            colPhiDichVu.HeaderText = "PHÍ DV";
            colPhiDichVu.MinimumWidth = 8;
            colPhiDichVu.Name = "colPhiDichVu";
            colPhiDichVu.ReadOnly = true;
            // 
            // colTongTien
            // 
            colTongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle4.Format = "N0";
            colTongTien.DefaultCellStyle = dataGridViewCellStyle4;
            colTongTien.HeaderText = "TỔNG TIỀN";
            colTongTien.MinimumWidth = 8;
            colTongTien.Name = "colTongTien";
            colTongTien.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "TRẠNG THÁI";
            colTrangThai.MinimumWidth = 8;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // pnlThongTin
            // 
            pnlThongTin.BackColor = Color.White;
            pnlThongTin.Controls.Add(tlpThongTin);
            pnlThongTin.Controls.Add(flpNut);
            pnlThongTin.Dock = DockStyle.Fill;
            pnlThongTin.Location = new Point(0, 411);
            pnlThongTin.Margin = new Padding(0);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Padding = new Padding(17, 13, 17, 13);
            pnlThongTin.Size = new Size(1150, 533);
            pnlThongTin.TabIndex = 2;
            // 
            // tlpThongTin
            // 
            tlpThongTin.ColumnCount = 2;
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpThongTin.Controls.Add(lblMaHoaDon, 0, 0);
            tlpThongTin.Controls.Add(lblThangNam, 1, 0);
            tlpThongTin.Controls.Add(txtMaHoaDon, 0, 1);
            tlpThongTin.Controls.Add(dtpThangNam, 1, 1);
            tlpThongTin.Controls.Add(lblPhong, 0, 2);
            tlpThongTin.Controls.Add(lblMaHopDong, 1, 2);
            tlpThongTin.Controls.Add(cboPhong, 0, 3);
            tlpThongTin.Controls.Add(cboMaHopDong, 1, 3);
            tlpThongTin.Controls.Add(lblDienCu, 0, 4);
            tlpThongTin.Controls.Add(lblDienMoi, 1, 4);
            tlpThongTin.Controls.Add(txtDienCu, 0, 5);
            tlpThongTin.Controls.Add(txtDienMoi, 1, 5);
            tlpThongTin.Controls.Add(lblNuocCu, 0, 6);
            tlpThongTin.Controls.Add(lblNuocMoi, 1, 6);
            tlpThongTin.Controls.Add(txtNuocCu, 0, 7);
            tlpThongTin.Controls.Add(txtNuocMoi, 1, 7);
            tlpThongTin.Controls.Add(lblPhiDichVu, 0, 8);
            tlpThongTin.Controls.Add(lblTongCong, 1, 8);
            tlpThongTin.Controls.Add(txtPhiDichVu, 0, 9);
            tlpThongTin.Controls.Add(txtTongCong, 1, 9);
            tlpThongTin.Dock = DockStyle.Fill;
            tlpThongTin.Location = new Point(17, 13);
            tlpThongTin.Margin = new Padding(4, 5, 4, 5);
            tlpThongTin.Name = "tlpThongTin";
            tlpThongTin.RowCount = 10;
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tlpThongTin.Size = new Size(1116, 434);
            tlpThongTin.TabIndex = 0;
            // 
            // lblMaHoaDon
            // 
            lblMaHoaDon.Dock = DockStyle.Fill;
            lblMaHoaDon.Font = new Font("Segoe UI", 8F);
            lblMaHoaDon.ForeColor = Color.FromArgb(107, 114, 128);
            lblMaHoaDon.Location = new Point(4, 0);
            lblMaHoaDon.Margin = new Padding(4, 0, 4, 0);
            lblMaHoaDon.Name = "lblMaHoaDon";
            lblMaHoaDon.Size = new Size(550, 33);
            lblMaHoaDon.TabIndex = 0;
            lblMaHoaDon.Text = "Mã hóa đơn";
            lblMaHoaDon.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblThangNam
            // 
            lblThangNam.Dock = DockStyle.Fill;
            lblThangNam.Font = new Font("Segoe UI", 8F);
            lblThangNam.ForeColor = Color.FromArgb(107, 114, 128);
            lblThangNam.Location = new Point(562, 0);
            lblThangNam.Margin = new Padding(4, 0, 4, 0);
            lblThangNam.Name = "lblThangNam";
            lblThangNam.Size = new Size(550, 33);
            lblThangNam.TabIndex = 1;
            lblThangNam.Text = "Tháng/Năm";
            lblThangNam.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.BorderStyle = BorderStyle.FixedSingle;
            txtMaHoaDon.Dock = DockStyle.Top;
            txtMaHoaDon.Font = new Font("Segoe UI", 10F);
            txtMaHoaDon.Location = new Point(0, 38);
            txtMaHoaDon.Margin = new Padding(0, 5, 17, 5);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(541, 34);
            txtMaHoaDon.TabIndex = 2;
            // 
            // dtpThangNam
            // 
            dtpThangNam.CalendarFont = new Font("Segoe UI", 9F);
            dtpThangNam.CustomFormat = "MM/yyyy";
            dtpThangNam.Dock = DockStyle.Top;
            dtpThangNam.Font = new Font("Segoe UI", 10F);
            dtpThangNam.Format = DateTimePickerFormat.Custom;
            dtpThangNam.Location = new Point(575, 38);
            dtpThangNam.Margin = new Padding(17, 5, 0, 5);
            dtpThangNam.Name = "dtpThangNam";
            dtpThangNam.Size = new Size(541, 34);
            dtpThangNam.TabIndex = 3;
            // 
            // lblPhong
            // 
            lblPhong.Dock = DockStyle.Fill;
            lblPhong.Font = new Font("Segoe UI", 8F);
            lblPhong.ForeColor = Color.FromArgb(107, 114, 128);
            lblPhong.Location = new Point(4, 86);
            lblPhong.Margin = new Padding(4, 0, 4, 0);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new Size(550, 33);
            lblPhong.TabIndex = 4;
            lblPhong.Text = "Phòng";
            lblPhong.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblMaHopDong
            // 
            lblMaHopDong.Dock = DockStyle.Fill;
            lblMaHopDong.Font = new Font("Segoe UI", 8F);
            lblMaHopDong.ForeColor = Color.FromArgb(107, 114, 128);
            lblMaHopDong.Location = new Point(562, 86);
            lblMaHopDong.Margin = new Padding(4, 0, 4, 0);
            lblMaHopDong.Name = "lblMaHopDong";
            lblMaHopDong.Size = new Size(550, 33);
            lblMaHopDong.TabIndex = 5;
            lblMaHopDong.Text = "Mã hợp đồng";
            lblMaHopDong.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboPhong
            // 
            cboPhong.Dock = DockStyle.Top;
            cboPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhong.FlatStyle = FlatStyle.Flat;
            cboPhong.Font = new Font("Segoe UI", 10F);
            cboPhong.Location = new Point(0, 124);
            cboPhong.Margin = new Padding(0, 5, 17, 5);
            cboPhong.Name = "cboPhong";
            cboPhong.Size = new Size(541, 36);
            cboPhong.TabIndex = 6;
            cboPhong.SelectionChangeCommitted += cboPhong_SelectionChangeCommitted;
            // 
            // cboMaHopDong
            // 
            cboMaHopDong.Dock = DockStyle.Top;
            cboMaHopDong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaHopDong.FlatStyle = FlatStyle.Flat;
            cboMaHopDong.Font = new Font("Segoe UI", 10F);
            cboMaHopDong.Location = new Point(575, 124);
            cboMaHopDong.Margin = new Padding(17, 5, 0, 5);
            cboMaHopDong.Name = "cboMaHopDong";
            cboMaHopDong.Size = new Size(541, 36);
            cboMaHopDong.TabIndex = 7;
            cboMaHopDong.SelectionChangeCommitted += cboMaHopDong_SelectionChangeCommitted;
            // 
            // lblDienCu
            // 
            lblDienCu.Dock = DockStyle.Fill;
            lblDienCu.Font = new Font("Segoe UI", 8F);
            lblDienCu.ForeColor = Color.FromArgb(107, 114, 128);
            lblDienCu.Location = new Point(4, 172);
            lblDienCu.Margin = new Padding(4, 0, 4, 0);
            lblDienCu.Name = "lblDienCu";
            lblDienCu.Size = new Size(550, 33);
            lblDienCu.TabIndex = 8;
            lblDienCu.Text = "Điện cũ";
            lblDienCu.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblDienMoi
            // 
            lblDienMoi.Dock = DockStyle.Fill;
            lblDienMoi.Font = new Font("Segoe UI", 8F);
            lblDienMoi.ForeColor = Color.FromArgb(107, 114, 128);
            lblDienMoi.Location = new Point(562, 172);
            lblDienMoi.Margin = new Padding(4, 0, 4, 0);
            lblDienMoi.Name = "lblDienMoi";
            lblDienMoi.Size = new Size(550, 33);
            lblDienMoi.TabIndex = 9;
            lblDienMoi.Text = "Điện mới";
            lblDienMoi.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtDienCu
            // 
            txtDienCu.BorderStyle = BorderStyle.FixedSingle;
            txtDienCu.Dock = DockStyle.Top;
            txtDienCu.Font = new Font("Segoe UI", 10F);
            txtDienCu.Location = new Point(0, 210);
            txtDienCu.Margin = new Padding(0, 5, 17, 5);
            txtDienCu.Name = "txtDienCu";
            txtDienCu.Size = new Size(541, 34);
            txtDienCu.TabIndex = 10;
            // 
            // txtDienMoi
            // 
            txtDienMoi.BorderStyle = BorderStyle.FixedSingle;
            txtDienMoi.Dock = DockStyle.Top;
            txtDienMoi.Font = new Font("Segoe UI", 10F);
            txtDienMoi.Location = new Point(575, 210);
            txtDienMoi.Margin = new Padding(17, 5, 0, 5);
            txtDienMoi.Name = "txtDienMoi";
            txtDienMoi.Size = new Size(541, 34);
            txtDienMoi.TabIndex = 11;
            // 
            // lblNuocCu
            // 
            lblNuocCu.Dock = DockStyle.Fill;
            lblNuocCu.Font = new Font("Segoe UI", 8F);
            lblNuocCu.ForeColor = Color.FromArgb(107, 114, 128);
            lblNuocCu.Location = new Point(4, 258);
            lblNuocCu.Margin = new Padding(4, 0, 4, 0);
            lblNuocCu.Name = "lblNuocCu";
            lblNuocCu.Size = new Size(550, 33);
            lblNuocCu.TabIndex = 12;
            lblNuocCu.Text = "Nước cũ";
            lblNuocCu.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblNuocMoi
            // 
            lblNuocMoi.Dock = DockStyle.Fill;
            lblNuocMoi.Font = new Font("Segoe UI", 8F);
            lblNuocMoi.ForeColor = Color.FromArgb(107, 114, 128);
            lblNuocMoi.Location = new Point(562, 258);
            lblNuocMoi.Margin = new Padding(4, 0, 4, 0);
            lblNuocMoi.Name = "lblNuocMoi";
            lblNuocMoi.Size = new Size(550, 33);
            lblNuocMoi.TabIndex = 13;
            lblNuocMoi.Text = "Nước mới";
            lblNuocMoi.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtNuocCu
            // 
            txtNuocCu.BorderStyle = BorderStyle.FixedSingle;
            txtNuocCu.Dock = DockStyle.Top;
            txtNuocCu.Font = new Font("Segoe UI", 10F);
            txtNuocCu.Location = new Point(0, 296);
            txtNuocCu.Margin = new Padding(0, 5, 17, 5);
            txtNuocCu.Name = "txtNuocCu";
            txtNuocCu.Size = new Size(541, 34);
            txtNuocCu.TabIndex = 14;
            // 
            // txtNuocMoi
            // 
            txtNuocMoi.BorderStyle = BorderStyle.FixedSingle;
            txtNuocMoi.Dock = DockStyle.Top;
            txtNuocMoi.Font = new Font("Segoe UI", 10F);
            txtNuocMoi.Location = new Point(575, 296);
            txtNuocMoi.Margin = new Padding(17, 5, 0, 5);
            txtNuocMoi.Name = "txtNuocMoi";
            txtNuocMoi.Size = new Size(541, 34);
            txtNuocMoi.TabIndex = 15;
            // 
            // lblPhiDichVu
            // 
            lblPhiDichVu.Dock = DockStyle.Fill;
            lblPhiDichVu.Font = new Font("Segoe UI", 8F);
            lblPhiDichVu.ForeColor = Color.FromArgb(107, 114, 128);
            lblPhiDichVu.Location = new Point(4, 344);
            lblPhiDichVu.Margin = new Padding(4, 0, 4, 0);
            lblPhiDichVu.Name = "lblPhiDichVu";
            lblPhiDichVu.Size = new Size(550, 33);
            lblPhiDichVu.TabIndex = 16;
            lblPhiDichVu.Text = "Phí dịch vụ";
            lblPhiDichVu.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTongCong
            // 
            lblTongCong.Dock = DockStyle.Fill;
            lblTongCong.Font = new Font("Segoe UI", 8F);
            lblTongCong.ForeColor = Color.FromArgb(107, 114, 128);
            lblTongCong.Location = new Point(562, 344);
            lblTongCong.Margin = new Padding(4, 0, 4, 0);
            lblTongCong.Name = "lblTongCong";
            lblTongCong.Size = new Size(550, 33);
            lblTongCong.TabIndex = 17;
            lblTongCong.Text = "Tổng cộng (tự tính)";
            lblTongCong.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtPhiDichVu
            // 
            txtPhiDichVu.BorderStyle = BorderStyle.FixedSingle;
            txtPhiDichVu.Dock = DockStyle.Top;
            txtPhiDichVu.Font = new Font("Segoe UI", 10F);
            txtPhiDichVu.Location = new Point(0, 382);
            txtPhiDichVu.Margin = new Padding(0, 5, 17, 5);
            txtPhiDichVu.Name = "txtPhiDichVu";
            txtPhiDichVu.Size = new Size(541, 34);
            txtPhiDichVu.TabIndex = 18;
            // 
            // txtTongCong
            // 
            txtTongCong.BackColor = Color.White;
            txtTongCong.BorderStyle = BorderStyle.FixedSingle;
            txtTongCong.Dock = DockStyle.Top;
            txtTongCong.Font = new Font("Segoe UI", 10F);
            txtTongCong.Location = new Point(575, 382);
            txtTongCong.Margin = new Padding(17, 5, 0, 5);
            txtTongCong.Name = "txtTongCong";
            txtTongCong.ReadOnly = true;
            txtTongCong.Size = new Size(541, 34);
            txtTongCong.TabIndex = 19;
            // 
            // flpNut
            // 
            flpNut.Controls.Add(btnLamMoi);
            flpNut.Controls.Add(btnXoaHoaDon);
            flpNut.Controls.Add(btnInHoaDon);
            flpNut.Controls.Add(btnDaThuTien);
            flpNut.Controls.Add(btnSua);
            flpNut.Controls.Add(btnLapHoaDon);
            flpNut.Controls.Add(btnTinhTien);
            flpNut.Dock = DockStyle.Bottom;
            flpNut.FlowDirection = FlowDirection.RightToLeft;
            flpNut.Location = new Point(17, 447);
            flpNut.Margin = new Padding(4, 5, 4, 5);
            flpNut.Name = "flpNut";
            flpNut.Size = new Size(1116, 73);
            flpNut.TabIndex = 1;
            flpNut.WrapContents = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(255, 255, 255);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.FromArgb(17, 24, 39);
            btnLamMoi.Location = new Point(959, 10);
            btnLamMoi.Margin = new Padding(11, 10, 0, 0);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(150, 57);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "↻ Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoaHoaDon
            // 
            btnXoaHoaDon.BackColor = Color.FromArgb(242, 21, 32);
            btnXoaHoaDon.Cursor = Cursors.Hand;
            btnXoaHoaDon.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnXoaHoaDon.FlatStyle = FlatStyle.Flat;
            btnXoaHoaDon.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnXoaHoaDon.ForeColor = Color.White;
            btnXoaHoaDon.Location = new Point(791, 10);
            btnXoaHoaDon.Margin = new Padding(11, 10, 0, 0);
            btnXoaHoaDon.Name = "btnXoaHoaDon";
            btnXoaHoaDon.Size = new Size(150, 57);
            btnXoaHoaDon.TabIndex = 2;
            btnXoaHoaDon.Text = "■ Xóa HĐ";
            btnXoaHoaDon.UseVisualStyleBackColor = false;
            btnXoaHoaDon.Click += btnXoaHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.BackColor = Color.White;
            btnInHoaDon.Cursor = Cursors.Hand;
            btnInHoaDon.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnInHoaDon.FlatStyle = FlatStyle.Flat;
            btnInHoaDon.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnInHoaDon.ForeColor = Color.FromArgb(17, 24, 39);
            btnInHoaDon.Location = new Point(623, 10);
            btnInHoaDon.Margin = new Padding(11, 10, 0, 0);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(150, 57);
            btnInHoaDon.TabIndex = 3;
            btnInHoaDon.Text = "🖨 In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = false;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnDaThuTien
            // 
            btnDaThuTien.BackColor = Color.FromArgb(242, 21, 32);
            btnDaThuTien.Cursor = Cursors.Hand;
            btnDaThuTien.FlatAppearance.BorderSize = 0;
            btnDaThuTien.FlatStyle = FlatStyle.Flat;
            btnDaThuTien.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnDaThuTien.ForeColor = Color.White;
            btnDaThuTien.Location = new Point(452, 10);
            btnDaThuTien.Margin = new Padding(11, 10, 0, 0);
            btnDaThuTien.Name = "btnDaThuTien";
            btnDaThuTien.Size = new Size(150, 57);
            btnDaThuTien.TabIndex = 2;
            btnDaThuTien.Text = "✔ Đã thu tiền";
            btnDaThuTien.UseVisualStyleBackColor = false;
            btnDaThuTien.Click += btnDaThuTien_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.FromArgb(17, 24, 39);
            btnSua.Margin = new Padding(11, 10, 0, 0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(130, 57);
            btnSua.TabIndex = 5;
            btnSua.Text = "✎ Sửa HĐ";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnLapHoaDon
            // 
            btnLapHoaDon.BackColor = Color.FromArgb(36, 70, 145);
            btnLapHoaDon.Cursor = Cursors.Hand;
            btnLapHoaDon.FlatAppearance.BorderSize = 0;
            btnLapHoaDon.FlatStyle = FlatStyle.Flat;
            btnLapHoaDon.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnLapHoaDon.ForeColor = Color.White;
            btnLapHoaDon.Location = new Point(270, 10);
            btnLapHoaDon.Margin = new Padding(11, 10, 0, 0);
            btnLapHoaDon.Name = "btnLapHoaDon";
            btnLapHoaDon.Size = new Size(160, 57);
            btnLapHoaDon.TabIndex = 1;
            btnLapHoaDon.Text = "+ Lập hóa đơn";
            btnLapHoaDon.UseVisualStyleBackColor = false;
            btnLapHoaDon.Click += btnLapHoaDon_Click;
            // 
            // btnTinhTien
            // 
            btnTinhTien.BackColor = Color.White;
            btnTinhTien.Cursor = Cursors.Hand;
            btnTinhTien.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnTinhTien.FlatStyle = FlatStyle.Flat;
            btnTinhTien.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnTinhTien.ForeColor = Color.FromArgb(17, 24, 39);
            btnTinhTien.Location = new Point(110, 10);
            btnTinhTien.Margin = new Padding(11, 10, 0, 0);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(140, 57);
            btnTinhTien.TabIndex = 0;
            btnTinhTien.Text = "\U0001f9ee Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = false;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // HoaDonControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 248);
            Controls.Add(tlpMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "HoaDonControl";
            Padding = new Padding(27, 28, 27, 28);
            Size = new Size(1204, 1000);
            Load += HoaDonControl_Load;
            tlpMain.ResumeLayout(false);
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            pnlThongTin.ResumeLayout(false);
            tlpThongTin.ResumeLayout(false);
            tlpThongTin.PerformLayout();
            flpNut.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoaHoaDon;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnDaThuTien;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Button btnTinhTien;
    }
}
