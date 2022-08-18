using AutoMapper;
using EasyMeets.Core.Common.DTO.Availability.NewAvailability;
using EasyMeets.Core.Common.DTO.Availability.Schedule;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles;

public class ScheduleProfile : Profile
{
    public ScheduleProfile()
    {
        CreateMap<ScheduleDto, Schedule>();
        CreateMap<ScheduleItemDto, ScheduleItem>();
    }
}