using BankCMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankCMS.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { EmployeeId = 1998, FirstName = "haya", LastName = "Alshamlan", Email = "haya@gmail.com", Department = "Ist" }
            };
          return View(employees);
        }
    }
}
