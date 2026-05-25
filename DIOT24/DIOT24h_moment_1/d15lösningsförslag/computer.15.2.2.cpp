#include <iostream>

using namespace std;

class laptop {
   private:
     string brand;
     string series;
     string product;
     string processor;
     int mem_max;
     string mem_type;
     int storage;
   public:
   	 laptop() { }
   	 laptop(string Brand, string Series, string Product) {
   	 	 brand = Brand; series = Series; product = Product;
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
   	 	 cout << "Brand: " << brand << endl;
   	 	 cout << "  Series: " << series << endl;
   	 	 cout << "  Product: " << product << endl;
   	 	 cout << "  Processor: " << processor << endl;
   	 	 cout << "  Memory (max): " << mem_max << " GB" << endl;
   	 	 cout << "  Memory type: " << mem_type << endl;
   	 	 cout << "  Storage: " << storage << " GB" << endl;
     }
};

class embedded {
   private:
     string brand;
     string series;
     string product;
     string mcu;
     string usb;
     double power;
   public:
   	 embedded() { }
   	 embedded(string Brand, string Series, string Product) {
   	 	 brand = Brand; series = Series; product = Product;
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
   	 	 cout << "Brand: " << brand << endl;
   	 	 cout << "  Series: " << series << endl;
   	 	 cout << "  Product: " << product << endl;
   	 	 cout << "  MCU: " << mcu << endl;
   	 	 cout << "  USB: " << usb << endl;
   	 	 cout << "  Power: " << power << "V" << endl;
     }
};

int main(int argc, char **argv) {
	laptop *PC[2];
	PC[0] = new laptop("Lenovo"s, "Essential"s, "G470"s);
	PC[0]->setProcessor("2.3 GHz Intel Core i5-2410M"s);
	PC[0]->setMem_max(8);
	PC[0]->setMem_type("DDR3"s);
	PC[0]->setStorage(500);
	PC[1] = new laptop("HP"s, "Probook"s, "x360 11 G1 EE"s);
	PC[1]->setProcessor("Intel Pentium N4200, 4 cores"s);
	PC[1]->setMem_max(4);
	PC[1]->setMem_type("DDR3"s);
	PC[1]->setStorage(256);
	for(int i = 0; i < 2; i++) 
		PC[i]->print();

	embedded *Card[2];
	Card[0] = new embedded("Arduino"s, "Uno"s, "R4 Wifi"s);
	Card[0]->setMCU("Renesas RA4M1 (Arm® Cortex®-M4)"s);
	Card[0]->setUSB("USB-C"s);
	Card[0]->setPower(5);
	Card[1] = new embedded("Arduino"s, "MKR"s, "WiFi 1010"s);
	Card[1]->setMCU("SAMD21 Cortex®-M0+ 32bit low power ARM®"s);
	Card[1]->setUSB("USB Cable Type A Male to Micro Type B Male"s);
	Card[1]->setPower(5);
	for(int i = 0; i < 2; i++) 
		Card[i]->print();
    return 0;
}