using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithAuth.Data;
using WebApiWithAuth.Models;
using WebApiWithAuth.Services;

namespace WebApiWithAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IIdentityService _identity;

        public UsersController(IIdentityService identity)
        {
            _identity = identity;
        }


        [AllowAnonymous]
        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromBody] SignUpModel model)
        {
            if (await _identity.CreateUserAsync(model))
                return new OkResult();
            
            return new BadRequestResult();
        }
    }
}
