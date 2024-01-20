create proc sp_UpdateKhuVuc
@MaKV NVARCHAR(100),
@TenKV NVARCHAR(100),
@DiaChi NVARCHAR(100)
as
update KhuVuc
set TenKV = @TenKV,
DiaChi = @DiaChi
where MaKV = @MaKV