﻿--2
CREATE DATABASE SALESDB

ON PRIMARY(
	NAME = SALESDB_DATA1,
	FILENAME ='D:\0306231316\SALESDB\QLBH_DATA1.MDF',
	SIZE = 10,
	MAXSIZE = 40,
	FILEGROWTH = 1
),
--3
(
	NAME = SALESDB_DATA2,
	FILENAME ='D:\0306231316\SALESDB\QLBH_DATA2.NDF',
	SIZE = 10,
	MAXSIZE = 40,
	FILEGROWTH = 1
)

LOG ON(
	NAME = SALESDB_LOG,
	FILENAME ='D:\0306231316\SALESDB\SALESDB.LDF',
	SIZE = 6,
	MAXSIZE = 8,
	FILEGROWTH = 1
)
--4
ALTER DATABASE SALESDB
MODIFY FILE(
	NAME = SALESDB_DATA1,
	SIZE = 50
)
--5
--A
CREATE TABLE LOP(
	MALOP CHAR(5) NOT NULL,
	TENLOP CHAR(20) NOT NULL,
	SISODUKIEN INT,
	NGAYKHAIGIANG DATE
	CONSTRAINT PK_LOP PRIMARY KEY (MALOP)
)
CREATE TABLE SV(
	MASV CHAR(5) NOT NULL,
	TENHO NVARCHAR(50) NOT NULL,
	NGAYSINH DATE,
	MALOP CHAR(5) NOT NULL
	CONSTRAINT PK_SV PRIMARY KEY (MASV)
)

ALTER TABLE SV
ADD CONSTRAINT FK_SV FOREIGN KEY (MALOP) REFERENCES LOP(MALOP)
--B
SET DATEFORMAT dmy
INSERT INTO LOP(MALOP,TENLOP,SISODUKIEN,NGAYKHAIGIANG)
VALUES ('456', 'CDTH23D', 63, '02/09/2024')
SET DATEFORMAT dmy
INSERT INTO LOP(MALOP,TENLOP,SISODUKIEN,NGAYKHAIGIANG)
VALUES ('478', 'CDTH23A', 65, '02/09/2024')
SET DATEFORMAT dmy
INSERT INTO LOP(MALOP,TENLOP,SISODUKIEN,NGAYKHAIGIANG)
VALUES ('489', 'CDTH23B', 62, '02/09/2024')
--C
SET DATEFORMAT dmy
INSERT INTO SV(MASV, TENHO, NGAYSINH, MALOP)
VALUES ('123', N'ĐỖ MINH NHẬT', '08/10/2005','456')
SET DATEFORMAT dmy
INSERT INTO SV(MASV, TENHO, NGAYSINH, MALOP)
VALUES ('145', N'ĐỖ NGỌC THẾ', '02/09/2005','478')
SET DATEFORMAT dmy
INSERT INTO SV(MASV, TENHO, NGAYSINH, MALOP)
VALUES ('189', N'ĐỖ MINH CHIẾN', '07/12/2005','489')

--6
CREATE TABLE HOADON(
	MAHD INT NOT NULL,
	NGAYLAPHD DATE,
	MANV CHAR(3),
	MAKH CHAR(5)
	CONSTRAINT PK_HOADON PRIMARY KEY (MAHD)
)
CREATE TABLE CHITIETHOADON(
	MAHD INT NOT NULL,
	MASP INT NOT NULL,
	SOLUONG INT,
	DONGIA MONEY
	CONSTRAINT PK_CTHD PRIMARY KEY (MAHD, MASP)
)

ALTER TABLE CHITIETHOADON
ADD CONSTRAINT FK_CTHD FOREIGN KEY (MAHD) REFERENCES HOADON(MAHD)

ALTER TABLE CHITIETHOADON
ADD CONSTRAINT CK_CTHD CHECK (SOLUONG > 0)

SET DATEFORMAT DMY
INSERT INTO HOADON(MAHD, NGAYLAPHD, MANV, MAKH)
VALUES ('123', '20/10/2024', '345', '678')
SET DATEFORMAT DMY
INSERT INTO HOADON(MAHD, NGAYLAPHD, MANV, MAKH)
VALUES ('987', '20/10/2024', '345', '678')

INSERT INTO CHITIETHOADON(MAHD, MASP, SOLUONG, DONGIA)
VALUES ('123', '456', 67, 25000)

INSERT INTO CHITIETHOADON(MAHD, MASP, SOLUONG, DONGIA)
VALUES ('123', '487', 0, 25000)

CREATE RULE DONGIABE
AS @DONGIA > 0

EXEC sp_bindrule 'DONGIABE','CHITIETHOADON.DONGIA'

INSERT INTO CHITIETHOADON(MAHD, MASP, SOLUONG, DONGIA)
VALUES ('123', '457', 2, 0)

