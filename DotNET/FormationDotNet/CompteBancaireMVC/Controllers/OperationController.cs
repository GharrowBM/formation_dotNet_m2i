using CompteBancaireVersion1.Classes;
using Microsoft.AspNetCore.Mvc;

namespace CompteBancaireMVC.Controllers
{
    public class OperationController : Controller
    {
        Banque banque;
        public IActionResult Form(int id, string type)
        {
            ViewBag.Type = type;
            ViewBag.Id = id;
            return View();
        }

        public IActionResult SubmitForm(decimal montant, int id, string type)
        {
            banque = new Banque();
            Compte compte = banque.RechercherCompte(id);
            object result = null;
            if(compte != null)
            {   
                if((type =="depot" && compte.Depot(new Operation(montant))) || (type =="retrait" && compte.Retrait(new Operation(montant * -1)))) {
                    result = new { Message = "Opération effectuée", ClassAlert = "alert-success", Search = compte.Id.ToString() };
                    return RedirectToAction("Search", "Compte", result);
                }
                else
                {
                    result =  new { Message = "Erreur opération", ClassAlert = "alert-danger" };
                }
            }
            else
            {
                result = new { Message = "Aucun compte avec cet id", ClassAlert = "alert-danger" };
            }
            return RedirectToAction("Index", "Compte", result);
        }
    }
}
