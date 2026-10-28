using Microsoft.AspNetCore.Mvc;

namespace AccessibleEmployeeManagement.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
