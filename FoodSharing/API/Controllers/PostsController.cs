using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route(Routes.POSTS)]
    public class PostsController : Controller
    {
        public class Post
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }

            public DateTime ConsumptionDate { get; set; }
        }

        [HttpGet]
        public IEnumerable<Post> Get()
        {

            return new List<Post>()
            {
                new Post {
                    Id = Guid.NewGuid(),
                    Name = "Frytki",
                    Description = "100g frytek",
                    ImageUrl = "https://cms.splendidtable.org/sites/default/files/styles/900x500/public/french-fries.jpg?itok=2wcnbFAY",
                    ConsumptionDate = DateTime.Now.AddDays(2)
                },
                new Post {
                    Id = Guid.NewGuid(),
                    Name = "Kurczak",
                    Description = "Żywy kurczak",
                    ImageUrl = "https://www.bbcgoodfood.com/sites/default/files/styles/carousel_medium/public/chicken-main_0.jpg?itok=pAFuYVvC",
                    ConsumptionDate = DateTime.Now.AddHours(6)
                }
            };
        }

        [Route("add")]
        [HttpPost("add", Name = "Add")]
        public ActionResult Add([FromBody] Post post)
        {
            if (post.Name != null && post.Description != null && post.ConsumptionDate != null)
                return Ok();
            // todo ADD XD
            return BadRequest();
        }

        [HttpGet("{id}", Name = "Get")]
        public Post Get(Guid id)
        {
            return new Post
            {
                Id = id,
                Name = "Frytki",
                Description = "100g frytek",
                ImageUrl = "https://cms.splendidtable.org/sites/default/files/styles/900x500/public/french-fries.jpg?itok=2wcnbFAY",
                ConsumptionDate = DateTime.Now.AddDays(2)
            };
        }
    }
}
