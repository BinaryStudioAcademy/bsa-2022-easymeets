using Google.Apis.Auth.AspNetCore3;

namespace EasyMeets.Core.BLL.Interfaces;

public interface ICalendarsService
{
    Task<string> GetCalendar(IGoogleAuthProvider auth);
}