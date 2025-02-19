thang = int(input("Nhap thang: "))
if thang == 1 or thang == 3 or thang == 5 or thang == 7 or thang == 8 or thang == 10 or thang == 12:
    print(f"thang {thang} co 31 ngay")
elif thang == 4 or thang == 6 or thang == 9 or thang == 11:
    print(f"thang {thang} co 30 ngay")
else:
    print(f"thang {thang} co 29 ngay")
    