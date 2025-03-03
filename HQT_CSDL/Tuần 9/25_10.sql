--1. Gán một mã phòng ban cho biến, rồi cho biết thông tin các nhân viên của phòng đó (họ
--tên nhân viên, tên phòng, lương)
DECLARE @MAPHG INT
SELECT @MAPHG = MAPHG FROM PHONGBAN
SELECT HONV, TENLOT, TENNV, PHG, LUONG
FROM NHANVIEN, PHONGBAN
WHERE PHG = MAPHG AND MAPHG = @MAPHG
--2. Gán một mã nhân viên cho biến, hiển thị tên nhân viên đó và số lượng nhân viên được
--quản lý bởi nhân viên này.
DECLARE @MANV CHAR(9)
SET @MANV = '005'
SELECT NV2.TENNV, COUNT(*) AS 'SỐ NHÂN VIÊN QL'
FROM NHANVIEN NV1, NHANVIEN NV2
WHERE NV1.MA_NQL = NV2.MANV AND NV1.MA_NQL = @MANV
GROUP BY NV1.MA_NQL, NV2.TENNV
--3. Cho biết thông tin họ tên nhân viên, tên phòng ban làm việc, và xếp loại theo lương
--của nhân viên. Biết rằng: lương nhân viên từ 40000 trở lên thì loại A, từ 35000 đến dưới
--40000 thì loại B, còn lại thì loại C.
SELECT HONV, TENLOT, TENNV, PHG, LUONG,
CASE WHEN LUONG < 35000 THEN 'C'
WHEN LUONG < 40000 THEN 'B'
ELSE 'A'
END 'RANK'
FROM NHANVIEN, PHONGBAN
WHERE PHG = MAPHG
--4. Gán một mã phòng cho biết, cập nhật tăng lương cho các nhân viên của phòng đó lên
--20% cho đến khi tổng lương của các nhân viên phòng đó vừa trên 100000 thì dừng lại.
DECLARE @MAPHONG INT
SET @MAPHONG = 5
WHILE(SELECT SUM(LUONG) FROM NHANVIEN WHERE PHG = @MAPHONG)>100000
BEGIN
UPDATE NHANVIEN
SET LUONG = LUONG * 1.2
WHERE PHG = @MAPHG
END
--5.Kiểm tra có nhân viên có tổng giờ làm >= 50, nếu có lập danh sách và tăng lương 10%.
--declare @emplyee_id nvarchar(5)

IF((SELECT COUNT(*) FROM (
select PC.MA_NVIEN
FROM PHANCONG as PC
group by PC.MA_NVIEN
having sum(PC.THOIGIAN) >= 50)a) > 0)
BEGIN
UPDATE NHANVIEN 
SET LUONG = LUONG * 1.1 
WHERE MANV IN (
	select PC.MA_NVIEN
	FROM PHANCONG as PC
	group by PC.MA_NVIEN
	having sum(PC.THOIGIAN) >= 50
)
END

select * from PHANCONG

--6. Tăng lương cho nv 15% cho đến khi luong tb>100000.
while ((select avg(LUONG) from NHANVIEN) < 100000)
begin
	update NHANVIEN
	set LUONG = LUONG * 1.15
end

--7. Tăng lương nhân viên lên 15%, lặp lại cho đến khi lương tối thiểu >=100.000.
while ((select min(LUONG) from NHANVIEN) >= 100000)
begin
	update NHANVIEN
	set LUONG = LUONG * 1.15
end

--8. Nếu lương tb của nv nữ < lương tb nv nam thì Tăng lương nhân viên nữ 5%.
declare @luong_tb_nam float
select @luong_tb_nam = avg(luong) from NHANVIEN where phai like N'Nam'
declare @luong_tb_nu float
select @luong_tb_nu = avg(luong) from NHANVIEN where phai like N'Nữ'

if (@luong_tb_nu < @luong_tb_nam)
begin
	update NHANVIEN
	set LUONG = LUONG * 1.05
	where PHAI like N'Nữ'
end

--9. Tăng lương cho trưởng phòng số 4 lên 7% cho đến khi > lương cao nhất của nv phòng số 4.
declare @luong_max money
select @luong_max = max(luong) from NHANVIEN where PHG = 4
declare @luong_tp money
select @luong_tp = luong from NHANVIEN, PHONGBAN where MANV = TRPHG and PHG = 4
declare @ma_tp nvarchar(5)
select @ma_tp = TRPHG from PHONGBAN where MAPHG = 4

while (@luong_max > @luong_tp)
begin
	update NHANVIEN
	set luong = luong * 1.07
	where MANV = @ma_tp
end
--10. Xuất ra thông tin nhân viên, trong đó, nếu phái nữ xuất 0, phái nam xuất 1.
select HONV, TENLOT, TENNV,
	case 
	when PHAI = N'NAM' then 0
	when PHAI = N'NỮ' then 1
	end as N'Giới Tính'
from NHANVIEN
--11. Hiển thị số lượng nam và số lượng nữ trong công ty trong cùng 1 câu truy vấn.
SELECT SUM(CASE WHEN PHAI = 'Nam' THEN 1 ELSE 0 END) AS SoLuongNam, SUM(CASE WHEN PHAI = 'Nữ' THEN 1 ELSE 0 END) AS SoLuongNu
FROM NHANVIEN


--12. Xuất thông tin dự án, trong đó, nếu dự án ở tphcm hay hà nội thì thêm ‘trọng yếu”.
select *,
	case 
	when DDIEM_DA IN (N'tp hcm', N'hà nội') then N'trọng yếu'
	ELSE N'Không trọng yếu' 
    END AS LoaiDuAn
from DEAN
--13. Xuất thông tin nhân viên tham gia dự án, trong đó, nhân viên có tổng thời gian làm >=40 thì
--thêm ‘khen thưởng’.
select MANV, HONV, TENLOT, TENNV,
	case
	when THOIGIAN >= 40
	then 'khen thuong'
	end as Thuong
from PHANCONG, NHANVIEN
where MANV = MA_NVIEN