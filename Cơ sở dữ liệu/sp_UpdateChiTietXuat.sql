create proc sp_UpdateChiTietXuat
@MaHDX VARCHAR(10),
@MaSach VARCHAR(50),
@SoLuong INT,
@DonGia INT
as
update ChiTiet_HDX
set MaSach = @MaSach,
SoLuong = @SoLuong,
DonGia = @DonGia
where MaHDX = @MaHDX