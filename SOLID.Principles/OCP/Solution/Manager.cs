using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Principles.OCP.Solution
{
    public class Manager : IPerson
    {
        public string GivenName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Lastname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IAccount Account { get; set; } = new ManagerAccount();
    }
}
