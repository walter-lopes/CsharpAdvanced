using SOLID.Principles.OCP.Solution;
using SOLID.Principles.SRP.Solution;
using SOLID.Principles.SRP.Violation;
using System;

namespace SOLID.Principles
{
    class Program
    {
        static void Main(string[] args)
        {

            // SRP - Single Resposibility Principle

            //ClassResponsibleForEverything everything = new ClassResponsibleForEverything();

            //everything.DoEverything();


            CustomerService customerService = new CustomerService();

            SRP.Solution.Customer customer = new SRP.Solution.Customer("Walter Cardoso", "walter.cardoso@gugadev.com", "44177673839");

            customerService.Save(customer);

            Console.ReadLine();


            // OCP  - Open Closed Principle

            //Person person = new Person()
            //{
            //    GivenName = "Bilbo",
            //    Lastname = "Bolseiro"
            //};

            //Employee employee = new Account().Create(person);

            //Console.WriteLine($"{employee.FullName} - {employee.Email}");

            //Console.ReadLine();

            IPerson person = new Motoboy()
            {
                GivenName = "Bilbo",
                Lastname = "Bolseiro"
            };

            Employee employee = person.Account.Create(person);

            Console.WriteLine($"{employee.FullName} - {employee.Email}");

            Console.ReadLine();
        }
    }
}
