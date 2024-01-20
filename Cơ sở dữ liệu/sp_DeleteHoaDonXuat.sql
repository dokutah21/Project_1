create proc sp_DeleteHoaDonXuat
@MaHDX VARCHAR(10)
as
Delete from HoaDonXuat
where MaHDX = @MaHDX