create proc sp_InsertHoaDonNhap
@MaHDN VARCHAR(10),
@NgayNhap DATE,
@NgayNhan DATE,
@MaNV VARCHAR(10),
@MaKho VARCHAR(10),
@TrangThai NVARCHAR(50),
@TongTien INT
as
insert into HoaDonNhap(MaHDN, NgayNhap, NgayNhan, MaNV, MaKho, TrangThai, TongTien)
values (@MaHDN, @NgayNhap, @NgayNhan, @MaNV, @MaKho, @TrangThai, @TongTien)