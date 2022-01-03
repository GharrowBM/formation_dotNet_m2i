using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactAPIRest.Models;
using ContactAPIRest.Tools;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactAPIRest.Controllers
{
    [Route("contact")]
    public class ContactController : Controller
    {
        DataContext _data;
        public ContactController(DataContext data)
        {
            _data = data;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_data.Contacts.ToList());
        }

        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Contact contact = _data.Contacts.Find(id);
            if(contact != null)
            {
                return Ok(contact);
            }
            return NotFound();
        }

        
        [HttpPost]
        public IActionResult Post([FromBody] Contact contact)
        {
            _data.Contacts.Add(contact);
            if(_data.SaveChanges() > 0)
            {
                return Ok(new { Message = "contact added", Contact = contact });
            }
            return Ok(new { Message = "Error" });
        }


        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
