using Product.Models;
using System;

namespace Product
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // I create a product.
            Models.Product product = new Models.Product
            {
                // The appearance of the product indicates that when rounded,
                // it is rounded to two decimal places. What name - it doesn't
                // matter. Rounding in bigger side.
                View = new View
                {
                    Sign = 2,
                    Name = "First",
                    RoundMode = RoundMode.Greater
                },

                // The type of product indicates that when rounded, it is
                // rounded to three decimal places. What name - it doesn't
                // matter. Mathematical rounding.
                Type = new Models.Type
                {
                    Sign = 3,
                    Name = "First",
                    RoundMode = RoundMode.Math
                },

                // Weight which we will round off.
                Weight = 3.14M
            };

            // We are rounded off according to mathematical rules - it is
            // preferable, therefore, if one of the properties has such
            // rounding, we round off according to mathematical rules.
            // Otherwise, in bigger side.
            Console.WriteLine(product.Weight);
        }
    }
}
