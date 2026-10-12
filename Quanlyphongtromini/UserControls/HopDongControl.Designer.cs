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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tlpMain = new TableLayoutPanel();
            pnlTimKiem = new Panel();
            txtTimKiem = new TextBox();
            btnTim = new Button();
            dgvHopDong = new DataGridView();
            pnlThongTin = new Panel();
            tlpThongTin = new TableLayoutPanel();
            lblMaHopDong = new Label();
            lblTrangThai = new Label();
            txtMaHopDong = new TextBox();
            cboTrangThai = new ComboBox();
            lblPhong = new Label();
            lblNguoiThue = new Label();
            cboPhong = new ComboBox();
            cboNguoiThue = new ComboBox();
            lblNgayBatDau = new Label();
            lblNgayKetThuc = new Label();
            dtpNgayBatDau = new DateTimePicker();
            dtpNgayKetThuc = new DateTimePicker();
            lblTienCoc = new Label();
            txtTienCoc = new TextBox();
            flpNut = new FlowLayoutPanel();
            btnLamMoi = new Button();
            btnXoaHD = new Button();
            btnSua = new Button();
            btnThem = new Button();
            colMaHopDong = new DataGridViewTextBoxColumn();
            colPhong = new DataGridViewTextBoxColumn();
            colNguoiThue = new DataGridViewTextBoxColumn();
            colNgayBatDau = new DataGridViewTextBoxColumn();
            colNgayKetThuc = new DataGridViewTextBoxColumn();
            colTienCoc = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            tlpMain.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHopDong).BeginInit();
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
            tlpMain.Controls.Add(dgvHopDong, 0, 1);
            tlpMain.Controls.Add(pnlThongTin, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(22, 23);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 387F));
            tlpMain.Size = new Size(919, 754);
            tlpMain.TabIndex = 0;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(btnTim);
            pnlTimKiem.Dock = DockStyle.Fill;
            pnlTimKiem.Location = new Point(0, 0);
            pnlTimKiem.Margin = new Padding(0, 0, 0, 16);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(919, 45);
            pnlTimKiem.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 10F);
            txtTimKiem.Location = new Point(0, 5);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tên người thuê hoặc mã phòng...";
            txtTimKiem.Size = new Size(791, 30);
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
            btnTim.Location = new Point(800, 0);
            btnTim.Margin = new Padding(3, 4, 3, 4);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(119, 45);
            btnTim.TabIndex = 1;
            btnTim.Text = "🔍 Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // dgvHopDong
            // 
            dgvHopDong.AllowUserToAddRows = false;
            dgvHopDong.AllowUserToDeleteRows = false;
            dgvHopDong.AllowUserToResizeRows = false;
            dgvHopDong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHopDong.BackgroundColor = Color.White;
            dgvHopDong.BorderStyle = BorderStyle.None;
            dgvHopDong.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHopDong.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle1.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvHopDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHopDong.ColumnHeadersHeight = 34;
            dgvHopDong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHopDong.Columns.AddRange(new DataGridViewColumn[] { colMaHopDong, colPhong, colNguoiThue, colNgayBatDau, colNgayKetThuc, colTienCoc, colTrangThai });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(232, 236, 248);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvHopDong.DefaultCellStyle = dataGridViewCellStyle5;
            dgvHopDong.Dock = DockStyle.Fill;
            dgvHopDong.EnableHeadersVisualStyles = false;
            dgvHopDong.GridColor = Color.FromArgb(229, 231, 235);
            dgvHopDong.Location = new Point(0, 61);
            dgvHopDong.Margin = new Padding(0, 0, 0, 16);
            dgvHopDong.MultiSelect = false;
            dgvHopDong.Name = "dgvHopDong";
            dgvHopDong.ReadOnly = true;
            dgvHopDong.RowHeadersVisible = false;
            dgvHopDong.RowHeadersWidth = 51;
            dgvHopDong.RowTemplate.Height = 32;
            dgvHopDong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHopDong.Size = new Size(919, 290);
            dgvHopDong.TabIndex = 1;
            dgvHopDong.CellClick += dgvHopDong_CellClick;
            // 
            // pnlThongTin
            // 
            pnlThongTin.BackColor = Color.White;
            pnlThongTin.Controls.Add(tlpThongTin);
            pnlThongTin.Controls.Add(flpNut);
            pnlThongTin.Dock = DockStyle.Fill;
            pnlThongTin.Location = new Point(0, 367);
            pnlThongTin.Margin = new Padding(0);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Padding = new Padding(14, 11, 14, 11);
            pnlThongTin.Size = new Size(919, 387);
            pnlThongTin.TabIndex = 2;
            // 
            // tlpThongTin
            // 
            tlpThongTin.ColumnCount = 2;
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpThongTin.Controls.Add(lblMaHopDong, 0, 0);
            tlpThongTin.Controls.Add(lblTrangThai, 1, 0);
            tlpThongTin.Controls.Add(txtMaHopDong, 0, 1);
            tlpThongTin.Controls.Add(cboTrangThai, 1, 1);
            tlpThongTin.Controls.Add(lblPhong, 0, 2);
            tlpThongTin.Controls.Add(lblNguoiThue, 1, 2);
            tlpThongTin.Controls.Add(cboPhong, 0, 3);
            tlpThongTin.Controls.Add(cboNguoiThue, 1, 3);
            tlpThongTin.Controls.Add(lblNgayBatDau, 0, 4);
            tlpThongTin.Controls.Add(lblNgayKetThuc, 1, 4);
            tlpThongTin.Controls.Add(dtpNgayBatDau, 0, 5);
            tlpThongTin.Controls.Add(dtpNgayKetThuc, 1, 5);
            tlpThongTin.Controls.Add(lblTienCoc, 0, 6);
            tlpThongTin.Controls.Add(txtTienCoc, 0, 7);
            tlpThongTin.Dock = DockStyle.Fill;
            tlpThongTin.Location = new Point(14, 11);
            tlpThongTin.Margin = new Padding(3, 4, 3, 4);
            tlpThongTin.Name = "tlpThongTin";
            tlpThongTin.RowCount = 8;
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tlpThongTin.Size = new Size(891, 306);
            tlpThongTin.TabIndex = 0;
            // 
            // lblMaHopDong
            // 
            lblMaHopDong.Dock = DockStyle.Fill;
            lblMaHopDong.Font = new Font("Segoe UI", 8F);
            lblMaHopDong.ForeColor = Color.FromArgb(107, 114, 128);
            lblMaHopDong.Location = new Point(3, 0);
            lblMaHopDong.Name = "lblMaHopDong";
            lblMaHopDong.Size = new Size(439, 29);
            lblMaHopDong.TabIndex = 0;
            lblMaHopDong.Text = "Mã hợp đồng";
            lblMaHopDong.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Dock = DockStyle.Fill;
            lblTrangThai.Font = new Font("Segoe UI", 8F);
            lblTrangThai.ForeColor = Color.FromArgb(107, 114, 128);
            lblTrangThai.Location = new Point(448, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(440, 29);
            lblTrangThai.TabIndex = 1;
            lblTrangThai.Text = "Trạng thái";
            lblTrangThai.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtMaHopDong
            // 
            txtMaHopDong.BorderStyle = BorderStyle.FixedSingle;
            txtMaHopDong.Dock = DockStyle.Top;
            txtMaHopDong.Font = new Font("Segoe UI", 10F);
            txtMaHopDong.Location = new Point(0, 33);
            txtMaHopDong.Margin = new Padding(0, 4, 14, 4);
            txtMaHopDong.Name = "txtMaHopDong";
            txtMaHopDong.Size = new Size(431, 30);
            txtMaHopDong.TabIndex = 2;
            // 
            // cboTrangThai
            // 
            cboTrangThai.Dock = DockStyle.Top;
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FlatStyle = FlatStyle.Flat;
            cboTrangThai.Font = new Font("Segoe UI", 10F);
            cboTrangThai.Items.AddRange(new object[] { "Còn hạn", "Hết hạn" });
            cboTrangThai.Location = new Point(459, 33);
            cboTrangThai.Margin = new Padding(14, 4, 0, 4);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(432, 31);
            cboTrangThai.TabIndex = 3;
            // 
            // lblPhong
            // 
            lblPhong.Dock = DockStyle.Fill;
            lblPhong.Font = new Font("Segoe UI", 8F);
            lblPhong.ForeColor = Color.FromArgb(107, 114, 128);
            lblPhong.Location = new Point(3, 74);
            lblPhong.Name = "lblPhong";
            lblPhong.Size = new Size(439, 29);
            lblPhong.TabIndex = 4;
            lblPhong.Text = "Phòng";
            lblPhong.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblNguoiThue
            // 
            lblNguoiThue.Dock = DockStyle.Fill;
            lblNguoiThue.Font = new Font("Segoe UI", 8F);
            lblNguoiThue.ForeColor = Color.FromArgb(107, 114, 128);
            lblNguoiThue.Location = new Point(448, 74);
            lblNguoiThue.Name = "lblNguoiThue";
            lblNguoiThue.Size = new Size(440, 29);
            lblNguoiThue.TabIndex = 5;
            lblNguoiThue.Text = "Người thuê";
            lblNguoiThue.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cboPhong
            // 
            cboPhong.Dock = DockStyle.Top;
            cboPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhong.FlatStyle = FlatStyle.Flat;
            cboPhong.Font = new Font("Segoe UI", 10F);
            cboPhong.Location = new Point(0, 107);
            cboPhong.Margin = new Padding(0, 4, 14, 4);
            cboPhong.Name = "cboPhong";
            cboPhong.Size = new Size(431, 31);
            cboPhong.TabIndex = 6;
            // 
            // cboNguoiThue
            // 
            cboNguoiThue.Dock = DockStyle.Top;
            cboNguoiThue.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNguoiThue.FlatStyle = FlatStyle.Flat;
            cboNguoiThue.Font = new Font("Segoe UI", 10F);
            cboNguoiThue.Location = new Point(459, 107);
            cboNguoiThue.Margin = new Padding(14, 4, 0, 4);
            cboNguoiThue.Name = "cboNguoiThue";
            cboNguoiThue.Size = new Size(432, 31);
            cboNguoiThue.TabIndex = 7;
            // 
            // lblNgayBatDau
            // 
            lblNgayBatDau.Dock = DockStyle.Fill;
            lblNgayBatDau.Font = new Font("Segoe UI", 8F);
            lblNgayBatDau.ForeColor = Color.FromArgb(107, 114, 128);
            lblNgayBatDau.Location = new Point(3, 148);
            lblNgayBatDau.Name = "lblNgayBatDau";
            lblNgayBatDau.Size = new Size(439, 29);
            lblNgayBatDau.TabIndex = 8;
            lblNgayBatDau.Text = "Ngày bắt đầu";
            lblNgayBatDau.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblNgayKetThuc
            // 
            lblNgayKetThuc.Dock = DockStyle.Fill;
            lblNgayKetThuc.Font = new Font("Segoe UI", 8F);
            lblNgayKetThuc.ForeColor = Color.FromArgb(107, 114, 128);
            lblNgayKetThuc.Location = new Point(448, 148);
            lblNgayKetThuc.Name = "lblNgayKetThuc";
            lblNgayKetThuc.Size = new Size(440, 29);
            lblNgayKetThuc.TabIndex = 9;
            lblNgayKetThuc.Text = "Ngày kết thúc";
            lblNgayKetThuc.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.CalendarFont = new Font("Segoe UI", 9F);
            dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            dtpNgayBatDau.Dock = DockStyle.Top;
            dtpNgayBatDau.Font = new Font("Segoe UI", 10F);
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.Location = new Point(0, 181);
            dtpNgayBatDau.Margin = new Padding(0, 4, 14, 4);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(431, 30);
            dtpNgayBatDau.TabIndex = 10;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.CalendarFont = new Font("Segoe UI", 9F);
            dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            dtpNgayKetThuc.Dock = DockStyle.Top;
            dtpNgayKetThuc.Font = new Font("Segoe UI", 10F);
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.Location = new Point(459, 181);
            dtpNgayKetThuc.Margin = new Padding(14, 4, 0, 4);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(432, 30);
            dtpNgayKetThuc.TabIndex = 11;
            // 
            // lblTienCoc
            // 
            tlpThongTin.SetColumnSpan(lblTienCoc, 2);
            lblTienCoc.Dock = DockStyle.Fill;
            lblTienCoc.Font = new Font("Segoe UI", 8F);
            lblTienCoc.ForeColor = Color.FromArgb(107, 114, 128);
            lblTienCoc.Location = new Point(3, 222);
            lblTienCoc.Name = "lblTienCoc";
            lblTienCoc.Size = new Size(885, 29);
            lblTienCoc.TabIndex = 12;
            lblTienCoc.Text = "Tiền cọc";
            lblTienCoc.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtTienCoc
            // 
            txtTienCoc.BorderStyle = BorderStyle.FixedSingle;
            tlpThongTin.SetColumnSpan(txtTienCoc, 2);
            txtTienCoc.Dock = DockStyle.Top;
            txtTienCoc.Font = new Font("Segoe UI", 10F);
            txtTienCoc.Location = new Point(0, 255);
            txtTienCoc.Margin = new Padding(0, 4, 0, 4);
            txtTienCoc.Name = "txtTienCoc";
            txtTienCoc.Size = new Size(891, 30);
            txtTienCoc.TabIndex = 13;
            // 
            // flpNut
            // 
            flpNut.Controls.Add(btnLamMoi);
            flpNut.Controls.Add(btnXoaHD);
            flpNut.Controls.Add(btnSua);
            flpNut.Controls.Add(btnThem);
            flpNut.Dock = DockStyle.Bottom;
            flpNut.FlowDirection = FlowDirection.RightToLeft;
            flpNut.Location = new Point(14, 317);
            flpNut.Margin = new Padding(3, 4, 3, 4);
            flpNut.Name = "flpNut";
            flpNut.Size = new Size(891, 59);
            flpNut.TabIndex = 1;
            flpNut.WrapContents = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.White;
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.FromArgb(17, 24, 39);
            btnLamMoi.Location = new Point(777, 8);
            btnLamMoi.Margin = new Padding(9, 8, 0, 0);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(114, 45);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "↻ Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoaHD
            // 
            btnXoaHD.BackColor = Color.FromArgb(242, 21, 32);
            btnXoaHD.Cursor = Cursors.Hand;
            btnXoaHD.FlatAppearance.BorderSize = 0;
            btnXoaHD.FlatStyle = FlatStyle.Flat;
            btnXoaHD.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnXoaHD.ForeColor = Color.White;
            btnXoaHD.Location = new Point(642, 8);
            btnXoaHD.Margin = new Padding(9, 8, 0, 0);
            btnXoaHD.Name = "btnXoaHD";
            btnXoaHD.Size = new Size(126, 45);
            btnXoaHD.TabIndex = 2;
            btnXoaHD.Text = "■ Xóa HD";
            btnXoaHD.UseVisualStyleBackColor = false;
            btnXoaHD.Click += btnXoaHD_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.FromArgb(17, 24, 39);
            btnSua.Location = new Point(548, 8);
            btnSua.Margin = new Padding(9, 8, 0, 0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(85, 45);
            btnSua.TabIndex = 1;
            btnSua.Text = "✎ Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(36, 70, 145);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(436, 8);
            btnThem.Margin = new Padding(9, 8, 0, 0);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(103, 45);
            btnThem.TabIndex = 0;
            btnThem.Text = "+ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // colMaHopDong
            // 
            colMaHopDong.DataPropertyName = "MaHD";
            colMaHopDong.HeaderText = "MÃ HĐ";
            colMaHopDong.MinimumWidth = 6;
            colMaHopDong.Name = "colMaHopDong";
            colMaHopDong.ReadOnly = true;
            // 
            // colPhong
            // 
            colPhong.DataPropertyName = "MaPhong";
            colPhong.HeaderText = "PHÒNG";
            colPhong.MinimumWidth = 6;
            colPhong.Name = "colPhong";
            colPhong.ReadOnly = true;
            // 
            // colNguoiThue
            // 
            colNguoiThue.DataPropertyName = "MaNguoi";
            colNguoiThue.HeaderText = "NGƯỜI THUÊ";
            colNguoiThue.MinimumWidth = 6;
            colNguoiThue.Name = "colNguoiThue";
            colNguoiThue.ReadOnly = true;
            // 
            // colNgayBatDau
            // 
            colNgayBatDau.DataPropertyName = "DayStart";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            colNgayBatDau.DefaultCellStyle = dataGridViewCellStyle2;
            colNgayBatDau.HeaderText = "NGÀY BẮT ĐẦU";
            colNgayBatDau.MinimumWidth = 6;
            colNgayBatDau.Name = "colNgayBatDau";
            colNgayBatDau.ReadOnly = true;
            // 
            // colNgayKetThuc
            // 
            colNgayKetThuc.DataPropertyName = "DayEnd";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            colNgayKetThuc.DefaultCellStyle = dataGridViewCellStyle3;
            colNgayKetThuc.HeaderText = "NGÀY KẾT THÚC";
            colNgayKetThuc.MinimumWidth = 6;
            colNgayKetThuc.Name = "colNgayKetThuc";
            colNgayKetThuc.ReadOnly = true;
            // 
            // colTienCoc
            // 
            colTienCoc.DataPropertyName = "TienCoc";
            dataGridViewCellStyle4.Format = "N0";
            colTienCoc.DefaultCellStyle = dataGridViewCellStyle4;
            colTienCoc.HeaderText = "TIỀN CỌC";
            colTienCoc.MinimumWidth = 6;
            colTienCoc.Name = "colTienCoc";
            colTienCoc.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "TRẠNG THÁI";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // HopDongControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 248);
            Controls.Add(tlpMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HopDongControl";
            Padding = new Padding(22, 23, 22, 23);
            Size = new Size(963, 800);
            Load += HopDongControl_Load;
            tlpMain.ResumeLayout(false);
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHopDong).EndInit();
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
        private System.Windows.Forms.DataGridView dgvHopDong;
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
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private DataGridViewTextBoxColumn colMaHopDong;
        private DataGridViewTextBoxColumn colPhong;
        private DataGridViewTextBoxColumn colNguoiThue;
        private DataGridViewTextBoxColumn colNgayBatDau;
        private DataGridViewTextBoxColumn colNgayKetThuc;
        private DataGridViewTextBoxColumn colTienCoc;
        private DataGridViewTextBoxColumn colTrangThai;
    }
}
