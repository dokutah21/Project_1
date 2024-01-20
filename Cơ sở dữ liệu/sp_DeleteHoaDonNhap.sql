create proc sp_DeleteHoaDonNhap
@MaHDN VARCHAR(10)
as
Delete from HoaDonNhap
where MaHDN = @MaHDN