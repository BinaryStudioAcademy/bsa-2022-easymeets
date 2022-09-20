using Microsoft.AspNetCore.Mvc;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface ILinkService
    {
        Task<string> GenerateNewPageLinkAsync(long teamId, string teamName);
        string GenerateInvivationLink(IUrlHelper Url, long? userId, string userEmail, long teamId);
    }
}
