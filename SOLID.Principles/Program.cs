using SOLID.Principles.SRP.Solution;
using SOLID.Principles.SRP.Violation;
using System;

namespace SOLID.Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassResponsibleForEverything everything = new ClassResponsibleForEverything();

            //everything.DoEverything();


            CustomerService customerService = new CustomerService();

            SRP.Solution.Customer customer = new SRP.Solution.Customer("Walter Cardoso", "walter.cardoso@gugadev.com", "44177673839");

            customerService.Save(customer);

            Console.ReadLine();
        }
    }
}
