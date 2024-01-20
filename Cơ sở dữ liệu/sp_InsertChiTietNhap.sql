create proc sp_InsertChiTietNhap
@MaHDN VARCHAR(10),
@MaSach VARCHAR(50),
@SoLuong INT,
@DonGia INT
as
insert into ChiTiet_HDN(MaHDN, MaSach, SoLuong, DonGia)
values (@MaHDN, @MaSach, @SoLuong, @DonGia)