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
        [Route("search")]
        [HttpPost("search", Name = "Searcg")]
        public IActionResult Create([FromBody] string query)
        {
            if (String.IsNullOrWhiteSpace(query))
                return Ok(OfferRepository.GetAll());
            else
                return Ok(OfferRepository.GetByQueryInProds(query));
            // todo ADD XD
            
        }

    }
}
