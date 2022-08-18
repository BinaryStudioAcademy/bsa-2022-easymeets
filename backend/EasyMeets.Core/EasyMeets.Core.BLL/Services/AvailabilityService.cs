using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;
using EasyMeets.Core.Common.DTO.Availability.Schedule;
using EasyMeets.Core.Common.DTO.Availability.UpdateAvailability;
using EasyMeets.Core.DAL.Entities;
using EasyMeets.Core.Common.Enums;


namespace EasyMeets.Core.BLL.Services
{
    public class AvailabilityService : BaseService, IAvailabilityService
    {
        private readonly IUserService _userService;
        public AvailabilityService(EasyMeetsCoreContext context, IMapper mapper, IUserService userService) : base(context, mapper)
        {
            _userService = userService;
        }

        public async Task<UserPersonalAndTeamSlotsDto> GetUserPersonalAndTeamSlotsAsync(long id)
        {
            var availabilitySlots = await _context.AvailabilitySlots
                .Include(x => x.Members)
                    .ThenInclude(x => x.User)
                .Include(x => x.Author)
                .Include(x => x.Team)
                .Include(x => x.Schedule)
                    .ThenInclude(s => s.ScheduleItems)
                .Where(x => x.CreatedBy == id || x.Members.Any(x => x.UserId == id))
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
                        LocationType = y.LocationType,
                        Members = _mapper.Map<ICollection<AvailabilitySlotMemberDto>>(y.Members),
                        Schedule = _mapper.Map<ScheduleDto>(y.Schedule)
                    }
                )
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
            var currentUserEmail = _userService.GetCurrentUserEmail();
            var currentUser = await _userService.GetCurrentUserAsync(currentUserEmail);
            var entity = _mapper.Map<AvailabilitySlot>(slotDto, opts => 
                opts.AfterMap((_, dest) => dest.CreatedBy = currentUser.Id));

            await _context.AvailabilitySlots.AddAsync(entity);

            if (slotDto.AdvancedSettings is not null)
            {
                var advancedSettings = _mapper.Map<AdvancedSlotSettings>(slotDto.AdvancedSettings,
                    opts => opts.AfterMap((_, dest) =>
                    {
                        dest.StartDate = dest.StartDate == DateTimeOffset.MinValue
                            ? DateTimeOffset.Now
                            : dest.StartDate;
                        dest.AvailabilitySlot = entity;
                    }));
                await _context.AdvancedSlotSettings.AddAsync(advancedSettings);
                entity.AdvancedSlotSettings = advancedSettings;
            }

            var schedule = _mapper.Map<Schedule>(slotDto.Schedule,
                opts => opts.AfterMap((_, dest) =>
                {
                    dest.AvailabilitySlot = entity;
                }));
            _context.Schedules.Add(schedule);
            entity.Schedule = schedule;
            
            CreateScheduleItems(slotDto.Schedule, schedule);

            await _context.SaveChangesAsync();
        }

        private void CreateScheduleItems(ScheduleDto scheduleDto, Schedule schedule)
        {
            foreach (var itemDto in scheduleDto.ScheduleItems)
            {
                var item = _mapper.Map<ScheduleItem>(itemDto, opts => 
                    opts.AfterMap((_, dest) => dest.Schedule = schedule));
                _context.ScheduleItems.Add(item);
                schedule.ScheduleItems.Add(item);
            }
        }

        public async Task<AvailabilitySlotDto> GetAvailabilitySlotById(long id)
        {
            var availabilitySlot = await _context.AvailabilitySlots
                .Include(slot => slot.AdvancedSlotSettings)
                .Include(slot => slot.Schedule)
                    .ThenInclude(s => s.ScheduleItems)
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
                .Include(slot => slot.Schedule)
                    .ThenInclude(s => s.ScheduleItems)
                .FirstOrDefaultAsync(slot => slot.Id == id);

            _mapper.Map(updateAvailabilityDto, availabilitySlot);
            
            if (availabilitySlot is null)
            {
                throw new KeyNotFoundException("Availability slot doesn't exist");
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

            _mapper.Map(updateAvailabilityDto.Schedule, availabilitySlot.Schedule);
            
            availabilitySlot.LocationType = updateAvailabilityDto.GeneralDetailsUpdate.LocationType;
            
            await _context.SaveChangesAsync();
            return _mapper.Map<AvailabilitySlotDto>(await _context.AvailabilitySlots.FirstOrDefaultAsync(slot => slot.Id == id));
        }

        public async Task DeleteAvailabilitySlot(long slotId)
        {
            var slot = await _context.AvailabilitySlots.FirstAsync(el => el.Id == slotId);
            _context.Remove(slot);

            await _context.SaveChangesAsync();
        }
    }
}
