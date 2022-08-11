namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IUploadFileService
    {
        public Task UploadFileBlobAsync(string filePath, string fileName);
    }
}
