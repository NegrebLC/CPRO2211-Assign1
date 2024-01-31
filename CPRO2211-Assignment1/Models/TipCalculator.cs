using System.ComponentModel.DataAnnotations;

namespace CPRO2211_Assignment1.Models
{
    public class TipCalculator
    {
        // Setting error handling, calculations and display formats for all
        [Required(ErrorMessage = "Please enter a number for the price!")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a number greater than 0!")]
        public decimal Price { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Fifteen => Price * 0.15m;

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Twenty => Price * 0.20m;

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TwentyFive => Price * 0.25m;
    }
}
