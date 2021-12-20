using CoursEFCore.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ContactAspNetCore.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult List()
        {
           // ViewData["contacts"] = DataContext.Instance.Personnes.ToList();
            return View(DataContext.Instance.Personnes.Include(p => p.Adresses).ToList());
        }

        public IActionResult List2()
        {
            //return View("List");
            return View("~/Views/Contact/List.cshtml");
        }

        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }
    }
}
