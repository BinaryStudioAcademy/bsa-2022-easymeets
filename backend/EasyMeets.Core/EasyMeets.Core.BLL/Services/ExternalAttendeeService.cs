using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.ExternalAttendee;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.Services;

public class ExternalAttendeeService : BaseService, IExternalAttendeeService
{
    public ExternalAttendeeService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper) { }

    public async Task SaveExternalAttendeeAsync(ExternalAttendeeDto externalAttendeeDto)
    {
        var attendee = _mapper.Map<ExternalAttendee>(externalAttendeeDto);
        if (!_context.ExternalAttendees.Any(el => el.Email == externalAttendeeDto.Email))
        {
            _context.ExternalAttendees.Add(attendee);
            await _context.SaveChangesAsync();
        }
    }
}