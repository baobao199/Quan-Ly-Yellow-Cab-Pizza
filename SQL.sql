use QLYellowCabPizza
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

--NguyenLieu(MaNguyenLieu, TenNguyenLieu, MaDanhMuc, SoLuong, GiaTien, ChiTiet)
create table NguyenLieu
(
	MaNguyenLieu varchar(30) not null primary key,
	TenNguyenLieu nvarchar(50) not null,
	MaLoaiNguyenLieu varchar(30) not null,
	MaNhaCungCap varchar(30),
	SoLuong int,
	Giatien int not null,
	foreign key (MaLoaiNguyenLieu) references LoaiNguyenLieu(MaLoaiNguyenLieu),
	foreign key (MaNhaCungCap) references NhaCungCap(MaNhaCungCap)
);
select count(MaLoaiNguyenLieu) from LoaiNguyenLieu where MaLoaiNguyenLieu = 'H'

SELECT *
FROM LoaiNguyenLieu
WHERE EXISTS (SELECT MaLoaiNguyenLieu FROM LoaiNguyenLieu WHERE MaLoaiNguyenLieu = 'H');

--Nhap(MaNhaCungCap,  NgayNhap, NguoiNhap)
create table NhapHang
(
	SoHoaDon  varchar(10),
	MaNguyenLieu varchar(30),
	TenNguyenLieu varchar(30),
	LoaiNguyenLieu varchar(30),
	MaNhaCungCap varchar(30),
	NgayNhap date default getdate(),
	GiaTien int,
	SoLuong int,
	foreign key (MaNhaCungCap) references NhaCungCap(MaNhaCungCap),
	foreign key (MaNguyenLieu) references NguyenLieu(MaNguyenLieu),
);
select count(SoHoaDon) from NhapHang where SoHoaDon = 'h';
select * from NhapHang ORDER BY SoHoaDon ASC;

select MaNguyenLieu,TenNguyenLieu,LoaiNguyenLieu,MaNguyenLieu,GiaTien,SoLuong from NhapHang
