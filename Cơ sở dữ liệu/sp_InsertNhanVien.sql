CREATE PROC sp_InsertNhanVien
@MaNV VARCHAR(10),
@HoTen NVARCHAR(100),
@QuocTich NVARCHAR(100),
@DanToc NVARCHAR(100),
@GioiTinh NVARCHAR(3),
@NgaySinh DATE,
@ChucVu NVARCHAR(100),
@QueQuan NVARCHAR(100),
@SoDienThoai CHAR(10),
@CCCD CHAR(12),
@Email VARCHAR(100),
@DiaChiHienTai NVARCHAR(100),
@MaKV NVARCHAR(100)
AS
INSERT INTO NhanVien(MaNV, HoTen, QuocTich, DanToc, GioiTinh, NgaySinh, ChucVu, QueQuan, SoDienThoai, CCCD, Email, DiaChiHienTai, MaKV)
VALUES(@MaNV, @HoTen, @QuocTich, @DanToc, @GioiTinh, @NgaySinh, @ChucVu, @QueQuan, @SoDienThoai, @CCCD, @Email, @DiaChiHienTai, @MaKV)