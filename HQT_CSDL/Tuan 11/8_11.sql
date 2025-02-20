SET DATEFORMAT dmy
--Câu 1: Hãy cài đặt thủ tục cho biết số nhân viên của các phòng ban.
--Thông tin bao gồm: tên phòng, số nhân viên tương ứng của phòng
--đó.
CREATE PROC SP_SONV
AS 
SELECT MAPHG, TENPHG, COUNT(*)
FROM PHONGBAN, NHANVIEN
WHERE PHG = MAPHG
GROUP BY MAPHG, TENPHG

EXEC SP_SONV
--Câu 2: Hãy cài đặt thủ tục cho biết số nhân viên của các phòng ban.
--Thông tin bao gồm: tên phòng, số nhân viên tương ứng của các
--phòng có trên 5 nhân viên.
CREATE PROC SP_SLNV
AS 
SELECT MAPHG, TENPHG, COUNT(*)
FROM PHONGBAN, NHANVIEN
WHERE PHG = MAPHG
GROUP BY MAPHG, TENPHG
HAVING COUNT(*) > 5
EXEC SP_SLNV
--Câu 3: Hãy cài đặt thủ tục liệt kê danh sách các nhân viên nữ phòng
--quản lý có mức lương cao hơn 20000.
CREATE PROC SP_NVNU
AS 
SELECT *
FROM PHONGBAN, NHANVIEN
WHERE PHG = MAPHG AND PHAI LIKE N'nữ' AND TENPHG LIKE N'quản lý' AND LUONG > 20000

EXEC SP_NVNU
--Câu 4: Hãy cài đặt thủ tục cho biết thông tin nhân viên có mức
--lương cao nhất phòng ‘Nghiên cứu’.
CREATE PROC SP_PNCMAX
AS 
SELECT *
FROM PHONGBAN, NHANVIEN
WHERE PHG = MAPHG AND TENPHG LIKE N'Nghiên cứu' AND LUONG >= ALL(
SELECT LUONG
FROM PHONGBAN, NHANVIEN
WHERE PHG = MAPHG AND TENPHG LIKE N'Nghiên cứu'
)

EXEC SP_PNCMAX
--Câu 5: Hãy cài đặt thủ tục liệt kê nhân viên đến tuổi về hưu, nam >=
--60, nữ >= 55.
CREATE PROC SP_TUOIHUU
AS 
SELECT *
FROM NHANVIEN
WHERE PHAI LIKE N'NAM' AND YEAR(GETDATE()) - YEAR(NGSINH) >= 60 
OR PHAI LIKE N'nữ' AND YEAR(GETDATE()) - YEAR(NGSINH) >= 55 
--Câu 6: Hãy cài đặt thủ tục tăng 10% lương cho nhân viên phòng
--‘Nghiên cứu’.
CREATE PROC SP_TANGLUONG
AS 
UPDATE NHANVIEN
SET LUONG = LUONG *1.1
FROM NHANVIEN, PHONGBAN
WHERE PHG = MAPHG AND TENPHG LIKE N'Nghiên cứu'
--Câu 7: Hãy cài đặt thủ tục xóa đề án 20
CREATE PROC SP_XOADA
AS 
DELETE PHANCONG
WHERE MADA = 20
DELETE CONGVIEC
WHERE MADA = 20
DELETE DEAN
WHERE MADA = 20
--Câu 8: Hãy cài đặt thủ tục thêm một nhân viên vào bảng nhân viên.
CREATE PROC SP_THEMNV
AS 
INSERT INTO NHANVIEN (MANV, HONV, TENLOT, TENNV, NGSINH, PHAI, DCHI, LUONG, MA_NQL, PHG)
VALUES ('010', N'TRẦN', N'VĂN', N'MINH', '20/04/1990', 'NAM', N'CỦ CHI', 20000, '006', 4)
--Câu 9: Hãy cài đặt thủ tục tang lương nhân viên nữ lên 5% nếu
--lương trung bình của nhân viên nữ nhỏ hơn lương trung bình của
--nhân viên nam.
CREATE PROC SP_TLNVNU
AS
UPDATE NHANVIEN
SET LUONG = LUONG * 1.05
WHERE PHAI LIKE N'nữ' AND (SELECT AVG(LUONG) FROM NHANVIEN WHERE PHAI LIKE N'NAM')  > 
(SELECT AVG(LUONG) FROM NHANVIEN WHERE PHAI LIKE N'nữ')
--Câu 1: Xây dựng thủ tục cho biết danh sách nhân viên thuộc một
--phòng ban bất kỳ.
CREATE PROC SP_SONVPHGBK(@MAPHG INT)
AS 
SELECT MAPHG, TENPHG, COUNT(*)
FROM PHONGBAN, NHANVIEN
WHERE PHG = MAPHG AND @MAPHG = MAPHG
GROUP BY MAPHG, TENPHG

EXEC SP_SONVPHGBK 1
--Câu 2: Xây dựng thủ tục cho biết lương cao nhất của một phòng bất
--kỳ
CREATE PROC SP_LUONGMAXPHG (@TENPHG NVARCHAR(25))
AS 
SELECT *
FROM PHONGBAN, NHANVIEN
WHERE PHG = MAPHG AND TENPHG LIKE @TENPHG AND LUONG >= ALL(
SELECT LUONG
FROM PHONGBAN, NHANVIEN
WHERE PHG = MAPHG AND TENPHG LIKE @TENPHG
)
EXEC SP_LUONGMAXPHG N'Nghiên cứu'
--Câu 3: Xây dựng thủ tục cho biết họ tên các nhân viên phòng nghiên
--cứu có địa chỉ bất kỳ. Nếu người dùng không truyền vào giá trị địa
--chỉ thì lấy mặc định là ‘TP. HCM’.
CREATE PROC SP_DIACHI (@DIACHI NVARCHAR(25) = N'%TP HCM%')
AS 
SELECT *
FROM NHANVIEN, PHONGBAN
WHERE PHG = MAPHG AND TENPHG = N'Nghiên cứu' AND DCHI LIKE @DIACHI
EXEC SP_DIACHI N'%BÌNH DƯƠNG%'
--Câu 5: Xây dựng thủ tục liệt kê nhân viên có tuổi >= tuổi do người
--dung nhập, sắp theo tuổi giảm dần.
CREATE PROC SP_TUOI (@TUOI INT)
AS 
SELECT *
FROM NHANVIEN
WHERE YEAR(GETDATE()) - YEAR(NGSINH) >= @TUOI
ORDER BY YEAR(GETDATE()) - YEAR(NGSINH) DESC

EXEC SP_TUOI 40
--Câu 6: Xây dựng thủ tục tăng 10% lương cho nhân viên thuộc
--phòng bất kỳ.
CREATE PROC SP_TANGLUONGPHG (@TENPHG NVARCHAR(25))
AS 
UPDATE NHANVIEN
SET LUONG = LUONG *1.1
FROM NHANVIEN, PHONGBAN
WHERE PHG = MAPHG AND TENPHG LIKE @TENPHG

EXEC SP_TANGLUONGPHG N'Nghiên cứu'
--Câu 7: Xây dựng thủ tục xóa đề án bất kỳ.
CREATE PROC SP_XOADABK (@MADA INT)
AS 
DELETE PHANCONG
WHERE MADA = @MADA
DELETE CONGVIEC
WHERE MADA = @MADA
DELETE DEAN
WHERE MADA = @MADA

EXEC SP_XOADABK 20
--Câu 8: Xây dựng thủ tục liệt kê nhân viên có tuổi lớn hơn tuổi do
--người dung nhập, sắp theo tuổi giảm dần, nếu người dung không
--nhập tuổi thì mặc định là 35.
CREATE PROC SP_TUOILH (@TUOI INT = 35)
AS 
SELECT *
FROM NHANVIEN
WHERE YEAR(GETDATE()) - YEAR(NGSINH) >= @TUOI
ORDER BY YEAR(GETDATE()) - YEAR(NGSINH) DESC

EXEC SP_TUOI 40
--Câu 9: Xây dựng thủ tục tăng 10% cho nhân viên thuộc một phòng
--bất kỳ. Nếu người dung không nhập tên phòng thì mặc định tăng
--lương cho tất cả nhân viên
CREATE PROC SP_TANGLUONGTHEOTP (@TENPHG NVARCHAR(25) = NULL)
AS
IF(@TENPHG IS NULL)
BEGIN
UPDATE NHANVIEN
SET LUONG = LUONG *1.1
END
ELSE
BEGIN
UPDATE NHANVIEN
SET LUONG = LUONG *1.1
FROM NHANVIEN, PHONGBAN
WHERE PHG = MAPHG AND TENPHG LIKE @TENPHG
END

EXEC SP_TANGLUONGTHEOTP N'Nghiên cứu'