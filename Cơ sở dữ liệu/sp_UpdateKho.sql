create proc sp_UpdateKho
@MaKho VARCHAR(10),
@TenKho NVARCHAR(100),
@DiaChi NVARCHAR(100),
@MaNV VARCHAR(10),
@TrangThai NVARCHAR(100)
as
Update Kho
set TenKho = @TenKho,
DiaChi = @DiaChi,
MaNV = @MaNV,
TrangThai = @TrangThai
where MaKho = @MaKho