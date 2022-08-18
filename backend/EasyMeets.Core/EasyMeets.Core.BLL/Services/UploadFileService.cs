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
        private static readonly BlobContainerClient _container = new BlobContainerClient(Environment.GetEnvironmentVariable("AzureBlogStorageConnectionString"), _containerName);
        public UploadFileService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<string> UploadFileBlobAsync(IFormFile file, long userId)
        {
            var fileName = Path.GetFileName(file.FileName);

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
