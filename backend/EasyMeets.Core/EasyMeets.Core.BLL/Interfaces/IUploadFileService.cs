namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IUploadFileService
    {
        public Task<string> UploadFileBlobAsync(string filePath, string fileName, int userId);
    }
}
