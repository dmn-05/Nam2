--csdl quản lý bán hàng
use master
create database banhang
go
--
use banhang
go
create table SanPham
(MaSp	int 	primary key,
TenSp	nvarchar(100)	,
MoTa	nvarchar(200),	
Donvitinh	nvarchar(20),
SoLuong int,	
DonGia	 Money,
mancc int
)
go
create table
nhanvien
(
	MaNV int primary key,
	HoNV	nvarchar(30),
	TenNV	nvarchar(30),
	GioiTinh	nvarchar(3),
	NgaySinh	datetime,
	DiaChi	nvarchar(100),
	Phone varchar(24)

)
create table HoaDon
(
MaHD	Int	primary key,
NgayLapHD	DateTime,
MaNV int,
NoiChuyen	nvarchar(50),
MaKh	char(5),
LoaiHD char(1)
)
create table CT_HoaDon
(
MaHD	Int	,
MaSp	int	,
SoLuong	Int	,
DonGia	Money,	
ChietKhau	Money,primary key(mahd,masp)
)
create table NhaCungCap
(
MaNCC	Int	primary key,
TenNcc	Nvarchar(100)	,
Diachi	Nvarchar(100),	
Phone	Varchar(24)	,
SoFax	Varchar(24)	,
DCMail	Varchar(50)	
)
create table KhachHang
(
MaKh	Char(5)primary key	,
TenKh	Nvarchar(100)	,
DiaChi	Nvarchar(100),	
Phone	Varchar(24),	
SoFax	Varchar(24)	,
DCMail	varchar(50)	
)
alter table hoadon
add foreign key(makh) references khachhang(makh)
--
alter table hoadon
add foreign key(manv)references nhanvien(manv)
--
alter table ct_hoadon
add foreign key(mahd) references hoadon(mahd)
--
alter table ct_hoadon
add foreign key(masp) references sanpham(masp)
--
alter table sanpham
add foreign key(mancc) references nhacungcap(mancc)

insert into nhanvien(MaNV,
	HoNV,
	TenNV,
	GioiTinh,
	NgaySinh,
	DiaChi,
	Phone)
values(2, 'Do', 'Nhat', 'Nam', '2020-10-10', 'TB', '01234556789')

insert into KhachHang(
MaKh,
TenKh,
DiaChi,	
Phone,	
SoFax,
DCMail)
values(1,'The', 'BT', '0123456789', '789654123', 'the@gmail.com')

insert into HoaDon(
MaHD,
NgayLapHD,
MaNV,
NoiChuyen,
MaKh,
LoaiHD
)
values (1, '2020-07-10', 2, 'haha', 1, 'A')

insert into NhaCungCap(
MaNCC,
TenNcc,
Diachi,	
Phone,
SoFax,
DCMail
)
values(1, '', '', '', '', '')

insert into SanPham(
MaSp,
TenSp,
MoTa,	
Donvitinh,
SoLuong,	
DonGia,
mancc
)
values (1, 'Banh', 'banh ne', 'Cái', 10, 10000,1)
insert into SanPham(
MaSp,
TenSp,
MoTa,	
Donvitinh,
SoLuong,	
DonGia,
mancc
)
values (2, 'Keo', 'keo ne', 'Cái', 10, 8000, 1)

insert into CT_HoaDon(
MaHD,
MaSp,
SoLuong,
DonGia,	
ChietKhau
)
values(1,1,10,100000, 50000)
insert into CT_HoaDon(
MaHD,
MaSp,
SoLuong,
DonGia,	
ChietKhau
)
values(1,2,10,100000,50000)
