using Microsoft.AspNetCore.Http;

namespace ContactAspNetCore.Interfaces
{
    public interface IUpload
    {
        public string Upload(IFormFile file);
    }
}
