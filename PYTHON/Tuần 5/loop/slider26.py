n = int(input("Nhap n: "))
flag = True

if n<2:
    flag = False

for i in range(2 , n , 1):
    if n % i==0:
        flag = False
        break
if flag:
    print("yes")
else:
    print("no")