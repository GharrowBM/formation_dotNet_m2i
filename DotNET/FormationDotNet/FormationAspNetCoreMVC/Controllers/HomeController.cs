using FormationAspNetCoreMVC.Models;
using FormationAspNetCoreMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FormationAspNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Personne> personnes = Personne.GetPersonnes();
            List<Adresse> adresses  = Adresse.GetAdresses();
            //Pour partager les données avec la view, 
            // 1 => on peut utiliser la propriété ViewData
            //ViewData["personnes"] = personnes;
            //2 => on peut utiliser la propriété ViewBag
            //ViewBag.Personnes = personnes;
            //3 => on peut utiliser les models de views
            PersonneViewModel vm = new PersonneViewModel();
            vm.Personnes = personnes;
            vm.Adresses = adresses;
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult GetPersonne(int id, string nom)
        {
            ViewBag.Id = id;
            ViewBag.Nom = nom;
            return View();
        }

        public IActionResult GetForm()
        {
            return View();
        }

        public IActionResult SubmitForm(int age)
        {
            //Logique métier
            return RedirectToAction("Index");
        }
    }
}
