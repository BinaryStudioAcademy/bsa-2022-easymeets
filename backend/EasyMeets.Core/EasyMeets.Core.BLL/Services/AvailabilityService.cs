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
        public async Task<ICollection<AvailabilitySlotsGroupByTeamsDto>> GetAllAvailabilitySlotsGroupByTeamsAsync(long id)
        {
            var teamsWithSlots = await _context.Teams
                .Include(x => x.AvailabilitySlots)
                    .ThenInclude(x => x.Members)
                .Include(x => x.AvailabilitySlots)
                    .ThenInclude(x => x.Location)
                .Include(x => x.AvailabilitySlots)
                    .ThenInclude(x => x.Author)
                .Select(x =>
                    new AvailabilitySlotsGroupByTeamsDto
                    {
                        Name = x.Name,
                        PageLink = x.PageLink,
                        AvailabilitySlots = x.AvailabilitySlots.Select(y =>
                        new AvailabilitySlotDto
                        {
                            Id = y.Id,
                            Name = y.Name,
                            Type = y.Type,
                            Size = y.Size,
                            IsEnabled = y.IsEnabled,
                            AuthorName = y.Author.Name,
                            LocationName = y.Location.Name,
                            Members = y.Members.Select(m =>
                                new AvailabilitySlotMemberDto
                                {
                                    Id = m.User.Id,
                                    MemberUserName = m.User.Name,
                                    MemberImage = m.User.ImagePath,
                                })
                            .ToList()
                        })
                        .ToList()
                    })
                .Where(x => x.AvailabilitySlots.Any(x => x.Type == SlotType.Team) && x.AvailabilitySlots.Any(x => x.Members.Any(x => x.Id == id)))
                .ToListAsync();

            return teamsWithSlots;
        }

        public async Task<ICollection<AvailabilitySlotDto>> GetAllUserAvailabilitySlotsAsync(long id)
        {
            ICollection<AvailabilitySlot> userSlots = await _context.Users
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
