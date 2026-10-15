namespace Quanlyphongtromini.UserControls
{
    partial class DichVuControl
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tlpMain = new TableLayoutPanel();
            pnlTimKiem = new Panel();
            txtTimKiem = new TextBox();
            btnTim = new Button();
            dgvDichVu = new DataGridView();
            colMaDichVu = new DataGridViewTextBoxColumn();
            colTenDichVu = new DataGridViewTextBoxColumn();
            colGia = new DataGridViewTextBoxColumn();
            pnlThongTin = new Panel();
            tlpThongTin = new TableLayoutPanel();
            lblMaDichVu = new Label();
            lblTenDichVu = new Label();
            lblGia = new Label();
            txtMaDV = new TextBox();
            txtTenDV = new TextBox();
            txtGia = new TextBox();
            flpNut = new FlowLayoutPanel();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            tlpMain.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).BeginInit();
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
            tlpMain.Controls.Add(dgvDichVu, 0, 1);
            tlpMain.Controls.Add(pnlThongTin, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(19, 17);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tlpMain.Size = new Size(805, 566);
            tlpMain.TabIndex = 0;
            // 
            // pnlTimKiem
            // 
            pnlTimKiem.Controls.Add(txtTimKiem);
            pnlTimKiem.Controls.Add(btnTim);
            pnlTimKiem.Dock = DockStyle.Fill;
            pnlTimKiem.Location = new Point(0, 0);
            pnlTimKiem.Margin = new Padding(0, 0, 0, 12);
            pnlTimKiem.Name = "pnlTimKiem";
            pnlTimKiem.Size = new Size(805, 34);
            pnlTimKiem.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 10F);
            txtTimKiem.Location = new Point(0, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Mã hoặc tên dịch vụ...";
            txtTimKiem.Size = new Size(693, 25);
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
            btnTim.Location = new Point(701, 0);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(104, 34);
            btnTim.TabIndex = 1;
            btnTim.Text = "🔍 Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // dgvDichVu
            // 
            dgvDichVu.AllowUserToAddRows = false;
            dgvDichVu.AllowUserToDeleteRows = false;
            dgvDichVu.AllowUserToResizeRows = false;
            dgvDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDichVu.BackgroundColor = Color.White;
            dgvDichVu.BorderStyle = BorderStyle.None;
            dgvDichVu.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDichVu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle1.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDichVu.ColumnHeadersHeight = 34;
            dgvDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDichVu.Columns.AddRange(new DataGridViewColumn[] { colMaDichVu, colTenDichVu, colGia });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(232, 236, 248);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDichVu.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDichVu.Dock = DockStyle.Fill;
            dgvDichVu.EnableHeadersVisualStyles = false;
            dgvDichVu.GridColor = Color.FromArgb(229, 231, 235);
            dgvDichVu.Location = new Point(0, 46);
            dgvDichVu.Margin = new Padding(0, 0, 0, 12);
            dgvDichVu.MultiSelect = false;
            dgvDichVu.Name = "dgvDichVu";
            dgvDichVu.ReadOnly = true;
            dgvDichVu.RowHeadersVisible = false;
            dgvDichVu.RowHeadersWidth = 62;
            dgvDichVu.RowTemplate.Height = 32;
            dgvDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDichVu.Size = new Size(805, 358);
            dgvDichVu.TabIndex = 1;
            // 
            // colMaDichVu
            // 
            colMaDichVu.DataPropertyName = "MaDichVu";
            colMaDichVu.FillWeight = 20F;
            colMaDichVu.HeaderText = "MÃ DV";
            colMaDichVu.MinimumWidth = 8;
            colMaDichVu.Name = "colMaDichVu";
            colMaDichVu.ReadOnly = true;
            // 
            // colTenDichVu
            // 
            colTenDichVu.DataPropertyName = "TenDichVu";
            colTenDichVu.FillWeight = 50F;
            colTenDichVu.HeaderText = "TÊN DỊCH VỤ";
            colTenDichVu.MinimumWidth = 8;
            colTenDichVu.Name = "colTenDichVu";
            colTenDichVu.ReadOnly = true;
            // 
            // colGia
            // 
            colGia.DataPropertyName = "Gia";
            dataGridViewCellStyle2.Format = "N0";
            colGia.DefaultCellStyle = dataGridViewCellStyle2;
            colGia.FillWeight = 30F;
            colGia.HeaderText = "GIÁ (VNĐ)";
            colGia.MinimumWidth = 8;
            colGia.Name = "colGia";
            colGia.ReadOnly = true;
            // 
            // pnlThongTin
            // 
            pnlThongTin.BackColor = Color.White;
            pnlThongTin.Controls.Add(tlpThongTin);
            pnlThongTin.Controls.Add(flpNut);
            pnlThongTin.Dock = DockStyle.Fill;
            pnlThongTin.Location = new Point(0, 416);
            pnlThongTin.Margin = new Padding(0);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Padding = new Padding(12, 8, 12, 8);
            pnlThongTin.Size = new Size(805, 150);
            pnlThongTin.TabIndex = 2;
            // 
            // tlpThongTin
            // 
            tlpThongTin.ColumnCount = 3;
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tlpThongTin.Controls.Add(lblMaDichVu, 0, 0);
            tlpThongTin.Controls.Add(lblTenDichVu, 1, 0);
            tlpThongTin.Controls.Add(lblGia, 2, 0);
            tlpThongTin.Controls.Add(txtMaDV, 0, 1);
            tlpThongTin.Controls.Add(txtTenDV, 1, 1);
            tlpThongTin.Controls.Add(txtGia, 2, 1);
            tlpThongTin.Dock = DockStyle.Fill;
            tlpThongTin.Location = new Point(12, 8);
            tlpThongTin.Name = "tlpThongTin";
            tlpThongTin.RowCount = 2;
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpThongTin.Size = new Size(781, 90);
            tlpThongTin.TabIndex = 0;
            // 
            // lblMaDichVu
            // 
            lblMaDichVu.Dock = DockStyle.Fill;
            lblMaDichVu.Font = new Font("Segoe UI", 8F);
            lblMaDichVu.ForeColor = Color.FromArgb(107, 114, 128);
            lblMaDichVu.Location = new Point(3, 0);
            lblMaDichVu.Name = "lblMaDichVu";
            lblMaDichVu.Size = new Size(254, 20);
            lblMaDichVu.TabIndex = 0;
            lblMaDichVu.Text = "Mã dịch vụ";
            lblMaDichVu.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTenDichVu
            // 
            lblTenDichVu.Dock = DockStyle.Fill;
            lblTenDichVu.Font = new Font("Segoe UI", 8F);
            lblTenDichVu.ForeColor = Color.FromArgb(107, 114, 128);
            lblTenDichVu.Location = new Point(263, 0);
            lblTenDichVu.Name = "lblTenDichVu";
            lblTenDichVu.Size = new Size(254, 20);
            lblTenDichVu.TabIndex = 1;
            lblTenDichVu.Text = "Tên dịch vụ";
            lblTenDichVu.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblGia
            // 
            lblGia.Dock = DockStyle.Fill;
            lblGia.Font = new Font("Segoe UI", 8F);
            lblGia.ForeColor = Color.FromArgb(107, 114, 128);
            lblGia.Location = new Point(523, 0);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(255, 20);
            lblGia.TabIndex = 2;
            lblGia.Text = "Giá (VNĐ)";
            lblGia.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtMaDV
            // 
            txtMaDV.BorderStyle = BorderStyle.FixedSingle;
            txtMaDV.Dock = DockStyle.Top;
            txtMaDV.Font = new Font("Segoe UI", 10F);
            txtMaDV.Location = new Point(0, 23);
            txtMaDV.Margin = new Padding(0, 3, 12, 3);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.Size = new Size(248, 25);
            txtMaDV.TabIndex = 3;
            // 
            // txtTenDV
            // 
            txtTenDV.BorderStyle = BorderStyle.FixedSingle;
            txtTenDV.Dock = DockStyle.Top;
            txtTenDV.Font = new Font("Segoe UI", 10F);
            txtTenDV.Location = new Point(260, 23);
            txtTenDV.Margin = new Padding(0, 3, 12, 3);
            txtTenDV.Name = "txtTenDV";
            txtTenDV.PlaceholderText = "Ví dụ: Điện, Nước, Internet";
            txtTenDV.Size = new Size(248, 25);
            txtTenDV.TabIndex = 4;
            // 
            // txtGia
            // 
            txtGia.BorderStyle = BorderStyle.FixedSingle;
            txtGia.Dock = DockStyle.Top;
            txtGia.Font = new Font("Segoe UI", 10F);
            txtGia.Location = new Point(520, 23);
            txtGia.Margin = new Padding(0, 3, 0, 3);
            txtGia.Name = "txtGia";
            txtGia.PlaceholderText = "Ví dụ: 3500";
            txtGia.Size = new Size(261, 25);
            txtGia.TabIndex = 5;
            // 
            // flpNut
            // 
            flpNut.Controls.Add(btnLamMoi);
            flpNut.Controls.Add(btnXoa);
            flpNut.Controls.Add(btnSua);
            flpNut.Controls.Add(btnThem);
            flpNut.Dock = DockStyle.Bottom;
            flpNut.FlowDirection = FlowDirection.RightToLeft;
            flpNut.Location = new Point(12, 98);
            flpNut.Name = "flpNut";
            flpNut.Size = new Size(781, 44);
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
            btnLamMoi.Location = new Point(676, 6);
            btnLamMoi.Margin = new Padding(8, 6, 0, 0);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(105, 34);
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
            btnXoa.Location = new Point(563, 6);
            btnXoa.Margin = new Padding(8, 6, 0, 0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(105, 34);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "■ Xóa";
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
            btnSua.Location = new Point(450, 6);
            btnSua.Margin = new Padding(8, 6, 0, 0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 34);
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
            btnThem.Location = new Point(337, 6);
            btnThem.Margin = new Padding(8, 6, 0, 0);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 34);
            btnThem.TabIndex = 0;
            btnThem.Text = "+ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // DichVuControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 248);
            Controls.Add(tlpMain);
            Name = "DichVuControl";
            Padding = new Padding(19, 17, 19, 17);
            Size = new Size(843, 600);
            tlpMain.ResumeLayout(false);
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDichVu).EndInit();
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
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.TableLayoutPanel tlpThongTin;
        private System.Windows.Forms.Label lblMaDichVu;
        private System.Windows.Forms.Label lblTenDichVu;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.FlowLayoutPanel flpNut;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}