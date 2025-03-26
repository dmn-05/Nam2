numbers = [1, -2, 3, -4]

#1
a = list(filter(lambda x : x ** 2, numbers))
print(a)
#2
b = list(filter(lambda x: x<0,numbers))
print(b)
#3
string = ["Nhat","The", "Quan", "Trung"]
c = list(sorted(string, key=lambda x: len(x)))
print(c)