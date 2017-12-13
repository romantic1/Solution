USE master
GO
IF DB_ID('QuanLiQuanAn')IS NOT NULL
BEGIN
	DROP DATABASE QuanLiQuanAn
END
GO
CREATE DATABASE QuanLiQuanAn
GO
USE QuanLiQuanAn
GO
CREATE TABLE Danh_Muc
(
	Ma_DM char(10),
	Ten_DM varchar(10),
	Ma_CN char(10),
	PRIMARY KEY(Ma_DM)
)

CREATE TABLE Chi_Tiet_Danh_Muc
(
	Ma_DM char(10),
	Ma_MA char(10)
)

CREATE TABLE Mon_An
(
	Ma_MA char(10),
	Ten_MA nvarchar(20),
	Gia char(20),
	GhiChu nvarchar(30),
	Ten_DM nvarchar(20),
	PRIMARY KEY(Ma_MA)
)

CREATE TABLE Chi_Nhanh
(
	Ma_CN char(20),
	Ten_CN nvarchar(100),
	SoDienThoai_CN char(20),
	DiaChi_CN nvarchar(50),
	TinhThanh nvarchar(30),
	TinhTrang nvarchar(50),
	NgayThanhLap datetime,
	MaMonAn char(100),
	SoBan char(100),
	Primary key(Ma_CN)
)

CREATE TABLE Ban
(
	Ma_Ban char(10),
	LoaiBan varchar(10),
	TinhTrangBan varchar(6),
	Ma_CN char(10)
	PRIMARY KEY(Ma_Ban)
)

CREATE TABLE Menu
(
	Ma_CN char(10),
	Ma_MA char(10)
)

CREATE TABLE Bao_Cao_Theo_Chi_Nhanh
(
	Ma_BCCN char(10),
	Ma_CN char(10),
	Ma_DH char(10),
	NgayLap_BC datetime,
	NoiDung_BC varchar(50),
	LoaiBaoCao varchar(10),
	ChiPhiBoRa float,
	DoanhThu float,
	LoiNhuan float,
	TyLe int,
	PRIMARY KEY(Ma_BCCN)
)

CREATE TABLE Bao_Cao_Tong
(
	Ma_BCT char(10),
	Ma_BCCN char(10),
	NgayLap_BC datetime,
	NoiDung_BC varchar(50),
	Loai_BC varchar(10),
	TongDoanhThu float,
	TongChiPhi float,
	TongLoiNhuan float
	PRIMARY KEY(Ma_BCT)
)

CREATE TABLE Bieu_Do_Don_Hang
(
	Ma_BDDH char(10),
	Ten_BDDH varchar(10),
	Ma_DH char(10),
	MocThoiGian varchar(10)
	PRIMARY KEY(Ma_BDDH)
)

CREATE TABLE Bieu_Do_Khach_Hang
(
	Ma_BDKH char(10),
	Ten_BDKH varchar(10),
	Ma_KH char(10),
	MocThoiGian varchar(10)
	PRIMARY KEY(Ma_BDKH)
)

CREATE TABLE Nhan_Vien
(
	Ma_NV char(20),
	ID_NV char(20),
	Password_NV char(20),
	Ten_NV nvarchar(50),
	CMND char(10) Unique,
	SoDienThoai_NV char(10),
	Ma_CN char(20),
	CaLam nvarchar(10),
	BoPhan nvarchar(20),
	DanhGia nvarchar(50),
	ThamNien varchar(10),
	NgayBatDauLam datetime,
	Luong char(15)
	PRIMARY KEY(Ma_NV)
)

CREATE TABLE Khach_Hang
(
	Ma_KH char(20),
	ID_KH char(20),
	Password_KH char(20),
	Ten_KH nvarchar(50),
	NgaySinh_KH datetime,
	DiaChi_KH nvarchar(50),
	SoDienThoai_KH char(20)
	PRIMARY KEY(Ma_KH)
)

CREATE TABLE Don_Hang
(
	Ma_DH char(10),
	MA_KH char(10),
	Ma_CN char(10),
	SoLuong int,
	NgayDat datetime,
	KhuyenMai varchar(30),
	PhiShip float,
	TrangThai_DH varchar(10)
	PRIMARY KEY(Ma_DH)
)

CREATE TABLE Chi_Tiet_Don_Hang
(
	Ma_DH char(10),
	Ma_MA char(10)
)

CREATE TABLE Hoa_Don
(
	Ma_HD char(10),
	Ma_DH char(10),
	Ma_NV char(10),
	NgayLap_HD datetime,
	MaThe char(12),
	NganHang varchar(10),
	Thue float
	PRIMARY KEY(Ma_HD)
)

CREATE TABLE Tong_Dai
(
	Ma_TD char(10),
	Ma_DH char(10),
	PRIMARY KEY(MA_TD)
)
GO

---------------------------------------------------------------------------------------------------------------------------------
Insert into Mon_An
values('MA1','Banh Canh',15000,'Ngon','CN1'),
		('MA2','Banh Canh Sua',25000,'Tuyet','CN2')

TRUNCATE TABLE Chi_Nhanh

TRUNCATE TABLE Mon_An

select * from Chi_Nhanh

select * from Mon_An

Select * from Nhan_Vien

Delete Mon_An Where Ten_MA = N'Cơm Trộn1'

Delete Chi_Nhanh Where Ten_CN = N'cơm gà'


drop database QuanLiQuanAn

InSert into Chi_Nhanh values('CN01',N'Bánh Bò','26265656',N'Đường D1',N'Quận 1',N'Hoạt động bình thường','20101010','40','MA1-5-6-8-1-3')
InSert into Chi_Nhanh values('CN02',N'Bánh Bèo','26265656',N'Đường D2',N'Quận 2',N'Hoạt động bình thường','20101020','50','MA1-2-6-8-1-3')
InSert into Chi_Nhanh values('CN03',N'Bánh Ú','26265656',N'Đường D3',N'Quận 3',N'Hoạt động bình thường','20101020','50','MA1-3-6-8-1')
InSert into Chi_Nhanh values('CN04',N'Bánh Đa','26265656',N'Đường D4',N'Quận 4',N'Hoạt động bình thường','20101020','50','MA1-4-6-8-1-3')
InSert into Chi_Nhanh values('CN05',N'Bánh Củ Cải','26265656',N'Đường D5',N'Quận 5',N'Hoạt động bình thường','20101020','50','MA1-5-6-8-1-3')
InSert into Chi_Nhanh values('CN06',N'Bánh Bao','26265656',N'Đường D6',N'Quận 6',N'Hoạt động bình thường','20101020','50','MA1-6-8-1-3')

update Chi_Nhanh set NgayThanhLap = '20100920' Where Ma_CN = 'CN01'

InSert into Mon_An values('MA01',N'Cơm Trộn1','20000',N'Món truyền thống','Cơm')
InSert into Mon_An values('MA06',N'Cơm Trộn2','20000',N'Món truyền thống','Gà')
InSert into Mon_An values('MA03',N'Cơm Trộn3','20000',N'Món truyền thống','Dê')
InSert into Mon_An values('MA04',N'Cơm Trộn4','20000',N'Món truyền thống','Heo')


Insert into Nhan_Vien values('NV1','TKNV01','123',N'Nguyễn Văn A','100','626262','','','','','','20100225','')

Truncate table Nhan_Vien

Select * from Khach_Hang

Select * from Nhan_Vien

Insert into Khach_Hang values('KH01','TK01','123',N'Nguyễn Văn A','20100320',N'Đường C','55656')