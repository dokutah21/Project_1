create proc sp_UpdateNhanVien
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
as
Update NhanVien
set HoTen = @HoTen,
QuocTich = @QuocTich,
DanToc = @DanToc,
GioiTinh = @GioiTinh,
NgaySinh = @NgaySinh,
ChucVu = @ChucVu,
QueQuan = @QueQuan,
SoDienThoai = @SoDienThoai,
CCCD = @CCCD,
Email = @Email,
DiaChiHienTai = @DiaChiHienTai,
MaKV = @MaKV
where MaNV = @MaNV