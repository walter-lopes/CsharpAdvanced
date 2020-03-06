using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Principles.OCP.Solution
{
    class ManagerAccount : IAccount
    {
        public Employee Create(IPerson person)
        {
            return new Employee()
            {
                Email = $"{person.GivenName}.{person.Lastname}@gugadev.manager.com",
                FullName = $"{person.GivenName} {person.Lastname}",
            };
        }
    }
}
