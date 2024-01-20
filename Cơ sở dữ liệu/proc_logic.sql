CREATE PROC proc_logic
@user nvarchar(50),
@pass nvarchar(50)
AS
BEGIN
	SELECT*FROM tbl_TaiKhoan WHERE sTaiKhoan = @user AND sMatKhau = @pass
END