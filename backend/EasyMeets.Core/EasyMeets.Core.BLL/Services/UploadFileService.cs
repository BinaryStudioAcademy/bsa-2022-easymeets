using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using EasyMeets.Core.BLL.Interfaces;

namespace EasyMeets.Core.BLL.Services
{
    public class UploadFileService : IUploadFileService
    {
        private static readonly string _containerName = "fileupload";
        private static readonly BlobContainerClient _container = new BlobContainerClient(Environment.GetEnvironmentVariable("AzureBlogStorageConnectionString"), _containerName);

        public Task UploadContentBlobAsync(string content, string fileName)
        {
            throw new NotImplementedException();
        }

        public async Task UploadFileBlobAsync(string filePath, string fileName)
        {
            var blob = _container.GetBlobClient(fileName);

            await blob.UploadAsync(filePath);
        }
    }
}
