CREATE PROC PSP_ChucVu_Select
AS
  Select ROW_NUMBER () OVER (ORDER BY (SELECT 1 ) ) AS 
 MaChucVu, TenChucVu
  FROM dbo.ChucVu

  
  