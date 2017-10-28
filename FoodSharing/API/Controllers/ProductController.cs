using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API.Model.Entities;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route(Routes.PRODUCTS)]
    public class ProductController : Controller
    {
        [HttpGet(Name = "Getproducts")]
        public IEnumerable<Product> Get()
        {
            return new List<Product>()
            {
                new Product {
                    ProductId = Guid.NewGuid(),
                    Name = "Frytki",
                    Description = "100g",
                    ImageId = Guid.NewGuid(),
                    ExpirationDate = DateTime.Now.AddHours(12)
                },
                new Product {
                    ProductId = Guid.NewGuid(),
                    Name = "Kurczak",
                    Description = "Żywy kurczak",
                    ImageId = Guid.NewGuid(),
                    ExpirationDate = DateTime.Now.AddHours(96)
                }
            };
        }
        [Route("create")]
        [HttpPost("create", Name = "CreateProduct")]
        public ActionResult Add([FromBody] Product product)
        {
            if (product.Name != null && product.Description != null)
                return Ok();
            // todo ADD XD
            return BadRequest();
        }

        [HttpGet("{id}", Name = "GetProduct")]
        public Product Get(Guid id)
        {
            return new Product
            {
                ProductId = Guid.NewGuid(),
                Name = "Kurczak",
                Description = "Żywy kurczak",
                ImageId = Guid.NewGuid(),
                ExpirationDate = DateTime.Now.AddHours(96)
            };
        }
    }
}
