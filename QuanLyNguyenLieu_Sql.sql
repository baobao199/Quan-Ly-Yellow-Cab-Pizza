create table QLYellowCabPizza
USE QLYellowCabPizza
--TaiKhoanQuanLy(TaiKhoan, MatKhau, TenQuanLy)
create table TaiKhoanQuanLy
(
	TaiKhoan varchar(30) not null primary key,
	MatKhau varchar(10) not null,
	TenQuanLy nvarchar(30) not null,
);
--NhanVien(MaNhanVien, TenNhanVien, NamSinh, DiaChi, SoDienThoai)
create table NhanVien
(
	MaNhanVien varchar(30) primary key,
	TenNhanVien nvarchar(100),
	NamSinh int,
	DiaChi nvarchar(100),
	SoDienThoai varchar(10)
);
--DanhMucNguyenLieu(MaNguyenLieu, TenDanhMuc)
create table LoaiNguyenLieu
(
	MaLoaiNguyenLieu varchar(30) not null primary key,
	TenLoaiNguyenLieu nvarchar(30) not null
);
--NhaCungCap(MaNhaCungCap, TenNhaCungCap, DiaChi, Email, SoDienThoai)
create table NhaCungCap
(
	MaNhaCungCap varchar(30) not null primary key,
	TenNhaCungCap nvarchar(50) not null,
	DiaChi nvarchar(50) not null,
	Email varchar(30),
	SoDienThoai varchar(10) not null
);
--NguyenLieu(MaNguyenLieu, TenNguyenLieu)
create table NguyenLieu
(
	MaNguyenLieu varchar(30) primary key,
	TenNguyenLieu nvarchar(50),
	MaLoaiNguyenLieu varchar(30),
	MaNhaCungCap varchar(30),
	GiaTien int,
	foreign key (MaLoaiNguyenLieu) references LoaiNguyenLieu(MaLoaiNguyenLieu),
	foreign key (MaNhaCungCap) references NhaCungCap(MaNhaCungCap)
);
--QuanLyNguyenLieu(MaNguyenLieu, TenNguyenLieu, MaLoaiNguyenLieu, SoLuong, GiaTien)
create table QuanLyNguyenLieu
(
	MaNguyenLieu varchar(30) not null primary key,
	TenNguyenLieu nvarchar(50) not null,
	MaLoaiNguyenLieu varchar(30) not null,
	MaNhaCungCap varchar(30),
	SoLuong int,
	GiaTien int,
	foreign key (MaNguyenLieu) references NguyenLieu(MaNguyenLieu),
	foreign key (MaLoaiNguyenLieu) references LoaiNguyenLieu(MaLoaiNguyenLieu),
	foreign key (MaNhaCungCap) references NhaCungCap(MaNhaCungCap)
);

--Nhap(MaNhaCungCap,  NgayNhap, NguoiNhap)
create table NhapHang
(
	SoHoaDon  varchar(30) primary key,
	NgayNhap date default getdate(),

);
--ChiTietNhapHang(SoHoaDon, MaNguyenLieu, MaLoaiNguyenLieu, MaNhaCungCap, SoLuong, GiaTien)
create table ChiTietNhapHang
(
	SoHoaDon varchar(30),
	MaNguyenLieu varchar(30),
	TenNguyenLieu nvarchar(50),
	MaLoaiNguyenLieu varchar(30),
	MaNhaCungCap varchar(30),
	SoLuong int,
	GiaTien int,
	constraint pk_ctnh primary key(SoHoaDon,MaNguyenLieu),
	foreign key (SoHoaDon) references NhapHang(SoHoaDon),
	foreign key (MaNguyenLieu) references NguyenLieu(MaNguyenLieu),
	foreign key (MaLoaiNguyenLieu) references LoaiNguyenLieu(MaLoaiNguyenLieu),
	foreign key (MaNhaCungCap) references NhaCungCap(MaNhaCungCap),
);
--BaoCaoNhapHang(SoHoaDon, MaNguyenLieu, TenNguyenLieu, MaLoaiNguyenLieu, MaNhaCungCap, NgayNhap, GiaTien)
create table BaoCaoNhapHang
(
	SoHoaDon  varchar(30),
	MaNguyenLieu varchar(30),
	TenNguyenLieu nvarchar(50),
	MaLoaiNguyenLieu varchar(30),
	MaNhaCungCap varchar(30),
	NgayNhap date default getdate(),
	SoLuong int,
	GiaTien int,
	constraint pk_ctbc primary key(SoHoaDon,MaNguyenLieu),
	foreign key (MaNguyenLieu) references NguyenLieu(MaNguyenLieu),
	foreign key (MaLoaiNguyenLieu) references LoaiNguyenLieu(MaLoaiNguyenLieu),
	foreign key (MaNhaCungCap) references NhaCungCap(MaNhaCungCap),
	foreign key (SoHoaDon) references NhapHang(SoHoaDon)
);
--XuatHang(SoHoaDon,  NgayXuat)
create table XuatHang
(
	SoHoaDon  varchar(30) primary key,
	NgayXuat date default getdate(),
);
--ChiTietNhapHang(SoHoaDon, MaNguyenLieu, MaLoaiNguyenLieu, MaNhaCungCap, SoLuong, GiaTien)
create table ChiTietXuatHang
(
	SoHoaDon varchar(30),
	MaNguyenLieu varchar(30),
	TenNguyenLieu nvarchar(50),
	MaLoaiNguyenLieu varchar(30),
	MaNhaCungCap varchar(30),
	SoLuong int,
	GiaTien int,
	constraint pk_ctxh primary key(SoHoaDon,MaNguyenLieu),
	foreign key (MaNguyenLieu) references NguyenLieu(MaNguyenLieu),
	foreign key (MaLoaiNguyenLieu) references LoaiNguyenLieu(MaLoaiNguyenLieu),
	foreign key (MaNhaCungCap) references NhaCungCap(MaNhaCungCap),
	foreign key (SoHoaDon) references XuatHang(SoHoaDon)
);
--BaoCaoNhapHang(SoHoaDon, MaNguyenLieu, TenNguyenLieu, MaLoaiNguyenLieu, MaNhaCungCap, NgayNhap, GiaTien)
create table BaoCaoXuatHang
(
	SoHoaDon  varchar(30),
	MaNguyenLieu varchar(30),
	TenNguyenLieu nvarchar(50),
	MaLoaiNguyenLieu varchar(30),
	MaNhaCungCap varchar(30),
	NgayXuat date default getdate(),
	SoLuong int,
	GiaTien int,
	constraint pk_ctbcxh primary key(SoHoaDon,MaNguyenLieu),
	foreign key (MaNguyenLieu) references NguyenLieu(MaNguyenLieu),
	foreign key (MaLoaiNguyenLieu) references LoaiNguyenLieu(MaLoaiNguyenLieu),
	foreign key (MaNhaCungCap) references NhaCungCap(MaNhaCungCap),
	foreign key (SoHoaDon) references XuatHang(SoHoaDon)
);
--NHẬP DỮ LIỆU QUẢN LÝ
insert into TaiKhoanQuanLy values ('ngoctram95', '123456', N'NGÔ THỤY TRÙY TRÂM');
insert into TaiKhoanQuanLy values ('anhkiet95', '123456', N'VÕ ANH KIỆT');
--NHẬP DỮ LIỆU NHÂN VIÊN
insert into NhanVien values ('QB', N'NGUYỄN QUỐC BẢO', '1999',N'QUẬN 7','0365997331');
insert into NhanVien values ('ND', N'LÊ NGỌC DUY', '1999',N'QUẬN 4','0907826651');
insert into NhanVien values ('CL', N'LÊ CẨM LINH', '1998',N'QUẬN 8','090722351');
--NHẬP DỮ LIỆU LOẠI NGUYÊN LIỆU
insert into LoaiNguyenLieu values ('MS', 'MEAT SEAFOOD');
insert into LoaiNguyenLieu values ('D', 'DOUGH');
insert into LoaiNguyenLieu values ('VS', 'VESTABALES');
insert into LoaiNguyenLieu values ('SA', 'SAUCE');
insert into LoaiNguyenLieu values ('ChD', 'CHEESE DAIRY');
--NHẬP DỮ LIỆU NHÀ CUNG CẤP
insert into NhaCungCap values ('COOP', N'COOP MART', N'QUẬN 2', 'COOP@GMAIL.COM', '0907865542');
insert into NhaCungCap values ('VIN', N'VIN MART', N'QUẬN 9', 'VIN@GMAIL.COM', '0907654321');
insert into NhaCungCap values ('TT', N'THỊT TƯƠI', N'QUẬN BÌNH CHÁNH', 'TT@GMAIL.COM', '0367889772');
insert into NhaCungCap values ('RS', N'RAU SẠCH', N'QUẬN ', 'VIN@GMAIL.COM', '0907654321');
-- NHẬP DỮ LIỆU NGUYÊN LIỆU
insert into NguyenLieu values ('H', 'HAM', 'MS', 'TT', '30000');
insert into NguyenLieu values ('GL', 'GRALIC', 'VS', 'RS', '5000');
insert into NguyenLieu values ('BACON BIT', 'BA', 'MS', 'TT', '45000');
insert into NguyenLieu values ('PIZZA FLOUR', 'PF', 'D', 'VIN', '60000');
insert into NguyenLieu values ('RP', 'RED PEPPER', 'VS', 'COOP', '15000');
insert into NguyenLieu values ('PS', 'PIZZA SAUCE', 'SA', 'VIN', '65000');
