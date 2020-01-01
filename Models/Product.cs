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

using System;

namespace Product.Models
{
    /// <summary>
    /// Product model.
    /// </summary>
    public class Product
    {
        private decimal weight;

        public decimal Weight
        {
            get => weight;

            set => weight = IsGreatPriority() ? Math.Round(value) : Math.Round(value, Sing);
        }

        public int Sing => View.Sign > Type.Sign ? View.Sign : Type.Sign;

        public View View { get; set; }

        public Type Type { get; set; }

        /// <summary>
        /// Mathematical rounding is preferred.
        /// </summary>
        /// <returns>View or type is mathematically rounded?</returns>
        private bool IsGreatPriority()
        {
            return View.RoundMode == RoundMode.Math || Type.RoundMode == RoundMode.Math;
        }
    }
}
