﻿using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Availability.SaveAvailability;
using EasyMeets.Core.Common.DTO.Availability.Schedule;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IAvailabilityService
    { 
        Task<UserPersonalAndTeamSlotsDto> GetUserPersonalAndTeamSlotsAsync(long id, long? teamId);
        Task CreateAvailabilitySlot(SaveAvailabilitySlotDto slotDto);
        Task<AvailabilitySlotDto> GetAvailabilitySlotById(long id);
        Task<AvailabilitySlotDto> UpdateAvailabilitySlot(long id, SaveAvailabilitySlotDto updateAvailabilityDto);
        Task<bool> UpdateAvailabilitySlotEnablingAsync(long id);
        Task DeleteAvailabilitySlot(long slotId);
        Task<List<ScheduleItemDto>> GetSlotScheduleItems(long slotId);
        Task<AvailabilitySlotDto?> GetByLink(string link);
        Task UpdateScheduleExternally(string link, ScheduleDto scheduleDto);
    }
}
