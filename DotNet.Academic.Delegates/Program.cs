using DotNet.Academic.Delegates.Library;
using System;
using System.Collections.Generic;

namespace DotNet.Academic.Delegates
{
    class Program
    {
        static Cart cart = new Cart();

        // Samples via Tim Corey
        static void Main(string[] args)
        {
            cart = new Cart() { Products = new List<Product>() { 
                new Product() { Name = "Lakers T-Shirt", Price = 80M, Quantity = 2 },
                new Product() { Name = "Lebron James Shoes", Price = 300M, Quantity = 1 },
                new Product() { Name = "Miami Head Jersey", Price = 90M, Quantity = 4 }
            } };


            var total = cart.CalculateTotal(NotifyDiscount, ApplyDiscounts);

            //short hand
            var total2 = cart.CalculateTotal((total) =>
            {
                if (total < 200M)
                {
                    Console.WriteLine("No Discount");
                }
                else
                {
                    Console.WriteLine("Discount applied");
                }
            }, (total) =>
            {
                if (total > 200M)
                {
                    return total *= 0.5M;
                }

                return total;
            });

            Console.WriteLine($"Total - {total:C2}");
        }

        public static decimal ApplyDiscounts(decimal total)
        {
            if (total > 200M)
            {
                return total *= 0.5M;
            }

            return total;
        }

        public static void NotifyDiscount(decimal total)
        {
            if (total < 200M)
            {
                Console.WriteLine("No Discount");
            }   
            else
            {
                Console.WriteLine("Discount applied");
            }
        }
    }
}
