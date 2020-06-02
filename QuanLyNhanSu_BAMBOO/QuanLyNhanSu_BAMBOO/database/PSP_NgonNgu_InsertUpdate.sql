if object_id('PSP_NgonNgu_InsertUpdate') is not null
begin
drop proc dbol.PSP_NgonNgu_InsertUpdate
end
go
create proc PSP_NgonNgu_InsertUpdate
@MaNgonNgu nvarchar(50),
@TenNgonNgu nvarchar(50),
@MoTa nvarchar(200)
as
if exists ( select 1 from dbo.NgoaiNgu where
MaNgoaiNgu = @MaNgonNgu)
begin
update dbo.NgoaiNgu
set TenNgoaiNgu=@TenNgonNgu
where MaNgoaiNgu=@MaNgonNgu
end
 else
 begin
 insert into NgoaiNgu(TenNgoaiNgu)
 values (@TenNgonNgu)
 end