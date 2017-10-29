using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API.Model.Entities;
using API.Repositories;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route(Routes.OFFERS)]
    public class OfferController : Controller
    {
        [HttpGet(Name = "GetOffers")]
        public IActionResult Get()
        {
            var isFound = Convert.ToBoolean(Request.Query["isFoundation"]);
            if (Request.Query.ContainsKey("count"))
            {
                int count;
                if (Int32.TryParse(Request.Query["count"], out count))
                    return Ok(OfferRepository.GetN(count, isFound));
                else
                    return BadRequest();
            }
            return Ok(OfferRepository.GetAll(isFound));
        }

        [Route("create")]
        [HttpPost("create", Name = "CreateOffer")]
        public IActionResult Create([FromBody] Offer offer)
        {
            if (OfferRepository.Create(offer))
            {
                return Ok(offer.OfferId);
            }
            // todo ADD XD
            return BadRequest();
        }

        [HttpGet("{id}", Name = "GetOffer")]
        public IActionResult Get(Guid id)
        {
            return Ok(OfferRepository.Get(id));
        }
    }
}
