﻿CREATE DATABASE QUANLYBANHANG
GO
USE QUANLYBANHANG;
GO
--1. Tạo các quan hệ và khai báo các khóa chính, khóa ngoại của quan hệ.
CREATE TABLE KHACHHANG(
	MAKH CHAR(9),
	HOTEN NVARCHAR(25),
	DCHI NVARCHAR(100),
	SODT VARCHAR(11),
	NGSINH DATE,
	DOANHSO NVARCHAR(10),
	NGDK DATE
)
CREATE TABLE NHANVIEN(
	MANV CHAR(9),
	HOTEN NVARCHAR(25),
	NGAYVL DATE,
	SODT VARCHAR(11),
)
CREATE TABLE SANPHAM(
	MASP CHAR(9),
	TENSP NVARCHAR(25),
	DVT NVARCHAR(10),
	NUOCSX NVARCHAR(10),
	GIA VARCHAR(11)
)
CREATE TABLE HOADON(
	SOHD CHAR(9),
	NGHD DATE,
	MAKH CHAR(9),
	MANV CHAR(9),
	TRIGIA VARCHAR(11)
)
CREATE TABLE CTHD(
	SOHD CHAR(9),
	MASP CHAR(9),
	SL VARCHAR(11)
)

--KHÓA CHÍNH KHÁCH HÀNG
ALTER TABLE KHACHHANG
ALTER COLUMN MAKH CHAR(9) NOT NULL

ALTER TABLE KHACHHANG
ADD CONSTRAINT PK_KHACHHANG PRIMARY KEY (MAKH)

--KHÓA CHÍNH NHÂN VIÊN
ALTER TABLE NHANVIEN
ALTER COLUMN MANV CHAR(9) NOT NULL

ALTER TABLE NHANVIEN
ADD CONSTRAINT PR_NHANVIEN PRIMARY KEY (MANV)

--KHÓA CHÍNH SẢN PHẨM
ALTER TABLE SANPHAM
ALTER COLUMN MASP CHAR(9) NOT NULL

ALTER TABLE SANPHAM
ADD CONSTRAINT PK_SANPHAM PRIMARY KEY (MASP)

--KHÓA CHÍNH HÓA ĐƠN
ALTER TABLE HOADON
ALTER COLUMN SOHD CHAR(9) NOT NULL

ALTER TABLE HOADON
ADD CONSTRAINT PK_HOADON PRIMARY KEY (SOHD)

--KHÓA CHÍNH CTHD
ALTER TABLE CTHD
ALTER COLUMN SOHD CHAR(9) NOT NULL

ALTER TABLE CTHD
ALTER COLUMN MASP CHAR(9) NOT NULL

ALTER TABLE CTHD
ADD CONSTRAINT PK_CTHD PRIMARY KEY (SOHD, MASP)

--KHÓA NGOẠI HÓA ĐƠN
ALTER TABLE HOADON
ADD CONSTRAINT FK_HOADON_KH FOREIGN KEY (MAKH) REFERENCES KHACHHANG (MAKH),
	CONSTRAINT FK_HOADON_NV FOREIGN KEY (MANV) REFERENCES NHANVIEN (MANV)
--KHÓA NGOẠI CTHD
ALTER TABLE CTHD
ADD CONSTRAINT FK_CTHD_HD FOREIGN KEY (SOHD) REFERENCES HOADON (SOHD),
	CONSTRAINT FK_CTHD_SP FOREIGN KEY (MASP) REFERENCES SANPHAM (MASP)

--2. Thêm vào thuộc tính GHICHU có kiểu dữ liệu varchar(20) cho quan hệ SANPHAM.
ALTER TABLE SANPHAM
ADD GHICHU VARCHAR(25)
--3. Sửa kiểu dữ liệu của thuộc tính GHICHU trong quan hệ SANPHAM thành varchar(100).
ALTER TABLE SANPHAM
ALTER COLUMN GHICHU VARCHAR(100)
--4. Làm thế nào để thuộc tính LOAIKH trong quan hệ KHACHHANG có thể lưu các giá trị là: “Vang
--lai”, “Thuong xuyen”, “Vip”, …
ALTER TABLE KHACHHANG
ADD LOAIKH VARCHAR(11)

ALTER TABLE KHACHHANG
ADD CONSTRAINT CK_KH_LKH
CHECK (LOAIKH IN ('Vang--lai', 'Thuong xuyen', 'Vip'))
--5. Đơn vị tính của sản phẩm chỉ có thể là (“cay”,”hop”,”cai”,”quyen”,”chuc”)
ALTER TABLE SANPHAM
ADD CONSTRAINT CK_SP_DVT
CHECK (DVT IN ('cay','hop','cai','quyen','chuc'))
--6. Giá bán của sản phẩm từ 500 đồng trở lên.
ALTER TABLE SANPHAM
ADD CONSTRAINT CK_SP_GIA
CHECK (GIA >= 500)
--7. Ngày khách hàng đăng ký là khách hàng thành viên phải lớn hơn ngày sinh của người đó.
ALTER TABLE KHACHHANG
ADD CONSTRAINT CK_KH_NGDK
CHECK (NGSINH < NGDK)