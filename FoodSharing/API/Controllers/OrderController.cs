using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API.Model.Entities;
using API.Repositories;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route(Routes.ORDERS)]
    public class OrderController : Controller
    {
        [HttpGet(Name = "GetOrders")]
        public IActionResult Get()
        {
            return Ok(OrderRepository.GetAll());
        }

        [Route("submit")]
        [HttpPost("submit", Name = "SubmitOrder")]
        public IActionResult Submit([FromBody] Order order)
        {
            if (OrderRepository.SubmitOrder(order))
            {
                return Ok();
            }
            else
                return BadRequest();
            // todo ADD XD
        }

        [HttpGet("{id}", Name = "GetOrder")]
        public IActionResult Get(Guid id)
        {
            return Ok(OrderRepository.Get(id));
        }
    }
}
