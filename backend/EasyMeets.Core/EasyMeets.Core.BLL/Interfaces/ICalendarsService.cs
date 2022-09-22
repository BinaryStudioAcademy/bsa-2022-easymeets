using EasyMeets.Core.Common.DTO.Calendar;
using EasyMeets.Core.Common.DTO.Meeting;
using EasyMeets.Core.Common.DTO.User;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.Interfaces;

public interface ICalendarsService
{
    Task<bool> UpdateGoogleCalendar(List<UserCalendarDto> calendarDtoList);
    Task<List<UserCalendarDto>> GetCurrentUserCalendars();
    Task<bool> DeleteCalendar(long id);
    Task<bool> CreateGoogleCalendarConnection(TokenResultDto tokenResultDto, UserDto currentUser);
    Task SubscribeOnCalendarChanges(TokenResultDto tokenResultDto, string connectedEmail);
    Task<List<EventItemDTO>> GetEventsFromGoogleCalendar(string email);
    Task AddMeetingsToCalendar(long? teamId, string refreshToken);
    Task<bool> SyncChangesFromGoogleCalendar(string email);
    Task AddMeetingToCalendar(SaveMeetingDto meeting, TokenResultDto tokenResultDto);
    Task CancelMeetingInGoogleCalendar(string meetingName, Calendar calendar);
}