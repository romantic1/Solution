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
	Ten_DM nvarchar(20),	
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
	Ten_CN nvarchar(50),
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
	Ma_DHTD int ,
	Ten_DH nvarchar(50),
	sdtKH char(15),
	dcKH char(100),
	Ten_CN nvarchar(50),
	TrangThai nvarchar(100),
	KhuyenMai nvarchar(15),
	NhanVien nvarchar(50),
	ThoiGian datetime,
	TongTien float,
)
CREATE TABLE Chi_Tiet_Don_Hang_DT
(	id int IDENTITY(1,1),
	Ma_DHTD char(10),
	Ma_MA char(10)
	PRIMARY KEY(id)
)

CREATE TABLE DoanhThuTungChiNhanh(
	Ten_CN nvarchar(50),
	TongTien float
)

GO
---------------------------------------------------------------------------------------------------------------------------------

--Chi Nhanh
InSert into Chi_Nhanh values('CN01',N'Nhà Hàng Quận 1','09094623571',N'Số 315 Nguyễn Chí Thanh',N'Quận 1',N'Hoạt động bình thường','20120510','40','MA1-5-6-8-1-3')
InSert into Chi_Nhanh values('CN02',N'Nhà Hàng Quận 3','09094623525',N'Số 125 Nguyễn Đình Chiểu',N'Quận 3',N'Tạm dừng bảo dưỡng','20101020','50','MA1-2-6-8-1-3')
InSert into Chi_Nhanh values('CN03',N'Nhà Hàng Quận 5','09094623534',N'Số 110 Nguyễn Trãi',N'Quận 5',N'Hoạt động bình thường','20110620','50','MA1-3-6-8-1')

--Mon An
InSert into Mon_An values('MA01',N'Lẩu Bò','150000','',N'Bò')
InSert into Mon_An values('MA02',N'Gà Xả Ớt','110000','',N'Gà')
InSert into Mon_An values('MA03',N'Dê Hấp','120000','',N'Dê')
InSert into Mon_An values('MA04',N'Heo Quay Lu','140000','',N'Lợn')
InSert into Mon_An values('MA05',N'Bành Mì Cà Ri','160000','',N'Gà')
InSert into Mon_An values('MA06',N'Gà Ta Luột','130000','',N'Gà')
InSert into Mon_An values('MA07',N'Dê Nướng Trong Gừng','120000','',N'Dê')
InSert into Mon_An values('MA08',N'Bò Xiên Nướng','120000','',N'Bò')
InSert into Mon_An values('MA09',N'Sườn Lợn Suốt','140000','',N'Lợn')
InSert into Mon_An values('MA010',N'Bò Muối Chua Ngọt','160000','',N'Bò')
-- Danh mục
InSert into Danh_Muc values('DM01',N'Bò')
InSert into Danh_Muc values('DM02',N'Lợn')
InSert into Danh_Muc values('DM03',N'Lẩu')
InSert into Danh_Muc values('DM04',N'Cơm')
InSert into Danh_Muc values('DM05',N'Bún - Phở')
InSert into Danh_Muc values('DM06',N'Cháo')
InSert into Danh_Muc values('DM07',N'Hải Sản')
InSert into Danh_Muc values('DM08',N'Gà')
InSert into Danh_Muc values('DM09',N'Dê')
--Chi_Tiet_Danh_Muc
InSert into Chi_Tiet_Danh_Muc values('DM01','MA01')
InSert into Chi_Tiet_Danh_Muc values('DM01','MA10')
InSert into Chi_Tiet_Danh_Muc values('DM01','MA08')
InSert into Chi_Tiet_Danh_Muc values('DM08','MA02')
InSert into Chi_Tiet_Danh_Muc values('DM08','MA06')
InSert into Chi_Tiet_Danh_Muc values('DM02','MA04')
InSert into Chi_Tiet_Danh_Muc values('DM02','MA09')
InSert into Chi_Tiet_Danh_Muc values('DM09','MA03')
InSert into Chi_Tiet_Danh_Muc values('DM09','MA07')
--Don_Hang_Tong_Dai

InSert into Don_Hang_Tong_Dai values('1','','','','','','','','','')
--Nhan Vien
Insert into Nhan_Vien values('NV01','ADMIN','Xuan123',N'Nguyễn Thị Kiều Xuân','365423269','09094236541',N'Nhà Hàng Quận 1','123',N'Giám Đốc','','20121220','')
Insert into Nhan_Vien values('NV02','TKNV2','Phuc123',N'Nguyễn Xuân Phúc','365423245','09094236524',N'Nhà Hàng Quận 3','123',N'Bán Hàng',N'Tốt','20121222','15000')
Insert into Nhan_Vien values('NV03','TKNV3','HuongT123',N'Tô Thị Cẩm Hương','365423237','09094236513',N'Nhà Hàng Quận 5','123',N'Tổng Đài',N'Tốt','20121225','15000')

--Khach Hang
Insert into Khach_Hang values('KH01','TKKH01','Xuan123',N'Nguyễn Xuân',N'Nhà Hàng Quận 3','19900212',N'Số 112 Điện Biên Phủ','0909236545')
Insert into Khach_Hang values('KH02','TKKH02','Tai123',N'Phan Văn Tài',N'Nhà Hàng Quận 5','19910321',N'Số 110 Bùi Viện','0909236547')
Insert into Khach_Hang values('KH03','TKKH03','Hong123',N'Trịnh Thị Hồng',N'Nhà Hàng Quận 1','19920412',N'45 Tô Ngọc Vân','0909236531')
Insert into Khach_Hang values('KH04','TKKH04','A123',N'Trịnh Văn A',N'Nhà Hàng Quận 1','19920412',N'45 Tô Ngọc Vân','0909236531')
Insert into Khach_Hang values('KH05','TKKH05','B123',N'Trịnh Xuân B',N'Nhà Hàng Quận 1','19920412',N'45 Tô Ngọc Vân','0909236531')

--Don Hang Chi Nhanh
Insert into Don_Hang_Chi_Nhanh values('DHCN01',N'Bàn Số 5','KH02',N'Nhà Hàng Quận 3',N'Chưa Thanh Toán',N'Không','NV02','20120320','200000')
Insert into Don_Hang_Chi_Nhanh values('DHCN02',N'Bàn Số 15','KH03',N'Nhà Hàng Quận 1',N'Đã Thanh Toán',N'Có','NV02','20120320','300000')
Insert into Don_Hang_Chi_Nhanh values('DHCN03',N'Bàn Số 11','KH01',N'Nhà Hàng Quận 5',N'Chưa Thanh Toán',N'Có','NV02','20120320','400000')

--Don Hang
Insert into Don_Hang values('DH01','KH01',N'Nhà Hàng Quận 1','10','20171112','20171113',N'Không','15000',N'Đã Hoàn Thành')
Insert into Don_Hang values('DH02','KH02',N'Nhà Hàng Quận 3','7','20171112','20171113',N'Không','25000',N'Đã Hoàn Thành')
Insert into Don_Hang values('DH03','KH03',N'Nhà Hàng Quận 5','9','20171112','20171113',N'Không','20000',N'Chưa Hoàn Thành')

--Thong Tin Ban
Insert into ThongTinBan values('B01',N'Bàn 2 Người','2',N'Còn Trống',N'Nhà Hàng Quận 3','')
Insert into ThongTinBan values('B02',N'Bàn 4 Người','3',N'Đang Hoạt Động',N'Nhà Hàng Quận 3','KH02')
Insert into ThongTinBan values('B03',N'Bàn 8 Người','7',N'Đặt Trước',N'Nhà Hàng Quận 3','KH02')