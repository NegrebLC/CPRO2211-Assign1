using Microsoft.AspNetCore.Mvc;
using CPRO2211_Assignment1.Models;

public class TipController : Controller
{
    public IActionResult Index()
    {
        var model = new TipCalculator();
        return View("TipCalculate", model);
    }

    // Action for Calculate Button
    [HttpPost]
    public IActionResult Calculate(TipCalculator model, string clearButton)
    {
        if (!string.IsNullOrEmpty(clearButton))
        {
            // Clear button was clicked, reset the form
            return RedirectToAction("Clear");
        }

        if (ModelState.IsValid)
        {
            // Calculation logic is handled in the model
            return View("TipCalculate", model);
        }

        return View("TipCalculate", model);
    }

    // Action for Clear Button
    public IActionResult Clear()
    {
        var model = new TipCalculator();
        return View("TipCalculate", model);
    }
}
