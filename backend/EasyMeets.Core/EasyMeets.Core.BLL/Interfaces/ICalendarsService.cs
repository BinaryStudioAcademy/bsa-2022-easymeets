using EasyMeets.Core.Common.DTO.Calendar;
using Google.Apis.Calendar.v3.Data;

namespace EasyMeets.Core.BLL.Interfaces;

public interface ICalendarsService
{
    Task<bool> CreateGoogleCalendarConnection(UserCredentialsDto credentialsDto);
    Task<Calendar> CreateCalendar();
}