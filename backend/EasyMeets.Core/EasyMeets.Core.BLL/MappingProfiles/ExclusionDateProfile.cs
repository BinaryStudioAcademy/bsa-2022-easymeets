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
        CreateMap<DayTimeRangeDto, DayTimeRange>()
            .ForMember(dest => dest.Start, opt => opt.MapFrom(src => src.Start.ToTimeSpan()))
            .ForMember(dest => dest.End, opt => opt.MapFrom(src => src.End.ToTimeSpan()));

        CreateMap<ExclusionDate, ExclusionDateDto>();
        CreateMap<DayTimeRange, DayTimeRangeDto>()
            .ForMember(dest => dest.Start, opt => opt.MapFrom(src => TimeOnly.FromTimeSpan(src.Start)))
            .ForMember(dest => dest.End, opt => opt.MapFrom(src => TimeOnly.FromTimeSpan(src.End)));
    }
}