namespace Product.Models
{
    /// <summary>
    /// Type model.
    /// </summary>
    public class Type
    {
        /// <summary>
        /// Number of decimal places by rounding.
        /// </summary>
        public int Sign { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// How this type of product is rounded.
        /// </summary>
        public RoundMode RoundMode { get; set; }
    }
}
