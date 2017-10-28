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
            var query = Request.Query["query"];
            if (String.IsNullOrWhiteSpace(query))
                return Ok(new List<Offer>());
            else
                return Ok(OfferRepository.GetByQueryInProds(query));
        }

    }
}
