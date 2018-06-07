using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net;

namespace MyCoreAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Automobiles")]
    public class AutomobilesController : Controller
    {
        [HttpGet]
        [Route("DataSource")]
        public JsonResult HierachyDataSource()
        {
            var obj = new []
            {
                new {
                name = "Automobiles",
                value = 1,
                items = new[] {
                new {
                    name = "Bus",
                    value = 2,
                    items = new dynamic [] {
                        new {
                            name = "Ford",
                            value=3
                        },
                            new {
                            name = "BMW",
                            value=4,
                        },

                        },
                    },

                new {
                    name = "Car",
                    value=5,
                    items = new dynamic [] {
                        new { name = "Honda", value=6},
                        new { name = "Ford",  value=7},

                    }
                },
            },
                },
            };
            return Json(obj);

      
        }

        [HttpGet]
        [Route("DropDownDataSource")]
        public JsonResult DropDownDataSource()
        {
            var obj = new[]
            {
                new {
                text = "Automobiles",
                expanded= true,
                items = new[] {
                new {
                    text = "Bus",
                    
                   
                    },

                new {
                    text = "Car"
                    
                    
                },
            },

                },
            };
            return Json(obj);


        }
    }
}