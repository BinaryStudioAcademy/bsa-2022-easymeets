using Azure.Storage.Blobs.Models;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IUploadFileService
    {
        public Task UploadFileBlobAsync(string filePath, string fileName);
        public Task UploadContentBlobAsync(string content, string fileName);
    }
}
