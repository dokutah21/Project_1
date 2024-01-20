create proc sp_DeleteKho
@MaKho VARCHAR(10)
as
Delete from Kho
where MaKho = @MaKho