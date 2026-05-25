#include <iostream>

using namespace std;

class person {
   public:
     string name, phone;
     person(string Name, string Phone) {
         name = Name; phone = Phone;
     }
     virtual void print() = 0;
};

class pupil : public person {
   public:
     enum grade_E { not_done, fail, pass, pass_w_dist };
   private:
     grade_E grade[4];
   public:
     pupil(string Name, string Phone)
        : person(Name, Phone)
     { }
     void setGrade(int mom, grade_E Grade) {
         grade[mom] = Grade;
     }
     void print() {
         cout << "elev: " << name << endl;
         cout << "  telefon: " << phone << endl;
         cout << "  betyg:" << endl;
         for(int i = 0; i < 4; i++) {
             cout << "    moment " << i+1 << ": ";
             switch(grade[i]) {
               case not_done: cout << "-" << endl; break;
               case fail: cout << "IG" << endl; break;
               case pass: cout << "G" << endl; break;
               case pass_w_dist: cout << "VG" << endl; break;
             }
         }
     }
};

class teacher : public person {
   public:
     teacher(string Name, string Phone)
        : person(Name, Phone)
     { }
     void print() {
         cout << "teacher: " << name << endl;
         cout << "  telefon: " << phone << endl;
     }
};

int main(int argc, char **argv) {
    person *kurslista[4];
    pupil *Egon = new pupil("Egon Maximus", "03-213341");
    Egon->setGrade(0, pupil::pass);
    Egon->setGrade(1, pupil::pass_w_dist);
    Egon->setGrade(2, pupil::pass);
    Egon->setGrade(3, pupil::pass);
    kurslista[0] = Egon;
    kurslista[0]->print();
    pupil *Nikolaus = new pupil("Nikolaus Qvist", "04-777777");
    Nikolaus->setGrade(0, pupil::pass);
    Nikolaus->setGrade(1, pupil::fail);
    Nikolaus->setGrade(2, pupil::not_done);
    Nikolaus->setGrade(3, pupil::not_done);
    kurslista[1] = Nikolaus;
    kurslista[1]->print();
    pupil *Eulalia = new pupil("Eulalia Svensson", "09-987655");
    Eulalia->setGrade(0, pupil::pass_w_dist);
    Eulalia->setGrade(1, pupil::pass);
    Eulalia->setGrade(2, pupil::pass_w_dist);
    Eulalia->setGrade(3, pupil::pass_w_dist);
    kurslista[2] = Eulalia;
    kurslista[2]->print();
    teacher *Caligula = new teacher("Caligula Hult", "007-141414");
    kurslista[3] = Caligula;
    kurslista[3]->print();
    return 0;
}