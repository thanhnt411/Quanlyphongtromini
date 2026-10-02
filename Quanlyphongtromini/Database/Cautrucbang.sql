CREATE DATABASE QLPhongTro;
GO
 
USE QLPhongTro;
GO
 
-- 1. Bảng PhongTro

CREATE TABLE PhongTro (
    MaPhong     NVARCHAR(50)    PRIMARY KEY,           -- Mã phòng
    TenPhong    NVARCHAR(50),                          -- Tên phòng
    DienTich    FLOAT,                                 -- Diện tích (m^2)
    GiaPhong    DECIMAL(10,0),                         -- Giá phòng / 1 tháng
    ToiDa       INT,                                   -- Số người tối đa
    TrangThai   NVARCHAR(20)
                CHECK (TrangThai IN (N'Đang thuê', N'Trống'))
);
GO
 

-- 2. Bảng NguoiThue

CREATE TABLE NguoiThue (
    MaNguoi     NVARCHAR(50)    PRIMARY KEY,           -- Mã người thuê
    Hoten       NVARCHAR(50),                          -- Họ tên
    Sdt         NVARCHAR(10),                          -- Số điện thoại
    Cccd        NVARCHAR(15),                          -- CCCD
    DiaChi      NVARCHAR(100)                          -- Địa chỉ thường trú
);
GO
 

-- 3. Bảng HopDong

CREATE TABLE HopDong (
    MaHD        NVARCHAR(50)    PRIMARY KEY,           -- Mã hợp đồng
    MaPhong     NVARCHAR(50)    FOREIGN KEY REFERENCES PhongTro(MaPhong),   -- Mã phòng (từ PhongTro)
    MaNguoi     NVARCHAR(50)    FOREIGN KEY REFERENCES NguoiThue(MaNguoi),  -- Mã người (từ NguoiThue)
    DayStart    DATETIME,                              -- Ngày bắt đầu
    DayEnd      DATETIME,                               -- Ngày kết thúc
    TrangThai   NVARCHAR(20)
                CHECK (TrangThai IN (N'Còn hạn', N'Hết hạn')),
    TienCoc     DECIMAL(10,0)                          -- Tiền cọc
);
GO
 

-- 4. Bảng HoaDon

CREATE TABLE HoaDon (
    MaHoaDon    NVARCHAR(50)    PRIMARY KEY,           -- Mã hóa đơn
    MaHD        NVARCHAR(50)    FOREIGN KEY REFERENCES HopDong(MaHD),      -- Mã hợp đồng (từ HopDong)
    MaPhong     NVARCHAR(50)    FOREIGN KEY REFERENCES PhongTro(MaPhong),  -- Mã phòng (từ PhongTro)
    ThoiGian    DATETIME,                              -- Hóa đơn của tháng/năm
    DienCu      INT,                                   -- Số điện cũ
    DienMoi     INT,                                   -- Số điện mới
    PhiDV       INT,                                   -- Tiền dịch vụ
    NuocCu      INT,                                   -- Số khối nước cũ
    NuocMoi     INT,                                   -- Số khối nước mới
    Tong        DECIMAL(10,0),                         -- Tổng tiền phải đóng
    TrangThai   NVARCHAR(20)
                CHECK (TrangThai IN (N'Đã thu', N'Chưa thu')),

    CONSTRAINT CK_HoaDon_DienMoi CHECK (DienMoi >= DienCu),
    CONSTRAINT CK_HoaDon_NuocMoi CHECK (NuocMoi >= NuocCu)
);
GO
