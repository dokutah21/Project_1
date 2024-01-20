create proc sp_UpdateTheLoaiSach
@MaTL VARCHAR(10),
@TenTL NVARCHAR(100)
as
update TheLoaiSach
set TenTL = @TenTL
where MaTL = @MaTL