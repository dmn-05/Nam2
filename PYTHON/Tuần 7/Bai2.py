import math
a = [2,4,6,8,10,12,14,16,18,20]
b = []
for i in range (0,10,1):
    b.append(a[i]*a[i])
print(b)

c = [2,-3,5,7,8,-10]
d = []
for i in range (0,len(c),1):
    if c[i] < 0:
        d.append(c[i] * c[i])
    else:
        d.append(c[i])

print(d)