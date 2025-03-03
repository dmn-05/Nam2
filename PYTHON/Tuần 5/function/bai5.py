def nhapten():
    ten = input("Nhap ten: ")
    return ten;
def nhapnamsinh():
    namsinh = input("Nhap nam sinh: ")
    return namsinh;
def chao(ten, namsinh):
    print(f"Xin chao, minh ten la {ten}")
    print(f"Minh sinh {namsinh}")
    print("Rat vui duoc gap ban")

chao(nhapten(), nhapnamsinh())
