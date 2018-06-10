using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCoreAPI.Model;

namespace MyCoreAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Employees")]
    public class EmployeesController : Controller
    {
     
        [HttpGet]
        [AllowAnonymous]       
        [Route("Empdetails")]
        public List<Employee> GetEmployees(int? EmployeeId)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "Arun", true, null));
            employees.Add(new Employee(2, "Pradeep", false, 1));
            employees.Add(new Employee(3, "Gowtham", true, null));
            employees.Add(new Employee(4, "Raj", false, 3));
            if (EmployeeId != null)
            {
                return employees.Where(e => e.ReportsTo == EmployeeId).ToList();
            }
            else
            {
                return employees.Where(e => !e.ReportsTo.HasValue).ToList();
            }
        }
    }
}