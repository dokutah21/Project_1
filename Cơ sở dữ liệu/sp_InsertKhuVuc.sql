create proc sp_InsertKhuVuc
@MaKV NVARCHAR(100),
@TenKV NVARCHAR(100),
@DiaChi NVARCHAR(100)
as
insert into KhuVuc(MaKV, TenKV, DiaChi)
values(@MaKV, @TenKV, @DiaChi)