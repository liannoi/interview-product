using System;

namespace Product.Models
{
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

        private bool IsGreatPriority()
        {
            return View.RoundMode == RoundMode.Math || Type.RoundMode == RoundMode.Math;
        }
    }
}
