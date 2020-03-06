using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Principles.OCP.Solution
{
    class MotoboyAccount : IAccount
    {
        public Employee Create(IPerson person)
        {
            return new Employee()
            {
                Email = $"{person.GivenName}.{person.Lastname}@gugadev.motoboy.com",
                FullName = $"{person.GivenName} {person.Lastname}",
            };
        }
    }
}
