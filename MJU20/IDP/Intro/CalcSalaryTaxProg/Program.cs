using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSalaryTaxProg
{
    class Program
    {
        static string CalcSalaryTax(double bruttolön, out double skatt, out double nettolön)
        {
            skatt = bruttolön * 0.32;
            nettolön = bruttolön - skatt;

            return $"Nettolön blir {nettolön} efter skatt {skatt}";
        }
        static void Main(string[] args)
        {
            Console.Write("Skriv in bruttolön: ");
            double bruttolön = double.Parse(Console.ReadLine());
            double skatt, nettolön;
            Console.WriteLine(CalcSalaryTax(bruttolön, out skatt, out nettolön));
        }
    }
}
