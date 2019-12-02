using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class CalculateTaxs
    {
        public double Calculate(Budget budget, ITax tax)
        {
            return tax.Calc(budget);
        }
    }
}
