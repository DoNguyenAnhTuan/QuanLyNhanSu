CREATE PROC PSP_NgonNgu_Select
AS
  Select ROW_NUMBER () OVER (ORDER BY (SELECT 1 ) ) AS 
 MaNgoaiNgu, TenNgoaiNgu
  FROM dbo.NgoaiNgu

  