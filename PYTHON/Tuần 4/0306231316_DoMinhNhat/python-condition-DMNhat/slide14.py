number1 = int(input("Nhap so nguyen 1: "))
number2 = int(input("Nhap so nguyen 2: "))
number3 = int(input("Nhap so nguyen 3: "))
tong = 0
if number1 < 0:
    tong += number1
    
if number2 < 0:
    tong += number2
    
if number3 < 0:
    tong += number3

print("tong so am la:", tong)