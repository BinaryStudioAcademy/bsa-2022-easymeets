using AutoMapper;
using Azure.Storage.Blobs;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.DAL.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace EasyMeets.Core.BLL.Services
{
    public class UploadFileService : BaseService, IUploadFileService
    {
        private readonly BlobContainerClient _container;
        public UploadFileService(EasyMeetsCoreContext context, IMapper mapper, IConfiguration configuration) : base(context, mapper)
        {
            _container = new(
                Environment.GetEnvironmentVariable("AzureBlogStorageConnectionString"), 
                configuration["AzureBlobStorage:ContainerName"]
            );
        }

        public async Task<string> UploadFileBlobAsync(IFormFile file)
        {
            var fileName = Path.GetFileName(file.FileName);

            var blob = _container.GetBlobClient(fileName);

            Stream stream = file.OpenReadStream();

            await blob.UploadAsync(stream, true);

            stream.Close();

            return blob.Uri.ToString() ?? throw new FileLoadException("File not loaded.");
        }
    }
}
