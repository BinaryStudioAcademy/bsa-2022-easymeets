using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.SaveAvailability;
using EasyMeets.Core.Common.DTO.Availability.Schedule;
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;
using EasyMeets.Core.DAL.Entities;
using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.BLL.Services
{
    public class AvailabilityService : BaseService, IAvailabilityService
    {
        private readonly IUserService _userService;

        public AvailabilityService(EasyMeetsCoreContext context, IMapper mapper, IUserService userService) : base(
            context, mapper)
        {
            _userService = userService;
        }

        public async Task<UserPersonalAndTeamSlotsDto> GetUserPersonalAndTeamSlotsAsync(long id, long? teamId)
        {
            var isSame = await _userService.ComparePassedIdAndCurrentUserIdAsync(id);

            if (!isSame)
            {
                throw new ArgumentException("Trying to get another user's slots", nameof(id));
            }

            Team? userTeam = null;
            if (teamId is not null)
            {
                userTeam = await _context.Teams.FirstOrDefaultAsync(team => team.Id == teamId) ?? throw new KeyNotFoundException("Team doesn't exist");
            }

            var availabilitySlots = await _context.AvailabilitySlots
                .Include(x => x.SlotMembers)
                    .ThenInclude(x => x.User)
                .Include(x => x.Author)
                .Include(x => x.Team)
                .Include(x => x.EmailTemplates)
                .Where(x => x.CreatedBy == id || x.SlotMembers.Any(m => m.MemberId == id))
                .Where(slot => userTeam != null && slot.Team.Id == userTeam.Id)
                .Select(y =>
                    new AvailabilitySlotDto
                    {
                        Id = y.Id,
                        Name = y.Name,
                        Type = y.Type,
                        Size = y.Size,
                        IsEnabled = y.IsEnabled,
                        AuthorName = y.Author.Name,
                        TeamId = y.Team.Id,
                        TeamName = y.Team.Name,
                        TeamLogoPath = y.Team.LogoPath,
                        LocationType = y.LocationType,
                        MeetingRoom = y.MeetingRoom,
                        Link = y.Link,
                        EmailTemplateSettings = _mapper.Map<List<EmailTemplatesSettingsDto>>(y.EmailTemplates),
                        Members = _mapper.Map<ICollection<AvailabilitySlotMemberDto>>(y.SlotMembers),
                        Color = y.Color,
                    }
                )
                .ToListAsync();

            var userSlots = availabilitySlots.Where(x => x.Type == SlotType.Personal).ToList();
            var availabilitySlotsGroupByTeams = availabilitySlots
                .Where(x => x.Type == SlotType.Team)
                .GroupBy(x => new { x.TeamId, x.TeamName, x.TeamLogoPath })
                .Select(x =>
                    new AvailabilitySlotsGroupByTeamsDto
                    {
                        Id = x.Key.TeamId,
                        Name = x.Key.TeamName,
                        Image = x.Key.TeamLogoPath,
                        AvailabilitySlots = x.ToList()
                    })
                .ToList();

            return new UserPersonalAndTeamSlotsDto(userSlots, availabilitySlotsGroupByTeams);
        }

        public async Task CreateAvailabilitySlot(SaveAvailabilitySlotDto slotDto)
        {
            var currentUser = await _userService.GetCurrentUserAsync();
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


            if (slotDto.Questions is not null)
            {
                var notEmptyQuestions = slotDto.Questions.Where(q => !string.IsNullOrWhiteSpace(q.QuestionText));
                var questionsToAdd = _mapper.Map<ICollection<Question>>(notEmptyQuestions,
                    opts => opts.AfterMap((_, dest) =>
                    {
                        var i = 0;
                        foreach (var question in dest)
                        {
                            question.Id = 0;
                            question.Order = i++;
                            question.AvailabilitySlot = entity;
                        }
                    }));
                _context.Questions.AddRange(questionsToAdd);
                entity.Questions = questionsToAdd;
            }


            if (slotDto.TemplateSettings is not null)
            {
                await SaveEmailTemplateConfig(slotDto.TemplateSettings, entity);
            }
            
            var members = _mapper.Map<List<SlotMember>>(slotDto.SlotMembers);

            entity.SlotMembers = members;
            _context.SlotMembers.AddRange(members);

            if (slotDto.Schedule is not null)
            {
                SetSingleSchedule(slotDto.Schedule, entity);
            }

            await _context.SaveChangesAsync();
        }

        public async Task<AvailabilitySlotDto> GetAvailabilitySlotById(long id)
        {
            var availabilitySlot = await _context.AvailabilitySlots
                .Include(slot => slot.AdvancedSlotSettings)
                .Include(slot => slot.Questions.OrderBy(q => q.Order))
                .Include(slot => slot.SlotMembers)
                    .ThenInclude(member => member.User)
                .Include(slot => slot.SlotMembers)
                    .ThenInclude(slot => slot.Schedule)
                        .ThenInclude(s => s.ScheduleItems)
                .Include(slot => slot.SlotMembers)
                    .ThenInclude(slot => slot.Schedule)
                        .ThenInclude(s => s.ExclusionDates)
                            .ThenInclude(d => d.DayTimeRanges)
                .Include(slot => slot.EmailTemplates)
                .FirstOrDefaultAsync(slot => slot.Id == id);
            if (availabilitySlot is null)
            {
                throw new KeyNotFoundException("Availability slot doesn't exist");
            }

            return _mapper.Map<AvailabilitySlotDto>(availabilitySlot);
        }

        public async Task<AvailabilitySlotDto> UpdateAvailabilitySlot(long id, SaveAvailabilitySlotDto updateAvailabilityDto)
        {
            var availabilitySlot = await _context.AvailabilitySlots
                .Include(slot => slot.AdvancedSlotSettings)
                .Include(slot => slot.Questions)
                .Include(slot => slot.SlotMembers)
                    .ThenInclude(slot => slot.Schedule)
                        .ThenInclude(s => s.ScheduleItems)
                .Include(slot => slot.EmailTemplates)
                .FirstOrDefaultAsync(slot => slot.Id == id) ?? throw new KeyNotFoundException("Availability slot doesn't exist");

            _mapper.Map(updateAvailabilityDto, availabilitySlot);

            if (updateAvailabilityDto.Schedule is not null)
            {
                SetSingleSchedule(updateAvailabilityDto.Schedule, availabilitySlot);
            }

            await UpdateAdvancedSlotSettings(updateAvailabilityDto, availabilitySlot);
            await UpdateTemplateSettings(updateAvailabilityDto, availabilitySlot);
            UpdateQuestions(updateAvailabilityDto, availabilitySlot);

            availabilitySlot.LocationType = updateAvailabilityDto.GeneralDetails!.LocationType;

            await _context.SaveChangesAsync();
            return _mapper.Map<AvailabilitySlotDto>(
                await _context.AvailabilitySlots.FirstOrDefaultAsync(slot => slot.Id == id));
        }

        private void SetSingleSchedule(ScheduleDto scheduleDto, AvailabilitySlot availabilitySlot)
        {
            var schedule = _mapper.Map<Schedule>(scheduleDto);
            UpdateSchedule(scheduleDto, schedule);
            foreach (var member in availabilitySlot.SlotMembers)
            {
                member.Schedule = schedule;
            }
        }

        private async Task UpdateAdvancedSlotSettings(SaveAvailabilitySlotDto updateAvailabilityDto, AvailabilitySlot availabilitySlot)
        {
            if (updateAvailabilityDto.HasAdvancedSettings && availabilitySlot.AdvancedSlotSettings is not null)
            {
                _mapper.Map(updateAvailabilityDto.AdvancedSettings, availabilitySlot.AdvancedSlotSettings);
            }
            else if (updateAvailabilityDto.HasAdvancedSettings && availabilitySlot.AdvancedSlotSettings is null)
            {
                var newAdvancedSlotSettings = _mapper.Map<AdvancedSlotSettings>(updateAvailabilityDto.AdvancedSettings);
                newAdvancedSlotSettings.AvailabilitySlotId = availabilitySlot.Id;
                await _context.AdvancedSlotSettings.AddAsync(newAdvancedSlotSettings);
            }

            else if (!updateAvailabilityDto.HasAdvancedSettings && availabilitySlot.AdvancedSlotSettings is not null)
            {
                _context.Remove(availabilitySlot.AdvancedSlotSettings);
            }
        }

         private async Task UpdateTemplateSettings(SaveAvailabilitySlotDto updateAvailabilityDto, AvailabilitySlot availabilitySlot)
         {
             if (updateAvailabilityDto.TemplateSettings is not null)
             {
                 foreach (var template in updateAvailabilityDto.TemplateSettings)
                 {
                     var oldTemplate = await _context.EmailTemplates.FirstOrDefaultAsync(t => t.TemplateType == template.Type
                         && t.AvailabilitySlotId == availabilitySlot.Id);
        
                     if (oldTemplate is not null)
                     {
                         var newTemplate = _mapper.Map(template, oldTemplate);
                         _context.EmailTemplates.Update(newTemplate);
                     }
                     else
                     {
                         var newTemplate = _mapper.Map<EmailTemplate>(template, opts => opts.AfterMap((_, dest) =>
                         {
                             dest.AvailabilitySlot = availabilitySlot;
                         }));

                         await _context.EmailTemplates.AddAsync(newTemplate);
                     }
                 }
             }
        }

        private void UpdateQuestions(SaveAvailabilitySlotDto updateAvailabilityDto, AvailabilitySlot availabilitySlot)
        {
            if (updateAvailabilityDto.Questions is null) return;

            availabilitySlot.Questions.Clear();

            var notEmptyQuestions = updateAvailabilityDto.Questions.Where(q => !string.IsNullOrWhiteSpace(q.QuestionText));
            var questions = _mapper.Map<ICollection<Question>>(notEmptyQuestions);
            var i = 0;
            foreach (var question in questions)
            {
                question.Id = 0;
                question.Order = i++;
                availabilitySlot.Questions.Add(question);
            }

            _context.Update(availabilitySlot);
        }

        private void UpdateSchedule(ScheduleDto scheduleDto, Schedule schedule)
        {
            var updatedExclusionDateIds = scheduleDto.ExclusionDates.Select(date => date.Id);
            var updatedDayTimeRangeIds =
                scheduleDto.ExclusionDates.SelectMany(dto => dto.DayTimeRanges)
                    .Select(dto => dto.Id);
            var deletedExclusionDates = _context.ExclusionDates.Where(date =>
                date.ScheduleId == schedule.Id &&
                updatedExclusionDateIds.All(updatedDateId => updatedDateId != date.Id));
            var deletedDayTimeRanges = _context.DayTimeRanges
                .Where(range =>
                    updatedExclusionDateIds.Any(updatedExclusionDateId => 
                        updatedExclusionDateId == range.ExclusionDateId) && 
                    updatedDayTimeRangeIds.All(updatedDayTimeRangeId => updatedDayTimeRangeId != range.Id));
            _context.ExclusionDates.RemoveRange(deletedExclusionDates);
            _context.DayTimeRanges.RemoveRange(deletedDayTimeRanges);
            _mapper.Map(scheduleDto, schedule);
        }

        public async Task<bool> UpdateAvailabilitySlotEnablingAsync(long id)
        {
            var availabilitySlot = await _context.AvailabilitySlots.FirstOrDefaultAsync(slot => slot.Id == id) ?? throw new KeyNotFoundException("Availability slot doesn't exist");

            availabilitySlot.IsEnabled = !availabilitySlot.IsEnabled;
            _context.AvailabilitySlots.Update(availabilitySlot);
            await _context.SaveChangesAsync();
            return !availabilitySlot.IsEnabled;
        }

        public async Task DeleteAvailabilitySlot(long slotId)
        {
            var slot = await _context.AvailabilitySlots.FirstAsync(el => el.Id == slotId);
            var members = _context.SlotMembers.Where(member => member.SlotId == slotId);
            var meetings = _context.Meetings.Where(meeting => meeting.AvailabilitySlotId == slotId);
            _context.RemoveRange(members);
            _context.RemoveRange(meetings);
            _context.Remove(slot);

            await _context.SaveChangesAsync();
        }

        public async Task<AvailabilitySlotDto?> GetByLink(string link)
        {
            var slot = await GetByLinkInternal(link);
            return _mapper.Map<AvailabilitySlotDto>(slot);
        }

        public async Task UpdateScheduleExternally(string link, ScheduleDto scheduleDto)
        {
            var slot = await GetByLinkInternal(link);
            foreach (var member in slot!.SlotMembers)
            {
                _mapper.Map(scheduleDto, member.Schedule);
            }

            await _context.SaveChangesAsync();
        }

        public async Task<bool> ValidateLinkAsync(long? slotId, string slotLink)
        {
            return !await _context.AvailabilitySlots.AnyAsync(s => s.Id != slotId && s.Link == slotLink);
        }

        public Task<bool> ValidateSlotPasswordAsync(string slotLink, string password)
        {
            return _context.AvailabilitySlots.AnyAsync(el => el.Link == slotLink && el.PasswordProtection == password);
        }

        private async Task<AvailabilitySlot?> GetByLinkInternal(string link)
        {
            return await _context.AvailabilitySlots
                .Include(slot => slot.SlotMembers)
                    .ThenInclude(slot => slot.Schedule)
                        .ThenInclude(s => s.ScheduleItems)
                .FirstOrDefaultAsync(s => s.Link == link);
        }

        private async Task SaveEmailTemplateConfig(ICollection<EmailTemplatesSettingsDto> settingsDto, AvailabilitySlot slot)
        {
            var emailTemplates = settingsDto.Select(s => _mapper.Map<EmailTemplate>(s,
                opts => opts.AfterMap((_, dest) =>
                {
                    dest.AvailabilitySlot = slot;
                }))).ToList();
            
            await _context.EmailTemplates.AddRangeAsync(emailTemplates);

            slot.EmailTemplates = emailTemplates;
        }
    }
}