USE QuanLyNhanSu_BAMBOO;
GO 
IF OBJECT_ID('TaiKhoan') IS NOT NULL
    BEGIN
        DROP TABLE TaiKhoan;
    END;
GO
CREATE TABLE TaiKhoan
    (
      MaTaiKhoan INT IDENTITY(1, 1)
                     PRIMARY KEY ,
      TenTaiKhoan NVARCHAR(30) ,
      IsDeLete BIT NOT NULL
                   DEFAULT ( 0 )
    );
INSERT  INTO dbo.TaiKhoan
        ( TenTaiKhoan, IsDeLete )
VALUES  ( N'Admin', -- TenTaiKhoan - nvarchar(30)
          0  -- IsDeLete - bit
          );
INSERT  INTO dbo.TaiKhoan
        ( TenTaiKhoan, IsDeLete )
VALUES  ( N'Quản Lý', -- TenTaiKhoan - nvarchar(30)
          0  -- IsDeLete - bit
          );
INSERT  INTO dbo.TaiKhoan
        ( TenTaiKhoan, IsDeLete )
VALUES  ( N'Nhân viên', -- TenTaiKhoan - nvarchar(30)
          0  -- IsDeLete - bit
          );
          
GO
--Bảng Nhân Viên
IF OBJECT_ID('NhanVien') IS NOT NULL
    BEGIN
        DROP TABLE NhanVien;
    END;
GO
CREATE TABLE NhanVien(
	MaNhanVien INT IDENTITY(1,1) PRIMARY KEY,
	TenNhanVien NVARCHAR(50) NOT NULL,
	NgaySinh DATE,
	DienThoai VARCHAR(13),
	MaTaiKhoan INT NOT NULL,
	TenDangNhap VARCHAR(30) NOT NULL,
	MatKhau VARBINARY(Max)NOT NULL,
	MaChucVu int not null,
	MaNgoaiNgu int not null
	CONSTRAINT pk_NhanVien_TaiKhoan FOREIGN KEY(MaTaiKhoan) REFERENCES dbo.TaiKhoan(MaTaiKhoan)
)
GO
INSERT INTO dbo.NhanVien
        ( TenNhanVien ,
          NgaySinh ,
          DienThoai ,
          MaTaiKhoan ,
          TenDangNhap ,
          MatKhau,
		  MaChucVu,
		  MaNgoaiNgu
        )
VALUES  ( N'Giám Đốc' , -- TenNhanVien - nvarchar(50)
         '2000-02-02' , -- NgaySinh - date
          '098123123' , -- DienThoai - varchar(13)
          1 , -- MaTaiKhoan - int
          'admin' , -- TenDangNhap - varchar(30)
          pwdencrypt('admin'),  -- MatKhau - varbinary(max)
		  '1',
		  '1'
        )
        INSERT INTO dbo.NhanVien
        ( TenNhanVien ,
          NgaySinh ,
          DienThoai ,
          MaTaiKhoan ,
          TenDangNhap ,
          MatKhau,
		  MaChucVu,
		  MaNgoaiNgu
        )
VALUES  ( N'Đỗ Nguyễn Anh Tuấn' , -- TenNhanVien - nvarchar(50)
         '2002-02-02' , -- NgaySinh - date
          '0983453635' , -- DienThoai - varchar(13)
          2 , -- MaTaiKhoan - int
          'anhtuan' , -- TenDangNhap - varchar(30)
          pwdencrypt('123'),  -- MatKhau - varbinary(max)
		  '2',
		  '2'
        )
GO
IF OBJECT_ID('ChucNang') IS NOT NULL
    BEGIN
        DROP TABLE ChucNang;
    END;
GO   
CREATE TABLE ChucNang(
	MaChucNang INT IDENTITY(1,1) PRIMARY KEY,
	TenChucNang NVARCHAR(100) NOT NULL,
	KyHieuChucNang VARCHAR(100) NOT NULL,--Frm_Main
	MoTa NVARCHAR(200),
	NhomChucNang INT NOT NULL,
	ChucNangCha INT ,
	IsDelete BIT NOT NULL DEFAULT(0)
)   
GO
IF OBJECT_ID('PhanQuyen') IS NOT NULL
    BEGIN
        DROP TABLE PhanQuyen;
    END;
GO  
CREATE TABLE PhanQuyen(
	MaChucNang INT ,
	MaTaiKhoan INT ,
	TongQuyen INT NOT NULL DEFAULT(0),
	IsDelete BIT NOT NULL DEFAULT(0),
	CONSTRAINT pk_PhanQuyen PRIMARY KEY(MaChucNang,MaTaiKhoan),
	CONSTRAINT fk_ChucNang_PhanQuyen FOREIGN KEY(MaChucNang) REFERENCES dbo.ChucNang(MaChucNang),
	CONSTRAINT fk_TaiKhoan_PhanQuyen FOREIGN KEY(MaTaiKhoan) REFERENCES dbo.TaiKhoan(MaTaiKhoan)	
)    
GO
ALTER TABLE dbo.NhanVien
ADD IsDelete BIT NOT NULL DEFAULT(0)
GO
--Thủ tục kiểm tra đăng nhập
CREATE PROC PSP_NhanVien_KiemTraDangNhap --'admin','admin'
@TenDangNhap VARCHAR(30),
@MatKhau VARCHAR(30)
AS	
IF EXISTS (SELECT 1 FROM dbo.NhanVien WHERE TenDangNhap=@TenDangNhap AND pwdcompare(@MatKhau,MatKhau)=1)
BEGIN
    SELECT 1 AS code,TenNhanVien,MaTaiKhoan FROM dbo.NhanVien WHERE TenDangNhap=@TenDangNhap AND pwdcompare(@MatKhau,MatKhau)=1
END
ELSE
BEGIN
    SELECT 0 AS code,'' AS TenNhanVien,0 AS MaTaiKhoan
END

GO
IF OBJECT_ID('dbo.PSP_NhanVien_LayDanhSachNhanVien')IS NOT NULL
BEGIN
    DROP PROC dbo.PSP_NhanVien_LayDanhSachNhanVien;
END
GO
CREATE PROC PSP_NhanVien_LayDanhSachNhanVien
AS
SELECT ROW_NUMBER() over (order by (select 1)) as STT, MaNhanVien, TenNhanVien, NgaySinh, DienThoai, MaTaiKhoan, TenDangNhap, MatKhau
FROM dbo.NhanVien
WHERE IsDelete=0
GO
IF OBJECT_ID('dbo.PSP_NhanVien_InsertVaUpdate')IS NOT NULL
BEGIN
    DROP PROC dbo.PSP_NhanVien_InsertVaUpdate;
END
GO
CREATE PROC PSP_NhanVien_InsertVaUpdate
@MaNhanVien int, 
@TenNhanVien NVARCHAR(50), 
@NgaySinh date, 
@DienThoai VARCHAR(13), 
@MaTaiKhoan INT , 
@TenDangNhap VARCHAR(30), 
@MatKhau VARCHAR(30)
AS
IF EXISTS (SELECT 1 FROM dbo.NhanVien WHERE MaNhanVien=@MaNhanVien)
BEGIN
    UPDATE dbo.NhanVien
    SET TenNhanVien=@TenNhanVien,
		NgaySinh=@NgaySinh,
		DienThoai=@DienThoai,
		MaTaiKhoan=@MaTaiKhoan,
		TenDangNhap=@TenDangNhap
	WHERE MaNhanVien=@MaNhanVien
END
ELSE	
BEGIN
    INSERT INTO dbo.NhanVien
            ( TenNhanVien ,
              NgaySinh ,
              DienThoai ,
              MaTaiKhoan ,
              TenDangNhap ,
              MatKhau
            )
    VALUES  ( @TenNhanVien , -- TenNhanVien - nvarchar(50)
             @NgaySinh , -- NgaySinh - date
              @DienThoai , -- DienThoai - varchar(13)
              @MaTaiKhoan , -- MaTaiKhoan - int
              @TenDangNhap , -- TenDangNhap - varchar(30)
              pwdencrypt(@MatKhau) -- MatKhau - varbinary(max)
            )
END
go
IF OBJECT_ID('dbo.PSP_TaiKhoan_LayCombo')IS NOT NULL
BEGIN
    DROP PROC dbo.PSP_TaiKhoan_LayCombo;
END
GO
CREATE PROC PSP_TaiKhoan_LayCombo
AS
SELECT MaTaiKhoan, TenTaiKhoan FROM dbo.TaiKhoan WHERE  IsDeLete=0
