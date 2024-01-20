create proc sp_InsertTheLoaiSach
@MaTL VARCHAR(10),
@TenTL NVARCHAR(100)
as
insert into TheLoaiSach(MaTL, TenTL)
values (@MaTL, @TenTL)