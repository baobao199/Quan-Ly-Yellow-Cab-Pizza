use QLYellowCabPizza
--DanhMucNguyenLieu(MaNguyenLieu, TenDanhMuc)
create table LoaiNguyenLieu
(
	MaLoaiNguyenLieu varchar(30) not null primary key,
	TenLoaiNguyenLieu nvarchar(30) not null
);
--NguyenLieu(MaNguyenLieu, TenNguyenLieu, MaDanhMuc, SoLuong, GiaTien, ChiTiet)
create table NguyenLieu
(
	MaNguyenLieu varchar(30) not null primary key,
	TenNguyenLieu nvarchar(50) not null,
	MaLoaiNguyenLieu varchar(30) not null,
	MaNhaCungCap nvarchar(30),
	SoLuong int,
	Giatien int not null,
	foreign key (MaLoaiNguyenLieu) references LoaiNguyenLieu(MaLoaiNguyenLieu)
);
update LoaiNguyenLieu set MaLoaiNguyenLieu = 'MS', TenLoaiNguyenLieu = 'Meat food' where MaLoaiNguyenLieu = 'MS'