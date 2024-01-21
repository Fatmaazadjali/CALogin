using Microsoft.AspNetCore.Mvc;

namespace CodeAcademy.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
