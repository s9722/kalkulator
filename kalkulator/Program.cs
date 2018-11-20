using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaPierwsza, liczbaDruga;

            Console.WriteLine("PROSTY KALKULATOR \n");
            Console.Write("Podaj pierwszą liczbę: ");
            liczbaPierwsza=Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            liczbaDruga = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wybierz działanie (+, -, *, /): ");

            string dzialanie;

            dzialanie = Console.ReadLine();

            switch (dzialanie)
            {
                case "+":
                    Console.WriteLine($"wynik dodawania to: {liczbaPierwsza + liczbaDruga}");
                    break;
                case "-":
                    Console.WriteLine($"wynik odejmowania to: {liczbaPierwsza - liczbaDruga}");
                    break;
                case "*":
                    Console.WriteLine($"wynik mnożenia to: {liczbaPierwsza * liczbaDruga}");
                    break;
                case "/":
                    Console.WriteLine($"wynik dzielenia to: {liczbaPierwsza / (double)liczbaDruga}");
                    break;
                                        
            }

            Console.ReadKey();

        }
    }
}
