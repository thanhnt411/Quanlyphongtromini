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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tlpMain = new TableLayoutPanel();
            pnlTimKiem = new Panel();
            txtTimKiem = new TextBox();
            btnTim = new Button();
            dgvPhongTro = new DataGridView();
            pnlThongTin = new Panel();
            tlpThongTin = new TableLayoutPanel();
            lblMaPhong = new Label();
            lblTenPhong = new Label();
            txtMaPhong = new TextBox();
            txtTenPhong = new TextBox();
            lblDienTich = new Label();
            lblGiaPhong = new Label();
            txtDienTich = new TextBox();
            txtGiaPhong = new TextBox();
            lblToiDa = new Label();
            lblTrangThai = new Label();
            txtToiDa = new TextBox();
            cboTrangThai = new ComboBox();
            flpNut = new FlowLayoutPanel();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            colMaPhong = new DataGridViewTextBoxColumn();
            colTenPhong = new DataGridViewTextBoxColumn();
            colDienTich = new DataGridViewTextBoxColumn();
            colGiaPhong = new DataGridViewTextBoxColumn();
            colToiDa = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            tlpMain.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhongTro).BeginInit();
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
            tlpMain.Controls.Add(dgvPhongTro, 0, 1);
            tlpMain.Controls.Add(pnlThongTin, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(27, 28);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 400F));
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
            txtTimKiem.PlaceholderText = "Nhập tên phòng...";
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
            // dgvPhongTro
            // 
            dgvPhongTro.AllowUserToAddRows = false;
            dgvPhongTro.AllowUserToDeleteRows = false;
            dgvPhongTro.AllowUserToResizeRows = false;
            dgvPhongTro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhongTro.BackgroundColor = Color.White;
            dgvPhongTro.BorderStyle = BorderStyle.None;
            dgvPhongTro.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPhongTro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle1.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvPhongTro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPhongTro.ColumnHeadersHeight = 34;
            dgvPhongTro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPhongTro.Columns.AddRange(new DataGridViewColumn[] { colMaPhong, colTenPhong, colDienTich, colGiaPhong, colToiDa, colTrangThai });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(232, 236, 248);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvPhongTro.DefaultCellStyle = dataGridViewCellStyle5;
            dgvPhongTro.Dock = DockStyle.Fill;
            dgvPhongTro.EnableHeadersVisualStyles = false;
            dgvPhongTro.GridColor = Color.FromArgb(229, 231, 235);
            dgvPhongTro.Location = new Point(0, 77);
            dgvPhongTro.Margin = new Padding(0, 0, 0, 20);
            dgvPhongTro.MultiSelect = false;
            dgvPhongTro.Name = "dgvPhongTro";
            dgvPhongTro.ReadOnly = true;
            dgvPhongTro.RowHeadersVisible = false;
            dgvPhongTro.RowHeadersWidth = 62;
            dgvPhongTro.RowTemplate.Height = 32;
            dgvPhongTro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhongTro.Size = new Size(1150, 447);
            dgvPhongTro.TabIndex = 1;
            // 
            // pnlThongTin
            // 
            pnlThongTin.BackColor = Color.White;
            pnlThongTin.Controls.Add(tlpThongTin);
            pnlThongTin.Controls.Add(flpNut);
            pnlThongTin.Dock = DockStyle.Fill;
            pnlThongTin.Location = new Point(0, 544);
            pnlThongTin.Margin = new Padding(0);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Padding = new Padding(17, 13, 17, 13);
            pnlThongTin.Size = new Size(1150, 400);
            pnlThongTin.TabIndex = 2;
            // 
            // tlpThongTin
            // 
            tlpThongTin.ColumnCount = 2;
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpThongTin.Controls.Add(lblMaPhong, 0, 0);
            tlpThongTin.Controls.Add(lblTenPhong, 1, 0);
            tlpThongTin.Controls.Add(txtMaPhong, 0, 1);
            tlpThongTin.Controls.Add(txtTenPhong, 1, 1);
            tlpThongTin.Controls.Add(lblDienTich, 0, 2);
            tlpThongTin.Controls.Add(lblGiaPhong, 1, 2);
            tlpThongTin.Controls.Add(txtDienTich, 0, 3);
            tlpThongTin.Controls.Add(txtGiaPhong, 1, 3);
            tlpThongTin.Controls.Add(lblToiDa, 0, 4);
            tlpThongTin.Controls.Add(lblTrangThai, 1, 4);
            tlpThongTin.Controls.Add(txtToiDa, 0, 5);
            tlpThongTin.Controls.Add(cboTrangThai, 1, 5);
            tlpThongTin.Dock = DockStyle.Fill;
            tlpThongTin.Location = new Point(17, 13);
            tlpThongTin.Margin = new Padding(4, 5, 4, 5);
            tlpThongTin.Name = "tlpThongTin";
            tlpThongTin.RowCount = 6;
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tlpThongTin.Size = new Size(1116, 301);
            tlpThongTin.TabIndex = 0;
            // 
            // lblMaPhong
            // 
            lblMaPhong.Dock = DockStyle.Fill;
            lblMaPhong.Font = new Font("Segoe UI", 8F);
            lblMaPhong.ForeColor = Color.FromArgb(107, 114, 128);
            lblMaPhong.Location = new Point(4, 0);
            lblMaPhong.Margin = new Padding(4, 0, 4, 0);
            lblMaPhong.Name = "lblMaPhong";
            lblMaPhong.Size = new Size(550, 37);
            lblMaPhong.TabIndex = 0;
            lblMaPhong.Text = "Mã phòng";
            lblMaPhong.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTenPhong
            // 
            lblTenPhong.Dock = DockStyle.Fill;
            lblTenPhong.Font = new Font("Segoe UI", 8F);
            lblTenPhong.ForeColor = Color.FromArgb(107, 114, 128);
            lblTenPhong.Location = new Point(562, 0);
            lblTenPhong.Margin = new Padding(4, 0, 4, 0);
            lblTenPhong.Name = "lblTenPhong";
            lblTenPhong.Size = new Size(550, 37);
            lblTenPhong.TabIndex = 1;
            lblTenPhong.Text = "Tên phòng";
            lblTenPhong.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtMaPhong
            // 
            txtMaPhong.BorderStyle = BorderStyle.FixedSingle;
            txtMaPhong.Dock = DockStyle.Top;
            txtMaPhong.Font = new Font("Segoe UI", 10F);
            txtMaPhong.Location = new Point(0, 42);
            txtMaPhong.Margin = new Padding(0, 5, 17, 5);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(541, 34);
            txtMaPhong.TabIndex = 2;
            // 
            // txtTenPhong
            // 
            txtTenPhong.BorderStyle = BorderStyle.FixedSingle;
            txtTenPhong.Dock = DockStyle.Top;
            txtTenPhong.Font = new Font("Segoe UI", 10F);
            txtTenPhong.Location = new Point(575, 42);
            txtTenPhong.Margin = new Padding(17, 5, 0, 5);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(541, 34);
            txtTenPhong.TabIndex = 3;
            // 
            // lblDienTich
            // 
            lblDienTich.Dock = DockStyle.Fill;
            lblDienTich.Font = new Font("Segoe UI", 8F);
            lblDienTich.ForeColor = Color.FromArgb(107, 114, 128);
            lblDienTich.Location = new Point(4, 94);
            lblDienTich.Margin = new Padding(4, 0, 4, 0);
            lblDienTich.Name = "lblDienTich";
            lblDienTich.Size = new Size(550, 37);
            lblDienTich.TabIndex = 4;
            lblDienTich.Text = "Diện tích (m²)";
            lblDienTich.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblGiaPhong
            // 
            lblGiaPhong.Dock = DockStyle.Fill;
            lblGiaPhong.Font = new Font("Segoe UI", 8F);
            lblGiaPhong.ForeColor = Color.FromArgb(107, 114, 128);
            lblGiaPhong.Location = new Point(562, 94);
            lblGiaPhong.Margin = new Padding(4, 0, 4, 0);
            lblGiaPhong.Name = "lblGiaPhong";
            lblGiaPhong.Size = new Size(550, 37);
            lblGiaPhong.TabIndex = 5;
            lblGiaPhong.Text = "Giá phòng";
            lblGiaPhong.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtDienTich
            // 
            txtDienTich.BorderStyle = BorderStyle.FixedSingle;
            txtDienTich.Dock = DockStyle.Top;
            txtDienTich.Font = new Font("Segoe UI", 10F);
            txtDienTich.Location = new Point(0, 136);
            txtDienTich.Margin = new Padding(0, 5, 17, 5);
            txtDienTich.Name = "txtDienTich";
            txtDienTich.Size = new Size(541, 34);
            txtDienTich.TabIndex = 6;
            // 
            // txtGiaPhong
            // 
            txtGiaPhong.BorderStyle = BorderStyle.FixedSingle;
            txtGiaPhong.Dock = DockStyle.Top;
            txtGiaPhong.Font = new Font("Segoe UI", 10F);
            txtGiaPhong.Location = new Point(575, 136);
            txtGiaPhong.Margin = new Padding(17, 5, 0, 5);
            txtGiaPhong.Name = "txtGiaPhong";
            txtGiaPhong.Size = new Size(541, 34);
            txtGiaPhong.TabIndex = 7;
            // 
            // lblToiDa
            // 
            lblToiDa.Dock = DockStyle.Fill;
            lblToiDa.Font = new Font("Segoe UI", 8F);
            lblToiDa.ForeColor = Color.FromArgb(107, 114, 128);
            lblToiDa.Location = new Point(4, 188);
            lblToiDa.Margin = new Padding(4, 0, 4, 0);
            lblToiDa.Name = "lblToiDa";
            lblToiDa.Size = new Size(550, 37);
            lblToiDa.TabIndex = 8;
            lblToiDa.Text = "Tối đa (người)";
            lblToiDa.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Dock = DockStyle.Fill;
            lblTrangThai.Font = new Font("Segoe UI", 8F);
            lblTrangThai.ForeColor = Color.FromArgb(107, 114, 128);
            lblTrangThai.Location = new Point(562, 188);
            lblTrangThai.Margin = new Padding(4, 0, 4, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(550, 37);
            lblTrangThai.TabIndex = 9;
            lblTrangThai.Text = "Trạng thái";
            lblTrangThai.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtToiDa
            // 
            txtToiDa.BorderStyle = BorderStyle.FixedSingle;
            txtToiDa.Dock = DockStyle.Top;
            txtToiDa.Font = new Font("Segoe UI", 10F);
            txtToiDa.Location = new Point(0, 230);
            txtToiDa.Margin = new Padding(0, 5, 17, 5);
            txtToiDa.Name = "txtToiDa";
            txtToiDa.Size = new Size(541, 34);
            txtToiDa.TabIndex = 10;
            // 
            // cboTrangThai
            // 
            cboTrangThai.Dock = DockStyle.Top;
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FlatStyle = FlatStyle.Flat;
            cboTrangThai.Font = new Font("Segoe UI", 10F);
            cboTrangThai.Items.AddRange(new object[] { "Đang thuê", "Trống", "Bảo trì" });
            cboTrangThai.Location = new Point(575, 230);
            cboTrangThai.Margin = new Padding(17, 5, 0, 5);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(541, 36);
            cboTrangThai.TabIndex = 11;
            // 
            // flpNut
            // 
            flpNut.Controls.Add(btnLamMoi);
            flpNut.Controls.Add(btnXoa);
            flpNut.Controls.Add(btnSua);
            flpNut.Controls.Add(btnThem);
            flpNut.Dock = DockStyle.Bottom;
            flpNut.FlowDirection = FlowDirection.RightToLeft;
            flpNut.Location = new Point(17, 314);
            flpNut.Margin = new Padding(4, 5, 4, 5);
            flpNut.Name = "flpNut";
            flpNut.Size = new Size(1116, 73);
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
            btnLamMoi.Location = new Point(973, 10);
            btnLamMoi.Margin = new Padding(11, 10, 0, 0);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(143, 57);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "↻ Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(242, 21, 32);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(856, 10);
            btnXoa.Margin = new Padding(11, 10, 0, 0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(106, 57);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "🗑 Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.FromArgb(17, 24, 39);
            btnSua.Location = new Point(739, 10);
            btnSua.Margin = new Padding(11, 10, 0, 0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(106, 57);
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
            btnThem.Location = new Point(599, 10);
            btnThem.Margin = new Padding(11, 10, 0, 0);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 57);
            btnThem.TabIndex = 0;
            btnThem.Text = "+ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // colMaPhong
            // 
            colMaPhong.DataPropertyName = "MaPhong";
            colMaPhong.HeaderText = "MÃ PHÒNG";
            colMaPhong.MinimumWidth = 8;
            colMaPhong.Name = "colMaPhong";
            colMaPhong.ReadOnly = true;
            // 
            // colTenPhong
            // 
            colTenPhong.DataPropertyName = "TenPhong";
            colTenPhong.HeaderText = "TÊN PHÒNG";
            colTenPhong.MinimumWidth = 8;
            colTenPhong.Name = "colTenPhong";
            colTenPhong.ReadOnly = true;
            // 
            // colDienTich
            // 
            colDienTich.DataPropertyName = "DienTich";
            dataGridViewCellStyle2.Format = "0 \"m²\"";
            colDienTich.DefaultCellStyle = dataGridViewCellStyle2;
            colDienTich.HeaderText = "DIỆN TÍCH";
            colDienTich.MinimumWidth = 8;
            colDienTich.Name = "colDienTich";
            colDienTich.ReadOnly = true;
            // 
            // colGiaPhong
            // 
            colGiaPhong.DataPropertyName = "GiaPhong";
            dataGridViewCellStyle3.Format = "N0";
            colGiaPhong.DefaultCellStyle = dataGridViewCellStyle3;
            colGiaPhong.HeaderText = "GIÁ PHÒNG";
            colGiaPhong.MinimumWidth = 8;
            colGiaPhong.Name = "colGiaPhong";
            colGiaPhong.ReadOnly = true;
            // 
            // colToiDa
            // 
            colToiDa.DataPropertyName = "ToiDa";
            dataGridViewCellStyle4.Format = "0 \"người\"";
            colToiDa.DefaultCellStyle = dataGridViewCellStyle4;
            colToiDa.HeaderText = "TỐI ĐA";
            colToiDa.MinimumWidth = 8;
            colToiDa.Name = "colToiDa";
            colToiDa.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "TRẠNG THÁI";
            colTrangThai.MinimumWidth = 8;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // PhongTroControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 248);
            Controls.Add(tlpMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PhongTroControl";
            Padding = new Padding(27, 28, 27, 28);
            Size = new Size(1204, 1000);
            Load += PhongTroControl_Load;
            tlpMain.ResumeLayout(false);
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhongTro).EndInit();
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
        private System.Windows.Forms.DataGridView dgvPhongTro;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.TableLayoutPanel tlpThongTin;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.Label lblGiaPhong;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.TextBox txtGiaPhong;
        private System.Windows.Forms.Label lblToiDa;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtToiDa;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.FlowLayoutPanel flpNut;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private DataGridViewTextBoxColumn colMaPhong;
        private DataGridViewTextBoxColumn colTenPhong;
        private DataGridViewTextBoxColumn colDienTich;
        private DataGridViewTextBoxColumn colGiaPhong;
        private DataGridViewTextBoxColumn colToiDa;
        private DataGridViewTextBoxColumn colTrangThai;
    }
}
