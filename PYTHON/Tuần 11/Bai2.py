import Bai1
import math
class Circle:
    def __init__(P2D, bk):
        P2D.x = 0
        P2D.y = 0
        bk = 0
    def scan(P2D, bk):
        P2D.x = int(input("Nhap x: "))
        P2D.y = int(input("Nhap y: "))
        bk = float(input("Nhap y: "))

    def print(P2D, bk):
        print("x = ", P2D.x)
        print("y = ", P2D.y)
        print("Ban Kinh: ", bk)
    def getx(P2D):
        return P2D.x;
    def gety(P2D):
        return P2D.y;
    def getbk(bk):
        return bk;
    def setx(P2D, x):
        P2D.x = x;
    def sety(P2D, y):
        P2D.y = y;
    def setbk(bk ,bk1):
        bk = bk1;
    def move(P2D, dx, dy):
        P2D.x = dx;
        P2D.y = dy;
    def getArea(bk):
        return math.pi * math.pow(bk,2)
    
