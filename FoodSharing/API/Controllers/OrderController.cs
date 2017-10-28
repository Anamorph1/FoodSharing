﻿using System;
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
        public IEnumerable<Offer> Get()
        {
            return new List<Offer>()
            {
                new Offer
                {
                    OfferId = Guid.NewGuid(),
                    Address = "Dziura w dupie 1/1",
                    OwnerId = Guid.NewGuid(),
                    IsForFoundationOnly = false,
                    ProductIds = new List<Guid>
                    {
                        Guid.NewGuid(),
                        Guid.NewGuid()
                    },
                    RecieveTimes = new List<TimeFrame>
                    {
                        new TimeFrame(DateTime.Now.AddHours(11), DateTime.Now.AddHours(12)),
                        new TimeFrame(DateTime.Now.AddHours(23), DateTime.Now.AddHours(24))
                    }
                },
                                new Offer
                {
                    OfferId = Guid.NewGuid(),
                    Address = "Dziura w dupie 1/2",
                    OwnerId = Guid.NewGuid(),
                    IsForFoundationOnly = false,
                    ProductIds = new List<Guid>
                    {
                        Guid.NewGuid(),
                        Guid.NewGuid()
                    },
                    RecieveTimes = new List<TimeFrame>
                    {
                        new TimeFrame(DateTime.Now.AddHours(1), DateTime.Now.AddHours(2)),
                        new TimeFrame(DateTime.Now.AddHours(3), DateTime.Now.AddHours(4))
                    }
                }
            };
        }
        [Route("create")]
        [HttpPost("create", Name = "CreateOrder")]
        public ActionResult Add([FromBody] Offer offer)
        {
            if (offer.Address != null)
                return Ok();
            // todo ADD XD
            return BadRequest();
        }

        [HttpGet("{id}", Name = "GetOrder")]
        public Offer Get(Guid id)
        {
            return new Offer
            {
                OfferId = id,
                Address = "Dziura w dupie 1/1",
                OwnerId = Guid.NewGuid(),
                IsForFoundationOnly = false,
                ProductIds = new List<Guid>
                    {
                        Guid.NewGuid(),
                        Guid.NewGuid()
                    },
                RecieveTimes = new List<TimeFrame>
                    {
                        new TimeFrame(DateTime.Now.AddHours(11), DateTime.Now.AddHours(12)),
                        new TimeFrame(DateTime.Now.AddHours(23), DateTime.Now.AddHours(24))
                    }
            };
        }
    }
}
