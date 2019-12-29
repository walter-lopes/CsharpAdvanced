using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Principles.SRP.Solution
{
    public class CustomerRepository
    {
        public void Save(Customer customer)
        {
            Console.WriteLine("Saving in database.");

            Console.WriteLine($"Name: {customer.Name}");
            Console.WriteLine($"CPF: {customer.CPF}");
            Console.WriteLine($"Email: {customer.Email}");
        }
    }
}
