create proc sp_UpdateHoaDonNhap
@MaHDN VARCHAR(10),
@NgayNhap DATE,
@NgayNhan DATE,
@MaNV VARCHAR(10),
@MaKho VARCHAR(10),
@TrangThai NVARCHAR(50),
@TongTien INT
as
update HoaDonNhap
set NgayNhap = @NgayNhap,
NgayNhan = @NgayNhan,
MaNV = @MaNV,
MaKho = @MaKho,
TrangThai = @TrangThai, 
TongTien = @TongTien
where MaHDN = @MaHDN