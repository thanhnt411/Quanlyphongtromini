using System.Data;
using System.Globalization;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Quanlyphongtromini.UserControls
{
    public partial class BaoCaoControl : UserControl
    {
        private const string ConnStr =
              //@"Data Source=localhost;Initial Catalog=QLPhongTro;User ID=sa;Password=123456;TrustServerCertificate=True";
              @"Server=localhost\SQLEXPRESS;Database=QlPhongTro;Trusted_Connection=True;TrustServerCertificate=True;";
        private static readonly CultureInfo ViVN = new("vi-VN");
        private readonly Font _fontDam = new("Segoe UI", 9F, FontStyle.Bold);

        public BaoCaoControl()
        {
            InitializeComponent();

            btnXem.Click += (s, e) => XemBaoCao();
            dgvBaoCao.CellFormatting += DgvBaoCao_CellFormatting;
            Load += BaoCaoControl_Load;

            // Căn phải các cột số
            foreach (var col in new[] { colDien, colNuoc, colPhiDV, colTongTien })
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void BaoCaoControl_Load(object? sender, EventArgs e)
        {
            if (DesignMode) return;

            NapDanhSachPhong();
            cboTrangThai.SelectedIndex = 0;
            XemBaoCao();
        }

        // Chạy câu SQL và trả về DataTable
        private static DataTable LayBang(string sql, params SqlParameter[] ps)
        {
            using var da = new SqlDataAdapter(sql, ConnStr);
            da.SelectCommand.Parameters.AddRange(ps);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // ====== Nạp combobox phòng ======
        private void NapDanhSachPhong()
        {
            try
            {
                DataTable dt = LayBang("SELECT MaPhong, TenPhong FROM PhongTro ORDER BY TenPhong");

                // Dòng đầu tiên: "Tất cả phòng" (MaPhong = null)
                DataRow tatCa = dt.NewRow();
                tatCa["TenPhong"] = "Tất cả phòng";
                dt.Rows.InsertAt(tatCa, 0);

                cboPhong.DataSource = dt;
                cboPhong.DisplayMember = "TenPhong";
                cboPhong.ValueMember = "MaPhong";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách phòng:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====== Xem báo cáo ======
        private void XemBaoCao()
        {
            // Null = không lọc
            object maPhong = cboPhong.SelectedValue ?? DBNull.Value;
            object trangThai = cboTrangThai.SelectedIndex <= 0 ? DBNull.Value : cboTrangThai.Text;

            const string sql = @"
SELECT hd.MaHoaDon,
       p.TenPhong,
       ISNULL(nt.Hoten, N'')                        AS Hoten,
       ISNULL(FORMAT(hd.ThoiGian, 'MM/yyyy'), '')   AS ThangNam,
       ISNULL(hd.DienMoi - hd.DienCu, 0)            AS SoDien,
       ISNULL(hd.NuocMoi - hd.NuocCu, 0)            AS SoNuoc,
       ISNULL(hd.PhiDV, 0)                          AS PhiDV,
       ISNULL(hd.Tong, 0)                           AS Tong,
       hd.TrangThai
FROM HoaDon hd
JOIN PhongTro p        ON p.MaPhong  = hd.MaPhong
LEFT JOIN HopDong h    ON h.MaHD     = hd.MaHD
LEFT JOIN NguoiThue nt ON nt.MaNguoi = h.MaNguoi
WHERE (@MaPhong IS NULL OR hd.MaPhong = @MaPhong)
  AND (@TrangThai IS NULL OR hd.TrangThai = @TrangThai)
ORDER BY hd.ThoiGian DESC, p.TenPhong";

            DataTable dt;
            try
            {
                dt = LayBang(sql,
                    new SqlParameter("@MaPhong", maPhong),
                    new SqlParameter("@TrangThai", trangThai));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được báo cáo:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Đổ dữ liệu vào bảng + cộng tổng cho 3 thẻ
            decimal tong = 0, daThu = 0;
            dgvBaoCao.Rows.Clear();

            foreach (DataRow r in dt.Rows)
            {
                decimal tien = Convert.ToDecimal(r["Tong"]);
                tong += tien;
                if (r["TrangThai"].ToString() == "Đã thu") daThu += tien;

                dgvBaoCao.Rows.Add(
                    r["MaHoaDon"], r["TenPhong"], r["Hoten"], r["ThangNam"],
                    So(r["SoDien"]), So(r["SoNuoc"]), So(r["PhiDV"]), So(tien),
                    r["TrangThai"]);
            }
            dgvBaoCao.ClearSelection();

            lblTongThu.Text = RutGonTien(tong);
            lblDaThu.Text = RutGonTien(daThu);
            lblConNo.Text = RutGonTien(tong - daThu);
        }

        // 1500000 -> "1.500.000"
        private static string So(object v) => Convert.ToDecimal(v).ToString("N0", ViVN);

        // 6130000 -> "6.13tr", 450000 -> "450k"
        private static string RutGonTien(decimal v)
        {
            if (Math.Abs(v) >= 1_000_000m) return (v / 1_000_000m).ToString("0.00", CultureInfo.InvariantCulture) + "tr";
            if (Math.Abs(v) >= 1_000m) return (v / 1_000m).ToString("0.#", CultureInfo.InvariantCulture) + "k";
            return v.ToString("0");
        }

        // Tô màu cột Trạng thái: Đã thu = xanh, Chưa thu = đỏ
        private void DgvBaoCao_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colTrangThai.Index) return;

            bool daThu = e.Value?.ToString() == "Đã thu";
            e.CellStyle.ForeColor = daThu ? Color.FromArgb(15, 118, 110) : Color.FromArgb(185, 28, 28);
            e.CellStyle.Font = _fontDam;
        }

        // ====== Xuất CSV (mở được bằng Excel, giữ tiếng Việt) ======
        // Gắn vào một nút bất kỳ: btnXuat.Click += (s, e) => XuatCsv();
        public void XuatCsv()
        {
            if (dgvBaoCao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.");
                return;
            }

            using var dlg = new SaveFileDialog
            {
                Filter = "CSV (*.csv)|*.csv",
                FileName = $"BaoCao_{DateTime.Now:yyyyMMdd_HHmm}.csv"
            };
            if (dlg.ShowDialog() != DialogResult.OK) return;

            static string Q(object? v) => "\"" + v?.ToString()?.Replace("\"", "\"\"") + "\"";

            var dong = new List<string>
            {
                string.Join(",", dgvBaoCao.Columns.Cast<DataGridViewColumn>().Select(c => Q(c.HeaderText)))
            };
            foreach (DataGridViewRow row in dgvBaoCao.Rows)
                dong.Add(string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(c => Q(c.Value))));

            File.WriteAllLines(dlg.FileName, dong, new UTF8Encoding(true));
            MessageBox.Show("Đã xuất báo cáo thành công.");
        }
    }
}