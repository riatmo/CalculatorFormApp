using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CalculatorMachine;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator Sederhana";

            Console.Write("Masukan nilai a : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan nilai b : ");
            int b = Convert.ToInt32(Console.ReadLine());

            var cal = new Calculator();

            Console.WriteLine();
            Console.WriteLine("Hasil penjumlahan dari {0} + {1} = {2}", a, b, cal.penjumlahan(a, b));
            Console.WriteLine("Hasil pengurangan dari {0} - {1} = {2}", a, b, cal.pengurangan(a, b));
            Console.WriteLine("Hasil perkalian dari {0} * {1} = {2}", a, b, cal.perkalian(a, b));
            Console.WriteLine("Hasil pembagian dari {0} / {1} = {2}", a, b, Calculator.pembagian(a, b));


            Console.ReadKey();
        }

    }
}
