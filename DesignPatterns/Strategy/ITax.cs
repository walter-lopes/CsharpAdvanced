using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public interface ITax
    {
        double Calc(Budget budget);
    }
}
