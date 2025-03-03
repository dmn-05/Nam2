m = int(input("Nhap m: ")) 
n = int(input("Nhap n: "))
dem = 0
for i in range(m , n+1 , 1):
    if i%2==0:
        dem+=1
print(dem)

n = int(input())
dem =0
for i in range(1 ,n + 1, 1):
    if n%i==0:
        dem+=1
print(dem)
