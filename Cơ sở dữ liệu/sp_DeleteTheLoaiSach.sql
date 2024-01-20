create proc sp_DeleteTheLoaiSach
@MaTL VARCHAR(10)
as
Delete from TheLoaiSach
where MaTL = @MaTL