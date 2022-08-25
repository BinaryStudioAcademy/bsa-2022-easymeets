using EasyMeets.Core.Common.DTO.Calendar;

namespace EasyMeets.Core.BLL.Interfaces;

public interface ICalendarsService
{
    Task<bool> CreateGoogleCalendarConnection();
    Task<bool> UpdateGoogleCalendar(List<UserCalendarDto> calendarDtoList);
    Task<List<UserCalendarDto>> GetCurrentUserCalendars();
    Task<bool> DeleteCalendar(long id);
}