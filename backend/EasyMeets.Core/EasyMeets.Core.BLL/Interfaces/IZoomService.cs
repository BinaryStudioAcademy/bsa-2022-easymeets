using EasyMeets.Core.Common.DTO.Credentials;
using EasyMeets.Core.Common.DTO.Credentials.Zoom;
using EasyMeets.Core.Common.DTO.User;

namespace EasyMeets.Core.BLL.Interfaces;

public interface IZoomService
{
    Task<CredentialsDto> GetNewCredentials(NewCredentialsRequestDto newCredentialsRequestDto);
    Task CreateZoomMeeting(long meetingId);
    Task<EmailDto> CreateZoomCredentials(NewCredentialsRequestDto newCredentialsRequestDto);
    Task RevokeAccessTokenAsync();
    Task<EmailDto> GetZoomUserEmailAsync();
}