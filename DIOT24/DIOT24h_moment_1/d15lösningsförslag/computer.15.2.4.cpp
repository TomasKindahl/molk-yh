#include <iostream>

using namespace std;

class computer {
   private:
     string brand;
     string series;
     string product;
   public:
     computer() { }
     computer(string Brand, string Series, string Product) {
   	 	 brand = Brand; series = Series; product = Product;
     }
     virtual void print() {
   	     cout << "Brand: " << brand << endl;
   	     cout << "  Series: " << series << endl;
   	     cout << "  Product: " << product << endl;
     }
};

class laptop : public computer {
   private:
     string processor;
     int mem_max;
     string mem_type;
     int storage;
   public:
   	 laptop() { }
   	 laptop(string Brand, string Series, string Product)
         : computer(Brand, Series, Product)
     {
   	 }
   	 void setProcessor(string Processor) {
   	 	 processor = Processor;
   	 }
   	 void setMem_max(int Mem_max) {
   	 	 mem_max = Mem_max;
   	 }
   	 void setMem_type(string Mem_type) {
   	 	 mem_type = Mem_type;
   	 }
   	 void setStorage(int Storage) {
   	 	 storage = Storage;
   	 }
   	 void print() {
         computer::print();
   	 	 cout << "  Processor: " << processor << endl;
   	 	 cout << "  Memory (max): " << mem_max << " GB" << endl;
   	 	 cout << "  Memory type: " << mem_type << endl;
   	 	 cout << "  Storage: " << storage << " GB" << endl;
     }
};

class embedded : public computer {
   private:
     string brand;
     string series;
     string product;
     string mcu;
     string usb;
     double power;
   public:
   	 embedded() { }
   	 embedded(string Brand, string Series, string Product)
         : computer(Brand, Series, Product)
     {
   	 }
   	 void setMCU(string MCU) {
   	 	 mcu = MCU;
   	 }
   	 void setUSB(string USB) {
   	 	 usb = USB;
   	 }
   	 void setPower(double Power) {
   	 	 power = Power;
   	 }
   	 void print() {
         computer::print();
   	 	 cout << "  MCU: " << mcu << endl;
   	 	 cout << "  USB: " << usb << endl;
   	 	 cout << "  Power: " << power << "V" << endl;
     }
};



int main(int argc, char **argv) {
	computer *C[4];

    laptop *L = new laptop("Lenovo"s, "Essential"s, "G470"s);
	L = new laptop("Lenovo"s, "Essential"s, "G470"s);
	L->setProcessor("2.3 GHz Intel Core i5-2410M"s);
	L->setMem_max(8);
	L->setMem_type("DDR3"s);
	L->setStorage(500);
    C[0] = L;

	L = new laptop("HP"s, "Probook"s, "x360 11 G1 EE"s);
	L->setProcessor("Intel Pentium N4200, 4 cores"s);
	L->setMem_max(4);
	L->setMem_type("DDR3"s);
	L->setStorage(256);
    C[1] = L;

    embedded *E = new embedded("Arduino"s, "Uno"s, "R4 Wifi"s);
	E->setMCU("Renesas RA4M1 (Arm® Cortex®-M4)"s);
	E->setUSB("USB-C"s);
	E->setPower(5);
    C[2] = E;

	E = new embedded("Arduino"s, "MKR"s, "WiFi 1010"s);
	E->setMCU("SAMD21 Cortex®-M0+ 32bit low power ARM®"s);
	E->setUSB("USB Cable Type A Male to Micro Type B Male"s);
	E->setPower(5);
    C[3] = E;

	for(int i = 0; i < 4; i++) 
		C[i]->print();

    return 0;
}