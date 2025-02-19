number1 = int(input("Nhap so nguyen 1: "))
number2 = int(input("Nhap so nguyen 2: "))
number3 = int(input("Nhap so nguyen 3: "))
dem = 0
if number1 < 0:
    dem += 1
    
if number2 < 0:
    dem += 1
    
if number3 < 0:
    dem += 1

print("so luong so am la:", dem)