namespace Quanlyphongtromini.UserControls
{
    partial class DashboardControl
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
            tlpCards = new TableLayoutPanel();
            pnlTongPhong = new Panel();
            lblTongPhong = new Label();
            lblTongPhongTitle = new Label();
            pnlDangThue = new Panel();
            lblDangThue = new Label();
            lblDangThueTitle = new Label();
            pnlPhongTrong = new Panel();
            lblPhongTrong = new Label();
            lblPhongTrongTitle = new Label();
            pnlDoanhThu = new Panel();
            lblDoanhThu = new Label();
            lblDoanhThuTitle = new Label();
            pnlChart = new Panel();
            lblChart = new Label();
            tlpCards.SuspendLayout();
            pnlTongPhong.SuspendLayout();
            pnlDangThue.SuspendLayout();
            pnlPhongTrong.SuspendLayout();
            pnlDoanhThu.SuspendLayout();
            pnlChart.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCards
            // 
            tlpCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpCards.BackColor = Color.Transparent;
            tlpCards.ColumnCount = 4;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.Controls.Add(pnlTongPhong, 0, 0);
            tlpCards.Controls.Add(pnlDangThue, 1, 0);
            tlpCards.Controls.Add(pnlPhongTrong, 2, 0);
            tlpCards.Controls.Add(pnlDoanhThu, 3, 0);
            tlpCards.Location = new Point(27, 28);
            tlpCards.Margin = new Padding(0);
            tlpCards.Name = "tlpCards";
            tlpCards.RowCount = 1;
            tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCards.Size = new Size(1150, 93);
            tlpCards.TabIndex = 0;
            // 
            // pnlTongPhong
            // 
            pnlTongPhong.BackColor = Color.White;
            pnlTongPhong.Controls.Add(lblTongPhong);
            pnlTongPhong.Controls.Add(lblTongPhongTitle);
            pnlTongPhong.Dock = DockStyle.Fill;
            pnlTongPhong.Location = new Point(0, 0);
            pnlTongPhong.Margin = new Padding(0, 0, 16, 0);
            pnlTongPhong.Name = "pnlTongPhong";
            pnlTongPhong.Size = new Size(271, 93);
            pnlTongPhong.TabIndex = 0;
            // 
            // lblTongPhong
            // 
            lblTongPhong.AutoSize = true;
            lblTongPhong.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTongPhong.ForeColor = Color.FromArgb(17, 24, 39);
            lblTongPhong.Location = new Point(14, 40);
            lblTongPhong.Margin = new Padding(4, 0, 4, 0);
            lblTongPhong.Name = "lblTongPhong";
            lblTongPhong.Size = new Size(30, 36);
            lblTongPhong.TabIndex = 1;
            lblTongPhong.Text = "3";
            // 
            // lblTongPhongTitle
            // 
            lblTongPhongTitle.AutoSize = true;
            lblTongPhongTitle.Font = new Font("Segoe UI", 8F);
            lblTongPhongTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblTongPhongTitle.Location = new Point(17, 13);
            lblTongPhongTitle.Margin = new Padding(4, 0, 4, 0);
            lblTongPhongTitle.Name = "lblTongPhongTitle";
            lblTongPhongTitle.Size = new Size(114, 21);
            lblTongPhongTitle.TabIndex = 0;
            lblTongPhongTitle.Text = "Tổng số phòng";
            // 
            // pnlDangThue
            // 
            pnlDangThue.BackColor = Color.White;
            pnlDangThue.Controls.Add(lblDangThue);
            pnlDangThue.Controls.Add(lblDangThueTitle);
            pnlDangThue.Dock = DockStyle.Fill;
            pnlDangThue.Location = new Point(287, 0);
            pnlDangThue.Margin = new Padding(0, 0, 16, 0);
            pnlDangThue.Name = "pnlDangThue";
            pnlDangThue.Size = new Size(271, 93);
            pnlDangThue.TabIndex = 1;
            // 
            // lblDangThue
            // 
            lblDangThue.AutoSize = true;
            lblDangThue.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDangThue.ForeColor = Color.FromArgb(180, 83, 9);
            lblDangThue.Location = new Point(14, 40);
            lblDangThue.Margin = new Padding(4, 0, 4, 0);
            lblDangThue.Name = "lblDangThue";
            lblDangThue.Size = new Size(30, 36);
            lblDangThue.TabIndex = 1;
            lblDangThue.Text = "1";
            // 
            // lblDangThueTitle
            // 
            lblDangThueTitle.AutoSize = true;
            lblDangThueTitle.Font = new Font("Segoe UI", 8F);
            lblDangThueTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblDangThueTitle.Location = new Point(17, 13);
            lblDangThueTitle.Margin = new Padding(4, 0, 4, 0);
            lblDangThueTitle.Name = "lblDangThueTitle";
            lblDangThueTitle.Size = new Size(82, 21);
            lblDangThueTitle.TabIndex = 0;
            lblDangThueTitle.Text = "Đang thuê";
            // 
            // pnlPhongTrong
            // 
            pnlPhongTrong.BackColor = Color.White;
            pnlPhongTrong.Controls.Add(lblPhongTrong);
            pnlPhongTrong.Controls.Add(lblPhongTrongTitle);
            pnlPhongTrong.Dock = DockStyle.Fill;
            pnlPhongTrong.Location = new Point(574, 0);
            pnlPhongTrong.Margin = new Padding(0, 0, 16, 0);
            pnlPhongTrong.Name = "pnlPhongTrong";
            pnlPhongTrong.Size = new Size(271, 93);
            pnlPhongTrong.TabIndex = 2;
            // 
            // lblPhongTrong
            // 
            lblPhongTrong.AutoSize = true;
            lblPhongTrong.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPhongTrong.ForeColor = Color.FromArgb(15, 118, 110);
            lblPhongTrong.Location = new Point(14, 40);
            lblPhongTrong.Margin = new Padding(4, 0, 4, 0);
            lblPhongTrong.Name = "lblPhongTrong";
            lblPhongTrong.Size = new Size(30, 36);
            lblPhongTrong.TabIndex = 1;
            lblPhongTrong.Text = "1";
            // 
            // lblPhongTrongTitle
            // 
            lblPhongTrongTitle.AutoSize = true;
            lblPhongTrongTitle.Font = new Font("Segoe UI", 8F);
            lblPhongTrongTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblPhongTrongTitle.Location = new Point(17, 13);
            lblPhongTrongTitle.Margin = new Padding(4, 0, 4, 0);
            lblPhongTrongTitle.Name = "lblPhongTrongTitle";
            lblPhongTrongTitle.Size = new Size(97, 21);
            lblPhongTrongTitle.TabIndex = 0;
            lblPhongTrongTitle.Text = "Phòng trống";
            // 
            // pnlDoanhThu
            // 
            pnlDoanhThu.BackColor = Color.White;
            pnlDoanhThu.Controls.Add(lblDoanhThu);
            pnlDoanhThu.Controls.Add(lblDoanhThuTitle);
            pnlDoanhThu.Dock = DockStyle.Fill;
            pnlDoanhThu.Location = new Point(861, 0);
            pnlDoanhThu.Margin = new Padding(0);
            pnlDoanhThu.Name = "pnlDoanhThu";
            pnlDoanhThu.Size = new Size(289, 93);
            pnlDoanhThu.TabIndex = 3;
            // 
            // lblDoanhThu
            // 
            lblDoanhThu.AutoSize = true;
            lblDoanhThu.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDoanhThu.ForeColor = Color.FromArgb(17, 24, 39);
            lblDoanhThu.Location = new Point(14, 40);
            lblDoanhThu.Margin = new Padding(4, 0, 4, 0);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Size = new Size(87, 36);
            lblDoanhThu.TabIndex = 1;
            lblDoanhThu.Text = "6.13tr";
            // 
            // lblDoanhThuTitle
            // 
            lblDoanhThuTitle.AutoSize = true;
            lblDoanhThuTitle.Font = new Font("Segoe UI", 8F);
            lblDoanhThuTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblDoanhThuTitle.Location = new Point(17, 13);
            lblDoanhThuTitle.Margin = new Padding(4, 0, 4, 0);
            lblDoanhThuTitle.Name = "lblDoanhThuTitle";
            lblDoanhThuTitle.Size = new Size(127, 21);
            lblDoanhThuTitle.TabIndex = 0;
            lblDoanhThuTitle.Text = "Doanh thu tháng";
            // 
            // pnlChart
            // 
            pnlChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlChart.BackColor = Color.White;
            pnlChart.Controls.Add(lblChart);
            pnlChart.Location = new Point(27, 142);
            pnlChart.Margin = new Padding(4, 5, 4, 5);
            pnlChart.Name = "pnlChart";
            pnlChart.Size = new Size(1150, 500);
            pnlChart.TabIndex = 1;
            // 
            // lblChart
            // 
            lblChart.Dock = DockStyle.Fill;
            lblChart.Font = new Font("Segoe UI Emoji", 10F);
            lblChart.ForeColor = Color.FromArgb(107, 114, 128);
            lblChart.Location = new Point(0, 0);
            lblChart.Margin = new Padding(4, 0, 4, 0);
            lblChart.Name = "lblChart";
            lblChart.Size = new Size(1150, 500);
            lblChart.TabIndex = 0;
            lblChart.Text = "📊 Biểu đồ doanh thu theo tháng";
            lblChart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DashboardControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 244, 248);
            Controls.Add(pnlChart);
            Controls.Add(tlpCards);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DashboardControl";
            Size = new Size(1204, 1000);
            tlpCards.ResumeLayout(false);
            pnlTongPhong.ResumeLayout(false);
            pnlTongPhong.PerformLayout();
            pnlDangThue.ResumeLayout(false);
            pnlDangThue.PerformLayout();
            pnlPhongTrong.ResumeLayout(false);
            pnlPhongTrong.PerformLayout();
            pnlDoanhThu.ResumeLayout(false);
            pnlDoanhThu.PerformLayout();
            pnlChart.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tlpCards;
        private System.Windows.Forms.Panel pnlTongPhong;
        private System.Windows.Forms.Label lblTongPhong;
        private System.Windows.Forms.Label lblTongPhongTitle;
        private System.Windows.Forms.Panel pnlDangThue;
        private System.Windows.Forms.Label lblDangThue;
        private System.Windows.Forms.Label lblDangThueTitle;
        private System.Windows.Forms.Panel pnlPhongTrong;
        private System.Windows.Forms.Label lblPhongTrong;
        private System.Windows.Forms.Label lblPhongTrongTitle;
        private System.Windows.Forms.Panel pnlDoanhThu;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblDoanhThuTitle;
        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.Label lblChart;
    }
}
