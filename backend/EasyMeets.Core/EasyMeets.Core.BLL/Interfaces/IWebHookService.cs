using EasyMeets.Core.Common.DTO.Calendar;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IWebHookService
    {
        Task GetNofiticationCalendarEvents(string email);
    }
}
