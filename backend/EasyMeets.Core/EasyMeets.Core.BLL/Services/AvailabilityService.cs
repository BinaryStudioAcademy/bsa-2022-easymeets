using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;
using EasyMeets.Core.DAL.Entities;
using EasyMeets.Core.Common.Enums; 

namespace EasyMeets.Core.BLL.Services
{
    public class AvailabilityService : BaseService, IAvailabilityService
    {
        public AvailabilityService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper) { }
        public async Task<ICollection<AvailabilitySlotDto>> GetAllAvailabilitySlotsForTeamAsync()
        {
            var availabilitySlots = await _context.AvailabilitySlots
                .Where(x => x.Type == SlotType.Team)
                .Include(x => x.Team)
                .Include(x => x.Location)
                .Include(x => x.Author)
                .Include(x => x.Members)
                .ToListAsync();
            var availabilitySlotsDto = _mapper.Map<ICollection<AvailabilitySlotDto>>(availabilitySlots);
            return availabilitySlotsDto;
        }

        public async Task CreateAvailabilitySlot(NewAvailabilitySlotDto slotDto)
        {
            var entity = _mapper.Map<AvailabilitySlot>(slotDto);

            await _context.AvailabilitySlots.AddAsync(entity);

            if (slotDto.AdvancedSettings is not null)
            {
                var advancedSettings = _mapper.Map<AdvancedSlotSettings>(slotDto.AdvancedSettings);
                advancedSettings.AvailabilitySlot = entity;
                await _context.AdvancedSlotSettings.AddAsync(advancedSettings);
                entity.AdvancedSlotSettings = advancedSettings;
            }
            await _context.SaveChangesAsync();
        }
    }
}
