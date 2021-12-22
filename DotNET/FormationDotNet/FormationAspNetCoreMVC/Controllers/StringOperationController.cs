using FormationAspNetCoreMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace FormationAspNetCoreMVC.Controllers
{
    public class StringOperationController : Controller
    {
        private IStringService _stringService;
        private AgeService _ageService;

        public StringOperationController(IStringService stringService, AgeService ageService)
        {
            _stringService = stringService;
            _ageService = ageService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Action(string nom, int age)
        {
            //action sur la chaine de caractère
            //string result = null;
            //if(id.Length %2 == 0)
            //{
            //    result = id.ToLower();
            //}
            //else
            //{
            //    result = id.ToUpper();
            //}
            return new ContentResult() { Content = _stringService.Convert(nom) +" / " + _ageService.Convert(age) };
        }


        //private string Convert(string s)
        //{
        //    string result = null;
        //    if (s.Length % 2 == 0)
        //    {
        //        result = s.ToLower();
        //    }
        //    else
        //    {
        //        result = s.ToUpper();
        //    }
        //    return result;
        //}
        
    }
}
