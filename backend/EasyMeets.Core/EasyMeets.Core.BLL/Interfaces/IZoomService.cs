using EasyMeets.Core.Common.DTO.Credentials;

namespace EasyMeets.Core.BLL.Interfaces;

public interface IZoomService
{
    Task<CredentialsDto> GetNewCredentials(string authCode, string redirectUri);
}