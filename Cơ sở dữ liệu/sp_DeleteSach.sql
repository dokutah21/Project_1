create proc sp_DeleteSach
@MaSach VARCHAR(50)
as
Delete from Sach
where MaSach = @MaSach