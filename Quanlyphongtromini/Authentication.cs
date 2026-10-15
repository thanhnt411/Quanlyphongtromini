using Microsoft.Data.SqlClient;
using System;
using System.Diagnostics;

namespace Quanlyphongtromini.Services
{
    public static class AuthService
    {
        private const string connectionString =
           @"Data Source=DESKTOP-GNHSIT6\SQLEXPRESS;Initial Catalog=QuanLyPhongTroMini3;Integrated Security=True;Trust Server Certificate=True";
        // Tên người đang đăng nhập (null = chưa đăng nhập); MainForm đọc để hiện ở sidebar
        public static string TenDangNhap { get; private set; }

        public static void Logout() => TenDangNhap = null;

        public static string Register(string tenDangNhap, string email, string soDienThoai, string matKhau)
        {
            tenDangNhap = (tenDangNhap ?? "").Trim();
            email = (email ?? "").Trim();
            soDienThoai = (soDienThoai ?? "").Trim();

            if (tenDangNhap == "" || email == "" || string.IsNullOrEmpty(matKhau))
                return "Vui lòng nhập đầy đủ thông tin.";
            if (soDienThoai.Length > 10)
                return "Số điện thoại tối đa 10 số.";

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();

                // 1. Kiểm tra trùng để báo lỗi đúng chỗ
                bool trungTen = false, trungEmail = false;
                using (var check = new SqlCommand(
                    "SELECT TenDangNhap, Email FROM TaiKhoan3 WHERE TenDangNhap = @u OR Email = @e", conn))
                {
                    check.Parameters.AddWithValue("@u", tenDangNhap);
                    check.Parameters.AddWithValue("@e", email);
                    using var r = check.ExecuteReader();
                    while (r.Read())
                    {
                        if (string.Equals(r.GetString(0), tenDangNhap, StringComparison.OrdinalIgnoreCase)) trungTen = true;
                        // Email trong bảng cho phép NULL nên phải kiểm tra trước khi đọc
                        if (!r.IsDBNull(1) && string.Equals(r.GetString(1), email, StringComparison.OrdinalIgnoreCase)) trungEmail = true;
                    }
                }
                if (trungTen) return "Tên đăng nhập đã tồn tại.";
                if (trungEmail) return "Email đã được sử dụng.";

                // 2. Lưu tài khoản
                using var insert = new SqlCommand(
                    "INSERT INTO TaiKhoan3 (TenDangNhap, Email, SoDienThoai, MatKhau) VALUES (@u, @e, @s, @m)", conn);
                insert.Parameters.AddWithValue("@u", tenDangNhap);
                insert.Parameters.AddWithValue("@e", email);
                insert.Parameters.AddWithValue("@s", soDienThoai);
                insert.Parameters.AddWithValue("@m", matKhau);
                insert.ExecuteNonQuery();
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return "Lỗi hệ thống: " + ex.Message;
            }
        }

        public static string Login(string tenDangNhap, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrEmpty(matKhau))
                return "Vui lòng nhập tên đăng nhập và mật khẩu.";

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();
                using var cmd = new SqlCommand(
                    "SELECT TenDangNhap, MatKhau FROM TaiKhoan3 WHERE TenDangNhap = @u", conn);
                cmd.Parameters.AddWithValue("@u", tenDangNhap.Trim());
                using var r = cmd.ExecuteReader();

                // So mật khẩu trong C# (phân biệt hoa/thường). Nếu so trong SQL thì
                // SQL Server mặc định KHÔNG phân biệt hoa/thường, "ABC" sẽ khớp "abc".
                if (!r.Read() || r.IsDBNull(1) || !string.Equals(r.GetString(1), matKhau, StringComparison.Ordinal))
                    return "Sai tên đăng nhập hoặc mật khẩu.";

                TenDangNhap = r.GetString(0);
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return "Lỗi hệ thống: " + ex.Message;
            }
        }
    }
}