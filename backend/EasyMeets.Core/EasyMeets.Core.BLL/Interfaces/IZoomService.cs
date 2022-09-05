using EasyMeets.Core.Common.DTO.Credentials;
using EasyMeets.Core.Common.DTO.Credentials.Zoom;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.Interfaces;

public interface IZoomService
{
    Task<CredentialsDto> GetNewCredentials(NewCredentialsRequestDto newCredentialsRequestDto);
    Task CreateZoomMeeting(long meetingId);
}