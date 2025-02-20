--1. Gán một giá trị cho biến tuổi, liệt kê nhân viên có tuổi >= tuổi do người dùng nhập, sắp
--xếp tuổi giảm dần.
DECLARE @TUOI INT
SET @TUOI = 65
SELECT *
FROM NHANVIEN
WHERE @TUOI <= YEAR(GETDATE()) - YEAR(NGSINH)
ORDER BY YEAR(GETDATE()) - YEAR(NGSINH) DESC
--2. Tạo 2 giá trị cho biến tuổi về hưu của nam, nữ. Liệt kê thông tin các nhân viên, thêm
--cột “Nghỉ hưu” cho các nhân viên có tuổi nghỉ hưu.
DECLARE @TUOINAM INT
SET @TUOINAM = 65
DECLARE @TUOINU INT
SET @TUOINU = 60
SELECT *,
	CASE
	WHEN PHAI LIKE N'NAM' AND YEAR(GETDATE()) - YEAR(NGSINH) >= @TUOINAM
		OR PHAI LIKE N'NỮ' AND YEAR(GETDATE()) - YEAR(NGSINH) >= @TUOINU THEN N'NGHỈ HƯU'
	ELSE N'CHƯA NGHỈ HƯU'
	END AS 'NGHỈ HƯU'
FROM NHANVIEN
--3. Gán một giá trị cho biến. In ra lương trung bình, số nhân viên của phòng đó (dùng lệnh
--print). Tăng lương nhân viên 10% nếu số lượng nhân viên phòng đó nhỏ hơn 2.
DECLARE @phong_id INT = 1; 
DECLARE @so_nhan_vien INT;
DECLARE @luong_trung_binh DECIMAL(10, 2);

SELECT 
    @so_nhan_vien = COUNT(*),
    @luong_trung_binh = AVG(LUONG)
FROM 
   NHANVIEN
WHERE 
    PHG = @phong_id;


PRINT N'Số nhân viên: ' + CAST(@so_nhan_vien AS NVARCHAR(2));
PRINT N'Lương trung bình: ' + CAST(@luong_trung_binh AS NVARCHAR(10));
IF @so_nhan_vien < 2
BEGIN
    UPDATE NHANVIEN
    SET luong = luong * 1.1
    WHERE PHG = @phong_id;
    
    PRINT 'Đã tăng lương 10% cho nhân viên trong phòng ' + CAST(@phong_id AS NVARCHAR(1));
END
--4. Tạo một biến n chứa thời gian cần làm thêm, tăng thời gian làm cho nhân viên thuộc
--phòng “Nghiên cứu” nếu thời gian làm việc ít hơn 25 giờ.
IF((SELECT COUNT(*) FROM (
select PC.MA_NVIEN
FROM PHANCONG as PC
group by PC.MA_NVIEN
having sum(PC.THOIGIAN) < 25) AS SL) > 0)
BEGIN
UPDATE NHANVIEN 
SET LUONG = LUONG * 1.1 
WHERE MANV IN (
	select PC.MA_NVIEN
	FROM PHANCONG as PC, PHONGBAN,
	group by PC.MA_NVIEN
	having sum(PC.THOIGIAN) < 25 AND 
)
END
--5. Xóa phân công của một đề án với mã đề án do người dùng tự thiết lập.

--6. Xóa đề án với mã đề án do người dùng tự thiết lập.
--7. Thực hiện các công việc sau:
--- Liệt kê nhân viên có tuổi >= tuổi do người dùng nhập, sắp xếp theo tuổi giảm dần
--- Tính lương trung bình của các nhân viên này. Dùng giá trị tính được truy vấn nhân viên
--viên có tuổi >= 60 và truy vấn nhóm tuổi có lương trung bình > lương trung bình tính
--được.
--8. Thực hiện các công việc sau
--- Liệt kê nhân viên đến tuổi về hưu nếu nam >= 60, nữ >=55
--- In ra số lượng nhân viên nam, nhân viên nữ về hưu (sử dụng lệnh print)
--- In ra số lượng nhân viên nam, nhân viên nữ về hưu của một phòng do người dùng tự
--thiết lập.
--9. Tăng lương nhân viên 10% cho nhân viên 1 tên phòng do người dùng vừa nhập, in ra
--số nhân viên được tăng lương và tổng tiền dùng để tăng lương.
--10. Tăng 5% lương nhân viên có tổng thời gian >= thời gian do người dùng nhập, in ra số
--nhân viên được tăng lương và tổng lương đã tăng.