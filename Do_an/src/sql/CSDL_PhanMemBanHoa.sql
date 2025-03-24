CREATE DATABASE QuanLyBanHang;
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
    LoaiSP NVARCHAR(50) NOT NULL,
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
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);
GO
INSERT INTO NhanVien (TenNV, TenDangNhap, MatKhau, SoDienThoai, Email, DiaChi, ChucVu, TrangThai)
VALUES (N'Đỗ Minh Nhật', 'admin', '123', '03306231316', '0306231316@caothang.edu.vn', N'Bình Phước', N'Quản Lý', 1)
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
select * from NhanVien where TenDangNhap = '' and MatKhau = N'' or 1=1--'