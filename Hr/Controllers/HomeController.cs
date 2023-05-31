using Hr.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hr.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Employees()
        { 
            return View();
        }

        [HttpPost]
        public ViewResult Employees(Employess employess)
        {
            if (ModelState.IsValid)
            {
                Repository.AddEmployee(employess);
                return View("ConfirmPage", employess);
            }
            else
            {
                return View();
            }
        }

        public ViewResult AllEmployees()
        {
            return View(Repository.GetEmployesses().Where(emp => emp.isActive==true));
        }


    }
}