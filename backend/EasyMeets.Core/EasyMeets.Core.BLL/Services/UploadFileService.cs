using AutoMapper;
using Azure.Storage.Blobs;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.DAL.Context;
using Microsoft.AspNetCore.Http;
namespace EasyMeets.Core.BLL.Services
{
    public class UploadFileService : BaseService, IUploadFileService
    {
        private const string ContainerName = "fileupload";
        private static readonly BlobContainerClient Container = new(Environment.GetEnvironmentVariable("AzureBlogStorageConnectionString"), ContainerName);
        public UploadFileService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<string> UploadFileBlobAsync(IFormFile file)
        {
            var fileName = Path.GetFileName(file.FileName);

            var blob = Container.GetBlobClient(fileName);

            Stream stream = file.OpenReadStream();

            await blob.UploadAsync(stream, true);

            stream.Close();

            return blob.Uri.ToString() ?? throw new FileLoadException("File not loaded.");
        }
    }
}
