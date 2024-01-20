create proc sp_InsertChiTietXuat
@MaHDX VARCHAR(10),
@MaSach VARCHAR(50),
@SoLuong INT,
@DonGia INT
as
insert into ChiTiet_HDX(MaHDX, MaSach, SoLuong, DonGia)
values (@MaHDX, @MaSach, @SoLuong, @DonGia)