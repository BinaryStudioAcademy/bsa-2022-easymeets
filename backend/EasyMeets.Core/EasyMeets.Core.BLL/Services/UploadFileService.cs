using AutoMapper;
using Azure.Storage.Blobs;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.DAL.Context;
using Microsoft.AspNetCore.Http; 
namespace EasyMeets.Core.BLL.Services
{
    public class UploadFileService : BaseService, IUploadFileService
    {
        private static readonly string _containerName = "fileupload";
        //TODO: Remove
        private static readonly string _connectionString =
            "DefaultEndpointsProtocol=https;AccountName=easymeetsblobstorage;AccountKey=P4aKGb6jQviO7r1sbsRfr3SxZp+sVQcyaRg38gZc5WIJ8ugyuFcQ7o08AfR8yyKQ9iAQwBKFZPHX+ASteixRvg==;EndpointSuffix=core.windows.net";
        //private static readonly BlobContainerClient _container = new BlobContainerClient(Environment.GetEnvironmentVariable("AzureBlogStorageConnectionString"), _containerName);
        private static readonly BlobContainerClient _container = new BlobContainerClient(_connectionString, _containerName);

        public UploadFileService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<string> UploadFileBlobAsync(IFormFile file, string? fileName, long userId)
        { 
            var blob = _container.GetBlobClient(fileName);

            Stream stream = file.OpenReadStream();

            await blob.UploadAsync(stream, true);

            stream.Close();

            var imageUrl = blob.Uri.ToString();

            var user = await _context.Users.FindAsync(userId);

            if (user is null)
            {
                throw new NullReferenceException();
            }

            user.ImagePath = imageUrl;

            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return user.ImagePath; 
        }
    }
}
