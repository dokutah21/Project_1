create proc sp_DeleteChiTietXuat
@MaHDX VARCHAR(10)
as
Delete from ChiTiet_HDX
where MaHDX = @MaHDX