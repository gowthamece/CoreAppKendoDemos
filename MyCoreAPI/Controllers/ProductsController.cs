using Microsoft.AspNetCore.Mvc;
using MyCoreAPI.Model;
using System;
using System.Collections.Generic;


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
                List<Product> products = new List<Product>
                {
                    new Product(1, "Tea pack", 100, 10,"Sku100","100","100","100","100","100","100","100","100","100","100"),
                    new Product(2, "Coffee pack", 120, 12,"Sku101","100","100","100","100","100","100","100","100","100","100"),
                };
               
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