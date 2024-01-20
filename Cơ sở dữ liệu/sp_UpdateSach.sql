create proc sp_UpdateSach
@MaSach VARCHAR(50),
@TenSach NVARCHAR(100),
@MaTL VARCHAR(10),
@DonGia INT,
@TrangThai NVARCHAR(50),
@NgayTao DATE
as
Update Sach
set TenSach = @TenSach,
MaTL = @MaTL,
DonGia = @DonGia,
TrangThai = @TrangThai,
NgayTao = @NgayTao
where MaSach = @MaSach