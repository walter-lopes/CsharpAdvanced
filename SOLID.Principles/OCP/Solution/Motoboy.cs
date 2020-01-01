using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Principles.OCP.Solution
{
    public class Motoboy : IPerson
    {
        public string GivenName { get ; set ; }
        public string Lastname { get ; set ; }
        public IAccount Account { get ; set ; } = new MotoboyAccount();
    }
}
