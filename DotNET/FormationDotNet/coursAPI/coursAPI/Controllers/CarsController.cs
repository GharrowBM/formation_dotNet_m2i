using System;
using System.Collections;
using System.Collections.Generic;
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
        public IEnumerable<string> Get()
        {
            return new List<string>() { "v1", "v2", "v3" };
        }

        [HttpGet("one")]
        public string GetOne()
        {
            return "v12";
        }
    }
}
