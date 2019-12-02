using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class ISS : ITax
    {
        public double Calc(Budget budget)
        {
            return budget.Value * 0.06;
        }
    }
}
