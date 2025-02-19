age = int(input("Nhap tuoi: "))
height = int(input("Nhap chieu cao (m): "))
weight = int(input("Nhap can nang (kg): "))
bmi = weight / height * height
if age >= 18:
    if bmi < 18.5:
        print("Gay")
    elif bmi < 25:
        print("Binh Thuong")
    elif bmi < 30:
        print("thua can")
    else:
        print("beo phi")
else:
    print("Khong kha dung")