using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API.Model.Entities;
using API.Repositories;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route(Routes.PRODUCTS)]
    public class ProductController : Controller
    {
        [HttpGet(Name = "Getproducts")]
        public IActionResult Get()
        {
            return Ok(ProductRepository.GetAll());
        }

        [HttpGet("{id}", Name = "GetProduct")]
        public IActionResult Get(Guid id)
        {
            return Ok(ProductRepository.Get(id));
        }

        [Route("create")]
        [HttpPost("create", Name = "CreateProduct")]
        public IActionResult Add([FromBody] Product product)
        {
            if (product.Name != null && product.Description != null)
                return Ok(product.ProductId);
            // todo ADD XD
            return BadRequest();
        }
    }
}
