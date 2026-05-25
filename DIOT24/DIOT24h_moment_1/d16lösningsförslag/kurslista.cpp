#include <iostream>

using namespace std;

class person {
   public:
     enum role_E { pupil, teacher };
     enum grade_E { not_done, fail, pass, pass_w_dist };
   private:
     string name, phone;
     role_E role;
     grade_E grade[4];
   public:
     person(string Name, string Phone, role_E Role) {
         name = Name; phone = Phone; role = Role;
     }
     void setGrade(int mom, grade_E Grade) {
         grade[mom] = Grade;
     }
     void print() {
         if(role == pupil)
             cout << "elev: " << name << endl;
         else
             cout << "lärare: " << name << endl;
         cout << "  telefon: " << phone << endl;
         if(role == pupil) {
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
     }
};

int main(int argc, char **argv) {
    person *kurslista[4];
    kurslista[0] = new person("Egon Maximus", "03-213341", person::pupil);
    kurslista[0]->setGrade(0, person::pass);
    kurslista[0]->setGrade(1, person::pass_w_dist);
    kurslista[0]->setGrade(2, person::pass);
    kurslista[0]->setGrade(3, person::pass);
    kurslista[0]->print();
    kurslista[1] = new person("Nikolaus Qvist", "04-777777", person::pupil);
    kurslista[1]->setGrade(0, person::pass);
    kurslista[1]->setGrade(1, person::fail);
    kurslista[1]->setGrade(2, person::not_done);
    kurslista[1]->setGrade(3, person::not_done);
    kurslista[1]->print();
    kurslista[2] = new person("Eulalia Svensson", "09-987655", person::pupil);
    kurslista[2]->setGrade(0, person::pass_w_dist);
    kurslista[2]->setGrade(1, person::pass);
    kurslista[2]->setGrade(2, person::pass_w_dist);
    kurslista[2]->setGrade(3, person::pass_w_dist);
    kurslista[2]->print();
    kurslista[2] = new person("Caligula Hult", "007-141414", person::teacher);
    kurslista[2]->print();
    return 0;
}