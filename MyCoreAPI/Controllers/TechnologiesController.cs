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

namespace MyCoreAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Technologies")]
    public class TechnologiesController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        [Route("TechnologiesList")]
        public List<TechnologyList> GetTechnology()
        {
            try
            {
                 List<TechnologyList> _TechList = new List<TechnologyList>();
                _TechList.Add(new TechnologyList(1, "ASP.NET"));
                _TechList.Add(new TechnologyList(2, "ADO.NET"));
                _TechList.Add(new TechnologyList(3, "SilverLight"));
                _TechList.Add(new TechnologyList(4, "C#"));
                _TechList.Add(new TechnologyList(5, "SQL Server"));
                _TechList.Add(new TechnologyList(6, "F#"));

                //return Request.CreateResponse(HttpStatusCode.OK, _TechList, Configuration.Formatters.JsonFormatter);
                return _TechList;

            }
            catch (Exception ex)
            {
                List < TechnologyList > _Tech= null;
                return _Tech;
            }
        }
    }
}