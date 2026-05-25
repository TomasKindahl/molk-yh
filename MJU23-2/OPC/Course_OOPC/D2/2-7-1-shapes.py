import math
class point:
    def __init__(self, x, y = None):
        if type(x) in [int, float] and type(y) in [int, float]:
            self.x = x
            self.y = y
        elif type(x) == str and y == None:
            xsplit = x.strip()[1:-1].split(',')
            self.x = float(xsplit[0])
            self.y = float(xsplit[1])
        else:
            self.x = "fel"
            self.y = "fel"
    def __repr__(self):
        x = self.x
        y = self.y
        return f'\u27E8{x},{y}\u27E9'
    def __neg__(self):
        return point(-self.x, -self.y)
    def __add__(self, other):
        return point(self.x+other.x, self.y+other.y)
    def __sub__(self, other):
        return self+-other
    def distance(self, other):
        x1 = self.x; x2 = other.x
        y1 = self.y; y2 = other.y
        return math.sqrt((x1-x2)**2+(y1-y2)**2)
    def __mul__(self, factor):
        return point(self.x*factor, self.y*factor)
    def __truediv__(self, factor):
        return point(self.x/factor, self.y/factor)
    def __eq__(self, other):
        return self.x == other.x and self.y == other.y

class shape:
    def __init__(self, cpoint, rotation):
        self.centerpoint = cpoint
        self.rotation = rotation
    def __repr__(self):
        return f"<Shape center={self.centerpoint}, rotation={self.rotation}°>"
    def getAttrString(self):
        return f"center={self.centerpoint}, rotation={self.rotation}°"
    def rotate(self, angle):
        self.rotation += angle
        self.rotation = self.rotation % 360
    def move(self, XYoff):
        self.centerpoint += XYoff
    def setcolor(self, color):
        self.color = color

class rectangle (shape):
    def __init__(self, center, rotation, width, height):
        super().__init__(center, rotation)
        self.width = width
        self.heigth = height
    def __repr__(self):
        superRepr = super().getAttrString()
        W = self.width
        H = self.heigth
        return f"<Rectangle {superRepr}, width={W}, height={H}>"

class ellipse (shape):
    def __init__(self, center, rotation, A, B):
        super().__init__(center, rotation)
        self.A = A
        self.B = B
    def __repr__(self):
        superRepr = super().getAttrString()
        A = self.A
        B = self.B
        return f"<Ellipse {superRepr}, majoraxis={A}, minoraxis={B}>"

s1 = shape(point(0,0), 30)
rect = rectangle(point(10,4), 60, 2.5, 3.5)
ell = ellipse(point(5,7), 60, 2.5, 3.5)
