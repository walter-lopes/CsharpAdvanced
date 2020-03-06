using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Principles.SRP.Solution
{
    public class CustomerValidator
    {
        public bool Validate(Customer customer)
        {
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

            return isValid;
        }
    }
}
