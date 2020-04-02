use QLYellowCabPizza
create table TaiKhoanQuanLy
(
	TaiKhoan varchar(30) not null primary key,
	MatKhau varchar(10) not null,
	TenQuanLy nvarchar(30) not null,
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

create table XuatHang
(
	SoHoaDon  varchar(30) primary key,
	NgayXuat date default getdate(),
);

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

insert into BaoCaoXuatHang values ('YLCXH0001','H','HAM','MS','TT','',10,12000)

create table NhanVien
(
	MaNhanVien varchar(30) primary key,
	TenNhanVien nvarchar(100),
	NamSinh int,
	DiaChi nvarchar(100),
	SoDienThoai varchar(10)
);


update QuanLyNguyenLieu set SoLuong = SoLuong - 
(select SoLuong from ChiTietNhapHang where MaNguyenLieu = 'H' and SoHoaDon = 'YLCNH0016') 
where MaNguyenLieu = 'H'

select * from NguyenLieu where MaNguyenLieu='h';

SELECT * FROM TaiKhoanQuanLy WHERE TaiKhoan ='tuankiet96' and MatKhau='12345'