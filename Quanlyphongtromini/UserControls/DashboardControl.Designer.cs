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
            this.tlpCards = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTongPhong = new System.Windows.Forms.Panel();
            this.lblTongPhong = new System.Windows.Forms.Label();
            this.lblTongPhongTitle = new System.Windows.Forms.Label();
            this.pnlDangThue = new System.Windows.Forms.Panel();
            this.lblDangThue = new System.Windows.Forms.Label();
            this.lblDangThueTitle = new System.Windows.Forms.Label();
            this.pnlPhongTrong = new System.Windows.Forms.Panel();
            this.lblPhongTrong = new System.Windows.Forms.Label();
            this.lblPhongTrongTitle = new System.Windows.Forms.Label();
            this.pnlDoanhThu = new System.Windows.Forms.Panel();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblDoanhThuTitle = new System.Windows.Forms.Label();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.lblChart = new System.Windows.Forms.Label();
            this.tlpCards.SuspendLayout();
            this.pnlTongPhong.SuspendLayout();
            this.pnlDangThue.SuspendLayout();
            this.pnlPhongTrong.SuspendLayout();
            this.pnlDoanhThu.SuspendLayout();
            this.pnlChart.SuspendLayout();
            this.SuspendLayout();
            //
            // tlpCards
            //
            this.tlpCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCards.BackColor = System.Drawing.Color.Transparent;
            this.tlpCards.ColumnCount = 4;
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.Controls.Add(this.pnlTongPhong, 0, 0);
            this.tlpCards.Controls.Add(this.pnlDangThue, 1, 0);
            this.tlpCards.Controls.Add(this.pnlPhongTrong, 2, 0);
            this.tlpCards.Controls.Add(this.pnlDoanhThu, 3, 0);
            this.tlpCards.Location = new System.Drawing.Point(19, 17);
            this.tlpCards.Margin = new System.Windows.Forms.Padding(0);
            this.tlpCards.Name = "tlpCards";
            this.tlpCards.RowCount = 1;
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCards.Size = new System.Drawing.Size(805, 56);
            this.tlpCards.TabIndex = 0;
            //
            // pnlTongPhong
            //
            this.pnlTongPhong.BackColor = System.Drawing.Color.White;
            this.pnlTongPhong.Controls.Add(this.lblTongPhong);
            this.pnlTongPhong.Controls.Add(this.lblTongPhongTitle);
            this.pnlTongPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTongPhong.Location = new System.Drawing.Point(0, 0);
            this.pnlTongPhong.Margin = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.pnlTongPhong.Name = "pnlTongPhong";
            this.pnlTongPhong.Size = new System.Drawing.Size(190, 56);
            this.pnlTongPhong.TabIndex = 0;
            //
            // lblTongPhongTitle
            //
            this.lblTongPhongTitle.AutoSize = true;
            this.lblTongPhongTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTongPhongTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblTongPhongTitle.Location = new System.Drawing.Point(12, 8);
            this.lblTongPhongTitle.Name = "lblTongPhongTitle";
            this.lblTongPhongTitle.TabIndex = 0;
            this.lblTongPhongTitle.Text = "Tổng số phòng";
            //
            // lblTongPhong
            //
            this.lblTongPhong.AutoSize = true;
            this.lblTongPhong.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTongPhong.ForeColor = System.Drawing.ColorTranslator.FromHtml("#111827");
            this.lblTongPhong.Location = new System.Drawing.Point(10, 24);
            this.lblTongPhong.Name = "lblTongPhong";
            this.lblTongPhong.TabIndex = 1;
            this.lblTongPhong.Text = "3";
            //
            // pnlDangThue
            //
            this.pnlDangThue.BackColor = System.Drawing.Color.White;
            this.pnlDangThue.Controls.Add(this.lblDangThue);
            this.pnlDangThue.Controls.Add(this.lblDangThueTitle);
            this.pnlDangThue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDangThue.Location = new System.Drawing.Point(201, 0);
            this.pnlDangThue.Margin = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.pnlDangThue.Name = "pnlDangThue";
            this.pnlDangThue.Size = new System.Drawing.Size(190, 56);
            this.pnlDangThue.TabIndex = 1;
            //
            // lblDangThueTitle
            //
            this.lblDangThueTitle.AutoSize = true;
            this.lblDangThueTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDangThueTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblDangThueTitle.Location = new System.Drawing.Point(12, 8);
            this.lblDangThueTitle.Name = "lblDangThueTitle";
            this.lblDangThueTitle.TabIndex = 0;
            this.lblDangThueTitle.Text = "Đang thuê";
            //
            // lblDangThue
            //
            this.lblDangThue.AutoSize = true;
            this.lblDangThue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblDangThue.ForeColor = System.Drawing.ColorTranslator.FromHtml("#B45309");
            this.lblDangThue.Location = new System.Drawing.Point(10, 24);
            this.lblDangThue.Name = "lblDangThue";
            this.lblDangThue.TabIndex = 1;
            this.lblDangThue.Text = "1";
            //
            // pnlPhongTrong
            //
            this.pnlPhongTrong.BackColor = System.Drawing.Color.White;
            this.pnlPhongTrong.Controls.Add(this.lblPhongTrong);
            this.pnlPhongTrong.Controls.Add(this.lblPhongTrongTitle);
            this.pnlPhongTrong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhongTrong.Location = new System.Drawing.Point(402, 0);
            this.pnlPhongTrong.Margin = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.pnlPhongTrong.Name = "pnlPhongTrong";
            this.pnlPhongTrong.Size = new System.Drawing.Size(190, 56);
            this.pnlPhongTrong.TabIndex = 2;
            //
            // lblPhongTrongTitle
            //
            this.lblPhongTrongTitle.AutoSize = true;
            this.lblPhongTrongTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPhongTrongTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblPhongTrongTitle.Location = new System.Drawing.Point(12, 8);
            this.lblPhongTrongTitle.Name = "lblPhongTrongTitle";
            this.lblPhongTrongTitle.TabIndex = 0;
            this.lblPhongTrongTitle.Text = "Phòng trống";
            //
            // lblPhongTrong
            //
            this.lblPhongTrong.AutoSize = true;
            this.lblPhongTrong.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPhongTrong.ForeColor = System.Drawing.ColorTranslator.FromHtml("#0F766E");
            this.lblPhongTrong.Location = new System.Drawing.Point(10, 24);
            this.lblPhongTrong.Name = "lblPhongTrong";
            this.lblPhongTrong.TabIndex = 1;
            this.lblPhongTrong.Text = "1";
            //
            // pnlDoanhThu
            //
            this.pnlDoanhThu.BackColor = System.Drawing.Color.White;
            this.pnlDoanhThu.Controls.Add(this.lblDoanhThu);
            this.pnlDoanhThu.Controls.Add(this.lblDoanhThuTitle);
            this.pnlDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoanhThu.Location = new System.Drawing.Point(603, 0);
            this.pnlDoanhThu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDoanhThu.Name = "pnlDoanhThu";
            this.pnlDoanhThu.Size = new System.Drawing.Size(202, 56);
            this.pnlDoanhThu.TabIndex = 3;
            //
            // lblDoanhThuTitle
            //
            this.lblDoanhThuTitle.AutoSize = true;
            this.lblDoanhThuTitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDoanhThuTitle.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblDoanhThuTitle.Location = new System.Drawing.Point(12, 8);
            this.lblDoanhThuTitle.Name = "lblDoanhThuTitle";
            this.lblDoanhThuTitle.TabIndex = 0;
            this.lblDoanhThuTitle.Text = "Doanh thu tháng";
            //
            // lblDoanhThu
            //
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThu.ForeColor = System.Drawing.ColorTranslator.FromHtml("#111827");
            this.lblDoanhThu.Location = new System.Drawing.Point(10, 24);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.TabIndex = 1;
            this.lblDoanhThu.Text = "6.13tr";
            //
            // pnlChart
            //
            this.pnlChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChart.BackColor = System.Drawing.Color.White;
            this.pnlChart.Controls.Add(this.lblChart);
            this.pnlChart.Location = new System.Drawing.Point(19, 85);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Size = new System.Drawing.Size(805, 300);
            this.pnlChart.TabIndex = 1;
            //
            // lblChart
            //
            this.lblChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChart.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.lblChart.ForeColor = System.Drawing.ColorTranslator.FromHtml("#6B7280");
            this.lblChart.Location = new System.Drawing.Point(0, 0);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(805, 300);
            this.lblChart.TabIndex = 0;
            this.lblChart.Text = "📊 Biểu đồ doanh thu theo tháng";
            this.lblChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // ucTongQuan
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2F4F8");
            this.Controls.Add(this.pnlChart);
            this.Controls.Add(this.tlpCards);
            this.Name = "ucTongQuan";
            this.Size = new System.Drawing.Size(843, 600);
            this.tlpCards.ResumeLayout(false);
            this.pnlTongPhong.ResumeLayout(false);
            this.pnlTongPhong.PerformLayout();
            this.pnlDangThue.ResumeLayout(false);
            this.pnlDangThue.PerformLayout();
            this.pnlPhongTrong.ResumeLayout(false);
            this.pnlPhongTrong.PerformLayout();
            this.pnlDoanhThu.ResumeLayout(false);
            this.pnlDoanhThu.PerformLayout();
            this.pnlChart.ResumeLayout(false);
            this.ResumeLayout(false);
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
