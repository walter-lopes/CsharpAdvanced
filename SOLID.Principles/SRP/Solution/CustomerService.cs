using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Principles.SRP.Solution
{
    public class CustomerService
    {
        public void Save(Customer customer)
        {
            var customerValidator = new CustomerValidator();

            var isValid =  customerValidator.Validate(customer);

            if(!isValid)
            {
                Console.WriteLine("Customer with errors");
                return;
            }           

            var customerRepository = new CustomerRepository();

            customerRepository.Save(customer);
        }
    }
}
