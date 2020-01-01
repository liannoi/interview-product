// Copyright 2020 Maksym Liannoi
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

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
