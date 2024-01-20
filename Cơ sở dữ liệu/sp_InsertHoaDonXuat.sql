create proc sp_InsertHoaDonXuat
@MaHDX VARCHAR(10),
@NgayXuat DATE,
@NgayNhan DATE,
@MaNV VARCHAR(10),
@MaKho VARCHAR(10),
@TrangThai NVARCHAR(50),
@TongTien INT
as
insert into HoaDonXuat(MaHDX, NgayXuat, NgayNhan, MaNV, MaKho, TrangThai, TongTien)
values (@MaHDX, @NgayXuat, @NgayNhan, @MaNV, @MaKho, @TrangThai, @TongTien)