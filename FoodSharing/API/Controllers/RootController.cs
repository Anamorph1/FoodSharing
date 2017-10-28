using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route(Routes.API)]
    public class RootController : Controller
    {
        // GET: api/Root
        [HttpGet]
        public Dictionary<string, string> Get()
        {
            var root = "http://" + Request.Host.ToString() + "/";
            return Routes.GetRoutes(root);
        }

    }
}
