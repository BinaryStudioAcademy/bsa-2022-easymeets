using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.BLL.Services
{
    public class AvailabilityService : BaseService, IAvailabilityService
    {
        public AvailabilityService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper) { }
        public async Task<ICollection<AvailabilitySlot>> GetAllAvailabilitySlotsAsync()
        {
            var availabilitySlots = await _context.AvailabilitySlots.ToListAsync();
            return availabilitySlots;
        }
    }
}
