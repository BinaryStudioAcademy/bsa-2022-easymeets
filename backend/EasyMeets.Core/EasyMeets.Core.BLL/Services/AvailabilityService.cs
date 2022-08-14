using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.AvailabilitySlotsResponse;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.DTO.User;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.BLL.Services
{
    public class AvailabilityService : BaseService, IAvailabilityService
    {
        public AvailabilityService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper)
        {
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
        
        public async Task<AvailabilitySlotDto> GetAvailabilitySlotById(long id)
        {
            var availabilitySlot = await _context.AvailabilitySlots.FirstOrDefaultAsync(_ => _.Id == id);
            if (availabilitySlot is null)
            {
                throw new KeyNotFoundException("Availability slot doesn't exist");
            }
            return _mapper.Map<AvailabilitySlotDto>(availabilitySlot);
        }
        
        private async Task<IEnumerable<AuthorSlotsDto>> GetPersonalAvailabilitySlotsWithAuthors()
        {
            return (await _context.AvailabilitySlots
                    .Where(slot => slot.Type == SlotType.Personal)
                    .Include(slot => slot.Author)
                    .ToListAsync())
                 .GroupBy(slot => slot.Author)
                 .Select(slots => new AuthorSlotsDto
                 {
                     Author = _mapper.Map<UserDto>(slots.Key),
                     AvailabilitySlots = _mapper.Map<List<AvailabilitySlotDto>>(slots.ToList())
                 });
        }
        
        private async Task<IEnumerable<TeamSlotsDto>> GetTeamAvailabilitySlotsWithTeams()
        {
            return (await _context.AvailabilitySlots
                    .Where(slot => slot.Type == SlotType.Team)
                    .Include(slot => slot.Team)
                    .ToListAsync())
                .GroupBy(slot => slot.Team)
                .Select(slots => new TeamSlotsDto
                {
                    Team = _mapper.Map<TeamDto>(slots.Key),
                    AvailabilitySlots = _mapper.Map<List<AvailabilitySlotDto>>(slots.ToList())
                });
        }

        public async Task<AvailabilitySlotsResponseDto> GetAvailabilitySlotsResponseDto()
        {
            return new AvailabilitySlotsResponseDto
            {
                PersonalAvailabilitySlotsWithAuthors = await GetPersonalAvailabilitySlotsWithAuthors(),
                TeamAvailabilitySlotsWithTeams = await GetTeamAvailabilitySlotsWithTeams()
            };
        }
    }
}
