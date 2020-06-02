if object_id('PSP_ChucVu_InsertUpdate') is not null
begin
drop proc dbo.PSP_ChucVu_InsertUpdate
end
go
create proc PSP_ChucVu_InsertUpdate
@MaChucVu nvarchar(50),
@TenChucVu nvarchar(50)
as
if exists ( select 1 from dbo.ChucVu where
MaChucVu = @MaChucVu)
begin
update dbo.ChucVu
set TenChucVu=@TenChucVu
where MaChucVu=@MaChucVu
end
 else
 begin
 insert into ChucVu(TenChucVu)
 values (@TenChucVu)
 end