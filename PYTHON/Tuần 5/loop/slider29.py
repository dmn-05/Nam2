w = int(input("Nhap w: ")) 
h = int(input("Nhap h: "))

for i in range(1 , h+1 , 1):
    for j in range(1 , w+1 , 1):
        if j < w and j > 1 and i < h and i > 1:
            print(" ",end=" ")
        else:
            print("*", end=" ")
    print("")