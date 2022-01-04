using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ContactAPIRest.Tools
{
    public class UploadService
    {
        private IWebHostEnvironment _webHostEnvironment;

        public UploadService(IWebHostEnvironment webHostEnvironment)

        {

            _webHostEnvironment = webHostEnvironment;

        }

        private void MakeFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public string Upload(IFormFile file)

        {

            string fileName = Guid.NewGuid().ToString() + "-" + file.FileName;

            //string path = Path.Combine(_webHostEnvironment.WebRootPath, "avatar", fileName);
            string path = Path.Combine(Environment.CurrentDirectory, "avatar", fileName);
            MakeFolder(Path.Combine(Environment.CurrentDirectory, "avatar"));
            Stream stream = System.IO.File.Create(path);

            file.CopyTo(stream);

            stream.Close();

            return "avatar/" + fileName;

        }

    }
}
