a= []
for i in range(1,6,1):
    a.append(i)
b = []
for i in range(6,11,1):
    b.append(i)

a.extend(b)
a.insert(2, 20)
a.remove(5)
a.pop()
a.clear()
for i in range(30,36,1):
    a.append(i)
print(a.pop(1))
a.clear()
print(a)