using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Jordan Henry" },
                new Customer { Id = 2, Name = "Logan Laderoute"}
            };

            return customers;
        }

        // GET: Customer
        //[Route("Customer/ListCustomers")]
        public ActionResult ListCustomers()
        {
            List<Customer> customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();


            return View(customer);
        }
    }
}