using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API.Model.Entities;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route(Routes.USERS)]
    public class UserController : Controller
    {
        [HttpGet(Name = "GetUsers")]
        public IEnumerable<User> Get()
        {
            return new List<User>()
            {
                new User {
                    UserId = Guid.NewGuid(),
                    Name = "Kamil Makarowski",
                    Email = "kam.makarowski@gmail.com",
                    DefaultAddress = "Dziura w dupie 1/2",
                    IsFoundation = true,
                    Password = "XD"
                },
                new User {
                    UserId = Guid.NewGuid(),
                    Name = "Adam Giża",
                    Email = "adam.giza@gmail.com",
                    DefaultAddress = "Dziura w dupie 2/1",
                    IsFoundation = false,
                    Password = "XD"
                }
            };
        }
        [Route("create")]
        [HttpPost("create", Name = "CreateUser")]
        public ActionResult Add([FromBody] User user)
        {
            if (user.Name != null && user.Password != null && user.Email != null)
                return Ok();
            // todo ADD XD
            return BadRequest();
        }

        [HttpGet("{id}", Name = "GetUser")]
        public User Get(Guid id)
        {
            return new User
            {
                UserId = Guid.NewGuid(),
                Name = "Adam Giża",
                Email = "adam.giza@gmail.com",
                DefaultAddress = "Dziura w dupie 2/1",
                IsFoundation = false,
                Password = "XD"
            };
        }
    }
}
