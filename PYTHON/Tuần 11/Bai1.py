import math
class Point2D:
    def __init__(self):
        self.x = 0
        self.y = 0
    def scan(self):
        self.x = int(input("Nhap x: "))
        self.y = int(input("Nhap y: "))
    def print(self):
        print("x = ", self.x)
        print("y = ", self.y)
    def getx(self):
        return self.x;
    def gety(self):
        return self.y;
    def setx(self, x):
        self.x = x;
    def sety(self, y):
        self.y = y;
    def move(self, dx, dy):
        self.x = dx;
        self.y = dy;
    def getDistance( self, P2D):
        return math.sqrt(pow(P2D.x - self.x,2) + pow(P2D.y - self.y,2))
s = Point2D()
s2 = Point2D()
s.scan()
s2.scan()
s.print()
print(s.getx());
print(s.gety());
print(s.getDistance(s2))