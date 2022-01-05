using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorrectionPetiteAnnonce.Interfaces;
using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CorrectionPetiteAnnonce.Controllers
{
    [EnableCors("specialOrigin")]
    [Route("api/v1/utilisateurs")]
    public class UtilisateurApiController : Controller
    {
        private IRepository<Utilisateur> _utilisateurRepository;
        LoginService _loginService;


        public UtilisateurApiController(IRepository<Utilisateur> utilisateurRepository, LoginService loginService)
        {
            _utilisateurRepository = utilisateurRepository;
            _loginService = loginService;
        }
        
        [HttpPost]
        public IActionResult SubmitFormLogin([FromForm]string login, [FromForm]string password)
        {
            string token = _loginService.GenerateToken(login, password);
            if(token != null)
            {
                return Ok(new { Token = token });
            }
            return NotFound();
        }
    }
}
