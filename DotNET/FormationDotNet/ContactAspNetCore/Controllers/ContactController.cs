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

        //public IActionResult List2()
        //{
        //    //return View("List");
        //    return View("~/Views/Contact/List.cshtml");
        //}

        public IActionResult Detail(int id)
        {
            Personne p = DataContext.Instance.Personnes.Include(p=>p.Adresses).FirstOrDefault(p=>p.Id == id);
            return View(p);
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult SubmitForm(string firstName, string lastName, string email)
        {
            Personne p = new Personne() 
            { 
                FirstName = firstName,
                LastName = lastName,
                Email = email,
            };
            DataContext.Instance.Personnes.Add(p);
            DataContext.Instance.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
