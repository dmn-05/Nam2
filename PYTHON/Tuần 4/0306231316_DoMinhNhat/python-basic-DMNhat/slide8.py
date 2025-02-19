from datetime import datetime
nguoi1 = int(input("Hay nhap nam sinh: "))
nguoi2 = int(input("Hay nhap nam sinh: "))
nguoi3 = int(input("Hay nhap nam sinh: "))

tuoi1 = datetime.now().year - nguoi1
tuoi2 = datetime.now().year - nguoi2
tuoi3 = datetime.now().year - nguoi3
print("Tuoi trung binh: ", (tuoi1+tuoi2+tuoi3)/3)