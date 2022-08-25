using EasyMeets.Core.Common.DTO.Credentials;
using EasyMeets.Core.Common.DTO.Credentials.Zoom;

namespace EasyMeets.Core.BLL.Interfaces;

public interface IZoomService
{
    Task<CredentialsDto> GetNewCredentials(NewCredentialsRequestDto newCredentialsRequestDto);
}