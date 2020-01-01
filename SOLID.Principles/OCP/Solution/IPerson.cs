using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Principles.OCP.Solution
{
    public interface IPerson
    {
        string GivenName { get; set; }

        string Lastname { get; set; }

        IAccount Account { get; set; }
    }
}
