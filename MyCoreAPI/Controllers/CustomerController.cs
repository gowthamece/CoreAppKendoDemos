using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCoreAPI.Model;

namespace MyCoreAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        [HttpGet]
        [Route("CustomerDetails")]

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(1, "Arun"));
            customers.Add(new Customer(2, "Raj"));
            return customers.ToList();
        }


    }
}