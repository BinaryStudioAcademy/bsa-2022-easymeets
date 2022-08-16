using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;
using EasyMeets.Core.Common.DTO.Availability.UpdateAvailability;
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
                .FirstOrDefaultAsync(_ => _.Id == id);
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
                .FirstOrDefaultAsync(_ => _.Id == id);
            if (availabilitySlot is null)
            {
                throw new KeyNotFoundException("Availability slot doesn't exist");
            }
            
            availabilitySlot.Frequency = updateAvailabilityDto.GeneralDetailsUpdate.SlotFrequency;
            availabilitySlot.Size = updateAvailabilityDto.GeneralDetailsUpdate.SlotSize;
            availabilitySlot.Name = updateAvailabilityDto.GeneralDetailsUpdate.MeetingName;
            //availabilitySlot.Location = await _context.Locations.FirstAsync(location =>
            //    location.Name == updateAvailabilityDto.GeneralDetailsUpdate.MeetingLocation);
            availabilitySlot.IsVisible = !updateAvailabilityDto.GeneralDetailsUpdate.HideFromCommon;
            // is enabled not updated

            availabilitySlot.TimeZoneVisibility = updateAvailabilityDto.EventDetailsUpdate.ZoneChoice;
            availabilitySlot.Link = updateAvailabilityDto.EventDetailsUpdate.LinkChoice;
            availabilitySlot.WelcomeMessage = updateAvailabilityDto.EventDetailsUpdate.WelcomeMessage;
            availabilitySlot.Language = updateAvailabilityDto.EventDetailsUpdate.LanguageSelect;
            availabilitySlot.BookingsPerDay = updateAvailabilityDto.EventDetailsUpdate.AllowBookingSelect;
            availabilitySlot.AllowToAddGuests = updateAvailabilityDto.EventDetailsUpdate.IsAllowBooker;
            availabilitySlot.PasswordProtectionIsUsed = updateAvailabilityDto.EventDetailsUpdate.PasswordProtect;
            availabilitySlot.PasswordProtection = updateAvailabilityDto.EventDetailsUpdate.PasswordInput;

            if (!updateAvailabilityDto.HasAdvancedSettings)
            {
                _context.Remove(availabilitySlot.AdvancedSlotSettings);
                await _context.SaveChangesAsync();
            }
            else if (availabilitySlot.AdvancedSlotSettingsId is not null)
            {
                availabilitySlot.AdvancedSlotSettings.ActivityType = updateAvailabilityDto.GeneralDetailsUpdate.SlotActivityOption;
                availabilitySlot.AdvancedSlotSettings.Days = updateAvailabilityDto.GeneralDetailsUpdate.SlotActivityValue;
                availabilitySlot.AdvancedSlotSettings.MaxNumberOfBookings = updateAvailabilityDto.GeneralDetailsUpdate.MaxBookings;
                availabilitySlot.AdvancedSlotSettings.PaddingMeeting = updateAvailabilityDto.GeneralDetailsUpdate.MeetingPadding;
                availabilitySlot.AdvancedSlotSettings.MinBookingMeetingDifference = updateAvailabilityDto.GeneralDetailsUpdate.MinBookingMeetingDifference;
                availabilitySlot.AdvancedSlotSettings.Color = updateAvailabilityDto.GeneralDetailsUpdate.Color;
            }
            else
            {
                var newAdvancedSlotSettings = new AdvancedSlotSettings
                {
                    ActivityType = updateAvailabilityDto.GeneralDetailsUpdate.SlotActivityOption,
                    Days = updateAvailabilityDto.GeneralDetailsUpdate.SlotActivityValue,
                    MaxNumberOfBookings = updateAvailabilityDto.GeneralDetailsUpdate.MaxBookings,
                    PaddingMeeting = updateAvailabilityDto.GeneralDetailsUpdate.MeetingPadding,
                    MinBookingMeetingDifference = updateAvailabilityDto.GeneralDetailsUpdate.MinBookingMeetingDifference,
                    Color = updateAvailabilityDto.GeneralDetailsUpdate.Color
                };
                _context.AdvancedSlotSettings.Add(newAdvancedSlotSettings);
                availabilitySlot.AdvancedSlotSettings = newAdvancedSlotSettings;
                await _context.SaveChangesAsync();
            }

            await _context.SaveChangesAsync();
            return _mapper.Map<AvailabilitySlotDto>(await _context.AvailabilitySlots.FirstOrDefaultAsync(slot => slot.Id == id));
        }
    }
}
