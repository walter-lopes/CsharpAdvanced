using DesignPatterns.Strategy;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strategy Pattern
            Console.WriteLine("Strategy Pattern ---------------------");

            ITax icms = new ICMS();
            ITax iss = new ISS();

            Budget budget = new Budget() { Value = 300.00 };


            Console.WriteLine("Calc for ICMS: " +  icms.Calc(budget));

            Console.WriteLine("Calc for ISS: " + iss.Calc(budget));

            Console.WriteLine("Strategy Pattern ---------------------");
            Console.ReadKey();
        }
    }
}
