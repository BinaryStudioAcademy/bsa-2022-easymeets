﻿using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.DAL.Context;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;
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

        public async Task DeleteAvailabilitySlot(long slotId)
        {
            var slot = await _context.AvailabilitySlots.FirstAsync(el => el.Id == slotId);
            _context.AvailabilitySlots.Remove(slot);

            await _context.SaveChangesAsync();
        }
    }
}
