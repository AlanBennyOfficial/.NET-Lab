using Microsoft.AspNetCore.Mvc;

namespace SQLDemoApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
