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

    public class AnnonceController : Controller
    {

        IRepository<Annonce> _annonceRepository;
        UploadService _uploadService;

        public AnnonceController(IRepository<Annonce> annonceRepository, UploadService uploadService)
        {
            _annonceRepository = annonceRepository;
            _uploadService = uploadService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            //string l = Request.Headers["Accept-Language"].ToString();
            List<Annonce> annonces = _annonceRepository.GetAll();

            //Ecrire des données dans les cookies;
            //Response.Cookies.Append("nombreVisite", "1", new CookieOptions() { Expires = DateTime.Now.AddDays(-1)});

            //Ecrire dans la session
            HttpContext.Session.SetString("nombre", "1");
            return View("Index", annonces);
        }


        public IActionResult SubmitSearch(string search)
        {
            List<Annonce> annonces = _annonceRepository.Search(search);
            return View("Index", annonces);
        }

        public IActionResult Detail(int id)
        {
            //Lire les données à partir d'un cookies
            //string valueOfCookies = Request.Cookies["nombreVisite"];

            //Lire les données à partir d'une session
            string valueOfSession = HttpContext.Session.GetString("nombre");
            Annonce a = _annonceRepository.Get(id);
            return View(a);
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult SubmitForm(Annonce annonce, IFormFile[] images)
        {
            foreach(IFormFile image in images)
            {
                annonce.Images.Add(new Image() { Url = _uploadService.Upload(image) });
            }
            _annonceRepository.Save(annonce);
            return RedirectToAction("Index");
        }
    }
}
