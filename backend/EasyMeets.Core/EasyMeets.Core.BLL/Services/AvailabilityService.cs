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
                .Where(x => x.CreatedBy == id || x.SlotMembers.Any(x => x.MemberId == id))
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
                        TeamName = y.Team.Name,
                        LocationType = y.LocationType,
                        Link = y.Link,
                        EmailTemplateSettings = _mapper.Map<List<EmailTemplatesSettingsDto>>(y.EmailTemplates),
                        Members = _mapper.Map<ICollection<AvailabilitySlotMemberDto>>(y.SlotMembers),
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

            var author = new SlotMember
            {
                MemberId = currentUser.Id,
                Priority = 3
            };

            if (!slotDto.Schedule.WithTeamMembers)
            {
                var schedule = _mapper.Map<Schedule>(slotDto.Schedule);
                _context.Schedules.Add(schedule);
                author.Schedule = schedule;
            }
            entity.SlotMembers.Add(author);
            _context.SlotMembers.Add(author);

            await _context.SaveChangesAsync();
        }

        public async Task<AvailabilitySlotDto> GetAvailabilitySlotById(long id)
        {
            var availabilitySlot = await _context.AvailabilitySlots
                .Include(slot => slot.AdvancedSlotSettings)
                .Include(slot => slot.Questions.OrderBy(q => q.Order))
                .Include(slot => slot.SlotMembers)
                    .ThenInclude(slot => slot.Schedule)
                        .ThenInclude(s => s.ScheduleItems)
                .Include(slot => slot.EmailTemplates)
                .FirstOrDefaultAsync(slot => slot.Id == id);
            if (availabilitySlot is null)
            {
                throw new KeyNotFoundException("Availability slot doesn't exist");
            }

            return _mapper.Map<AvailabilitySlotDto>(availabilitySlot);
        }

        public async Task<AvailabilitySlotDto> UpdateAvailabilitySlot(long id,
            SaveAvailabilitySlotDto updateAvailabilityDto)
        {
            var availabilitySlot = await _context.AvailabilitySlots
                .Include(slot => slot.AdvancedSlotSettings)
                .Include(slot => slot.Questions)
                .Include(slot => slot.SlotMembers)
                    .ThenInclude(slot => slot.Schedule)
                        .ThenInclude(s => s.ScheduleItems)
                .Include(slot => slot.EmailTemplates)
                .FirstOrDefaultAsync(slot => slot.Id == id);

            if (availabilitySlot is null)
            {
                throw new KeyNotFoundException("Availability slot doesn't exist");
            }

            if (updateAvailabilityDto is null)
            {
                throw new ArgumentNullException(nameof(updateAvailabilityDto), "Updated slot cannot be null.");
            }

            _mapper.Map(updateAvailabilityDto, availabilitySlot);

            if (updateAvailabilityDto.HasAdvancedSettings && availabilitySlot.AdvancedSlotSettings is not null)
            {
                _mapper.Map(updateAvailabilityDto.AdvancedSettings, availabilitySlot.AdvancedSlotSettings);
            }
            else if (updateAvailabilityDto.HasAdvancedSettings && availabilitySlot.AdvancedSlotSettings is null)
            {
                var newAdvancedSlotSettings = _mapper.Map<AdvancedSlotSettings>(updateAvailabilityDto.AdvancedSettings);
                newAdvancedSlotSettings.AvailabilitySlotId = availabilitySlot.Id;
                _context.AdvancedSlotSettings.Add(newAdvancedSlotSettings);
            }

            else if (!updateAvailabilityDto.HasAdvancedSettings && availabilitySlot.AdvancedSlotSettings is not null)
            {
                _context.Remove(availabilitySlot.AdvancedSlotSettings);
            }

            if (updateAvailabilityDto.TemplateSettings is not null)
            {
                var oldTemplate = await _context.EmailTemplates.FirstOrDefaultAsync(t => t.TemplateType == updateAvailabilityDto.TemplateSettings.Type
                && t.AvailabilitySlotId == availabilitySlot.Id);

                if (oldTemplate is not null)
                {
                    var newTemplate = _mapper.Map(updateAvailabilityDto.TemplateSettings, oldTemplate);
                    _context.EmailTemplates.Update(oldTemplate);
                }
                else
                {
                    await SaveEmailTemplateConfig(updateAvailabilityDto.TemplateSettings, availabilitySlot);
                }
            }

            if (updateAvailabilityDto.Questions is not null)
            {
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

            if (!updateAvailabilityDto.Schedule.WithTeamMembers)
            {
                _mapper.Map(updateAvailabilityDto.Schedule, availabilitySlot.SlotMembers.First().Schedule);
            }

            availabilitySlot.LocationType = updateAvailabilityDto.GeneralDetails!.LocationType;

            await _context.SaveChangesAsync();
            return _mapper.Map<AvailabilitySlotDto>(
                await _context.AvailabilitySlots.FirstOrDefaultAsync(slot => slot.Id == id));
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
            _context.RemoveRange(members);
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

        private async Task<AvailabilitySlot?> GetByLinkInternal(string link)
        {
            return await _context.AvailabilitySlots
                .Include(slot => slot.SlotMembers)
                    .ThenInclude(slot => slot.Schedule)
                        .ThenInclude(s => s.ScheduleItems)
                .FirstOrDefaultAsync(s => s.Link == link);
        }

        private async Task SaveEmailTemplateConfig(EmailTemplatesSettingsDto settingsDto, AvailabilitySlot slot)
        {
            var emailTemplate = _mapper.Map<EmailTemplate>(settingsDto,
                    opts => opts.AfterMap((_, dest) =>
                    {
                        dest.AvailabilitySlot = slot;
                    }));
            await _context.EmailTemplates.AddAsync(emailTemplate);
            slot.EmailTemplates.Add(emailTemplate);
        }
    }
}