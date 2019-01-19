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
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        [HttpGet]
        [Route("ProductDetails")]
        public List<Product> GetProduct()
        {
            try
            {
                List<Product> products = new List<Product>();
                products.Add(new Product(1, "Tea pack", 100, 10));
                products.Add(new Product(2, "Coffee pack", 120, 12));
                return products;
            }
            catch (Exception ex)
            {
                List<Product> products = null;
                return products;
            }
        }
    }
}