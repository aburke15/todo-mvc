using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoData;
using TodoMvc.Models;

namespace TodoMvc.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly TodoContext Context;

        public UsersController(TodoContext context) 
            => Context = context;

        [HttpPost]
        public IActionResult CreateUser([FromBody]CreateUserRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = new User
            {
                LastUpdatedOn = null,
                DeprecatedOn = null,
                Firstname = request.Firstname,
                Lastname = request.Lastname,
                Username = request.Username,
                Email = request.Email,
                Phone = request.Phone
            };

            Context.User.Add(user);
            Context.SaveChanges();

            return Ok("User successfully created.");
        }

        public class CreateUserRequest
        {
            [Required]
            [StringLength(25, ErrorMessage = "cannot exceed [25] characters.")]
            public string Firstname { get; set; }

            [Required]
            [StringLength(25, ErrorMessage = "cannot exceed [25] characters.")]
            public string Lastname { get; set; }

            [Required]
            [StringLength(50, ErrorMessage = "cannot exceed [50] characters.")]
            public string Username { get; set; }

            [Required]
            [StringLength(50, ErrorMessage = "cannot exceed [50] characters.")]
            public string Email { get; set; }

            [StringLength(10, ErrorMessage = "cannot exceed [10] characters.")]
            public string Phone { get; set; }
        }
    }
}
