create proc sp_UpdateChiTietNhap
@MaHDN VARCHAR(10),
@MaSach VARCHAR(50),
@SoLuong INT,
@DonGia INT
as
update ChiTiet_HDN
set MaSach = @MaSach,
SoLuong = @SoLuong,
DonGia = @DonGia
where MaHDN = @MaHDN