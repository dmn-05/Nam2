INSERT INTO KhachHang (MaKh, TenKh, DiaChi, Phone, SoFax, DCMail)
VALUES ('001', N'THU', N'GÒ VẤP', '0306231316', '56764', NULL)

SET DATEFORMAT dmy
INSERT INTO nhanvien (MaNV, HoNV, TenNV, GioiTinh, NgaySinh, DiaChi, Phone)
VALUES ('310', N'LÝ THỊ', N'THỦY', N'NỮ','08/02/2000', N'QUẬN 3', '0306288606')

SET DATEFORMAT dmy
INSERT INTO HoaDon (MaHD, NgayLapHD, MaNV, NoiChuyen, MaKh)
VALUES ('386', '29/10/2024', '310', N'Gò Vấp','001')

INSERT INTO NhaCungCap(MaNCC, TenNcc, DiaChi, Phone, SoFax, DCMail)
VALUES ('987', N'Xăng', N'Củ Chi', '0377877816', '98764', NULL)

INSERT INTO SanPham(MaSp, TenSp, MoTa, Donvitinh, SoLuong, DonGia, mancc)
VALUES ('657', N'Xăng 95', N'xăng dầu xe', 'lit', '5000', '20000', '987')

INSERT INTO CT_HoaDon(MaHD, MaSp, SoLuong, DonGia, ChietKhau)
VALUES ('386', '657', '2', '21000', '1000')

--a.Northwind.dbo.Customers vào KhachHang
select * from KhachHang
select * from Northwind.dbo.Customers
--
insert into KhachHang
select CustomerID, CompanyName, Address+' '+ City, Phone,
Fax, null
from Northwind.dbo.Customers
--b.Northwind.dbo.Suppliers vào NhaCungCap
select * from NhaCungCap
select * from Northwind.dbo.Suppliers
--
insert into NhaCungCap
select SupplierID, CompanyName,Address+ ' '+ City, Phone,
Fax, null
from Northwind.dbo.Suppliers

delete from NhaCungCap
WHERE MaNCC = '1'

delete from SanPham
where mancc = '1'

delete from CT_HoaDon
where MaSp = (select MaSp from SanPham where mancc = '1')
--c.Northwind..products vào SanPham
select * from SanPham
select * from Northwind..products
--
insert into SanPham
select ProductID,
ProductName,QuantityPerUnit,null,UnitsInStock, UnitPrice,
SupplierID
from Northwind..products
--d.Northwind.dbo.Employees vào nhanvien
select * from nhanvien
select * from Northwind.dbo.Employees
--
insert into nhanvien
select EmployeeID,LastName,FirstName,null, BirthDate,Address+'
'+City,HomePhone
from Northwind.dbo.Employees
--e.Northwind.dbo.Orders vào HoaDon (OrderID>=10257 là hóa đơn
--nhập 'N',còn lại là hóa đơn xuất 'X')
select * from HoaDon
select * from Northwind.dbo.Orders
--
insert into HoaDon
select OrderID, OrderDate,EmployeeID,null,CustomerID,'N'
from Northwind.dbo.Orders where OrderID>=10257
--
insert into HoaDon
select OrderID, OrderDate,EmployeeID,null,CustomerID,'X'
from Northwind.dbo.Orders where OrderID <= 10256
--f.Northwind.dbo.[Order Details] vào CT_HoaDon
select * from CT_HoaDon
select * from Northwind.dbo.[Order Details]
--
insert into CT_HoaDon
select OrderID,ProductID ,Quantity,UnitPrice,Discount
from Northwind.dbo.[Order Details]

--BÀI TẬP 2: LỆNH UPDATE
--1. Cập nhật đơn giá 30000 cho mã sản phẩm có tên bắt đầu bằng chữ T
update SanPham
set DonGia = '30000'
where TenSp like N'T%'
--2. Cập nhật số lượng tồn = 50% số lượng tồn hiện có cho những cuốn sản phẩm có
--đơn vị tính có chữ box
update SanPham
set SoLuong = SoLuong * 1/2
where Donvitinh like N'%Box%'
--3. Cập nhật mã khách hàng ANTON trong bảng khách hàng thành ONTAN. Bạn có
--cập nhật được hay không?. Vì sao?.
update KhachHang
set MaKh = 'ONTAN'
where MaKh like 'ANTON'

--không đổi được vì makh đang liên kết khóa với bảng hóa đơn

--4. Tăng đơn giá các sản phẩm lên 3%
update SanPham
set DonGia = DonGia * 3/100
--5. Giảm 10% đơn giá cho những sản phẩm có số lượng tồn tên 50.
update SanPham
set DonGia = DonGia * 90/100
where SoLuong > 50
--6. Cập nhật giá bán trong bảng CT_HoaDon bằng với đơn giá trong bảng SanPham.
update CT_HoaDon
set CT_HoaDon.DonGia = SanPham.DonGia
from CT_HoaDon JOIN SanPham on CT_HoaDon.MaSp = SanPham.MaSp

--BÀI TẬP 3: LỆNH DELETE
--1. Xóa các hóa đơn được lập trong tháng 7 năm 1996. Bạn có thực hiện được không?
--Vì sao?
delete from HoaDon
where MONTH(NgayLapHD) = '7' AND YEAR(NgayLapHD) = '1996'

--xóa không được vì có khóa chính liên kết với ct_hoadon làm khóa ngoại

--2. Tạo bảng HoaDon797 chứa các hóa đơn được lập trong tháng 7 năm 1997. Sau đó
--xóa toàn bộ dữ liệu của bảng này bằng lệnh Truncate
create table HoaDon797(
MaHD	Int	primary key,
NgayLapHD	DateTime,
MaNV int,
NoiChuyen	nvarchar(50),
MaKh	char(5),
LoaiHD char(1)
)

insert into HoaDon797
select MaHD, NgayLapHD, MaNV, NoiChuyen, MaKh, LoaiHD
from banhang.dbo.HoaDon
where MONTH(NgayLapHD) = '7' AND YEAR(NgayLapHD) = '1997'

Truncate table HoaDon797