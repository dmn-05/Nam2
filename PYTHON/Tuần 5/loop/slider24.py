m = int(input("Nhap m: ")) 
n = int(input("Nhap n: "))

for i in range(m , n+1 , 1):
    if i%6==0:
        print(i)
        break
