using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.DAL.Context; 
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.BLL.Services
{
    public class AvailabilityService : BaseService, IAvailabilityService
    {
        public AvailabilityService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper) { }
        public async Task<ICollection<AvailabilitySlotDto>> GetAllAvailabilitySlotsAsync()
        {
            var availabilitySlots = await _context.AvailabilitySlots
                .Include(x=>x.Team)
                .Include(x=>x.Location)
                .Include(x=>x.Author)
                .Include(x => x.Members)
                .ToListAsync();
           var availabilitySlotsDto = _mapper.Map<ICollection<AvailabilitySlotDto>>(availabilitySlots);
            return availabilitySlotsDto;
        }
    }
}
