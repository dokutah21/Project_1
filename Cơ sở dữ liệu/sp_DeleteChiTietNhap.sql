create proc sp_DeleteChiTietNhap
@MaHDN VARCHAR(10)
as
Delete from ChiTiet_HDN
where MaHDN = @MaHDN