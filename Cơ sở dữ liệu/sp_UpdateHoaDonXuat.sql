create proc sp_UpdateHoaDonXuat
@MaHDX VARCHAR(10),
@NgayXuat DATE,
@NgayNhan DATE,
@MaNV VARCHAR(10),
@MaKho VARCHAR(10),
@TrangThai NVARCHAR(50),
@TongTien INT
as
update HoaDonXuat
set NgayXuat = @NgayXuat,
NgayNhan = @NgayNhan,
MaNV = @MaNV,
MaKho = @MaKho,
TrangThai = @TrangThai, 
TongTien = @TongTien
where MaHDX = @MaHDX