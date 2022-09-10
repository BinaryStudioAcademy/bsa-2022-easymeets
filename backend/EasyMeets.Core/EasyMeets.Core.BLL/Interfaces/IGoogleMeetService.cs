using EasyMeets.Core.Common.DTO.Credentials.GoogleMeet;

namespace EasyMeets.Core.BLL.Interfaces;

public interface IGoogleMeetService
{
    Task<List<MeetCredentialsDto>> GetAvailableEmails();
    Task CreateMeetCredentials(MeetCredentialsDto credentialsDto);
    Task CreateGoogleMeet(long meetingId);
    Task<MeetCredentialsDto?> GetCurrentCredentials();
    Task DeleteCredentials(string email, long userId);
    Task CreateDefaultCredentials(string? userId = null);
}