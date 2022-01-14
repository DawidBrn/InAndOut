using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class ExpensesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
