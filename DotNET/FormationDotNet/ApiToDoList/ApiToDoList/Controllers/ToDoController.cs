using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiToDoList.Models;
using ApiToDoList.Tools;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiToDoList.Controllers
{
    [EnableCors("allAllowd")]
    [Route("api/v1/[controller]")]
    public class ToDoController : Controller
    {
        DataContext _data;

        public ToDoController(DataContext data)
        {
            _data = data;
        }
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_data.Todos.ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_data.Todos.Find(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromForm] IFormFile file, [FromForm] string name)
        {
            ToDo todo = new ToDo()
            {
                Name = name,
                IsDone = false,
                IsEdited = false
            };
            _data.Todos.Add(todo);
            if(_data.SaveChanges() > 0)
            {
                return Ok(new { Message = "toDo added", todo = todo });
            }
            return Ok(new { Message = "Error insertion" });
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
