using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorrectionPetiteAnnonce.Interfaces;
using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CorrectionPetiteAnnonce.Controllers
{
    public class UtilisateurController : Controller
    {
        private IRepository<Utilisateur> _utilisateurRepository;
        LoginService _loginService;


        public UtilisateurController(IRepository<Utilisateur> utilisateurRepository, LoginService loginService)
        {
            _utilisateurRepository = utilisateurRepository;
            _loginService = loginService;
        }
        // GET: /<controller>/
        public IActionResult FormLogin()
        {
            return View();
        }

        public IActionResult SubmitFormLogin(string login, string password)
        {
            /*Utilisateur u = _utilisateurRepository.SearchOne(u => u.Login == login && u.Password == password);
            if(u != null)
            {
                HttpContext.Session.SetString("isLogged", "true");
                return RedirectToAction("Form", "Annonce");
            }*/
            if(_loginService.Login(login, password))
            {
                return RedirectToAction("Form", "Annonce");
            }
            return RedirectToAction("FormLogin");
        }
    }
}
