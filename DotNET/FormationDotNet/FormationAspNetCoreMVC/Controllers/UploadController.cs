using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace FormationAspNetCoreMVC.Controllers
{
    public class UploadController : Controller
    {
        private IWebHostEnvironment _webHostEnvironment;
        public UploadController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Form()
        {
            return View();
        }

        public IActionResult SubmitUpload(IFormFile[] images)
        {
            string wwwRootPath = _webHostEnvironment.WebRootPath;
            foreach (IFormFile image in images)
            {

                string path = Path.Combine(wwwRootPath, "img", image.FileName);
                Stream stream = System.IO.File.Create(path);
                image.CopyTo(stream);
                stream.Close();
                string basePath = "img/" + image.FileName;
            }
            return RedirectToAction("Form");
        }
    }
}
