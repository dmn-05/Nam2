n = int(input("Nhap n: "))
dem=0
tong=0
for j in range(2, n , 1):
    flag = True
    if j < 2:
        flag = False

    for i in range(2 , j , 1):
        if j % i==0:
            flag = False
            break
    if flag:
        print(j, end=" ")
        dem+=1
        tong+=j
print("")
print(dem)
print(tong)