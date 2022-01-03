using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorrectionPetiteAnnonce.Interfaces;
using CorrectionPetiteAnnonce.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CorrectionPetiteAnnonce.Controllers
{
    [EnableCors("specialOrigin")]
    [Route("api/v1/annonces")]
    public class AnnonceApiController : Controller
    {
        IRepository<Annonce> _annonceRepository;
       
        public AnnonceApiController(IRepository<Annonce> annonceRepository)
        {
            _annonceRepository = annonceRepository;
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
        [HttpPost]
        public IActionResult Post([FromBody] Annonce annonce)
        {
            _annonceRepository.Save(annonce);
            return Ok(new { Message = "Annonce ajoutée", id= annonce.Id});
        }
    }
}
