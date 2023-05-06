using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------FizzBuzz---------\nWitaj w grze podaj liczbę:");
            FizzBuzz fizzBuzz = new FizzBuzz();

            while (true)
            {
                var number = GetValue();
                var result = fizzBuzz.CheckResult(number);
                Console.WriteLine(result);
                Console.WriteLine("\nPodaj kolejną liczbę. Żeby zakończyć wybierz 't'");
            }

        }

        private static int GetValue()
        {
            while (true)
            {
                var value = Console.ReadLine();
                if (value.ToUpper() == "T")
                    Environment.Exit(0);

                if(!int.TryParse(value, out int number))
                {
                    Console.WriteLine("\nNiewłasćiwa wartość. Spróbuj ponownie. Żeby zakończyć wybierz 't'\n");
                    continue;
                }
                return number;
            }
        }
    }
}
