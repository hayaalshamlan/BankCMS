using BankCMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankCMS.Controllers
{
    public class CustomerController : Controller
    {
       static List<Customer> customers = new List<Customer>()
           
            {
                new Customer { Id = "0080", Name = "haya", Email = "haya@gmail.com" }
};

public IActionResult Index()
        {
            ViewData["data"] = customers;
            return View();
        }

        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCustomer(AddCustomerForm form)
        {
          
            var name = form.CustomerName;
            var email = form.CustomerEmail;
            customers.Add(new Customer { Name = name , Email = email});
            return RedirectToAction("Index");
            

        }
     
   }
}

