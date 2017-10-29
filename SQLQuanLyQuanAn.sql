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
	Ten_MA varchar(20),
	Gia float,
	GhiChu varchar(30),
	PRIMARY KEY(Ma_MA)
)

CREATE TABLE Chi_Nhanh
(
	Ma_CN char(10),
	Ten_CN varchar(15),
	SoDienThoai_CN char(10),
	DiaChi_CN varchar(20),
	TinhThanh varchar(10),
	TinhTrang varchar(10),
	NgayThanhLap datetime
	PRIMARY KEY(Ma_CN)
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
	Ma_NV char(10),
	ID_NV char(10),
	Password_NV char(20),
	Ten_NV varchar(10),
	CMND char(9) Unique,
	SoDienThoai_NV char(10),
	Ma_CN char(10),
	CaLam varchar(5),
	BoPhan varchar(10),
	DanhGia_NV varchar(6),
	ThamNien varchar(10),
	NgayBatDauLam datetime,
	Luong float
	PRIMARY KEY(Ma_NV)
)

CREATE TABLE Khach_Hang
(
	Ma_KH char(10),
	ID_KH char(10),
	Password_KH char(20),
	Ten_KH varchar(20),
	DiaChi_KH varchar(20),
	SoDienThoai_KH char(10)
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

ALTER TABLE Danh_Muc ADD
CONSTRAINT FK_Danh_Muc_Chi_Nhanh FOREIGN KEY(Ma_CN) REFERENCES Chi_Nhanh(Ma_CN)
ALTER TABLE Chi_Tiet_Danh_Muc ADD
CONSTRAINT FK_Chi_Tiet_Danh_Muc_Danh_Muc FOREIGN KEY(Ma_DM) REFERENCES Danh_Muc(Ma_DM)
ALTER TABLE Chi_Tiet_Danh_Muc ADD
CONSTRAINT FK_Chi_Tiet_Danh_Muc_Mon_An FOREIGN KEY(Ma_MA) REFERENCES Mon_An(Ma_MA)
ALTER TABLE Ban ADD
CONSTRAINT FK_Ban_Chi_Nhanh FOREIGN KEY(Ma_CN) REFERENCES Chi_Nhanh(Ma_CN)
ALTER TABLE Menu ADD
CONSTRAINT FK_Menu_Chi_Nhanh FOREIGN KEY(Ma_CN) REFERENCES Chi_Nhanh(Ma_CN)
ALTER TABLE Menu ADD
CONSTRAINT FK_Menu_Mon_An FOREIGN KEY(Ma_MA) REFERENCES Mon_An(Ma_MA)
ALTER TABLE Bao_Cao_Theo_Chi_Nhanh ADD
CONSTRAINT FK_Bao_Cao_Theo_Chi_Nhanh_Chi_Nhanh FOREIGN KEY(Ma_CN) REFERENCES Chi_Nhanh(Ma_CN)
ALTER TABLE Bao_Cao_Theo_Chi_Nhanh ADD
CONSTRAINT FK_Bao_Cao_Theo_Chi_Nhanh_Don_Hang FOREIGN KEY(Ma_DH) REFERENCES Don_Hang(Ma_DH)
ALTER TABLE Bao_Cao_Tong ADD
CONSTRAINT FK_Bao_Cao_Tong_Bao_Cao_Theo_Chi_Nhanh FOREIGN KEY(Ma_BCCN) REFERENCES Bao_Cao_Theo_Chi_Nhanh(Ma_BCCN)
ALTER TABLE Bieu_Do_Don_Hang ADD
CONSTRAINT FK_Bieu_Do_Don_Hang_Don_Hang FOREIGN KEY(Ma_DH) REFERENCES Don_Hang(Ma_DH)
ALTER TABLE Bieu_Do_Khach_Hang ADD
CONSTRAINT FK_Bieu_Do_Khach_Hang_Khach_Hang FOREIGN KEY(Ma_KH) REFERENCES Khach_Hang(Ma_KH)
ALTER TABLE Nhan_Vien ADD
CONSTRAINT FK_Nhan_Vien_Chi_Nhanh FOREIGN KEY(Ma_CN) REFERENCES Chi_Nhanh(Ma_CN)
ALTER TABLE Don_Hang ADD
CONSTRAINT FK_Don_Hang_Chi_Nhanh FOREIGN KEY(Ma_CN) REFERENCES Chi_Nhanh(Ma_CN)
ALTER TABLE Don_Hang ADD
CONSTRAINT FK_Don_Hang_Khach_Hang FOREIGN KEY(Ma_KH) REFERENCES Khach_Hang(Ma_KH)
ALTER TABLE Chi_Tiet_Don_Hang ADD
CONSTRAINT FK_Chi_Tiet_Don_Hang_Don_Hang FOREIGN KEY(Ma_DH) REFERENCES Don_Hang(Ma_DH)
ALTER TABLE Chi_Tiet_Don_Hang ADD
CONSTRAINT FK_Chi_Tiet_Don_Hang_Mon_An FOREIGN KEY(Ma_MA) REFERENCES Mon_An(Ma_MA)
ALTER TABLE Hoa_Don ADD
CONSTRAINT FK_Hoa_Don_Don_Hang FOREIGN KEY(Ma_DH) REFERENCES Don_Hang(Ma_DH)
ALTER TABLE Hoa_Don ADD
CONSTRAINT FK_Hoa_Don_Nhan_Vien FOREIGN KEY(Ma_NV) REFERENCES Nhan_Vien(Ma_NV)
ALTER TABLE Tong_Dai ADD
CONSTRAINT FK_Tong_Dai_Don_Hang FOREIGN KEY(Ma_DH) REFERENCES Don_Hang(Ma_DH)