class Person:
    def __init__(self, persname, surname, phone, address):
        self.__persname = persname
        self.__surname  = surname
        self.__phone    = phone
        self.__address  = address
    def getpersname(self):
        return self.__persname
    def setpersname(self, persname):
        self.__persname = persname
    def getsurname(self):
        return self.__surname
    def setsurname(self, surname):
        self.__surname = surname
    def getphone(self):
        return self.__phone
    def setphone(self, phone):
        self.__phone = phone
    def getaddress(self):
        return self.__address
    def setaddress(self, address):
        self.__address = address
    def toString(self):
        return f"{self.__persname} {self.__surname}, {self.__phone}, {self.__address}"

Parne = Person('Arne', 'Olsson', '013-113 13 13', 'Gränden 23B')
print(Parne.toString())
Perith = Person('Berith', 'Qvist', '013-141 15 16', 'Storgatan 8B')
print(Perith.toString())
Paesar = Person('Caesar', 'Augustus', '0771-772 73 74', 'Capitolium 8')
print(Paesar.toString())
