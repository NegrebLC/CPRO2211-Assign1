using Microsoft.AspNetCore.Mvc;

namespace CPRO2211_Assignment1.Controllers
{
    public class PriceController : Controller
    {
        public IActionResult Index()
        {
            var model = new Models.PriceQuotation();
            return View("PriceCalculate", model);
        }

        // Action for Calculate Button
        [HttpPost]
        public IActionResult Calculate(Models.PriceQuotation model, string clearButton)
        {
            // Chicking which button was pressed
            if (!string.IsNullOrEmpty(clearButton))
            {
                // Clear button was clicked, reset the form
                return RedirectToAction("Clear");
            }

            if (ModelState.IsValid)
            {
                // Calculation logic is handled in the model
                return View("PriceCalculate", model);
            }

            return View("PriceCalculate", model);
        }

        // Action for Clear Button
        public IActionResult Clear()
        {
            var model = new Models.PriceQuotation();
            return View("PriceCalculate", model);
        }
    }
}
