using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route(Routes.API)]
    public class RootController : Controller
    {
        // GET: api/
        [HttpGet(Name = "GetRoot")]
        public IActionResult Get()
        {
            var root = "https://" + Request.Host.ToString() + "/";
            return Ok(Routes.GetRoutes(root));
        }
    }
}
