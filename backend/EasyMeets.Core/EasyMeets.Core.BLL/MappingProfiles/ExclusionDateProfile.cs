using AutoMapper;
using EasyMeets.Core.Common.DTO.Availability.Schedule.ExclusionDate;
using EasyMeets.Core.Common.DTO.Availability.Schedule.ExclusionDate.DayTimeRange;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles;

public class ExclusionDateProfile : Profile
{
    public ExclusionDateProfile()
    {
        CreateMap<ExclusionDateDto, ExclusionDate>();
        CreateMap<DayTimeRangeDto, DayTimeRange>();
        
        CreateMap<ExclusionDate, ExclusionDateDto>();
        CreateMap<DayTimeRange, DayTimeRangeDto>();
    }
}