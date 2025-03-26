f = open("demo.txt")
read = f.readlines()
print(len(read))
print(read)
from collections import Counter
with open ("demo.txt") as fin:
    counter = Counter(fin.read().strip().split())

print(counter.most_common())
