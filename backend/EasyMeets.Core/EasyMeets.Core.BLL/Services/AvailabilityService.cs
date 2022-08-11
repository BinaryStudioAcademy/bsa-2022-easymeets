using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;
using EasyMeets.Core.DAL.Entities;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.Common.DTO;

namespace EasyMeets.Core.BLL.Services
{
    public class AvailabilityService : BaseService, IAvailabilityService
    {
        public AvailabilityService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper) { }
        public async Task<ICollection<AvailabilitySlotsGroupByTeamsDto>> GetAllAvailabilitySlotsGroupByTeamsAsync(int id)
        {
            var teamsWithSlots = await _context.Teams
                .Include(x => x.AvailabilitySlots)
                    .ThenInclude(x => x.Members)
                .Include(x => x.AvailabilitySlots)
                    .ThenInclude(x => x.Location)
                .Include(x => x.AvailabilitySlots)
                    .ThenInclude(x => x.Author)
                .Where(x => x.AvailabilitySlots.Any(x => x.Type == SlotType.Team))
                .Where(x => x.AvailabilitySlots.Any(x => x.Members.Any(x => x.UserId == id)))
                .ToListAsync();
            var teamsWithSlotsDto = _mapper.Map<ICollection<AvailabilitySlotsGroupByTeamsDto>>(teamsWithSlots);
            return teamsWithSlotsDto;
        }

        public async Task<ICollection<AvailabilitySlotDto>> GetAllUserAvailabilitySlotsAsync(int id)
        {
            var userSlots = await _context.Users
                 .Where(x => x.Id == id)
                 .Include(x => x.CreatedSlots)
                    .ThenInclude(x => x.Members)
                    .ThenInclude(x => x.User)
                 .Include(x => x.CreatedSlots)
                    .ThenInclude(x => x.Location)
                 .Where(x => x.CreatedSlots.Any(x => x.Type == SlotType.Personal))
                 .SelectMany(x => x.CreatedSlots)
                 .ToListAsync();
            var userSlotsDto = _mapper.Map<ICollection<AvailabilitySlotDto>>(userSlots);
            return userSlotsDto;
        }

        public async Task<UserDto> GetCurrentUserForAvailabilityPageAsync(int id)
        {
            var currentUser = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            var currentUserDto = _mapper.Map<UserDto>(currentUser);
            return currentUserDto;
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
