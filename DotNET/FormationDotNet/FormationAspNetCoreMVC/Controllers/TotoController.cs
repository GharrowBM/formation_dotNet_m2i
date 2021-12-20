using Microsoft.AspNetCore.Mvc;

namespace FormationAspNetCoreMVC.Controllers
{
    public class TotoController : Controller
    {
        public IActionResult First()
        {
            //return new ContentResult() { Content = "<h1>Hello From our first action</h1>", ContentType="text/html" };
            return View();
        }
    }
}
