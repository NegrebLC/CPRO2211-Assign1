using System.ComponentModel.DataAnnotations;

namespace CPRO2211_Assignment1.Models
{
    // Class for the Price Quotation
    public class PriceQuotation
    {
        // Setting error handling and calculations for all
        [Required(ErrorMessage = "Please enter a number for the subtotal!")]
        public decimal Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a number for the discount percentage!")]
        [Range(0, 100, ErrorMessage = "The discount percentage must be between 0 and 100!")]
        public decimal DiscountPercent { get; set; }
        public decimal DiscountPrice => Subtotal * (DiscountPercent / 100);
        public decimal Total => Subtotal - DiscountPrice;
    }
}
