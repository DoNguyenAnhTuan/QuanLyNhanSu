Create proc PSP_tblQLNS_select

as
select 0 as 'Delete', MaNhanVien, TenNhanVien,DienThoai
from dbo.NhanVien

go
create proc PSP_QLNS_Xoa
@MaNhanVien int
as
delete dbo.NhanVien
where MaNhanVien=@MaNhanVien
go
create proc PSP_QLNS_Insert_Update
@MaNhanVien int, 
@TenNhanVien nvarchar(50), 
@DienThoai varchar(13)
as
if exists (select 1 from NhanVien where MaNhanVien=@MaNhanVien)
begin 
	update NhanVien
	set TenNhanVien=@TenNhanVien, DienThoai=@DienThoai
	where MaNhanVien=@MaNhanVien
end
else
begin 
	INsert into NhanVien( TenNhanVien, DienThoai)
	values( @TenNhanVien, @DienThoai)
	end