using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API.Model.Entities;
using API.Repositories;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route(Routes.SEARCH)]
    public class SearchController : Controller
    {
        [HttpGet(Name = "Search")]
        public IActionResult Create()
        {
            if (!Request.Query.ContainsKey("query"))
                return Ok(new List<Offer>());
            var query = Request.Query["count"];
            if (String.IsNullOrWhiteSpace(query))
                return Ok(new List<Offer>());
            else
                return Ok(OfferRepository.GetByQueryInProds(query));
            // todo ADD XD
            
        }

    }
}
