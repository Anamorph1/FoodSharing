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
            return Ok(OfferRepository.GetAll());
        }

        [Route("create")]
        [HttpPost("create", Name = "CreateOffer")]
        public IActionResult Create([FromBody] Offer offer)
        {
            if (offer.Address != null)
                return Ok(offer.OfferId);
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
