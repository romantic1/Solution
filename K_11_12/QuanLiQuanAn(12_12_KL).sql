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
	Ten_CN nvarchar(50),
	SoDienThoai_CN char(20),
	DiaChi_CN nvarchar(50),
	TinhThanh nvarchar(30),
	TinhTrang nvarchar(50),
	NgayThanhLap datetime,
	MaMonAn char(100),
	SoBan char(100),
	Primary key(Ma_CN)
)

CREATE TABLE ThongTinBan
(
	Ma_Ban char(15),
	LoaiBan nvarchar(50),
	SoLuongNguoi int,
	TinhTrangBan nvarchar(30),
	Ten_CN nvarchar(50),
	MaKhachHang char(15),
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
	NoiDung_BC nvarchar(50),
	LoaiBaoCao nvarchar(10),
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
	Password_NV char(30),
	Ten_NV nvarchar(50),
	CMND char(15) Unique,
	SoDienThoai_NV char(15),
	Ten_CN nvarchar(50),
	CaLam nvarchar(20),
	BoPhan nvarchar(20),
	DanhGia nvarchar(50),
	NgayBatDauLam datetime,
	Luong char(20),
	PRIMARY KEY(Ma_NV)
)

CREATE TABLE Khach_Hang
(
	Ma_KH char(20),
	ID_KH char(20),
	Password_KH char(20),
	Ten_KH nvarchar(50),
	Ten_CN nvarchar(50),
	NgaySinh_KH datetime,
	DiaChi_KH nvarchar(50),
	SoDienThoai_KH char(20)
	PRIMARY KEY(Ma_KH)
)

CREATE TABLE Don_Hang
(
	Ma_DH char(15),
	MA_KH char(15),
	Ma_CN nvarchar(50),
	SoLuong int,
	NgayDat datetime,
	NgayGiao datetime,
	KhuyenMai nvarchar(30),
	PhiShip float,
	TrangThai_DH nvarchar(15)
	PRIMARY KEY(Ma_DH)
)

CREATE TABLE Don_Hang_Chi_Nhanh(
	Ma_DHCN char(15),
	Ten_DH nvarchar(50),
	Ma_KH char(15),
	Ten_CN nvarchar(50),
	TrangThai nvarchar(50),
	KhuyenMai nvarchar(20),
	NhanVien nvarchar(20),
	ThoiGian datetime,
	TongTien float,
	Primary key(Ma_DHCN)
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

CREATE TABLE Don_Hang_Tong_Dai(
	Ma_DHTD char(15),
	Ten_DH nvarchar(50),
	Ma_KH char(15),
	Ten_CN nvarchar(50),
	TrangThai nvarchar(15),
	KhuyenMai nvarchar(15),
	NhanVien nvarchar(20),
	ThoiGian datetime,
	TongTien float,
)

CREATE TABLE DoanhThuTungChiNhanh(
	Ten_CN nvarchar(50),
	TongTien float
)

GO
---------------------------------------------------------------------------------------------------------------------------------

--Chi Nhanh
InSert into Chi_Nhanh values('CN01',N'Bánh Gạo Cay Giòn','26265656',N'Đường D1',N'Quận 1',N'Hoạt động bình thường','20101010','40','MA1-5-6-8-1-3')
InSert into Chi_Nhanh values('CN02',N'Bánh Chuối Tươi','26265656',N'Đường D2',N'Quận 2',N'Hoạt động bình thường','20101020','50','MA1-2-6-8-1-3')
InSert into Chi_Nhanh values('CN03',N'Bánh Gạo Dừa','26265656',N'Đường D3',N'Quận 3',N'Hoạt động bình thường','20101020','50','MA1-3-6-8-1')
InSert into Chi_Nhanh values('CN04',N'Bánh Sừng Trâu','26265656',N'Đường D4',N'Quận 4',N'Hoạt động bình thường','20101020','50','MA1-4-6-8-1-3')
InSert into Chi_Nhanh values('CN05',N'Bánh Trôi Nước','26265656',N'Đường D5',N'Quận 5',N'Hoạt động bình thường','20101020','50','MA1-5-6-8-1-3')
InSert into Chi_Nhanh values('CN06',N'Bánh Xèo Lá','26265656',N'Đường D6',N'Quận 6',N'Hoạt động bình thường','20101020','50','MA1-6-8-1-3')

--Mon An
InSert into Mon_An values('MA01',N'Cơm Chiên','20000',N'Món truyền thống','Cơm')
InSert into Mon_An values('MA06',N'Cơm Cuộn','20000',N'Món truyền thống','Gà')
InSert into Mon_An values('MA03',N'Cơm Thái','20000',N'Món truyền thống','Dê')
InSert into Mon_An values('MA04',N'Cơm SuSi','20000',N'Món truyền thống','Heo')

--Nhan Vien

Insert into Nhan_Vien values('NV01','123','123',N'Nguyễn Văn A','100','626262','','123',N'Giám Đốc','123','20100225','')


--Khach Hang
Insert into Khach_Hang values('KH01','TK01','123',N'Nguyễn Văn A','','20100320',N'Đường C','55656')

--Don Hang Chi Nhanh

Insert into Don_Hang_Chi_Nhanh values('DHCN01',N'Bàn Số 12','',N'Bánh Gạo Cay Giòn','','','','20120320','2000')
Insert into Don_Hang_Chi_Nhanh values('DHCN02',N'Bàn Số 12','',N'Bánh Chuối Tươi','','','','20120320','3000')
Insert into Don_Hang_Chi_Nhanh values('DHCN03',N'Bàn Số 12','',N'Bánh Gạo Dừa','','','','20120320','4000')
Insert into Don_Hang_Chi_Nhanh values('DHCN04',N'Bàn Số 12','',N'Bánh Xèo Lá','','','','20120320','5000')
Insert into Don_Hang_Chi_Nhanh values('DHCN05',N'Bàn Số 12','',N'Bánh Xèo Lá','','','','20120320','6000')


--Don Hang
Insert into Don_Hang values('DH01','','','','','','','','')

--Thong Tin Ban
Insert into ThongTinBan values('B01','','','','','')

Delete Nhan_Vien Where Ma_NV = 'NV01'

TRUNCATE TABLE Nhan_Vien

Select * from Khach_Hang

Select * from Nhan_Vien

Select * from Mon_An

Select * from Chi_Nhanh

Select * from Don_Hang_Chi_Nhanh

TRUNCATE TABLE Don_Hang_Chi_Nhanh

TRUNCATE TABLE Khach_Hang

Delete from Mon_An Where Ten_MA = 'Cơm Chiên'

TRUNCATE TABLE Chi_Nhanh

TRUNCATE TABLE Don_Hang_Chi_Nhanh

Select sum(TongTien) as TongTien from Don_Hang_Chi_Nhanh Where Ten_CN = N'Bánh Xèo Lá'

Select * from DoanhThuTungChiNhanh

TRUNCATE TABLE DoanhThuTungChiNhanh

Insert into DoanhThuTungChiNhanh values((Select Ten_CN from Don_Hang_Chi_Nhanh),(Select sum(TongTien) from Don_Hang_Chi_Nhanh Where Ten_CN = N'Bánh Xèo Lá' ))
Select * from Khach_Hang
Select Ten_CN,COUNT(Ten_CN) AS SoLuongKhach from Khach_Hang Group by Ten_CN

Select Ten_CN,Sum(TongTien) AS DoanhThuChiNhanh from Don_Hang_Chi_Nhanh Group by Ten_CN

Select Sum((Select Sum(TongTien) AS DoanhThuChiNhanh from Don_Hang_Chi_Nhanh Group by Ten_CN))

Select * from Don_Hang_Chi_Nhanh

Select Sum((Select Ten_CN,Sum(TongTien) from Don_Hang_Chi_Nhanh Group by Ten_CN))

