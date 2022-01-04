using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactAPIRest.Models;
using ContactAPIRest.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactAPIRest.Controllers
{
    [Route("contact")]
    public class ContactController : Controller
    {
        DataContext _data;
        UploadService _upload;
        public ContactController(DataContext data, UploadService upload)
        {
            _data = data;
            _upload = upload;
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


        /*[HttpPost]
        public IActionResult Post([FromBody] Contact contact)
        {
            _data.Contacts.Add(contact);
            if(_data.SaveChanges() > 0)
            {
                return Ok(new { Message = "contact added", Contact = contact });
            }
            return Ok(new { Message = "Error" });
        }*/

        [HttpPost]
        public IActionResult Post([FromForm] IFormFile avatar, [FromForm] string FirstName, [FromForm] string LastName, [FromForm] string Phone, [FromForm] string Email)
        {
            Contact contact = new Contact()
            {
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                Phone = Phone,
                Avatar = _upload.Upload(avatar)
            };

            _data.Contacts.Add(contact);
            if (_data.SaveChanges() > 0)
            {
                return Ok(new { Message = "contact added", Contact = contact });
            }
            return Ok(new { Message = "Error" });
        }



        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Contact newContact)
        {
            Contact contact = _data.Contacts.Find(id);
            if (contact != null)
            {
                contact.FirstName = newContact.FirstName ?? contact.FirstName;
                contact.LastName = newContact.LastName ?? contact.LastName;
                contact.Phone = newContact.Phone ?? contact.Phone;
                contact.Email = newContact.Email ?? contact.Email;
                
                if (_data.SaveChanges() > 0)
                {
                    return Ok(new { Message = "contact updated" });
                }
                return Ok(new { Message = "Error" });
            }
            return NotFound();
        }

       
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Contact contact = _data.Contacts.Find(id);
            if (contact != null)
            {
                _data.Contacts.Remove(contact);
                if (_data.SaveChanges() > 0)
                {
                    return Ok(new { Message = "contact deleted" });
                }
                return Ok(new { Message = "Error" });
            }
            return NotFound();
        }
    }
}
