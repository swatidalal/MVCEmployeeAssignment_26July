using Microsoft.AspNetCore.Mvc;

namespace _26July_EmployeeMVCAssignment.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}
