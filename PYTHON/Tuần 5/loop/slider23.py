n = int(input("Nhap n: "))
tong = 0
for i in range(1 , n+1 , 1):
        tong+=i
print(tong)

n = int(input("Nhap n: "))
tich = 1
for i in range(1 ,n + 1, 1):
    if n%i==0 and i % 2 == 0:
        tich*=i
print(tich)
