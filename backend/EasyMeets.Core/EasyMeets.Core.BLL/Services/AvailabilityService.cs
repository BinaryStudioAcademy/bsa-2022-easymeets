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
        public async Task<ICollection<AvailabilitySlotsGroupByTeamsDto>> GetAllAvailabilitySlotsGroupByTeamsAsync()
        {
            var teamsWithSlots = await _context.Teams
                .Include(x => x.AvailabilitySlots)
                    .ThenInclude(x => x.Members)
                .Include(x => x.AvailabilitySlots)
                    .ThenInclude(x => x.Location)
                .Include(x => x.AvailabilitySlots)
                    .ThenInclude(x => x.Author)
                .Where(x => x.AvailabilitySlots.Count(x => x.Type == SlotType.Team) > 0)
                .ToListAsync();
            var teamsWithSlotsDto = _mapper.Map<ICollection<AvailabilitySlotsGroupByTeamsDto>>(teamsWithSlots);
            return teamsWithSlotsDto;
        }

        public async Task<ICollection<AvailabilitySlotsGroupByTeamsDto>> GetAllAvailabilitySlotsGroupByUserAsync()
        {
            var teamsWithSlots = await _context.Teams
                .Include(x => x.AvailabilitySlots)
                    .ThenInclude(x => x.Members)
                .Include(x => x.AvailabilitySlots)
                    .ThenInclude(x => x.Location)
                .Include(x => x.AvailabilitySlots)
                    .ThenInclude(x => x.Author)
                .Where(x => x.AvailabilitySlots.Count(x => x.Type == SlotType.Personal) > 0)
                .ToListAsync();
            var teamsWithSlotsDto = _mapper.Map<ICollection<AvailabilitySlotsGroupByTeamsDto>>(teamsWithSlots);
            return teamsWithSlotsDto;
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
