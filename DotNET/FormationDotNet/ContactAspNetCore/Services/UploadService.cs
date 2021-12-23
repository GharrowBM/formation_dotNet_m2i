using ContactAspNetCore.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ContactAspNetCore.Services
{
    public class UploadService : IUpload
    {
        IWebHostEnvironment _webHostEnvironment;

        public UploadService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public string Upload(IFormFile file)
        {
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "img", file.FileName);
            Stream stream = System.IO.File.Create(path);
            file.CopyTo(stream);
            stream.Close();
            string finalPath = "img/" + file.FileName;
            return finalPath;
        }
    }
}
