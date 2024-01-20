create proc sp_InsertKho
@MaKho VARCHAR(10),
@TenKho NVARCHAR(100),
@DiaChi NVARCHAR(100),
@MaNV VARCHAR(10),
@TrangThai NVARCHAR(100)
as
insert into Kho(MaKho, TenKho, DiaChi, MaNV, TrangThai)
values (@MaKho, @TenKho, @DiaChi, @MaNV, @TrangThai)