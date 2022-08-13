using AutoMapper;
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
        
        public async Task<AvailabilitySlotDto> GetAvailabilitySlotById(long id)
        {
            var availabilitySlot = await _context.AvailabilitySlots.FirstOrDefaultAsync(_ => _.Id == id);
            if (availabilitySlot is null)
            {
                throw new KeyNotFoundException("Availability slot doesn't exist");
            }
            return _mapper.Map<AvailabilitySlotDto>(availabilitySlot);
        }
        
        public async Task<List<AvailabilitySlotDto>> GetAvailabilitySlots()
        {
            return _mapper.Map<List<AvailabilitySlotDto>>(await _context.AvailabilitySlots.ToListAsync());
        }
    }
}
