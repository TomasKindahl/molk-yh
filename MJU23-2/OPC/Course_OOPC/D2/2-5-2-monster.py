import random
class monster:
    def __init__(self, name, HP, damage):
        self.name = name
        self.HP = HP
        self.damage = damage
    def __repr__(self):
        return f'name={self.name}, HP={self.HP}, damage={self.damage}'
    def hit(self, other):
        other.HP -= random.randint(1, self.damage)
    def isdead(self):
        return self.HP <= 0
    def getname(self):
        return self.name
