using Product.Models;
using System;

namespace Product
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Models.Product product = new Models.Product
            {
                View = new View
                {
                    Sign = 2,
                    Name = "First",
                    RoundMode = RoundMode.Greater
                },
                Type = new Models.Type
                {
                    Sign = 3,
                    Name = "First",
                    RoundMode = RoundMode.Math
                },
                Weight = 3.14M
            };
            Console.WriteLine(product.Weight);
        }
    }
}
