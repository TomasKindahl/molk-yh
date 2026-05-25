from monster import *
def main():
    m1 = monster("Ugluk", 16, 4)
    m2 = monster("Aragorn", 14, 6)
    while True:
        m1.hit(m2)
        if m2.isdead():
            break
        m2.hit(m1)
        if m1.isdead():
            break
    if m1.isdead() and (not m2.isdead()):
        print(f"{m2.getname()} vann!")
    elif (not m1.isdead()) and m2.isdead():
        print(f"{m1.getname()} vann!")
    else:
        print("bägge dog!")

for i in range(200):
    main()
