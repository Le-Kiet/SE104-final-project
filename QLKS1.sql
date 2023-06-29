create database QLKS1
--DROP database QLKS1
GO
Use QLKS1
GO
															-- Mục lục --
--1.Tạo các bảng trong cơ sở dữ liệu
--2.Thêm một số dữ liệu
--3.Tạo trigger
--4.Tạo proc



									--1.Tạo các bảng trong cơ sở dữ liệu
--1.1.Tạo bảng tài khoản
CREATE TABLE TAIKHOAN
(
	Username NVARCHAR(50) PRIMARY KEY NOT NULL,
	password NVARCHAR(50) NOT NULL
)

--1.2.Tạo bảng Danh mục phòng
CREATE TABLE DANHMUCPHONG
(
	MaPhong INT PRIMARY KEY,
	TenPhong NVARCHAR(50) NOT NULL,
	MaLoaiPhong VARCHAR(4) NOT NULL,
	TinhTrangPhong NVARCHAR(50) NOT NULL DEFAULT N'Trống'
)
 
ALTER TABLE DANHMUCPHONG
   ADD CONSTRAINT FK_DANHMUCPHONG_LOAIPHONG_PK FOREIGN KEY (MaLoaiPhong)
      REFERENCES dbo.LOAIPHONG (MaLoaiPhong)
;
GO

--1.3.Tạo bảng loại phòng
CREATE TABLE LOAIPHONG
(
	MaLoaiPhong VARCHAR(4) PRIMARY KEY,
	TenLoaiPhong NVARCHAR(50) NOT NULL,
	DonGia INT NOT NULL
)
GO

--1.4.Tạo bảng loại khách hàng
CREATE TABLE LOAIKHACHHANG
(
	MaLoaiKhach VARCHAR(4) PRIMARY KEY,
	TenLoaiKhach NVARCHAR(50) NOT NULL,
	HeSoPhuThu FLOAT NOT NULL
)
GO

--1.5.Tạo bảng tỉ lệ phụ thu
CREATE TABLE TILEPHUTHU
(
	KhachThuBaoNhieu INT PRIMARY KEY ,
	TiLePhuThu FLOAT NOT NULL
)
GO

--1.6.Tạo bảng hóa đơn
CREATE TABLE HOADON
(
	MaHoaDon INT PRIMARY KEY,
	TenKhachHangThanhToan NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(50) NOT NULL,
	NgayThanhToan DATE NOT NULL DEFAULT GETDATE(),
	TriGia FLOAT NOT NULL
)
alter table HOADON add MaPhong int 
GO

--1.7.Tạo bảng báo cáo doanh thu
CREATE TABLE BAOCAODOANHTHUTHANG
(
	MaBCDTT INT PRIMARY KEY,
	Thang DATE NOT NULL,
	Nam DATE NOT NULL,
	TongDoanhThu FLOAT NOT NULL DEFAULT 0,
)
GO

--1.8.Tạo bảng chi tiết báo cáo doanh thu
CREATE TABLE CT_BAOCAODOANHTHUTHANG
(
	MaCTBKDTT INT primary key,
	MaBCDTT INT NOT NULL,
	MaHoaDon INT NOT NULL,
	Thang DATE NOT NULL,
	Nam DATE NOT NULL,
	MaLoaiPhong VARCHAR(4) NOT NULL,
	DoanhThu FLOAT NOT NULL DEFAULT 0,
	TiLe FLOAT
	FOREIGN KEY (MaBCDTT) REFERENCES dbo.BAOCAODOANHTHUTHANG(MaBCDTT),
	FOREIGN KEY (MaHoaDon) REFERENCES dbo.HOADON(MaHoaDon)
)
GO

--1.9.Tạo bảng phiểu thuê phòng
CREATE TABLE PHIEUTHUEPHONG
(
	MaPhieuThuePhong INT PRIMARY KEY,
	MaPhong INT NOT NULL,
	DonGiaThue1Ngay FLOAT NOT NULL,
	SoKhachTrongPhong INT NOT NULL,
	NgayBatDauThue DATE NOT NULL DEFAULT GETDATE()
	FOREIGN KEY (MaPhong) REFERENCES dbo.DANHMUCPHONG(MaPhong),
	FOREIGN KEY (SoKhachTrongPhong) REFERENCES dbo.TILEPHUTHU(KhachThuBaoNhieu)
)
alter table PHIEUTHUEPHONG add TinhTrangPhieuThuePhong nvarchar(50) not null default N'Chưa thanh toán'

GO

--1.10. Tạo bảng Chi tiết phiếu thuê phòng
CREATE TABLE CT_PHIEUTHUEPHONG
(
	MaPhieuThuePhong INT,
	MaLoaiKhach VARCHAR(4),
	CMND NCHAR(10) NOT NULL,
	TenKhachHang NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(50) NOT NULL
	CONSTRAINT CT_PHIEUTHUEPHONG_pk PRIMARY KEY (MaPhieuThuePhong,CMND)
	FOREIGN KEY (MaLoaiKhach) REFERENCES dbo.LOAIKHACHHANG(MaLoaiKhach),
	FOREIGN KEY (MaPhieuThuePhong) REFERENCES dbo.PHIEUTHUEPHONG(MaPhieuThuePhong)
)
GO

--1.11.Tạo bảng chi tiết hóa đơn
CREATE TABLE CT_HOADON
(
	MaPhieuThuePhong INT,
	MaHoaDon INT,
	SoNgayThue INT NOT NULL,
	SoTienPhaiTra FLOAT NOT NULL
	CONSTRAINT CT_HOADON_pk PRIMARY KEY (MaPhieuThuePhong,MaHoaDon)
	FOREIGN KEY (MaPhieuThuePhong) REFERENCES dbo.PHIEUTHUEPHONG(MaPhieuThuePhong),
	FOREIGN KEY (MaHoaDon) REFERENCES dbo.HOADON(MaHoaDon)
)
GO

--1.12.Tạo bảng tham số
CREATE TABLE THAMSO
(
	SoKhachToiDa INT NOT NULL,
	SoKhachKhongTinhPhuThu INT NOT NULL
)
GO


				--2.Thêm dữ liệu vào bảng
--2.1.Thêm dữ liệu tài khoản
INSERT INTO dbo.TAIKHOAN(Username,password)
VALUES (N'Nhom3',20521495)
INSERT INTO dbo.TAIKHOAN(Username,password)
VALUES (N'Kiet',1)
INSERT INTO dbo.TAIKHOAN(Username,password)
VALUES (N'Tri',20521495)
INSERT INTO dbo.TAIKHOAN(Username,password)
VALUES (N'Minh',20521495)
go
SELECT * FROM TAIKHOAN


--2.2.Thêm phòng
--2.2.a.Phòng loại a
DECLARE @room INT = 1
WHILE @room<= 10
BEGIN 
	INSERT dbo.DANHMUCPHONG(MaPhong,TenPhong,MaLoaiPhong,TinhTrangPhong)
	VALUES (@room,N'Phòng A'+cast(@room AS NVARCHAR(50)),N'A',N'Trống')
	SET @room =@room+1
END
--2.2.b.Phòng loại b
DECLARE @roomb INT = 11
WHILE @roomb<= 20
BEGIN 
	INSERT dbo.DANHMUCPHONG(MaPhong,TenPhong,MaLoaiPhong,TinhTrangPhong)
	VALUES (@roomb,N'Phòng B'+cast(@roomb -10 AS NVARCHAR(50)),N'B',N'Trống')
	SET @roomb =@roomb+1
END
--2.2.c.Phòng loại c
DECLARE @roomc INT = 21
WHILE @roomc<= 30
BEGIN 
	INSERT dbo.DANHMUCPHONG(MaPhong,TenPhong,MaLoaiPhong,TinhTrangPhong)
	VALUES (@roomc,N'Phòng C'+cast(@roomc-20 AS NVARCHAR(50)),N'C',N'Trống')
	SET @roomc=@roomc+1
END

	
select * from LOAIPHONG
select * from LOAIKHACHHANG
delete from DANHMUCPHONG
go



go
--2.3.Thêm loại khách hàng
INSERT INTO LOAIKHACHHANG(MaLoaiKhach,TenLoaiKhach,HeSoPhuThu) VALUES (N'IN',N'Khách nội địa',1.0) 
INSERT INTO LOAIKHACHHANG(MaLoaiKhach,TenLoaiKhach,HeSoPhuThu) VALUES (N'OUT',N'Khách ngoại địa',1.5) 
go
SELECT * FROM LOAIKHACHHANG
DELETE FROM LOAIKHACHHANG
--2.4.Thêm tỉ lệ phụ thu
INSERT INTO TILEPHUTHU(KhachThuBaoNhieu,TiLePhuThu) VALUES (2,1.0)
INSERT INTO TILEPHUTHU(KhachThuBaoNhieu,TiLePhuThu) VALUES (3,1.25)
INSERT INTO TILEPHUTHU(KhachThuBaoNhieu,TiLePhuThu) VALUES (4,1.5)
INSERT INTO TILEPHUTHU(KhachThuBaoNhieu,TiLePhuThu) VALUES (5,2)
SELECT * FROM TILEPHUTHU
DELETE FROM TILEPHUTHU
--2.5.Thêm loại phòng
INSERT INTO LOAIPHONG(MaLoaiPhong,TenLoaiPhong,DonGia) VALUES (N'A',N'Loại phòng A',150000)
INSERT INTO LOAIPHONG(MaLoaiPhong,TenLoaiPhong,DonGia) VALUES (N'B',N'Loại phòng B',170000)
INSERT INTO LOAIPHONG(MaLoaiPhong,TenLoaiPhong,DonGia) VALUES (N'C',N'Loại phòng C',200000)
SELECT * FROM LOAIPHONG
DELETE FROM LOAIPHONG

--2.6.Thêm phiếu thuê phòng
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (1,1,170000,2,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (2,2,170000,2,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (3,3,170000,2,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (4,4,170000,2,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (5,5,170000,3,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (6,6,170000,3,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (7,7,170000,4,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (8,8,170000,4,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (9,9,170000,5,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (10,10,170000,5,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (11,11,170000,3,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (12,12,170000,4,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (13,13,170000,4,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (14,14,170000,5,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (15,15,170000,5,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (16,1,170000,4,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (17,2,170000,5,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (18,3,170000,5,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (19,2,170000,5,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (20,3,170000,5,GETDATE())

INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (21,16,170000,5,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (22,17,170000,5,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (23,18,170000,5,GETDATE())
INSERT PHIEUTHUEPHONG(MaPhieuThuePhong,MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
VALUES (24,19,170000,5,GETDATE())
DELETE FROM CT_PHIEUTHUEPHONG
DELETE FROM CT_HOADON
DELETE FROM PHIEUTHUEPHONG
SELECT * FROM PHIEUTHUEPHONG

--2.7.Thêm chi tiết phiếu thuê
INSERT CT_PHIEUTHUEPHONG(MaPhieuThuePhong,MaLoaiKhach,CMND,TenKhachHang,DiaChi)
VALUES (9,N'IN',12345,N'Kiệt',N'ktx')
INSERT CT_PHIEUTHUEPHONG(MaPhieuThuePhong,MaLoaiKhach,CMND,TenKhachHang,DiaChi)
VALUES (9,N'OUT',123453,N'Kiệt',N'ktxkhua')
INSERT CT_PHIEUTHUEPHONG(MaPhieuThuePhong,MaLoaiKhach,CMND,TenKhachHang,DiaChi)
VALUES (9,N'IN',123454,N'Kiệt',N'ktxkhub')
INSERT CT_PHIEUTHUEPHONG(MaPhieuThuePhong,MaLoaiKhach,CMND,TenKhachHang,DiaChi)
VALUES (9,N'OUT',1234,N'Kiệt2',N'ktxkhubc')
INSERT CT_PHIEUTHUEPHONG(MaPhieuThuePhong,MaLoaiKhach,CMND,TenKhachHang,DiaChi)
VALUES (4,N'IN',123456,N'Kiệt',N'ktxkhuc')
INSERT CT_PHIEUTHUEPHONG(MaPhieuThuePhong,MaLoaiKhach,CMND,TenKhachHang,DiaChi)
VALUES (9,N'IN',1111,N'Kiệt123',N'ktx')
INSERT CT_PHIEUTHUEPHONG(MaPhieuThuePhong,MaLoaiKhach,CMND,TenKhachHang,DiaChi)
VALUES (9,N'OUT',111453,N'Kiệt321',N'ktxkhua')
INSERT CT_PHIEUTHUEPHONG(MaPhieuThuePhong,MaLoaiKhach,CMND,TenKhachHang,DiaChi)
VALUES (9,N'IN',123354,N'Kiệt222',N'ktxkhub')
INSERT CT_PHIEUTHUEPHONG(MaPhieuThuePhong,MaLoaiKhach,CMND,TenKhachHang,DiaChi)
VALUES (8,N'OUT',123334,N'Kiệt211',N'ktxkhubc')
INSERT CT_PHIEUTHUEPHONG(MaPhieuThuePhong,MaLoaiKhach,CMND,TenKhachHang,DiaChi)
VALUES (4,N'IN',123456444,N'Kiệt1111',N'ktxkhuc')
INSERT CT_PHIEUTHUEPHONG(MaPhieuThuePhong,MaLoaiKhach,CMND,TenKhachHang,DiaChi)
VALUES (10,N'IN',123354,N'Kiệt222',N'ktxkhub')
INSERT CT_PHIEUTHUEPHONG(MaPhieuThuePhong,MaLoaiKhach,CMND,TenKhachHang,DiaChi)
VALUES (7,N'OUT',123334,N'Kiệt211',N'ktxkhubc')
INSERT CT_PHIEUTHUEPHONG(MaPhieuThuePhong,MaLoaiKhach,CMND,TenKhachHang,DiaChi)
VALUES (7,N'IN',123456444,N'Kiệt1111',N'ktxkhuc')
INSERT CT_PHIEUTHUEPHONG(MaPhieuThuePhong,MaLoaiKhach,CMND,TenKhachHang,DiaChi)
VALUES (8,N'OUT',12311134,N'Kiệt211',N'ktxkhubc')
INSERT CT_PHIEUTHUEPHONG(MaPhieuThuePhong,MaLoaiKhach,CMND,TenKhachHang,DiaChi)
VALUES (6,N'IN',12226444,N'Kiệt1111',N'ktxkhuc')
SELECT * FROM PHIEUTHUEPHONG
SELECT * FROM CT_PHIEUTHUEPHONG

--2.8.Thêm dữ liệu vào bảng hóa đơn
SELECT * FROM HOADON
INSERT HOADON(MaHoaDon, TenKhachHangThanhToan, DiaChi, TriGia)
VALUES (1, N'Kiệt', N'ktx', 340000)
INSERT HOADON(MaHoaDon, TenKhachHangThanhToan, DiaChi, TriGia)
VALUES (2, N'Kiệt', N'ktxkhua', 340000)
INSERT HOADON(MaHoaDon, TenKhachHangThanhToan, DiaChi, TriGia)
VALUES (3, N'Kiệt', N'ktxkhub', 340000)

--2.9.Thêm dữ liệu vào bảng chi tiết hóa đơn
INSERT CT_HOADON(MaPhieuThuePhong, MaHoaDon, SoNgayThue, SoTienPhaiTra)
VALUES (1, 1, 2, 340000)
INSERT CT_HOADON(MaPhieuThuePhong, MaHoaDon, SoNgayThue, SoTienPhaiTra)
VALUES (2, 2, 2, 340000)
INSERT CT_HOADON(MaPhieuThuePhong, MaHoaDon, SoNgayThue, SoTienPhaiTra)
VALUES (3, 3, 2, 340000)

SELECT * FROM HOADON
SELECT * FROM CT_HOADON

SELECT * FROM PHIEUTHUEPHONG
SELECT * FROM CT_PHIEUTHUEPHONG



					--3.TRIGGER 
--3.1.Trigger tự động cập nhật khi thay đổi dữ liệu khách thứ bao nhiêu để tính đơn giá thuê 1 ngày
CREATE TRIGGER update_DonGiaThue1Ngay_Trigger
ON TILEPHUTHU
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE PHIEUTHUEPHONG
    SET DonGiaThue1Ngay = LOAIPHONG.DonGia * TiLePhuThu * LOAIKHACHHANG.HeSoPhuThu
    FROM PHIEUTHUEPHONG 
	JOIN DANHMUCPHONG ON PHIEUTHUEPHONG.MaPhong=DANHMUCPHONG.MaPhong 
	JOIN LOAIPHONG ON DANHMUCPHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong
	JOIN CT_PHIEUTHUEPHONG ON CT_PHIEUTHUEPHONG.MaPhieuThuePhong = PHIEUTHUEPHONG.MaPhieuThuePhong
	JOIN LOAIKHACHHANG ON LOAIKHACHHANG.MaLoaiKhach = CT_PHIEUTHUEPHONG.MaLoaiKhach
    JOIN inserted ON PHIEUTHUEPHONG.SoKhachTrongPhong = inserted.KhachThuBaoNhieu 
END
GO

--DROP trigger update_DonGiaThue1Ngay_Trigger

--3.2.Trigger tự động cập nhật khi thay đổi dữ liệu đơn giá của một loại phòng để tính đơn giá thuê 1 ngày

CREATE TRIGGER update_DonGiaThue1Ngay_LoaiPhong_Trigger
ON LOAIPHONG
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE PHIEUTHUEPHONG
    SET DonGiaThue1Ngay = DonGia * TILEPHUTHU.TiLePhuThu *LOAIKHACHHANG.HeSoPhuThu
    FROM PHIEUTHUEPHONG 
	JOIN TILEPHUTHU ON TILEPHUTHU.KhachThuBaoNhieu=PHIEUTHUEPHONG.SoKhachTrongPhong 
	JOIN DANHMUCPHONG ON DANHMUCPHONG.MaPhong=PHIEUTHUEPHONG.MaPhong
	JOIN CT_PHIEUTHUEPHONG ON CT_PHIEUTHUEPHONG.MaPhieuThuePhong = PHIEUTHUEPHONG.MaPhieuThuePhong
	JOIN LOAIKHACHHANG ON LOAIKHACHHANG.MaLoaiKhach = CT_PHIEUTHUEPHONG.MaLoaiKhach
    JOIN inserted ON DANHMUCPHONG.MaLoaiPhong = inserted.MaLoaiPhong 

END
GO

--DROP TRIGGER update_DonGiaThue1Ngay_LoaiPhong_Trigger
go 

--3.3.Trigger tự động cập nhật giá trị Đơn giá thuê 1 ngày khi thay đổi

CREATE TRIGGER update_DonGiaThue1Ngay_SoKhachTrongPhong_Trigger
ON PHIEUTHUEPHONG
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    IF (UPDATE(SoKhachTrongPhong) OR (UPDATE(DonGiaThue1Ngay))) BEGIN
        UPDATE PHIEUTHUEPHONG
        SET DonGiaThue1Ngay = LOAIPHONG.DonGia * TiLePhuThu * HeSoPhuThu
        FROM PHIEUTHUEPHONG 
        JOIN DANHMUCPHONG ON PHIEUTHUEPHONG.MaPhong = DANHMUCPHONG.MaPhong 
        JOIN LOAIPHONG ON DANHMUCPHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong
		JOIN TILEPHUTHU ON TILEPHUTHU.KhachThuBaoNhieu = PHIEUTHUEPHONG.SoKhachTrongPhong
		JOIN CT_PHIEUTHUEPHONG ON CT_PHIEUTHUEPHONG.MaPhieuThuePhong = PHIEUTHUEPHONG.MaPhieuThuePhong
		JOIN LOAIKHACHHANG ON LOAIKHACHHANG.MaLoaiKhach = CT_PHIEUTHUEPHONG.MaLoaiKhach
        WHERE PHIEUTHUEPHONG.MaPhieuThuePhong IN (SELECT MaPhieuThuePhong FROM inserted)
    END
END
GO

--3.4.Trigger update số tiền
CREATE TRIGGER trig_update_SoTienPhaiTra
ON CT_HOADON
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE CT_HOADON
    SET SoTienPhaiTra = PHIEUTHUEPHONG.DonGiaThue1Ngay * CT_HOADON.SoNgayThue
    FROM CT_HOADON
    JOIN inserted ON CT_HOADON.MaHoaDon = inserted.MaHoaDon
    JOIN PHIEUTHUEPHONG ON CT_HOADON.MaPhieuThuePhong = PHIEUTHUEPHONG.MaPhieuThuePhong
    WHERE CT_HOADON.MaHoaDon IN (SELECT MaHoaDon FROM inserted);
END
GO
CREATE TRIGGER update_DonGiaThue1Ngay_Trigger_HSPT
ON LOAIKHACHHANG
AFTER UPDATE
AS
BEGIN
	UPDATE PHIEUTHUEPHONG
	SET DonGiaThue1Ngay = HeSoPhuThu * LOAIPHONG.DonGia * TILEPHUTHU.TiLePhuThu
	FROM PHIEUTHUEPHONG
	JOIN inserted ON MaLoaiKhach = inserted.MaLoaiKhach
	JOIN CT_PHIEUTHUEPHONG ON CT_PHIEUTHUEPHONG.MaLoaiKhach = inserted.MaLoaiKhach
	JOIN TILEPHUTHU ON TILEPHUTHU.KhachThuBaoNhieu = PHIEUTHUEPHONG.SoKhachTrongPhong
	JOIN DANHMUCPHONG ON DANHMUCPHONG.MaPhong = PHIEUTHUEPHONG.MaPhong
	JOIN LOAIPHONG ON LOAIPHONG.MaLoaiPhong = DANHMUCPHONG.MaLoaiPhong
	WHERE PHIEUTHUEPHONG.MaPhieuThuePhong IN (SELECT MaPhieuThuePhong FROM CT_PHIEUTHUEPHONG)
END
GO

CREATE TRIGGER trg_CT_PHIEUTHUEPHONG_upd_ins 
ON PHIEUTHUEPHONG
AFTER INSERT, UPDATE
AS
BEGIN
	UPDATE PHIEUTHUEPHONG
	SET DonGiaThue1Ngay = LOAIPHONG.DonGia * LOAIKHACHHANG.HeSoPhuThu
	FROM PHIEUTHUEPHONG
	INNER JOIN inserted ON PHIEUTHUEPHONG.MaPhieuThuePhong = inserted.MaPhieuThuePhong
	INNER JOIN CT_PHIEUTHUEPHONG ON CT_PHIEUTHUEPHONG.MaPhieuThuePhong = PHIEUTHUEPHONG.MaPhieuThuePhong
	INNER JOIN LOAIKHACHHANG ON CT_PHIEUTHUEPHONG.MaLoaiKhach = LOAIKHACHHANG.MaLoaiKhach
	INNER JOIN LOAIPHONG ON PHIEUTHUEPHONG.MaPhong = LOAIPHONG.MaLoaiPhong
END;
GO
drop trigger trig_update_SoTienPhaiTra

--3.5.
CREATE TRIGGER trig_NgayThanhToan_hoadon
ON HOADON
AFTER INSERT, UPDATE
AS
BEGIN
	DECLARE @DateRent date;
	DECLARE @SoNgayThue int;

	select @DateRent = NgayBatDauThue from PHIEUTHUEPHONG where MaPhong = (select MaPhong  from inserted)
	IF (select NgayThanhToan from inserted) < @DateRent
		Begin
			rollback transaction
		end;
	else
	begin
		SET @SoNgayThue = DATEDIFF(DAY,  @DateRent, (select NgayThanhToan from inserted))

	UPDATE CT_HOADON SET SoNgayThue = @SoNgayThue where MaHoaDon = (select MaHoaDon from inserted)
	end
END
GO


--3.6.3 trigger để load đơn giá
alter TRIGGER update_DonGiaThue1Ngay_Trigger
ON TILEPHUTHU
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE PHIEUTHUEPHONG
    SET DonGiaThue1Ngay = LOAIPHONG.DonGia * TiLePhuThu
    FROM PHIEUTHUEPHONG 
	JOIN DANHMUCPHONG ON PHIEUTHUEPHONG.MaPhong=DANHMUCPHONG.MaPhong 
	JOIN LOAIPHONG ON DANHMUCPHONG.MaLoaiPhong=LOAIPHONG.MaLoaiPhong
    JOIN inserted ON PHIEUTHUEPHONG.SoKhachTrongPhong = inserted.KhachThuBaoNhieu 

END
go
drop trigger update_DonGiaThue1Ngay_Trigger


alter TRIGGER update_DonGiaThue1Ngay_LoaiPhong_Trigger
ON LOAIPHONG
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE PHIEUTHUEPHONG
    SET DonGiaThue1Ngay = DonGia * TILEPHUTHU.TiLePhuThu
    FROM PHIEUTHUEPHONG 
	JOIN TILEPHUTHU ON TILEPHUTHU.KhachThuBaoNhieu=PHIEUTHUEPHONG.SoKhachTrongPhong 
	JOIN DANHMUCPHONG ON DANHMUCPHONG.MaPhong=PHIEUTHUEPHONG.MaPhong
    JOIN inserted ON DANHMUCPHONG.MaLoaiPhong = inserted.MaLoaiPhong 

END
GO

DROP TRIGGER update_DonGiaThue1Ngay_LoaiPhong_Trigger

alter TRIGGER update_DonGiaThue1Ngay_SoKhachTrongPhong_Trigger
ON PHIEUTHUEPHONG
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    IF (UPDATE(SoKhachTrongPhong)) BEGIN
        UPDATE PHIEUTHUEPHONG
        SET DonGiaThue1Ngay = LOAIPHONG.DonGia * TiLePhuThu
        FROM PHIEUTHUEPHONG 
        JOIN DANHMUCPHONG ON PHIEUTHUEPHONG.MaPhong = DANHMUCPHONG.MaPhong 
        JOIN LOAIPHONG ON DANHMUCPHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong
		JOIN TILEPHUTHU ON TILEPHUTHU.KhachThuBaoNhieu = PHIEUTHUEPHONG.SoKhachTrongPhong
        WHERE PHIEUTHUEPHONG.MaPhieuThuePhong IN (SELECT MaPhieuThuePhong FROM inserted)
    END
END
GO


drop trigger update_DonGiaThue1Ngay_SoKhachTrongPhong_Trigger


SET DATEFORMAT DMY

CREATE TRIGGER trg_PTP_Insert 
ON PHIEUTHUEPHONG
FOR INSERT
AS 
BEGIN
    DECLARE @MaPhieuThue INT;
	DECLARE @MaPhong INT;
    DECLARE @MaHoaDon INT;
    DECLARE @NgayBatDau DATE;
    DECLARE @NgayThanhToan DATE;
    
    SELECT @MaPhieuThue = MaPhieuThuePhong FROM inserted;
    SELECT @NgayBatDau = NgayBatDauThue FROM PHIEUTHUEPHONG WHERE MaPhieuThuePhong = @MaPhieuThue;
	SELECT @MaPhong = MaPhong FROM PHIEUTHUEPHONG WHERE MaPhieuThuePhong = @MaPhieuThue;
    SELECT @MaHoaDon = MaHoaDon FROM HOADON WHERE HOADON.MaPhong = @MaPhong;
    SELECT @NgayThanhToan = NgayThanhToan FROM HOADON WHERE MaHoaDon = @MaHoaDon;
    
    IF (@NgayBatDau IS NOT NULL AND @NgayThanhToan IS NOT NULL AND @NgayBatDau > @NgayThanhToan)
    BEGIN
        RAISERROR('NgayBatDauThue cannot be later than NgayThanhToan in HOADON', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END
GO


CREATE TRIGGER trg_PTP_Update
ON PHIEUTHUEPHONG
AFTER UPDATE
AS 
BEGIN
    UPDATE CT_HOADON
    SET SoNgayThue = DATEDIFF(day, PHIEUTHUEPHONG.NgayBatDauThue, HOADON.NgayThanhToan) + 1
    FROM CT_HOADON
    JOIN HOADON ON CT_HOADON.MaHoaDon = HOADON.MaHoaDon
    JOIN PHIEUTHUEPHONG ON CT_HOADON.MaPhieuThuePhong = PHIEUTHUEPHONG.MaPhieuThuePhong
    JOIN inserted ON PHIEUTHUEPHONG.MaPhieuThuePhong = inserted.MaPhieuThuePhong
END
GO
drop trigger trg_PTP_Update

CREATE TRIGGER trg_HD_Update
ON HOADON
AFTER UPDATE
AS 
BEGIN
    UPDATE CT_HOADON
    SET SoNgayThue = DATEDIFF(day, PHIEUTHUEPHONG.NgayBatDauThue, HOADON.NgayThanhToan) + 1
    FROM CT_HOADON
    JOIN HOADON ON CT_HOADON.MaHoaDon = HOADON.MaHoaDon
    JOIN PHIEUTHUEPHONG ON CT_HOADON.MaPhieuThuePhong = PHIEUTHUEPHONG.MaPhieuThuePhong
    JOIN inserted ON HOADON.MaHoaDon = inserted.MaHoaDon
END
GO
alter trigger trg_HD_Update

CREATE TRIGGER trg_CTHD_Insert
ON CT_HOADON
AFTER INSERT
AS 
BEGIN
    UPDATE CT_HOADON
    SET SoNgayThue = DATEDIFF(day, PHIEUTHUEPHONG.NgayBatDauThue, HOADON.NgayThanhToan) + 1
    FROM CT_HOADON
    JOIN HOADON ON CT_HOADON.MaHoaDon = HOADON.MaHoaDon
    JOIN PHIEUTHUEPHONG ON CT_HOADON.MaPhieuThuePhong = PHIEUTHUEPHONG.MaPhieuThuePhong
    JOIN inserted ON HOADON.MaHoaDon = inserted.MaHoaDon
END
GO
alter trigger trg_CTHD_Insert


--trigger đổi tình trạng phòng
alter trigger update_tinhtrangphong
on DANHMUCPHONG
after Insert,update
as
begin
	update DANHMUCPHONG
	set TinhTrangPhong = N'Có người' from DANHMUCPHONG
	join PHIEUTHUEPHONG on PHIEUTHUEPHONG.MaPhong=DANHMUCPHONG.MaPhong
	join CT_PHIEUTHUEPHONG on CT_PHIEUTHUEPHONG.MaPhieuThuePhong=PHIEUTHUEPHONG.MaPhieuThuePhong
end
go
drop trigger update_tinhtrangphong

SELECT * FROM DANHMUCPHONG
SELECT * FROM LOAIPHONG
SELECT * FROM PHIEUTHUEPHONG
SELECT * FROM TILEPHUTHU
UPDATE LOAIPHONG SET dongia = 150000 WHERE MaLoaiPhong='A'
UPDATE TILEPHUTHU SET TiLePhuThu = 1 WHERE KhachThuBaoNhieu = 2
SELECT * FROM PHIEUTHUEPHONG
DECLARE @MaPhieuThuePhongNew INT = 3
SELECT * FROM CT_PHIEUTHUEPHONG WHERE MaPhieuThuePhong=@MaPhieuThuePhongNew

DECLARE @MaPhieuThuePhongOld INT = 2
go

--trigger để khi thanh toán tình trạng phiếu thuê phòng sẽ chuyển sang đã được thanh toán

CREATE TRIGGER update_tinhtrangphieuthuephong
ON PHIEUTHUEPHONG
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
	if (insert(MaHoaDon)) begin
	
    IF (UPDATE(SoKhachTrongPhong)) BEGIN
        UPDATE PHIEUTHUEPHONG
        SET DonGiaThue1Ngay = LOAIPHONG.DonGia * TiLePhuThu
        FROM PHIEUTHUEPHONG 
        JOIN DANHMUCPHONG ON PHIEUTHUEPHONG.MaPhong = DANHMUCPHONG.MaPhong 
        JOIN LOAIPHONG ON DANHMUCPHONG.MaLoaiPhong = LOAIPHONG.MaLoaiPhong
		JOIN TILEPHUTHU ON TILEPHUTHU.KhachThuBaoNhieu = PHIEUTHUEPHONG.SoKhachTrongPhong
        WHERE PHIEUTHUEPHONG.MaPhieuThuePhong IN (SELECT MaPhieuThuePhong FROM inserted)
    END
END
GO
CREATE TRIGGER tr_HoaDon_Insert ON Hoadon AFTER INSERT
AS
BEGIN
  --Cập nhật TinhTrangPhieuThuePhong của các Phiếu Thuê Phòng liên quan tới hóa đơn mới
  UPDATE PHIEUTHUEPHONG
  SET TinhTrangPhieuThuePhong = N'Đã thanh toán'
  FROM PHIEUTHUEPHONG pt INNER JOIN CT_HOADON cthd ON pt.MaPhieuThuePhong = cthd.MaPhieuThuePhong
                         INNER JOIN inserted hd ON cthd.MaHoaDon = hd.MaHoaDon
  WHERE pt.TinhTrangPhieuThuePhong = N'Chưa thanh toán';
END;

								--4.create Procedure
alter proc USP_SwitchRoom
@MaPhongMot INT, @MaPhongHai INT
AS BEGIN
	DECLARE @MaPhieuThuePhongMot INT
	DECLARE @MaPhieuThuePhongHai INT
	SELECT @MaPhieuThuePhongHai=MaPhieuThuePhong FROM PHIEUTHUEPHONG,DANHMUCPHONG WHERE DANHMUCPHONG.MaPhong = @MaPhongMot and TinhTrangphong =N'Trống'
	SELECT @MaPhieuThuePhongMot=MaPhieuThuePhong FROM PHIEUTHUEPHONG,DANHMUCPHONG WHERE DANHMUCPHONG.MaPhong = @MaPhongHai and TinhTrangphong =N'Trống'
		
		
		print @MaPhieuThuePhongMot
		print @MaPhieuThuePhongHai
		print '----------------'
	if (@MaPhieuThuePhongMot is NULL)
	BEGIN
		print 'Loi1'
		print '----------------'
		print @MaPhieuThuePhongMot
		INSERT PHIEUTHUEPHONG (MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue) 
		VALUES (@MaPhongMot,0,0,GETDATE())
		SELECT @MaPhieuThuePhongMot = MAX(MaPhieuThuePhong) FROM PHIEUTHUEPHONG,DANHMUCPHONG WHERE PHIEUTHUEPHONG.MaPhong=@MaPhongMot and TinhTrangPhong='Trống'
	END
	if (@MaPhieuThuePhongHai is NULL)
	BEGIN
		print 'Loi1'
		print '----------------'
		print @MaPhieuThuePhongMot
		print 'Loi2'
		INSERT PHIEUTHUEPHONG (MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue) 
		VALUES (@MaPhongHai,0,0,GETDATE())
		SELECT @MaPhieuThuePhongHai = MAX(MaPhieuThuePhong) FROM PHIEUTHUEPHONG,DANHMUCPHONG WHERE PHIEUTHUEPHONG.MaPhong=@MaPhongHai and TinhTrangPhong='Trống'
	END
	SELECT maphieuthuephong into machitietphieuthuephong FROM CT_PHIEUTHUEPHONG WHERE MaPhieuThuePhong=@MaPhieuThuePhongHai


	UPDATE CT_PHIEUTHUEPHONG SET MaPhieuThuePhong=@MaPhieuThuePhongHai WHERE MaPhieuThuePhong=@MaPhieuThuePhongMot
	UPDATE CT_PHIEUTHUEPHONG SET MaPhieuThuePhong=@MaPhieuThuePhongMot WHERE maphieuthuephong in (SELECT * FROM machitietphieuthuephong)
	DROP table machitietphieuthuephong
END
go
EXEC USP_SwitchRoom @MaPhongMot =3,@MaPhongHai =4
DROP proc USP_SwitchRoom


alter proc USP_SwitchTableTest
@MaPhongMot INT, @MaPhongHai INT
AS BEGIN
	DECLARE	@MaPhieuThuePhongMot INT
	DECLARE @MaPhieuThuePhongHai INT
	DECLARE @TinhTrangThuNhat NVARCHAR(50) = N'Có người'
	DECLARE @TinhTrangThuHai NVARCHAR(50) = N'Trống'

	SELECT @MaPhieuThuePhongMot = MaPhieuThuePhong FROM PHIEUTHUEPHONG WHERE MaPhong = @MaPhongMot 
	SELECT @MaPhieuThuePhongHai = MaPhieuThuePhong FROM PHIEUTHUEPHONG WHERE MaPhong = @MaPhongHai
	SELECT MaPhieuThuePhong FROM PHIEUTHUEPHONG WHERE MaPhong = @MaPhongHai

	if (@MaPhieuThuePhongMot is null)
	BEGIN

		INSERT PHIEUTHUEPHONG(MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
		VALUES (@MaPhongMot,0,0,GETDATE())
		SELECT @MaPhieuThuePhongMot = max(MaPhieuThuePhong) FROM PHIEUTHUEPHONG WHERE MaPhong = @MaPhongMot
	END

	SELECT @TinhTrangThuNhat = count(*) FROM CT_PHIEUTHUEPHONG WHERE MaPhieuThuePhong=@MaPhieuThuePhongMot 


	if (@MaPhieuThuePhongHai is null)
	BEGIN
	print 'loi2'
		INSERT PHIEUTHUEPHONG(MaPhong,DonGiaThue1Ngay,SoKhachTrongPhong,NgayBatDauThue)
		VALUES (@MaPhongHai,0,0,GETDATE())
		SELECT @MaPhieuThuePhongHai = max(MaPhieuThuePhong) FROM PHIEUTHUEPHONG WHERE MaPhong = @MaPhongHai
	END
	SELECT @TinhTrangThuHai = count(*) FROM CT_PHIEUTHUEPHONG WHERE MaPhieuThuePhong=@MaPhieuThuePhongHai

	SELECT CT_PHIEUTHUEPHONG.MaPhieuThuePhong into CT_MaPhieuThuePhong_Test FROM CT_PHIEUTHUEPHONG,DANHMUCPHONG,PHIEUTHUEPHONG 
	WHERE CT_PHIEUTHUEPHONG.MaPhieuThuePhong = @MaPhieuThuePhongHai and DANHMUCPHONG.MaPhong=PHIEUTHUEPHONG.MaPhong and CT_PHIEUTHUEPHONG.MaPhieuThuePhong=PHIEUTHUEPHONG.MaPhieuThuePhong
	UPDATE CT_PHIEUTHUEPHONG SET MaPhieuThuePhong=@MaPhieuThuePhongHai WHERE MaPhieuThuePhong=@MaPhieuThuePhongMot
	UPDATE CT_PHIEUTHUEPHONG SET MaPhieuThuePhong=@MaPhieuThuePhongMot WHERE MaPhieuThuePhong in (SELECT * FROM CT_MaPhieuThuePhong_Test)
	UPDATE DANHMUCPHONG SET TinhTrangPhong=N'Có người' WHERE MaPhong=@MaPhongMot
	UPDATE DANHMUCPHONG SET TinhTrangPhong=N'Trống' WHERE MaPhong=@MaPhongHai
	DROP table CT_MaPhieuThuePhong_Test
END
go
EXEC USP_SwitchTableTest @MaPhongMot =3,@MaPhongHai =8

INSERT INTO CT_PHIEUTHUEPHONG (MaPhong) VALUES (1) WHERE MaPhieuThuePhong = 1

					-- trigger UPDATE Chitietphieuthue
--aa

alter trigger UTG_UpdateVoucherInfo
on CT_PHIEUTHUEPHONG for INSERT,UPDATE
AS
BEGIN
	DECLARE @MaPhieuThuePhong INT
	SELECT @MaPhieuThuePhong = MaPhieuThuePhong FROM inserted
	DECLARE @MaPhong INT 
	SELECT @MaPhong = MaPhong FROM PHIEUTHUEPHONG WHERE MaPhieuThuePhong = @MaPhieuThuePhong
	DECLARE @countCT_PHIEUTHUEPHONG INT
	SELECT count(*) FROM CT_PHIEUTHUEPHONG WHERE MaPhieuThuePhong=@MaPhieuThuePhong
	if(@countCT_PHIEUTHUEPHONG=0)
		UPDATE DANHMUCPHONG SET TinhTrangPhong=N'Trống' WHERE MaPhong=@MaPhong
	else 
		UPDATE DANHMUCPHONG SET TinhTrangPhong = N'Có người' WHERE MaPhong = @MaPhong
END
go	
DROP trigger UTG_UpdateVoucherInfo

alter trigger UTG_UpdateRoom
on DANHMUCPHONG for INSERT,UPDATE
AS
BEGIN
	DECLARE @MaPhong INT
	DECLARE @TinhTrangPhong NVARCHAR(50)
	SELECT @MaPhong = MaPhong,@TinhTrangPhong=inserted.TinhTrangPhong FROM inserted

	DECLARE @MaPhieuThuePhong INT
	SELECT @MaPhieuThuePhong = MaPhieuThuePhong FROM PHIEUTHUEPHONG,DANHMUCPHONG WHERE PHIEUTHUEPHONG.MaPhong = @MaPhong and DANHMUCPHONG.TinhTrangPhong =N'Trống'

	DECLARE @CountPhieuThuePhongInfo INT
	SELECT @CountPhieuThuePhongInfo = Count(*) FROM CT_PHIEUTHUEPHONG WHERE MaPhieuThuePhong=@MaPhieuThuePhong

	If(@CountPhieuThuePhongInfo>0 and @TinhTrangPhong <> N'Có người')
		UPDATE DANHMUCPHONG SET TinhTrangPhong=N'Trống' WHERE MaPhong=@MaPhong
	else if (@CountPhieuThuePhongInfo <= 0 and @TinhTrangPhong <>N'Trống')
	UPDATE DANHMUCPHONG SET TinhTrangPhong=N'Trống' WHERE MaPhong=@MaPhong

END
go
DROP trigger UTG_UpdateRoom

CREATE PROC USP_GetListBillByDate 
@checkInn date, @checkOutt date 
AS
BEGIN
	DECLARE @checkIn date;
	DECLARE @checkOut date;
	SET @checkIn = getdate();
	SET @checkOut = '2023-06-30'
	SELECT H.MaHoaDon AS N'Mã hóa đơn', TenPhong AS N'Tên phòng', MONTH(NgayThanhToan) AS Tháng, YEAR(NgayThanhToan) AS Năm, TriGia AS N'Tổng tiền'
	FROM DANHMUCPHONG AS D, HOADON AS H, PHIEUTHUEPHONG AS P, CT_HOADON AS C, CT_PHIEUTHUEPHONG AS CP
	WHERE NgayThanhToan >= @checkIn AND NgayThanhToan <= @checkOut AND D.MaPhong = P.MaPhong AND p.MaPhieuThuePhong = C.MaPhieuThuePhong AND C.MaHoaDon = H.MaHoaDon AND CP.MaPhieuThuePhong = C.MaPhieuThuePhong
	END
GO
exec USP_GetListBillByDate '2023-06-18', '2023-06-30'
select * from DANHMUCPHONG
select * from hoadon
select * from CT_HOADON
select * from PHIEUTHUEPHONG
select * from CT_PhieuThuePhong

UPDATE  DANHMUCPHONG SET TinhTrangPhong = N'Trống'

CREATE PROC USP_GetListAccount
@Username NVARCHAR(50)
AS
BEGIN
SELECT * FROM dbo.TAIKHOAN WHERE @Username = Username
END
go

EXEC USP_GetListAccount @Username = 'Nhom3'

CREATE PROC USP_GetRoomList
AS SELECT * FROM DANHMUCPHONG
Go

SELECT * FROM DANHMUCPHONG
SELECT * FROM CT_PHIEUTHUEPHONG
SELECT * FROM PHIEUTHUEPHONG
SELECT * FROM LOAIPHONG
SELECT * FROM TILEPHUTHU
select * from HOADON
select * from HOADON,CT_HOADON where hoadon.MaHoaDon=CT_HOADON.MaHoaDon and HOADON.MaHoaDon=113
select * from CT_HOADON