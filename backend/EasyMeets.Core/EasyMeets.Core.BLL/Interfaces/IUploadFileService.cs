using Azure.Storage.Blobs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMeets.Core.BLL.Interfaces
{
    internal interface IUploadFileService
    {
        public Task<BlobInfo> GetBlobAsync(string name);
        public Task<IEnumerable<string>> ListBlobsAsync();
        public Task UploadFileBlobAsync(string filePath, string fileName);
        public Task UploadContentBlobAsync(string content, string fileName);
        public Task DeleteBlobAsync(string blobName);
    }
}
