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
        public List<TechnologyList> GetTechnology()
        {
            try
            {
                List<TechnologyList> _TechList = new List<TechnologyList>();
                for (int i = 1; i <= 10000; i++)
                {
                    _TechList.Add(new TechnologyList(i, "ASP.NET"));
                    _TechList.Add(new TechnologyList(i + 1, "ADO.NET"));
                    _TechList.Add(new TechnologyList(i + 2, "SilverLight"));
                    _TechList.Add(new TechnologyList(i + 3, "C#"));
                    _TechList.Add(new TechnologyList(i + 4, "SQL Server"));
                    i = i + 4;
                }

                //return Request.CreateResponse(HttpStatusCode.OK, _TechList, Configuration.Formatters.JsonFormatter);
                // return callback=;

                // var json = JsonConvert.SerializeObject(new { callback = _TechList });
                return _TechList;
            }
            catch (Exception ex)
            {
                List<TechnologyList> _Tech = null;
                return _Tech;
            }
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("TechnologiesLimitedList")]
        public List<TechnologyList> GetLimitedTechnology()
        {
            try
            {
                List<TechnologyList> _TechList = new List<TechnologyList>();
                for (int i = 1; i <= 70; i++)
                {
                    _TechList.Add(new TechnologyList(i, "ASP.NET"));
                    _TechList.Add(new TechnologyList(i + 1, "ADO.NET"));
                    _TechList.Add(new TechnologyList(i + 2, "SilverLight"));
                    _TechList.Add(new TechnologyList(i + 3, "C#"));
                    _TechList.Add(new TechnologyList(i + 4, "SQL Server"));
                    i = i + 4;
                }


                return _TechList;
            }
            catch (Exception ex)
            {
                List<TechnologyList> _Tech = null;
                return _Tech;
            }
        }
    }
}