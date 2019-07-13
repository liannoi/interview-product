namespace Product.Models
{
    public class View
    {
        /// <summary>
        /// Number of decimal places by rounding.
        /// </summary>
        public int Sign { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// How this view of product is rounded.
        /// </summary>
        public RoundMode RoundMode { get; set; }
    }
}
