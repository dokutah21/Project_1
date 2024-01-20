CREATE DATABASE QuanLySach

USE QuanLySach

GO

CREATE TABLE Account
(
    TenTK NVARCHAR(100) PRIMARY KEY NOT NULL,
    Password VARCHAR(100) NOT NULL
)

CREATE TABLE KhuVuc
(
    MaKV NVARCHAR(100) PRIMARY KEY,
    TenKV NVARCHAR(100),
    DiaChi NVARCHAR(100)
)

CREATE TABLE NhanVien
(
    MaNV VARCHAR(10) PRIMARY KEY NOT NULL,
    HoTen NVARCHAR(100),
    QuocTich NVARCHAR(100),
    DanToc NVARCHAR(100),
    GioiTinh NVARCHAR(3),
    NgaySinh DATE,
    ChucVu NVARCHAR(100),
    QueQuan NVARCHAR(100),
    SoDienThoai CHAR(10),
    CCCD CHAR(12),
    Email VARCHAR(100),
    DiaChiHienTai NVARCHAR(100),
    MaKV NVARCHAR(100) FOREIGN KEY REFERENCES KhuVuc(MaKV)
)

CREATE TABLE TheLoaiSach
(
    MaTL VARCHAR(10) PRIMARY KEY,
    TenTL NVARCHAR(100)
)

CREATE TABLE Sach
(
    MaSach VARCHAR(50) PRIMARY KEY,
    TenSach NVARCHAR(100),
    MaTL VARCHAR(10) FOREIGN KEY REFERENCES TheLoaiSach(MaTL),
    DonGia INT,
    TrangThai NVARCHAR(50),
    NgayTao DATE
)

CREATE TABLE Kho
(
    MaKho VARCHAR(10) PRIMARY KEY,
    TenKho NVARCHAR(100),
    DiaChi NVARCHAR(100),
    MaNV VARCHAR(10) FOREIGN KEY REFERENCES NhanVien(MaNV),
    TrangThai NVARCHAR(100)
)

CREATE TABLE HoaDonNhap
(
    MaHDN VARCHAR(10) PRIMARY KEY,
    NgayNhap DATE,
    NgayNhan DATE,
    MaNV VARCHAR(10) FOREIGN KEY REFERENCES NhanVien(MaNV),
    MaKho VARCHAR(10) FOREIGN KEY REFERENCES Kho(MaKho),
    TrangThai NVARCHAR(50),
    TongTien INT
)

CREATE TABLE ChiTiet_HDN
(
    MaHDN VARCHAR(10) FOREIGN KEY REFERENCES HoaDonNhap(MaHDN),
    MaSach VARCHAR(50) FOREIGN KEY REFERENCES Sach(MaSach),
    SoLuong INT,
    DonGia INT
)

CREATE TABLE HoaDonXuat
(
    MaHDX VARCHAR(10) PRIMARY KEY,
    NgayXuat DATE,
    NgayNhan DATE,
    MaNV VARCHAR(10) FOREIGN KEY REFERENCES NhanVien(MaNV),
    MaKho VARCHAR(10) FOREIGN KEY REFERENCES Kho(MaKho),
	TrangThai NVARCHAR(50),
	TongTien INT
)

CREATE TABLE ChiTiet_HDX
(
    MaHDX VARCHAR(10) FOREIGN KEY REFERENCES HoaDonXuat(MaHDX),
    MaSach VARCHAR(50) FOREIGN KEY REFERENCES Sach(MaSach),
    SoLuong INT,
	DonGia INT
)

INSERT INTO TheLoaiSach(MaTL, TenTL) 
VALUES ('TT001', 'Manga')
INSERT INTO TheLoaiSach(MaTL, TenTL)
VALUES ('BL001', 'Boys Love')
INSERT INTO TheLoaiSach(MaTL, TenTL)
VALUES ('BS001', 'Box Set')
INSERT INTO TheLoaiSach(MaTL, TenTL)
VALUES ('NV001', N'Tiểu Thuyết')

SELECT*FROM TheLoaiSach

INSERT INTO Sach(MaSach, TenSach ,MaTL ,DonGia ,TrangThai ,NgayTao)
VALUES ('8935250709866', N'Cô gái nơi xứ ngoài', 'TT001', 49300, N'Còn hàng', '01/30/2023')
INSERT INTO Sach(MaSach, TenSach ,MaTL ,DonGia ,TrangThai ,NgayTao)
VALUES ('8935250709156', N'Chỉ những vì sao mới tỏ','BL001', 72250, N'Còn hàng', '02/01/2023')

SELECT*FROM Sach

INSERT INTO KhuVuc(MaKV, TenKV, DiaChi)
VALUES ('HY89', N'Hưng Yên', N'TP Hưng Yên')
INSERT INTO KhuVuc(MaKV, TenKV, DiaChi)
VALUES('HN29', N'Hà Nội', N'Thạch Thất')
INSERT INTO KhuVuc(MaKV, TenKV, DiaChi)
VALUES('BG98', N'Dĩnh Khế', N'Bắc Giang')
INSERT INTO KhuVuc(MaKV, TenKV, DiaChi)
VALUES('HCM50', N'Hồ Chí Minh', N'TP Hồ Chí Minh')
INSERT INTO KhuVuc(MaKV, TenKV, DiaChi)
VALUES('DN48', N'Đà Nẵng', N'TP Đà Nẵng')

SELECT*FROM KhuVuc



INSERT INTO NhanVien(MaNV, HoTen, QuocTich, DanToc, GioiTinh, NgaySinh, ChucVu, QueQuan, SoDienThoai, CCCD, Email, DiaChiHienTai, MaKV)
VALUES ('NV001', N'Nguyễn Khánh Huyền', N'Việt Nam', N'Kinh', N'Nữ', '09/21/2003', N'Quản lý', N'Hưng Yên', '0913377629', '033303006006', N'nguyenhuyen21903@gmai.com', N'Lê Lợi - Hưng Yên - Hưng Yên', 'HY89')
INSERT INTO NhanVien(MaNV, HoTen, QuocTich, DanToc, GioiTinh, NgaySinh, ChucVu, QueQuan, SoDienThoai, CCCD, Email, DiaChiHienTai, MaKV)
VALUES('NV002', N'Nguyễn Phương Anh', N'Việt Nam', N'Kinh', N'Nữ', '11/11/2003', N'Nhân viên', N'Hưng Yên', '0916489624', '038303916006', N'nguyenanh11@gmai.com', N'Nhân Hòa - Mĩ Hào - Hưng Yên', 'HY89')
INSERT INTO NhanVien(MaNV, HoTen, QuocTich, DanToc, GioiTinh, NgaySinh, ChucVu, QueQuan, SoDienThoai, CCCD, Email, DiaChiHienTai, MaKV)
VALUES('NV003', N'Đỗ Hoàng Nhật', N'Việt Nam', N'Kinh', N'Nam', '02/19/2003', N'Nhân viên', N'Hà Nội', '0918480614', '048313936016', N'dochanta03@gmai.com', N'Thạch Hòa - Thạch Thất - Hà Nội', 'HN29')

SELECT*FROM NhanVien


INSERT INTO Kho(MaKho, TenKho, DiaChi, MaNV, TrangThai)
VALUES ('CS01', N'Kho sách Nguyễn Thiện Thuật - Cơ Sở 1', N'Lê Lợi - Hưng Yên - Hưng Yên', 'NV001' ,N'Còn hàng')
INSERT INTO Kho(MaKho, TenKho, DiaChi, MaNV, TrangThai)
VALUES ('CS02', N'Kho sách Điện Biên - Cơ Sở 2', N'Lê Lợi - Hưng Yên - Hưng Yên', 'NV002' ,N'Hết hàng')

SELECT*FROM Kho

--DELETE FROM Kho

INSERT INTO HoaDonNhap(MaHDN, NgayNhap, NgayNhan, MaNV, MaKho, TrangThai, TongTien)
VALUES ('HDN001', '04/25/2023', '04/25/2023','NV001','CS01', N'Đủ mặt hàng', 15750389)
INSERT INTO HoaDonNhap(MaHDN, NgayNhap, NgayNhan, MaNV, MaKho, TrangThai, TongTien)
VALUES ('HDN002', '06/17/2023', '06/17/2023', 'NV002','CS02', N'Thiếu mặt hàng', 10126984)

SELECT*FROM HoaDonNhap

--DELETE FROM HoaDonNhap

INSERT INTO HoaDonXuat(MaHDX, NgayXuat, NgayNhan, MaNV, MaKho, TrangThai, TongTien)
VALUES ('HDX001', '04/25/2023', '04/25/2023','NV001','CS01', N'Đủ mặt hàng', 15750389)
INSERT INTO HoaDonXuat(MaHDX, NgayXuat, NgayNhan, MaNV, MaKho, TrangThai, TongTien)
VALUES ('HDX002', '06/17/2023', '06/17/2023', 'NV002','CS02', N'Thiếu mặt hàng', 10126984)

SELECT*FROM HoaDonXuat

--DELETE FROM HoaDonXuat