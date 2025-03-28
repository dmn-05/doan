﻿CREATE DATABASE QuanLyBanHang;
GO
USE QuanLyBanHang;
GO

-- Bảng Khách hàng
CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY IDENTITY NOT NULL,
    TenKH NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15) UNIQUE NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    DiaChi NVARCHAR(255) NOT NULL
);

-- Bảng Sản phẩm
CREATE TABLE SanPham (
    MaSP INT PRIMARY KEY IDENTITY NOT NULL,
    TenSP NVARCHAR(100) NOT NULL,
	GiaBanLe DECIMAL(18,2) NOT NULL,
	GiaNhap DECIMAL(18,2) NOT NULL,
	GiaXuat DECIMAL(18,2) NOT NULL,
    SoLuongTonKho INT CHECK (SoLuongTonKho >= 0) NOT NULL
);

-- Bảng Nhân viên
CREATE TABLE NhanVien (
    MaNV INT PRIMARY KEY IDENTITY NOT NULL,
    TenNV NVARCHAR(100) NOT NULL,
	TenDangNhap VARCHAR(50) UNIQUE NOT NULL,
	MatKhau VARCHAR(50) NOT NULL,
    SoDienThoai VARCHAR(15) UNIQUE NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    DiaChi NVARCHAR(255) NOT NULL,
    ChucVu NVARCHAR(50) NOT NULL,
	TrangThai INT NOT NULL
);

-- Bảng Hóa đơn
CREATE TABLE HoaDon (
    MaHD INT PRIMARY KEY IDENTITY NOT NULL,
    MaNV INT NOT NULL,
    MaKH INT NOT NULL,
    NgayLapHoaDon DATETIME DEFAULT GETDATE(),
    TrangThai NVARCHAR(50) NOT NULL,
    DiaChiGiao NVARCHAR(255) NOT NULL,
    ThanhTien DECIMAL(18,2) CHECK (ThanhTien >= 0) NOT NULL,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);

-- Bảng Chi tiết hóa đơn
CREATE TABLE ChiTietHoaDon (
    MaHD INT NOT NULL,
    MaSP INT NOT NULL,
    SoLuong INT CHECK (SoLuong > 0) NOT NULL,
    PRIMARY KEY (MaHD, MaSP),
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD) ON DELETE CASCADE,
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

-- Bảng Nhập hàng
CREATE TABLE NhapHang (
    MaHDNhap INT PRIMARY KEY IDENTITY NOT NULL,
    NgayNhap DATETIME DEFAULT GETDATE(),
    MaSP INT NOT NULL,
    SoLuong INT CHECK (SoLuong > 0) NOT NULL,
	ThanhTien DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);
-- Bảng xuất hàng
CREATE TABLE XuatHang (
    MaHDXuat INT PRIMARY KEY IDENTITY NOT NULL,
    NgayXuat DATETIME DEFAULT GETDATE(),
    MaSP INT NOT NULL,
    SoLuong INT CHECK (SoLuong > 0) NOT NULL,
	ThanhTien DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);
GO
INSERT INTO NhanVien (TenNV, TenDangNhap, MatKhau, SoDienThoai, Email, DiaChi, ChucVu, TrangThai)
VALUES 
(N'Đỗ Minh Nhật', 'admin', '123', '03306231316', '0306231316@caothang.edu.vn', N'Bình Phước', N'Quản Lý', 1),
(N'Bùi Minh Quân', 'bmquan', '123', '03306231328', '0306231328@caothang.edu.vn', N'TP HCM', N'Giám Đốc', 1),
(N'Đỗ Quốc Trung', 'dqtrung', '123', '03306231346', '0306231346@caothang.edu.vn', N'Bình Thuận', N'Phó Giám Đốc', 1),
(N'Đỗ Ngọc Thế', 'dnthe', '123', '03306231335', '0306231335@caothang.edu.vn', N'Cà Mau', N'Nhân Viên', 1),
(N'Nguyễn Thái Nguyên', 'ntnguyen', '123', '03306231313', '0306231313@caothang.edu.vn', N'Long An', N'Bảo Vệ', 1);
GO
INSERT INTO KhachHang (TenKH, SoDienThoai, Email, DiaChi)
VALUES 
    (N'Nguyễn Vương Anh', '0987654321', 'nva@example.com', N'123 Phố Hoàng Văn Thụ, Phường Quán Thánh, Quận Ba Đình, TP Hà Nội'),
    (N'Trần Thị Bình', '0978123456', 'ttb@example.com', N'456 Đường Nguyễn Văn Sỹ, Phường 14,  Quận 3, TP.Hồ Chí Minh'),
    (N'Lê Văn Chiến', '0912233445', 'lvc@example.com', N'789 Đường Đoàn Thị Điểm, Phường Hải Châu 2, Quận Hải Châu, TP  Đà Nẵng'),
    (N'Phạm Thị Dung', '0905566778', 'ptd@example.com', N'321 Phố Hai Bà Trưng, Cát Dài, Lê Chân, Hải Phòng'),
    (N'Hoàng Văn Minh', '0923344556', 'hvm@example.com', N'654 Đường Ngô Quyền, Phường Tây An, Quận Ninh Kiều, TP Cần Thơ');
GO
INSERT INTO SanPham (TenSP, GiaBanLe, GiaNhap, GiaXuat, SoLuongTonKho)
VALUES 
    (N'Hoa Hồng', 50000, 30000, 40000, 100),
    (N'Hoa Cúc', 30000, 15000, 20000, 150),
    (N'Hoa Lan', 120000, 80000, 100000, 50),
    (N'Hoa Ly', 90000, 60000, 75000, 70),
    (N'Hoa Tulip', 150000, 110000, 130000, 30);
GO
CREATE PROC USP_GetAccountByUserName
@username NVARCHAR(100)
AS
BEGIN
	SELECT * FROM NHANVIEN WHERE TenDangNhap = @username
END
GO
CREATE PROC USP_Login
@username NVARCHAR(100), @password NVARCHAR(100)
AS
BEGIN
	SELECT * FROM NHANVIEN WHERE TenDangNhap = @username AND MatKhau = @password
END
GO
CREATE PROC USP_Login_Admin
@username NVARCHAR(100), @password NVARCHAR(100)
AS
BEGIN
	SELECT * FROM NHANVIEN WHERE TenDangNhap = @username AND MatKhau = @password AND ChucVu = N'Quản Lý'
END
