using CompteBancaireVersion1.Classes;
using Microsoft.AspNetCore.Mvc;

namespace CompteBancaireMVC.Controllers
{
    public class CompteController : Controller
    {
        private Banque banque;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(string search)
        {
            Compte compte = null;
            if(int.TryParse(search, out int id))
            {
                banque = new Banque();
                compte = banque.RechercherCompte(id);
                if(compte == null)
                {
                    ViewBag.ClassAlert = "alert-danger";
                    ViewBag.Message = "Aucun compte avec ce numéro";
                }
            }
            else
            {
                ViewBag.ClassAlert = "alert-danger";
                ViewBag.Message = "Merci de saisir un numéro";
            }
            return View("Index", compte);
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult SubmitForm()
        {
            return RedirectToAction("Index");
        }
    }
}
