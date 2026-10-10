namespace Quanlyphongtromini.UserControls
{
    partial class NguoiThueControl
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
            tlpMain = new TableLayoutPanel();
            pnlTimKiem = new Panel();
            txtTimKiem = new TextBox();
            btnTim = new Button();
            dgvNguoiThue = new DataGridView();
            colMaNguoiThue = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colSoDienThoai = new DataGridViewTextBoxColumn();
            colCCCD = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            pnlThongTin = new Panel();
            tlpThongTin = new TableLayoutPanel();
            lblMaNguoiThue = new Label();
            lblHoTen = new Label();
            txtMaNguoi = new TextBox();
            txtHoTen = new TextBox();
            lblSoDienThoai = new Label();
            lblCCCD = new Label();
            txtSdt = new TextBox();
            txtCCCD = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            flpNut = new FlowLayoutPanel();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            tlpMain.SuspendLayout();
            pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNguoiThue).BeginInit();
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
            tlpMain.Controls.Add(dgvNguoiThue, 0, 1);
            tlpMain.Controls.Add(pnlThongTin, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(19, 17);
            tlpMain.Margin = new Padding(0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 240F));
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
            txtTimKiem.PlaceholderText = "Tìm Kiếm";
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
            // dgvNguoiThue
            // 
            dgvNguoiThue.AllowUserToAddRows = false;
            dgvNguoiThue.AllowUserToDeleteRows = false;
            dgvNguoiThue.AllowUserToResizeRows = false;
            dgvNguoiThue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNguoiThue.BackgroundColor = Color.White;
            dgvNguoiThue.BorderStyle = BorderStyle.None;
            dgvNguoiThue.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNguoiThue.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle1.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvNguoiThue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNguoiThue.ColumnHeadersHeight = 34;
            dgvNguoiThue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNguoiThue.Columns.AddRange(new DataGridViewColumn[] { colMaNguoiThue, colHoTen, colSoDienThoai, colCCCD, colDiaChi });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(232, 236, 248);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 24, 39);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNguoiThue.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNguoiThue.Dock = DockStyle.Fill;
            dgvNguoiThue.EnableHeadersVisualStyles = false;
            dgvNguoiThue.GridColor = Color.FromArgb(229, 231, 235);
            dgvNguoiThue.Location = new Point(0, 46);
            dgvNguoiThue.Margin = new Padding(0, 0, 0, 12);
            dgvNguoiThue.MultiSelect = false;
            dgvNguoiThue.Name = "dgvNguoiThue";
            dgvNguoiThue.ReadOnly = true;
            dgvNguoiThue.RowHeadersVisible = false;
            dgvNguoiThue.RowTemplate.Height = 32;
            dgvNguoiThue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNguoiThue.Size = new Size(805, 268);
            dgvNguoiThue.TabIndex = 1;
            // 
            // colMaNguoiThue
            // 
            colMaNguoiThue.DataPropertyName = "MaNguoiThue";
            colMaNguoiThue.HeaderText = "MÃ";
            colMaNguoiThue.Name = "colMaNguoiThue";
            colMaNguoiThue.ReadOnly = true;
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.HeaderText = "HỌ TÊN";
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            // 
            // colSoDienThoai
            // 
            colSoDienThoai.DataPropertyName = "SoDienThoai";
            colSoDienThoai.HeaderText = "SĐT";
            colSoDienThoai.Name = "colSoDienThoai";
            colSoDienThoai.ReadOnly = true;
            // 
            // colCCCD
            // 
            colCCCD.DataPropertyName = "CCCD";
            colCCCD.HeaderText = "CCCD";
            colCCCD.Name = "colCCCD";
            colCCCD.ReadOnly = true;
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.HeaderText = "ĐỊA CHỈ";
            colDiaChi.Name = "colDiaChi";
            colDiaChi.ReadOnly = true;
            // 
            // pnlThongTin
            // 
            pnlThongTin.BackColor = Color.White;
            pnlThongTin.Controls.Add(tlpThongTin);
            pnlThongTin.Controls.Add(flpNut);
            pnlThongTin.Dock = DockStyle.Fill;
            pnlThongTin.Location = new Point(0, 326);
            pnlThongTin.Margin = new Padding(0);
            pnlThongTin.Name = "pnlThongTin";
            pnlThongTin.Padding = new Padding(12, 8, 12, 8);
            pnlThongTin.Size = new Size(805, 240);
            pnlThongTin.TabIndex = 2;
            // 
            // tlpThongTin
            // 
            tlpThongTin.ColumnCount = 2;
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpThongTin.Controls.Add(lblMaNguoiThue, 0, 0);
            tlpThongTin.Controls.Add(lblHoTen, 1, 0);
            tlpThongTin.Controls.Add(txtMaNguoi, 0, 1);
            tlpThongTin.Controls.Add(txtHoTen, 1, 1);
            tlpThongTin.Controls.Add(lblSoDienThoai, 0, 2);
            tlpThongTin.Controls.Add(lblCCCD, 1, 2);
            tlpThongTin.Controls.Add(txtSdt, 0, 3);
            tlpThongTin.Controls.Add(txtCCCD, 1, 3);
            tlpThongTin.Controls.Add(lblDiaChi, 0, 4);
            tlpThongTin.Controls.Add(txtDiaChi, 0, 5);
            tlpThongTin.Dock = DockStyle.Fill;
            tlpThongTin.Location = new Point(12, 8);
            tlpThongTin.Name = "tlpThongTin";
            tlpThongTin.RowCount = 6;
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpThongTin.Size = new Size(781, 180);
            tlpThongTin.TabIndex = 0;
            // 
            // lblMaNguoiThue
            // 
            lblMaNguoiThue.Dock = DockStyle.Fill;
            lblMaNguoiThue.Font = new Font("Segoe UI", 8F);
            lblMaNguoiThue.ForeColor = Color.FromArgb(107, 114, 128);
            lblMaNguoiThue.Location = new Point(3, 0);
            lblMaNguoiThue.Name = "lblMaNguoiThue";
            lblMaNguoiThue.Size = new Size(384, 22);
            lblMaNguoiThue.TabIndex = 0;
            lblMaNguoiThue.Text = "Mã người thuê";
            lblMaNguoiThue.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblHoTen
            // 
            lblHoTen.Dock = DockStyle.Fill;
            lblHoTen.Font = new Font("Segoe UI", 8F);
            lblHoTen.ForeColor = Color.FromArgb(107, 114, 128);
            lblHoTen.Location = new Point(393, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(385, 22);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ tên";
            lblHoTen.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtMaNguoi
            // 
            txtMaNguoi.BorderStyle = BorderStyle.FixedSingle;
            txtMaNguoi.Dock = DockStyle.Top;
            txtMaNguoi.Font = new Font("Segoe UI", 10F);
            txtMaNguoi.Location = new Point(0, 25);
            txtMaNguoi.Margin = new Padding(0, 3, 12, 3);
            txtMaNguoi.Name = "txtMaNguoi";
            txtMaNguoi.Size = new Size(378, 25);
            txtMaNguoi.TabIndex = 2;
           
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Dock = DockStyle.Top;
            txtHoTen.Font = new Font("Segoe UI", 10F);
            txtHoTen.Location = new Point(402, 25);
            txtHoTen.Margin = new Padding(12, 3, 0, 3);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(379, 25);
            txtHoTen.TabIndex = 3;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.Dock = DockStyle.Fill;
            lblSoDienThoai.Font = new Font("Segoe UI", 8F);
            lblSoDienThoai.ForeColor = Color.FromArgb(107, 114, 128);
            lblSoDienThoai.Location = new Point(3, 56);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(384, 22);
            lblSoDienThoai.TabIndex = 4;
            lblSoDienThoai.Text = "SĐT";
            lblSoDienThoai.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblCCCD
            // 
            lblCCCD.Dock = DockStyle.Fill;
            lblCCCD.Font = new Font("Segoe UI", 8F);
            lblCCCD.ForeColor = Color.FromArgb(107, 114, 128);
            lblCCCD.Location = new Point(393, 56);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(385, 22);
            lblCCCD.TabIndex = 5;
            lblCCCD.Text = "CCCD";
            lblCCCD.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtSdt
            // 
            txtSdt.BorderStyle = BorderStyle.FixedSingle;
            txtSdt.Dock = DockStyle.Top;
            txtSdt.Font = new Font("Segoe UI", 10F);
            txtSdt.Location = new Point(0, 81);
            txtSdt.Margin = new Padding(0, 3, 12, 3);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(378, 25);
            txtSdt.TabIndex = 6;
            // 
            // txtCCCD
            // 
            txtCCCD.BorderStyle = BorderStyle.FixedSingle;
            txtCCCD.Dock = DockStyle.Top;
            txtCCCD.Font = new Font("Segoe UI", 10F);
            txtCCCD.Location = new Point(402, 81);
            txtCCCD.Margin = new Padding(12, 3, 0, 3);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(379, 25);
            txtCCCD.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            tlpThongTin.SetColumnSpan(lblDiaChi, 2);
            lblDiaChi.Dock = DockStyle.Fill;
            lblDiaChi.Font = new Font("Segoe UI", 8F);
            lblDiaChi.ForeColor = Color.FromArgb(107, 114, 128);
            lblDiaChi.Location = new Point(3, 112);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(775, 22);
            lblDiaChi.TabIndex = 8;
            lblDiaChi.Text = "Địa chỉ thường trú";
            lblDiaChi.TextAlign = ContentAlignment.BottomLeft;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            tlpThongTin.SetColumnSpan(txtDiaChi, 2);
            txtDiaChi.Dock = DockStyle.Top;
            txtDiaChi.Font = new Font("Segoe UI", 10F);
            txtDiaChi.Location = new Point(0, 137);
            txtDiaChi.Margin = new Padding(0, 3, 0, 3);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.PlaceholderText = "Địa chỉ thường trú";
            txtDiaChi.Size = new Size(781, 25);
            txtDiaChi.TabIndex = 9;
            // 
            // flpNut
            // 
            flpNut.Controls.Add(btnLamMoi);
            flpNut.Controls.Add(btnXoa);
            flpNut.Controls.Add(btnSua);
            flpNut.Controls.Add(btnThem);
            flpNut.Dock = DockStyle.Bottom;
            flpNut.FlowDirection = FlowDirection.RightToLeft;
            flpNut.Location = new Point(12, 188);
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
            btnLamMoi.Location = new Point(681, 6);
            btnLamMoi.Margin = new Padding(8, 6, 0, 0);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(100, 34);
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
            btnXoa.Location = new Point(599, 6);
            btnXoa.Margin = new Padding(8, 6, 0, 0);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 34);
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
            btnSua.Location = new Point(517, 6);
            btnSua.Margin = new Padding(8, 6, 0, 0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(74, 34);
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
            btnThem.Location = new Point(419, 6);
            btnThem.Margin = new Padding(8, 6, 0, 0);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 34);
            btnThem.TabIndex = 0;
            btnThem.Text = "+ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // NguoiThueControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 248);
            Controls.Add(tlpMain);
            Name = "NguoiThueControl";
            Padding = new Padding(19, 17, 19, 17);
            Size = new Size(843, 600);
            tlpMain.ResumeLayout(false);
            pnlTimKiem.ResumeLayout(false);
            pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNguoiThue).EndInit();
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
        private System.Windows.Forms.DataGridView dgvNguoiThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNguoiThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.TableLayoutPanel tlpThongTin;
        private System.Windows.Forms.Label lblMaNguoiThue;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtMaNguoi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.FlowLayoutPanel flpNut;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}
