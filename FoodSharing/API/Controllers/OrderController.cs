using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API.Model.Entities;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route(Routes.ORDERS)]
    public class OrderController : Controller
    {
        [HttpGet(Name = "GetOrders")]
        public IActionResult Get()
        {
            return Ok();
        }

        [Route("create")]
        [HttpPost("create", Name = "CreateOrder")]
        public IActionResult Create([FromBody] Order order)
        {
            return Ok();
            // todo ADD XD
        }

        [Route("update")]
        [HttpPost("update", Name = "UpdateOrder")]
        public IActionResult Update([FromBody] Order order)
        {
            return Ok();
            // todo ADD XD
        }

        [Route("submit/{id}")]
        [HttpPost("submit/{id}", Name = "SubmitOrder")]
        public IActionResult Submit([FromBody] Guid id)
        {
            return Ok();
            // todo ADD XD
        }

        [HttpGet("{id}", Name = "GetOrder")]
        public IActionResult Get(Guid id)
        {
            return Ok(new Order
            {
                OrderId = Guid.NewGuid(),
                OwnerId = Guid.NewGuid(),
                OfferIds = new List<Guid>()
                {
                    Guid.NewGuid(),
                    Guid.NewGuid()
                }
            });
        }
    }
}
