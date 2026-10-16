using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Quanlyphongtromini.UserControls
{
    public partial class DashboardControl : UserControl
    {
        private const string connectionString =
            @"Data Source=localhost;Initial Catalog=QLPhongTro;User ID=sa;password = 123456; Trust Server Certificate=True;";
        // ================= LẤY DỮ LIỆU TỪ DB =================

        public void LoadDashboard()
        {
            try
            {
                int tong = 0, dangThue = 0, trong = 0;
                decimal doanhThu = 0;
                DataTable tbTheoPhong = new DataTable();
                int thang = DateTime.Now.Month;
                int nam = DateTime.Now.Year;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    //b1 thong ke phong tro
                    string sqlPhong =
                        "SELECT COUNT(*) AS Tong, " +
                        "ISNULL(SUM(CASE WHEN TrangThai = N'Đang thuê' THEN 1 ELSE 0 END), 0) AS DangThue, " +
                        "ISNULL(SUM(CASE WHEN TrangThai = N'Trống' THEN 1 ELSE 0 END), 0) AS Trong " +
                        "FROM PhongTro";
                    using (SqlCommand cmd = new SqlCommand(sqlPhong, conn))
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            tong = Convert.ToInt32(rd["Tong"]);
                            dangThue = Convert.ToInt32(rd["DangThue"]);
                            trong = Convert.ToInt32(rd["Trong"]);
                        }
                    }

                    //b2 doanh thu thang hien tai (chi tinh hoa don DA THU)
                    string sqlDT =
                        "SELECT ISNULL(SUM(Tong), 0) FROM HoaDon " +
                        "WHERE MONTH(ThoiGian) = @thang AND YEAR(ThoiGian) = @nam " +
                        "AND TrangThai = N'Đã thu'";
                    using (SqlCommand cmd = new SqlCommand(sqlDT, conn))
                    {
                        cmd.Parameters.Add("@thang", SqlDbType.Int).Value = thang;
                        cmd.Parameters.Add("@nam", SqlDbType.Int).Value = nam;
                        doanhThu = Convert.ToDecimal(cmd.ExecuteScalar());
                    }

                    //b3 doanh thu theo tung phong trong thang
                    string sqlTheoPhong =
                        "SELECT MaPhong, SUM(Tong) AS DoanhThu FROM HoaDon " +
                        "WHERE MONTH(ThoiGian) = @thang AND YEAR(ThoiGian) = @nam " +
                        "AND TrangThai = N'Đã thu' " +
                        "GROUP BY MaPhong";
                    using (SqlCommand cmd = new SqlCommand(sqlTheoPhong, conn))
                    {
                        cmd.Parameters.Add("@thang", SqlDbType.Int).Value = thang;
                        cmd.Parameters.Add("@nam", SqlDbType.Int).Value = nam;
                        new SqlDataAdapter(cmd).Fill(tbTheoPhong);
                    }
                }

                //b4 do du lieu len 4 the
                lblTongPhong.Text = tong.ToString();
                lblDangThue.Text = dangThue.ToString();
                lblPhongTrong.Text = trong.ToString();
                lblDoanhThu.Text = DinhDangTien(doanhThu);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không tải được dữ liệu tổng quan: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string DinhDangTien(decimal tien)
        {
            if (tien >= 1000000)
                return (tien / 1000000m).ToString("0.##", CultureInfo.InvariantCulture) + "tr";
            if (tien >= 1000)
                return (tien / 1000m).ToString("0.##", CultureInfo.InvariantCulture) + "k";
            return tien.ToString("0");
        }
    }
}
 