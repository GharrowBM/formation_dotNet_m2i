using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace CorrectionPetiteAnnonce.Services
{
    public class UploadService
    {

        private IWebHostEnvironment _webHostEnvironment;
        public UploadService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public string Upload(IFormFile file)
        {
            string fileName = Guid.NewGuid().ToString() + "-" + file.FileName;
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "annonces", fileName);
            Stream stream = System.IO.File.Create(path);
            file.CopyTo(stream);
            stream.Close();
            return "annonces/" + fileName;
        }
    }
}
