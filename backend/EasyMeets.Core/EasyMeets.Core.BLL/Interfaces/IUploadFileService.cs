using Microsoft.AspNetCore.Http;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IUploadFileService
    {
        public Task<string> UploadFileBlobAsync(IFormFile file);
        Task DeleteFileBlobAsync(string uri);
    }
}
