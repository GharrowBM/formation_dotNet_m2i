using ContactAspNetCore.Interfaces;
using CoursEFCore.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ContactAspNetCore.Controllers
{
    public class ContactController : Controller
    {

        private IUpload _uploadService;

        public ContactController(IUpload uploadService)
        {
            _uploadService = uploadService;
        }
        public IActionResult List(string message)
        {
            // ViewData["contacts"] = DataContext.Instance.Personnes.ToList();
            ViewBag.Message = message;
            return View(DataContext.Instance.Personnes.Include(p => p.Adresses).ToList());
        }

        //public IActionResult List2()
        //{
        //    //return View("List");
        //    return View("~/Views/Contact/List.cshtml");
        //}

        public IActionResult Detail(int id)
        {
            Personne p = DataContext.Instance.Personnes.Include(p => p.Adresses).FirstOrDefault(p => p.Id == id);
            return View(p);
        }

        public IActionResult Edit(int id)
        {
            Personne p = DataContext.Instance.Personnes.Include(p => p.Adresses).FirstOrDefault(p => p.Id == id);
            return View("Form", p);
        }

        public IActionResult Delete(int id)
        {
            Personne p = DataContext.Instance.Personnes.Include(p => p.Adresses).FirstOrDefault(p => p.Id == id);
            string message = null;
            if (p != null)
            {
                DataContext.Instance.Personnes.Remove(p);
                DataContext.Instance.SaveChanges();
                message = "Suppression effectuée";
            }
            return RedirectToAction("List", "Contact", new { Message = message });
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult SubmitForm(Personne personne, IFormFile avatar)
        {
            //Personne p = new Personne() 
            //{ 
            //    FirstName = firstName,
            //    LastName = lastName,
            //    Email = email,
            //};

            try
            {
                if (personne.Id > 0)
                {
                    Personne personneEdit = DataContext.Instance.Personnes.Include(p => p.Adresses).FirstOrDefault(p => p.Id == personne.Id);
                    personneEdit.FirstName = personne.FirstName;
                    personneEdit.LastName = personne.LastName;
                    personneEdit.Email = personne.Email;
                    if (DataContext.Instance.SaveChanges() > 0)
                    {
                        return RedirectToAction("List", "Contact", new { message = "Contact modifié" });
                    }
                    else
                    {
                        return RedirectToAction("Form");
                    }
                }
                else
                {
                    personne.Avatar = _uploadService.Upload(avatar);
                    DataContext.Instance.Personnes.Add(personne);
                    if (DataContext.Instance.SaveChanges() > 0)
                    {
                        return RedirectToAction("List", "Contact", new { message = "Contact ajouté" });
                    }
                    else
                    {
                        return RedirectToAction("Form");
                    }
                }
            }
            catch (Exception e)
            {
                DataContext.Instance.Personnes.Remove(personne);
                return View("Form", personne);
            }
        }
    }
}
