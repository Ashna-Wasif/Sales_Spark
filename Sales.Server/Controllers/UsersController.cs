using Microsoft.AspNetCore.Mvc;
using Sales.Server.Model;
using Sales.Server.Model.Entities;
using System;

namespace Sales.Server.Controllers
{
    [Route("api/users")]  //  Define API base route
    [ApiController]       // Mark this as an API controller
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("signup")]
        public ActionResult<object> Create([FromBody] addUsers a)
        {
            try
            {
                Users user = new Users()
                {
                    user_Name = a.user_Name,
                    user_Email = a.user_Email,
                    user_Contact = a.user_Contact,
                    user_Password = a.user_Password,
                    user_AccessLevel = 3
                };

                _context.Users.Add(user);
                _context.SaveChanges();

                return Ok(new { message = "User registered successfully" });  // Return JSON response
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = "Registration failed", details = ex.Message });  // Return error JSON
            }
        }

       
    }
}
