import math
class point:
    def __init__(self, x, y = None):
        self.x = x
        self.y = y
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
    
p1 = point(2,3)
print(f"p1 = {p1}")
print(f"-p1 = {-p1}")
p2 = point(4, -2)
print(f"p2 = {p2}")
print(f"p1+p2 = {p1+p2}")
print(f"p1*2 = {p1*2}")
print(f"p1/2 = {p1/2}")
print(f"p1.distance(p2) = {p1.distance(p2)}")
