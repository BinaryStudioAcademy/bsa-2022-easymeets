using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMeets.Core.Common.DTO.Availability;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IAvailabilityService
    { 
        Task CreateAvailabilitySlot(NewAvailabilitySlotDto slotDto);
    }
}
