using APIs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // POST: api/Users
        [HttpPost("Login")]
        public async Task<bool> Login([FromBody] User user)
        {
            var data = new List<string>()
            {
                user.EmailAddress,
                user.Password,
                user.Role
            };
            return true;
        }

        // POST: api/Users
        [HttpPost("RegisterUser")]
        public async Task<bool> RegisterUser(User user)
        {
            var data = new List<string>()
            {
                user.EmailAddress,
                user.Password,
                user.Role
            };
            return true;
        }

    }
}
