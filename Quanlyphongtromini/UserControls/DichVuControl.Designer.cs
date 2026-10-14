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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            txtMaDichVu = new TextBox();
            txtTenDichVu = new TextBox();
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
            tlpMain.Location = new Point(27, 28);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F));
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
            txtTimKiem.PlaceholderText = "Mã hoặc tên dịch vụ...";
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(232, 236, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDichVu.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDichVu.Dock = DockStyle.Fill;
            dgvDichVu.EnableHeadersVisualStyles = false;
            dgvDichVu.GridColor = Color.FromArgb(229, 231, 235);
            dgvDichVu.Location = new Point(0, 77);
            dgvDichVu.Margin = new Padding(0, 0, 0, 20);
            dgvDichVu.MultiSelect = false;
            dgvDichVu.Name = "dgvDichVu";
            dgvDichVu.ReadOnly = true;
            dgvDichVu.RowHeadersVisible = false;
            dgvDichVu.RowHeadersWidth = 62;
            dgvDichVu.RowTemplate.Height = 32;
            dgvDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDichVu.Size = new Size(1150, 597);
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
            dataGridViewCellStyle3.Format = "N0";
            colGia.DefaultCellStyle = dataGridViewCellStyle3;
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
            pnlThongTin.Location = new Point(0, 694);
            pnlThongTin.Margin = new Padding(0);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Padding = new Padding(17, 13, 17, 13);
            pnlThongTin.Size = new Size(1150, 250);
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
            tlpThongTin.Controls.Add(txtMaDichVu, 0, 1);
            tlpThongTin.Controls.Add(txtTenDichVu, 1, 1);
            tlpThongTin.Controls.Add(txtGia, 2, 1);
            tlpThongTin.Dock = DockStyle.Fill;
            tlpThongTin.Location = new Point(17, 13);
            tlpThongTin.Margin = new Padding(4, 5, 4, 5);
            tlpThongTin.Name = "tlpThongTin";
            tlpThongTin.RowCount = 2;
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tlpThongTin.Size = new Size(1116, 151);
            tlpThongTin.TabIndex = 0;
            // 
            // lblMaDichVu
            // 
            lblMaDichVu.Dock = DockStyle.Fill;
            lblMaDichVu.Font = new Font("Segoe UI", 8F);
            lblMaDichVu.ForeColor = Color.FromArgb(107, 114, 128);
            lblMaDichVu.Location = new Point(4, 0);
            lblMaDichVu.Margin = new Padding(4, 0, 4, 0);
            lblMaDichVu.Name = "lblMaDichVu";
            lblMaDichVu.Size = new Size(364, 33);
            lblMaDichVu.TabIndex = 0;
            lblMaDichVu.Text = "Mã dịch vụ";
            lblMaDichVu.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTenDichVu
            // 
            lblTenDichVu.Dock = DockStyle.Fill;
            lblTenDichVu.Font = new Font("Segoe UI", 8F);
            lblTenDichVu.ForeColor = Color.FromArgb(107, 114, 128);
            lblTenDichVu.Location = new Point(376, 0);
            lblTenDichVu.Margin = new Padding(4, 0, 4, 0);
            lblTenDichVu.Name = "lblTenDichVu";
            lblTenDichVu.Size = new Size(364, 33);
            lblTenDichVu.TabIndex = 1;
            lblTenDichVu.Text = "Tên dịch vụ";
            lblTenDichVu.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblGia
            // 
            lblGia.Dock = DockStyle.Fill;
            lblGia.Font = new Font("Segoe UI", 8F);
            lblGia.ForeColor = Color.FromArgb(107, 114, 128);
            lblGia.Location = new Point(748, 0);
            lblGia.Margin = new Padding(4, 0, 4, 0);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(364, 33);
            lblGia.TabIndex = 2;
            lblGia.Text = "Giá (VNĐ)";
            lblGia.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtMaDichVu
            // 
            txtMaDichVu.BorderStyle = BorderStyle.FixedSingle;
            txtMaDichVu.Dock = DockStyle.Top;
            txtMaDichVu.Font = new Font("Segoe UI", 10F);
            txtMaDichVu.Location = new Point(0, 38);
            txtMaDichVu.Margin = new Padding(0, 5, 17, 5);
            txtMaDichVu.Name = "txtMaDichVu";
            txtMaDichVu.Size = new Size(355, 34);
            txtMaDichVu.TabIndex = 3;
            // 
            // txtTenDichVu
            // 
            txtTenDichVu.BorderStyle = BorderStyle.FixedSingle;
            txtTenDichVu.Dock = DockStyle.Top;
            txtTenDichVu.Font = new Font("Segoe UI", 10F);
            txtTenDichVu.Location = new Point(372, 38);
            txtTenDichVu.Margin = new Padding(0, 5, 17, 5);
            txtTenDichVu.Name = "txtTenDichVu";
            txtTenDichVu.PlaceholderText = "Ví dụ: Điện, Nước, Internet";
            txtTenDichVu.Size = new Size(355, 34);
            txtTenDichVu.TabIndex = 4;
            // 
            // txtGia
            // 
            txtGia.BorderStyle = BorderStyle.FixedSingle;
            txtGia.Dock = DockStyle.Top;
            txtGia.Font = new Font("Segoe UI", 10F);
            txtGia.Location = new Point(744, 38);
            txtGia.Margin = new Padding(0, 5, 0, 5);
            txtGia.Name = "txtGia";
            txtGia.PlaceholderText = "Ví dụ: 3500";
            txtGia.Size = new Size(372, 34);
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
            flpNut.Location = new Point(17, 164);
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
            btnLamMoi.Location = new Point(959, 10);
            btnLamMoi.Margin = new Padding(11, 10, 0, 0);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(150, 57);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "↻ Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(242, 21, 32);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(798, 10);
            btnXoa.Margin = new Padding(11, 10, 0, 0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 57);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "■ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.FromArgb(17, 24, 39);
            btnSua.Location = new Point(637, 10);
            btnSua.Margin = new Padding(11, 10, 0, 0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 57);
            btnSua.TabIndex = 1;
            btnSua.Text = "✎ Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(36, 70, 145);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(476, 10);
            btnThem.Margin = new Padding(11, 10, 0, 0);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 57);
            btnThem.TabIndex = 0;
            btnThem.Text = "+ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // DichVuControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 248);
            Controls.Add(tlpMain);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DichVuControl";
            Padding = new Padding(27, 28, 27, 28);
            Size = new Size(1204, 1000);
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
        private System.Windows.Forms.TextBox txtMaDichVu;
        private System.Windows.Forms.TextBox txtTenDichVu;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.FlowLayoutPanel flpNut;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}