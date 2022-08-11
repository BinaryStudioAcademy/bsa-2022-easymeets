using AutoMapper;
using Azure.Storage.Blobs;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.DAL.Context;

namespace EasyMeets.Core.BLL.Services
{
    public class UploadFileService : BaseService, IUploadFileService
    {
        private static readonly string _containerName = "fileupload";
        private static readonly BlobContainerClient _container = new BlobContainerClient(Environment.GetEnvironmentVariable("AzureBlogStorageConnectionString"), _containerName);

        public UploadFileService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task UploadFileBlobAsync(string filePath, string fileName, int userId)
        {
            var blob = _container.GetBlobClient(fileName);

            await blob.UploadAsync(filePath);

            var user = await _context.Users.FindAsync(userId);

            user.ImagePath = "";

            _context.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
