using Microsoft.AspNetCore.Mvc;
using DemoApp.Models;

namespace DemoApp.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View(new CalculatorViewModel());
        }

        // POST: Calculator/Index
        [HttpPost]
        public IActionResult Index(CalculatorViewModel model, string command)
        {
            if (ModelState.IsValid)
            {
                switch (command)
                {
                    case "Add":
                        model.Result = model.Number1 + model.Number2;
                        break;
                    case "Sub":
                        model.Result = model.Number1 - model.Number2;
                        break;
                    case "Mul":
                        model.Result = model.Number1 * model.Number2;
                        break;
                    case "Div":
                        if (model.Number2 != 0)
                        {
                            model.Result = model.Number1 / model.Number2;
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "Cannot divide by zero.");
                        }
                        break;
                }
            }
            return View(model);
        }
    }
}
