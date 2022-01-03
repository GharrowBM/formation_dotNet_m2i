using System;
using System.Collections;
using System.Collections.Generic;
using coursAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace coursAPI.Controllers
{
    [Route("voitures")]
    public class CarsController : ControllerBase
    {
        public CarsController()
        {
        }

        //[Route("get")]
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult( new List<string>{ "v1", "v2", "v3" });
        }

        [HttpGet("one/{name}")]
        public string GetOne(string name)
        {
            return "v12";
        }



        //Des donnés en formData
        /*[HttpPost]
        public IActionResult Post(string nom, string prenom)
        {
            return Ok(new { message = "Post OK" });
        }*/

        //Des donnés en json
        [HttpPost]
        public IActionResult Post([FromBody]Car car)
        {
            return Ok(new { message = "Post OK" });
        }
    }
}
