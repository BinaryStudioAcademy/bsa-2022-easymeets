using EasyMeets.Core.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IAvailabilityService
    {
        public Task<ICollection<AvailabilitySlot>> GetAllAvailabilitySlotsAsync();
    }
}
