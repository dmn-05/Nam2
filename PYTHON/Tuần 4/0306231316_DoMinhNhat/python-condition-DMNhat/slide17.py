nam = int(input("Nhap nam: "))
if nam % 4 == 0 and nam % 100 != 0 or nam % 400 == 0:
    print("nam nhuan")
else:
    print("nam khong nhuan")