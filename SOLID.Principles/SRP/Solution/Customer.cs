using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Principles.SRP.Solution
{
    public class Customer
    {
        public string Name { get; private set; }

        public string Email { get; private set; }

        public string CPF { get; private set; }


        public Customer(string name, string email, string cpf)
        {
            this.Name = name;
            this.Email = email;
            this.CPF = cpf;
        }
    }
}
