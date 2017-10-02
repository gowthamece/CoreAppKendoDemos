using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCoreAPI.Model;
using System.Net.Http;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace MyCoreAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Technologies")]
    public class TechnologiesController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        [Route("TechnologiesList")]
        public string GetTechnology()
        {
            try
            {
                 List<TechnologyList> _TechList = new List<TechnologyList>();
                _TechList.Add(new TechnologyList(1, "ASP.NET"));
                _TechList.Add(new TechnologyList(2, "ADO.NET"));
                _TechList.Add(new TechnologyList(3, "SilverLight"));
                _TechList.Add(new TechnologyList(4, "C#"));
                _TechList.Add(new TechnologyList(5, "SQL Server"));


                //return Request.CreateResponse(HttpStatusCode.OK, _TechList, Configuration.Formatters.JsonFormatter);
                // return callback=;

                var json = JsonConvert.SerializeObject(new { callback = _TechList });
                return json;
            }
            catch (Exception ex)
            {
                //List <TechnologyList> _Tech= null;
                return "";
            }
        }
    }
}