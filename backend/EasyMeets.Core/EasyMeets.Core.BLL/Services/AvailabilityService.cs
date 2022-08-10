using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.DAL.Entities;

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

            await _context.SaveChangesAsync();
            
            if (slotDto.AdvancedSettings is not null)
            {
                var advancedSettings = _mapper.Map<AdvancedSlotSettings>(slotDto.AdvancedSettings);
                advancedSettings.AvailabilitySlotId = entity.Id;
                await _context.AdvancedSlotSettings.AddAsync(advancedSettings);
                entity.AdvancedSlotSettingsId = advancedSettings.Id;
                await _context.SaveChangesAsync();
            }
        }
    }
}
