using Microsoft.AspNetCore.Mvc;

namespace WebApplication04.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
