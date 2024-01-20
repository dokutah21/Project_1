create proc sp_DeleteKhuVuc
@MaKV NVARCHAR(100)
as
Delete from KhuVuc
where MaKV = @MaKV