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
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTimKiem = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvNguoiThue = new System.Windows.Forms.DataGridView();
            this.colMaNguoiThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.tlpThongTin = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaNguoiThue = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtMaNguoiThue = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.flpNut = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.pnlTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiThue)).BeginInit();
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
            this.tlpMain.Controls.Add(this.dgvNguoiThue, 0, 1);
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
            this.txtTimKiem.PlaceholderText = "Tên hoặc CCCD...";
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
            // dgvNguoiThue
            //
            this.dgvNguoiThue.AllowUserToAddRows = false;
            this.dgvNguoiThue.AllowUserToDeleteRows = false;
            this.dgvNguoiThue.AllowUserToResizeRows = false;
            this.dgvNguoiThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoiThue.BackgroundColor = System.Drawing.Color.White;
            this.dgvNguoiThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNguoiThue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNguoiThue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgvHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvHeaderStyle.BackColor = System.Drawing.Color.White;
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            dgvHeaderStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dgvHeaderStyle.SelectionBackColor = System.Drawing.Color.White;
            dgvHeaderStyle.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            dgvHeaderStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNguoiThue.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvNguoiThue.ColumnHeadersHeight = 34;
            this.dgvNguoiThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNguoiThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNguoiThue,
            this.colHoTen,
            this.colSoDienThoai,
            this.colCCCD,
            this.colDiaChi});
            dgvCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dgvCellStyle.BackColor = System.Drawing.Color.White;
            dgvCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvCellStyle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#111827");
            dgvCellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dgvCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#E8ECF8");
            dgvCellStyle.SelectionForeColor = System.Drawing.ColorTranslator.FromHtml("#111827");
            dgvCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNguoiThue.DefaultCellStyle = dgvCellStyle;
            this.dgvNguoiThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNguoiThue.EnableHeadersVisualStyles = false;
            this.dgvNguoiThue.GridColor = System.Drawing.ColorTranslator.FromHtml("#E5E7EB");
            this.dgvNguoiThue.Location = new System.Drawing.Point(0, 46);
            this.dgvNguoiThue.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.dgvNguoiThue.MultiSelect = false;
            this.dgvNguoiThue.Name = "dgvNguoiThue";
            this.dgvNguoiThue.ReadOnly = true;
            this.dgvNguoiThue.RowHeadersVisible = false;
            this.dgvNguoiThue.RowTemplate.Height = 32;
            this.dgvNguoiThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguoiThue.Size = new System.Drawing.Size(805, 268);
            this.dgvNguoiThue.TabIndex = 1;
            //
            // colMaNguoiThue
            //
            this.colMaNguoiThue.DataPropertyName = "MaNguoiThue";
            this.colMaNguoiThue.HeaderText = "MÃ";
            this.colMaNguoiThue.Name = "colMaNguoiThue";
            this.colMaNguoiThue.ReadOnly = true;
            //
            // colHoTen
            //
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "HỌ TÊN";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            //
            // colSoDienThoai
            //
            this.colSoDienThoai.DataPropertyName = "SoDienThoai";
            this.colSoDienThoai.HeaderText = "SĐT";
            this.colSoDienThoai.Name = "colSoDienThoai";
            this.colSoDienThoai.ReadOnly = true;
            //
            // colCCCD
            //
            this.colCCCD.DataPropertyName = "CCCD";
            this.colCCCD.HeaderText = "CCCD";
            this.colCCCD.Name = "colCCCD";
            this.colCCCD.ReadOnly = true;
            //
            // colDiaChi
            //
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "ĐỊA CHỈ";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.ReadOnly = true;
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
            this.tlpThongTin.Controls.Add(this.lblMaNguoiThue, 0, 0);
            this.tlpThongTin.Controls.Add(this.lblHoTen, 1, 0);
            this.tlpThongTin.Controls.Add(this.txtMaNguoiThue, 0, 1);
            this.tlpThongTin.Controls.Add(this.txtHoTen, 1, 1);
            this.tlpThongTin.Controls.Add(this.lblSoDienThoai, 0, 2);
            this.tlpThongTin.Controls.Add(this.lblCCCD, 1, 2);
            this.tlpThongTin.Controls.Add(this.txtSoDienThoai, 0, 3);
            this.tlpThongTin.Controls.Add(this.txtCCCD, 1, 3);
            this.tlpThongTin.Controls.Add(this.lblDiaChi, 0, 4);
            this.tlpThongTin.Controls.Add(this.txtDiaChi, 0, 5);
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
            // lblMaNguoiThue
            //
            this.lblMaNguoiThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaNguoiThue.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMaNguoiThue.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblMaNguoiThue.Name = "lblMaNguoiThue";
            this.lblMaNguoiThue.TabIndex = 0;
            this.lblMaNguoiThue.Text = "Mã người thuê";
            this.lblMaNguoiThue.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // lblHoTen
            //
            this.lblHoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblHoTen.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên";
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // txtMaNguoiThue
            //
            this.txtMaNguoiThue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNguoiThue.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMaNguoiThue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaNguoiThue.Margin = new System.Windows.Forms.Padding(0, 3, 12, 3);
            this.txtMaNguoiThue.Name = "txtMaNguoiThue";
            this.txtMaNguoiThue.TabIndex = 2;
            //
            // txtHoTen
            //
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.TabIndex = 3;
            //
            // lblSoDienThoai
            //
            this.lblSoDienThoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSoDienThoai.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.TabIndex = 4;
            this.lblSoDienThoai.Text = "SĐT";
            this.lblSoDienThoai.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // lblCCCD
            //
            this.lblCCCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCCCD.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCCCD.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.TabIndex = 5;
            this.lblCCCD.Text = "CCCD";
            this.lblCCCD.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // txtSoDienThoai
            //
            this.txtSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoDienThoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(0, 3, 12, 3);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.TabIndex = 6;
            //
            // txtCCCD
            //
            this.txtCCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCCCD.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.TabIndex = 7;
            //
            // lblDiaChi
            //
            this.tlpThongTin.SetColumnSpan(this.lblDiaChi, 2);
            this.lblDiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDiaChi.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.TabIndex = 8;
            this.lblDiaChi.Text = "Địa chỉ thường trú";
            this.lblDiaChi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            //
            // txtDiaChi
            //
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpThongTin.SetColumnSpan(this.txtDiaChi, 2);
            this.txtDiaChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PlaceholderText = "Địa chỉ thường trú";
            this.txtDiaChi.TabIndex = 9;
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
            // ucNguoiThue
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F4F8");
            this.Controls.Add(this.tlpMain);
            this.Name = "ucNguoiThue";
            this.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.Size = new System.Drawing.Size(843, 600);
            this.tlpMain.ResumeLayout(false);
            this.pnlTimKiem.ResumeLayout(false);
            this.pnlTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiThue)).EndInit();
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
        private System.Windows.Forms.TextBox txtMaNguoiThue;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtSoDienThoai;
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
