using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API.Model.Entities;
using API.Repositories;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route(Routes.USERS)]
    public class UserController : Controller
    {
        [HttpGet(Name = "GetUsers")]
        public IActionResult Get()
        {
            return Ok(UserRepository.GetAll());
        }
        [Route("create")]
        [HttpPost("create", Name = "CreateUser")]
        public IActionResult Add([FromBody] User user)
        {
            if (UserRepository.Add(user))
                return Ok(user.UserId);
            // todo ADD XD
            return BadRequest();
        }

        [HttpGet("{id}", Name = "GetUser")]
        public IActionResult Get(Guid id)
        {
            return Ok(UserRepository.Get(id));
        }
    }
}
