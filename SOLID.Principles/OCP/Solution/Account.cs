using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Principles.OCP.Solution
{
    public class Account : IAccount
    {
        public Employee Create(IPerson person)
        {
            return new Employee()
            {
                Email = $"{person.GivenName}.{person.Lastname}@gugadev.com",
                FullName = $"{person.GivenName} {person.Lastname}",
            };
        }
    }
}
