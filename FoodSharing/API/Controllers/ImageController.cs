using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API.Model.Entities;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route(Routes.IMAGES)]
    public class ImageController : Controller
    {
        [HttpGet(Name = "GetImages")]
        public IEnumerable<Image> Get()
        {
            return new List<Image>()
            {
                new Image {
                    ImageId = Guid.NewGuid(),
                    Payload = "ASDF"
                },
                new Image {
                    ImageId = Guid.NewGuid(),
                    Payload = "FDSA"
                }
            };
        }
        [Route("create")]
        [HttpPost("create", Name = "CreateImage")]
        public ActionResult Add([FromBody] Image image)
        {
            if (image.Payload != null)
                return Ok();
            // todo ADD XD
            return BadRequest();
        }

        [HttpGet("{id}", Name = "GetImage")]
        public Image Get(Guid id)
        {
            return new Image {
                ImageId = Guid.NewGuid(),
                Payload = "ASDF"
            };
        }
    }
}
