using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Calendar;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.Services;

public class CalendarEventService : BaseService, ICalendarEventService
{
    public CalendarEventService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task RemoveCalendarEvents(long calendarId)
    {
        var events = _context.CalendarEvents.Where(e => e.CalendarId == calendarId);
        
        _context.CalendarEvents.RemoveRange(events);
        await _context.SaveChangesAsync();
    }

    public async Task AddCalendarEvents(List<EventItemDTO> eventItemDtos, long calendarId)
    {
        foreach (var item in eventItemDtos)
        {
            var calendarEvent = _mapper.Map<CalendarEvent>(item, opts => 
                opts.AfterMap((_, dest) => dest.CalendarId = calendarId));
            await _context.CalendarEvents.AddAsync(calendarEvent);
        }

        await _context.SaveChangesAsync();
    }
}