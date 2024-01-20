create proc sp_InsertSach
@MaSach VARCHAR(50),
@TenSach NVARCHAR(100),
@MaTL VARCHAR(10),
@DonGia INT,
@TrangThai NVARCHAR(50),
@NgayTao DATE
as
insert into Sach(MaSach, TenSach, MaTL, DonGia, TrangThai, NgayTao)
values (@MaSach, @TenSach, @MaTL, @DonGia, @TrangThai, @NgayTao)