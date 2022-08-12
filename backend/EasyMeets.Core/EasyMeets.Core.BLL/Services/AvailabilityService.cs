﻿using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;
using EasyMeets.Core.DAL.Entities;
using EasyMeets.Core.Common.Enums; 
using EasyMeets.Core.Common.DTO.User; 
using EasyMeets.Core.Common.DTO.Location;

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
                .Where(x => x.AvailabilitySlots.Any(x => x.Type == SlotType.Team) && x.AvailabilitySlots.Any(x => x.Members.Any(x => x.UserId == id)))
                .Select(x =>
                    new AvailabilitySlotsGroupByTeamsDto
                    {
                        Name = x.Name,
                        PageLink = x.PageLink,
                        AvailabilitySlots = x.AvailabilitySlots
                            .Select(y =>
                                new AvailabilitySlotDto
                                {
                                    Id = y.Id,
                                    Name = y.Name,
                                    Link = y.Link,
                                    Type = y.Type,
                                    Size = y.Size,
                                    IsEnabled = y.IsEnabled,
                                    Author =
                                        new UserDto
                                        {
                                            Id = y.Author.Id,
                                            UserName = y.Author.Name,
                                            Email = y.Author.Email,
                                            Image = y.Author.ImagePath,
                                            Phone = y.Author.PhoneNumber
                                        },
                                    Location = new LocationDto
                                    {
                                        Name = y.Location.Name,
                                    },
                                    Members = y.Members
                                        .Select(m =>
                                         new UserDto
                                         {
                                             Id = m.User.Id,
                                             UserName = m.User.Name,
                                             Email = m.User.Email,
                                             Image = m.User.ImagePath,
                                             Phone = m.User.PhoneNumber
                                         })
                                        .ToList()
                                })
                            .ToList()
                    })
                .ToListAsync();

            return teamsWithSlots;
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
