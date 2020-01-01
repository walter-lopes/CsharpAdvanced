using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Principles.OCP.Violention
{
    public class Person
    {
        public string GivenName { get; set; }

        public string Lastname { get; set; }

        public EmployeeType Type { get; set; } = EmployeeType.Staff;
    }
}
