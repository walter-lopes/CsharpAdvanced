

namespace SOLID.Principles.OCP.Violention
{
    public class Account
    {
        public Employee Create(Person person)
        {
            //if (person.Type == EmployeeType.Motoboy)
            //{
            //    return new Employee()
            //    {
            //        Email = $"{person.GivenName}.{person.Lastname}@gugadev.manager.com",
            //        FullName = $"{person.GivenName} {person.Lastname}",
            //    };
            //}

            switch (person.Type)
            {
                case EmployeeType.Motoboy:
                    return new Employee()
                    {
                        Email = $"{person.GivenName}.{person.Lastname}@gugadev.motoboy.com",
                        FullName = $"{person.GivenName} {person.Lastname}",
                    };
                case EmployeeType.Sales:
                    return new Employee()
                    {
                        Email = $"{person.GivenName}.{person.Lastname}@gugadev.sales.com",
                        FullName = $"{person.GivenName} {person.Lastname}",
                    };
                case EmployeeType.Manager:
                    return new Employee()
                    {
                        Email = $"{person.GivenName}.{person.Lastname}@gugadev.manager.com",
                        FullName = $"{person.GivenName} {person.Lastname}",
                    };
                default:
                    return new Employee()
                    {
                        Email = $"{person.GivenName}.{person.Lastname}@gugadev.com",
                        FullName = $"{person.GivenName} {person.Lastname}",
                    };
            }            
        }
    }
}
