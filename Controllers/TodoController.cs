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
    public class TodoController : Controller
    {
        private readonly TodoContext Context;

        public TodoController(TodoContext context) 
            => Context = context;

        [HttpPost]
        public IActionResult Test([FromBody]TestRequest request)
        {

            

            return Ok("Todo Created");
        }

        public class TestRequest
        {

        }
    }
}
