using EasyMeets.Core.Common.DTO.Calendar;

namespace EasyMeets.Core.BLL.Interfaces;

public interface ICalendarEventService
{
    Task RemoveCalendarEvents(long userId);
    Task AddCalendarEvents(List<EventItemDTO> eventItemDtos, long userId);
}