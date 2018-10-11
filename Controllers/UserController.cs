using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoData;
using TodoMvc.Models;

namespace TodoMvc.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly TodoContext Context;

        public UserController(TodoContext context) 
            => Context = context;

        [HttpPost]
        public IActionResult CreateUser([FromBody]TestRequest request)
        {

            

            return Ok("Todo Created");
        }

        public class TestRequest
        {

        }
    }
}
