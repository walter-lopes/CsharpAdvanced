using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Principles.SRP.Violation
{
    public class ClassResponsibleForEverything
    {
        public void DoEverything()
        {
            Console.WriteLine("Starting SRP Violation.");

            Customer customer = new Customer()
            {
                Name = "Walter Cardoso",
                Email = "walter.cardoso@gugadev.com",
                CPF = "44177673839"
            };

            bool isValid = true;

            Console.WriteLine("Validating customer.");

            if (string.IsNullOrEmpty(customer.Name))
            {
                Console.WriteLine("Name is required.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(customer.Email))
            {
                Console.WriteLine("Email is required.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(customer.CPF))
            {
                Console.WriteLine("CPF is required.");
                isValid = false;
            }

            if (!isValid)
            {
                return;
            }


            Console.WriteLine("Saving in database.");

            Console.WriteLine($"Name: {customer.Name}");
            Console.WriteLine($"CPF: {customer.CPF}");
            Console.WriteLine($"Email: {customer.Email}");

        }
    }

    public class Customer
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string CPF { get; set; }
    }
}
