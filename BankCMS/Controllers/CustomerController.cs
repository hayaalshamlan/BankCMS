using BankCMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankCMS.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
     List<Customer> customers = new List<Customer>();
           
            {
                new Customer { Id = 0080, Name = "haya", Email = "haya@gmail.com" };
           

            };
            return View(customers);
        }
    }
}
