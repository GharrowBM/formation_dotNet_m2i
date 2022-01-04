using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoursJWT.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoursJWT.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        LoginService _loginService;
        public LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        public IActionResult Login([FromForm]string email, [FromForm] string password)
        {
            string token = _loginService.GenerateToken(email, password);
            if(token == null)
            {
                return NotFound();
            }
            return Ok(token);
        }
    }
}
