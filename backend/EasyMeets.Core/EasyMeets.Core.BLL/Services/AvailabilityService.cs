using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;
using EasyMeets.Core.Common.DTO.Availability.UpdateAvailability;
using EasyMeets.Core.Common.DTO.Location;
using EasyMeets.Core.DAL.Entities;
using EasyMeets.Core.Common.Enums;


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
        
        public async Task<AvailabilitySlotDto> GetAvailabilitySlotById(long id)
        {
            var availabilitySlot = await _context.AvailabilitySlots
                .Include(slot => slot.AdvancedSlotSettings)
                .Include(slot => slot.Location)
                .FirstOrDefaultAsync(slot => slot.Id == id);
            if (availabilitySlot is null)
            {
                throw new KeyNotFoundException("Availability slot doesn't exist");
            }
            return _mapper.Map<AvailabilitySlotDto>(availabilitySlot);
        }

        public async Task<AvailabilitySlotDto> UpdateAvailabilitySlot(long id, UpdateAvailabilityDto updateAvailabilityDto)
        {
            var availabilitySlot = await _context.AvailabilitySlots
                .Include(slot => slot.AdvancedSlotSettings)
                .FirstOrDefaultAsync(slot => slot.Id == id);
            if (availabilitySlot is null)
            {
                throw new KeyNotFoundException("Availability slot doesn't exist");
            }
            
            _mapper.Map(updateAvailabilityDto, availabilitySlot);

            var locationToAdd = await _context.Locations.FirstOrDefaultAsync(location => 
                location.Name == updateAvailabilityDto.GeneralDetailsUpdate.MeetingLocation);
            if (locationToAdd is not null)
            {
                availabilitySlot.LocationId = locationToAdd.Id;
            }
            
            if (updateAvailabilityDto.HasAdvancedSettings && availabilitySlot.AdvancedSlotSettings is not null)
            {
                _mapper.Map(updateAvailabilityDto, availabilitySlot.AdvancedSlotSettings);
            }
            else if (updateAvailabilityDto.HasAdvancedSettings && availabilitySlot.AdvancedSlotSettings is null)
            {
                var newAdvancedSlotSettings = _mapper.Map<UpdateAvailabilityDto, AdvancedSlotSettings>(updateAvailabilityDto);
                newAdvancedSlotSettings.AvailabilitySlotId = availabilitySlot.Id;
                _context.AdvancedSlotSettings.Add(newAdvancedSlotSettings);
            }
            
            else if (!updateAvailabilityDto.HasAdvancedSettings && availabilitySlot.AdvancedSlotSettings is not null)
            {
                _context.Remove(availabilitySlot.AdvancedSlotSettings);
            }

            await _context.SaveChangesAsync();
            return _mapper.Map<AvailabilitySlotDto>(await _context.AvailabilitySlots.FirstOrDefaultAsync(slot => slot.Id == id));
        }

        public async Task DeleteAvailabilitySlot(long slotId)
        {
            var slot = await _context.AvailabilitySlots.FirstAsync(el => el.Id == slotId);
            _context.Remove(slot);

            await _context.SaveChangesAsync();
        }

        public List<LocationDto> GetLocations()
        {
            return _mapper.Map<List<LocationDto>>(_context.Locations);
        }
    }
}
