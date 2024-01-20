create proc sp_DeleteNhanVien
@MaNV VARCHAR(10)
as
Delete from NhanVien
where MaNV = @MaNV