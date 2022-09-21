using AutoMapper;
using EasyMeets.Core.Common.DTO.Availability.Schedule.ExclusionTImeRange;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles;

public class ExclusionTimeRangeProfile : Profile
{
    public ExclusionTimeRangeProfile()
    {
        CreateMap<ExclusionTimeRangeDto, ExclusionTimeRange>();
        CreateMap<ExclusionTimeRange, ExclusionTimeRangeDto>();
    }
}