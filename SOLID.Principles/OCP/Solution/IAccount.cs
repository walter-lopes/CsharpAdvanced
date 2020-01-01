using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Principles.OCP.Solution
{
    public interface IAccount
    {
        Employee Create(IPerson person);
    }
}
