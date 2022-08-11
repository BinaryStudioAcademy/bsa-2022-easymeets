using Azure.Storage.Blobs.Models;
using EasyMeets.Core.BLL.Interfaces;

namespace EasyMeets.Core.BLL.Services
{
    public class UploadFileService : IUploadFileService
    {
        public Task DeleteBlobAsync(string blobName)
        {
            throw new NotImplementedException();
        }

        public Task<BlobInfo> GetBlobAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> ListBlobsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UploadContentBlobAsync(string content, string fileName)
        {
            throw new NotImplementedException();
        }

        public Task UploadFileBlobAsync(string filePath, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
