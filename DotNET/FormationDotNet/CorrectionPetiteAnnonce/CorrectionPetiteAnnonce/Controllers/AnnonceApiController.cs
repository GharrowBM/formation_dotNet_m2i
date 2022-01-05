using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorrectionPetiteAnnonce.Interfaces;
using CorrectionPetiteAnnonce.Models;
using CorrectionPetiteAnnonce.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CorrectionPetiteAnnonce.Controllers
{
    [EnableCors("specialOrigin")]
    [Route("api/v1/annonces")]
    public class AnnonceApiController : Controller
    {
        IRepository<Annonce> _annonceRepository;
        UploadService _uploadService;
       
        public AnnonceApiController(IRepository<Annonce> annonceRepository, UploadService uploadService)
        {
            _annonceRepository = annonceRepository;
            _uploadService = uploadService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_annonceRepository.GetAll());
        }

        // GET api/values/5
        [HttpGet("{annonceId}")]
        public IActionResult Get(int annonceId)
        {
            Annonce a = _annonceRepository.Get(annonceId);
            if(a != null)
            {
                return Ok(a);
            }
            return NotFound();
        }

        // POST api/values

        [Authorize(Policy = "protected")]
        [HttpPost]
        public IActionResult Post([FromForm] IFormFile image, [FromForm] string titre, [FromForm] string description, [FromForm] decimal prix)
        {
            Annonce annonce = new Annonce()
            {
                Titre = titre,
                Description = description,
                Prix = prix
            };
            annonce.Images.Add(new Image() { Url = _uploadService.Upload(image) });
            _annonceRepository.Save(annonce);
            return Ok(new { Message = "Annonce ajoutée", id= annonce.Id});
        }

        [Authorize(Policy = "protected")]
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromForm] IFormFile image)
        {
            Annonce a = _annonceRepository.Get(id);
            if (a != null)
            {
                a.Images.Add(new Image() { Url = _uploadService.Upload(image) });
                _annonceRepository.Update();
                return Ok(a);
            }
            return NotFound();
        }
    }
}
