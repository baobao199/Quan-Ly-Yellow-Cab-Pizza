use QLYellowCabPizza
--DanhMucNguyenLieu(MaNguyenLieu, TenDanhMuc)
create table LoaiNguyenLieu
(
	MaLoaiNguyenLieu varchar(30) not null primary key,
	TenLoaiNguyenLieu nvarchar(30) not null
);

--NguyenLieu(MaNguyenLieu, TenNguyenLieu)
create table NguyenLieu
(
	MaNguyenLieu varchar(30) primary key,
	TenNguyenLieu nvarchar(50),
	MaLoaiNguyenLieu varchar(30),
	foreign key (MaLoaiNguyenLieu) references LoaiNguyenLieu(MaLoaiNguyenLieu)
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

--QuanLyNguyenLieu(MaNguyenLieu, TenNguyenLieu, MaLoaiNguyenLieu, SoLuong, GiaTien)
create table QuanLyNguyenLieu
(
	MaNguyenLieu varchar(30) not null primary key,
	TenNguyenLieu nvarchar(50) not null,
	MaLoaiNguyenLieu varchar(30) not null,
	MaNhaCungCap varchar(30),
	SoLuong int,
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

create table ChiTietNhapHang
(
	SoHoaDon varchar(30),
	MaNguyenLieu varchar(30),
	TenNguyenLieu nvarchar(50),
	MaNhaCungCap varchar(30),
	SoLuong int,
	GiaTien int,
	constraint pk_ctnh primary key(SoHoaDon,MaNguyenLieu),
	foreign key (MaNguyenLieu) references NguyenLieu(MaNguyenLieu),
	foreign key (MaNhaCungCap) references NhaCungCap(MaNhaCungCap),
	foreign key (SoHoaDon) references NhapHang(SoHoaDon)
);

create table BaoCaoNhapHang
(
	SoHoaDon  varchar(30),
	MaNguyenLieu varchar(30),
	TenNguyenLieu nvarchar(50),
	MaNhaCungCap varchar(30),
	NgayNhap date default getdate(),
	SoLuong int,
	GiaTien int,
	constraint pk_ctbc primary key(SoHoaDon,MaNguyenLieu),
	foreign key (MaNguyenLieu) references NguyenLieu(MaNguyenLieu),
	foreign key (MaNhaCungCap) references NhaCungCap(MaNhaCungCap),
	foreign key (SoHoaDon) references NhapHang(SoHoaDon)
);

insert into NhapHang values ('YLCNH0001','03-17-2020')
--them du lieu vao chi tiet nhap hang
insert into ChiTietNhapHang values ('YLCNH0001','H','HAM','VIN',2,36000)
insert into ChiTietNhapHang values ('YLCNH0001','GL','GRALIC','COOP',10,12000)

insert into BaoCaoNhapHang values ('YLCNH0001','H','HAM','VIN','',2,36000)

delete ChiTietNhapHang where SoHoaDon = 'YLCNH0002';
delete NhapHang where SoHoaDon = 'YLCNH0004';
delete BaoCaoNhapHang where SoHoaDon = 'YLCNH0002';

update ChiTietNhapHang set MaNguyenLieu ='gl', TenNguyenLieu = 'gralic', MaNhaCungCap ='vin', SoLuong= 1, GiaTien = 5 where SoHoaDon = 'YLCNH0002' and MaNguyenLieu = 'gl'

insert into BaoCaoNhapHang values ('YLCNH0001','GL','GRALIC','COOP','',10,12000)



