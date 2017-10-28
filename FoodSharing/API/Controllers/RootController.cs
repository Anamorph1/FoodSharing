using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route(Routes.API)]
    public class RootController : Controller
    {
        // GET: api/
        [HttpGet]
        public Dictionary<string, string> Get()
        {
            var root = "http://" + Request.Host.ToString() + "/";
            return Routes.GetRoutes(root);
        }

    }
}
