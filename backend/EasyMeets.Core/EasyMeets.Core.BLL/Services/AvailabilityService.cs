using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;
using EasyMeets.Core.DAL.Entities;
using EasyMeets.Core.Common.Enums;
using System.Linq;

namespace EasyMeets.Core.BLL.Services
{
    public class AvailabilityService : BaseService, IAvailabilityService
    {
        public AvailabilityService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<UserPersonalAndTeamSlotsDto> GetUserPersonalAndTeamSlotsAsync(long id)
        {
            var availabilitySlots = await _context.AvailabilitySlots
                .Include(x => x.Members)
                    .ThenInclude(x => x.User)
                .Include(x => x.Location)
                .Include(x => x.Author)
                .Include(x => x.Team)
                .Where(x => x.CreatedBy == id && x.Members.Any(x => x.UserId == id))
                .Select(y =>
                    new AvailabilitySlotDto
                    {
                        Id = y.Id,
                        Name = y.Name,
                        Type = y.Type,
                        Size = y.Size,
                        IsEnabled = y.IsEnabled,
                        AuthorName = y.Author.Name,
                        TeamName = y.Team.Name,
                        LocationName = y.Location.Name,
                        Members = _mapper.Map<ICollection<AvailabilitySlotMemberDto>>(y.Members)
                    })
                .ToListAsync();

            var userSlots = availabilitySlots.Where(x => x.Type == SlotType.Personal).ToList();
            var availabilitySlotsGroupByTeams = availabilitySlots
                .Where(x => x.Type == SlotType.Team)
                .GroupBy(x => x.TeamName)
                .Select(x =>
                new AvailabilitySlotsGroupByTeamsDto
                {
                    Name = x.Key,
                    AvailabilitySlots = x.ToList()
                })
                .ToList();

            var availabilitySlotsGroupByTeamsAndUser = new UserPersonalAndTeamSlotsDto(userSlots, availabilitySlotsGroupByTeams);

            return availabilitySlotsGroupByTeamsAndUser;
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
