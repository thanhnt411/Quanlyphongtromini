using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

    

namespace Quanlyphongtromini.UserControls
{
    public partial class DashboardControl : UserControl
    {

        private const string connectionString =
             @"Data Source=LAPTOP-71REBECI;Initial Catalog=QLPhongTro;Integrated Security=True;TrustServerCertificate=True";

        public DashboardControl()
        {
            InitializeComponent();
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;     // tránh lỗi khi mở ở Designer
            LoadThongKe();
        }
        public void LoadThongKe()
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    int tongPhong = LayInt(conn, "SELECT COUNT(*) FROM PhongTro");
                    int dangThue = LayInt(conn, "SELECT COUNT(DISTINCT MaPhong) FROM HopDong WHERE RTRIM(TrangThai) = N'Còn hạn'");
                    decimal doanhThu = LayDecimal(conn,
                        @"SELECT ISNULL(SUM(Tong), 0) FROM HoaDon
                          WHERE MONTH(ThoiGian) = MONTH(GETDATE()) AND YEAR(ThoiGian) = YEAR(GETDATE())");

                    lblTongPhong.Text = tongPhong.ToString();
                    lblDangThue.Text = dangThue.ToString();
                    lblPhongTrong.Text = (tongPhong - dangThue).ToString();
                    lblDoanhThu.Text = DinhDangTien(doanhThu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thống kê: " + ex.Message);
            }
        }

        private int LayInt(SqlConnection conn, string sql)
        {
            using (var cmd = new SqlCommand(sql, conn))
                return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private decimal LayDecimal(SqlConnection conn, string sql)
        {
            using (var cmd = new SqlCommand(sql, conn))
                return Convert.ToDecimal(cmd.ExecuteScalar());
        }

        private string DinhDangTien(decimal tien)
        {
            if (tien >= 1_000_000)
                return (tien / 1_000_000).ToString("0.##") + "tr";    // 6130000 -> 6.13tr
            return tien.ToString("N0");
        }
    }
}
