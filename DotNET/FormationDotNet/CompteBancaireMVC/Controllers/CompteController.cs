using CompteBancaireVersion1.Classes;
using Microsoft.AspNetCore.Mvc;

namespace CompteBancaireMVC.Controllers
{
    public class CompteController : Controller
    {
        private Banque banque;
        public IActionResult Index(string Message, string ClassAlert)
        {
            ViewBag.Message = Message;
            ViewBag.ClassAlert = ClassAlert;
            return View();
        }

        public IActionResult Search(string search, string Message, string ClassAlert)
        {
            Compte compte = null;
            ViewBag.Message = Message;
            ViewBag.ClassAlert = ClassAlert;
            if (int.TryParse(search, out int id))
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

        public IActionResult SubmitForm(string Nom, string Prenom, string Telephone, decimal Solde)
        {
            Client client = new Client(Nom,Prenom, Telephone);
            banque = new Banque();
            Compte compte = banque.CreationCompte(client, Solde, "1");
            if(compte != null)
            {
                return RedirectToAction("Index", "Compte", new {Message = "Compte crée avec le numéro "+compte.Id, ClassAlert="alert-success"});
            }else
            {
                return View("Form");
            }
        }
    }
}
