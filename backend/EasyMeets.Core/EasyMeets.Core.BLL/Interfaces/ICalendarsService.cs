using EasyMeets.Core.Common.DTO.Calendar;
using EasyMeets.Core.Common.DTO.User;

namespace EasyMeets.Core.BLL.Interfaces;

public interface ICalendarsService
{
    Task<bool> UpdateGoogleCalendar(List<UserCalendarDto> calendarDtoList);
    Task<List<UserCalendarDto>> GetCurrentUserCalendars();
    Task<bool> DeleteCalendar(long id);
    Task<bool> CreateGoogleCalendarConnection(TokenResultDto tokenResultDto, UserDto currentUser);
    Task<string> SubscribeOnCalendarChanges(TokenResultDto tokenResultDto);
}