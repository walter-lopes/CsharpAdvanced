using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotNet.Academic.Delegates.Library
{
    public class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }      
    }



    public class Cart
    {
        public delegate void NotifyDiscount(decimal total);

        public IList<Product> Products { get; set; }

        public decimal CalculateTotal(NotifyDiscount notifyDiscount, Func<decimal, decimal> applyDiscount)
        {
            var total = this.Products.Sum(x => x.Price * x.Quantity);

            total = applyDiscount(total);

            notifyDiscount(total);

            return total;
        }
    }
}
