using AutoMapper;
using EasyMeets.Core.Common.DTO.Calendar;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles;

public class CalendarEventProfile : Profile
{
    public CalendarEventProfile()
    {
        CreateMap<EventItemDTO, CalendarEvent>()
            .ForMember(e => e.Start, opts
                => opts.MapFrom(src => src.Start!.DateTime))
            .ForMember(e => e.End, opts
                => opts.MapFrom(src => src.End!.DateTime))
            .ForMember(e => e.TimeZone, opts
                => opts.MapFrom(src => src.Start!.TimeZone));
    }
}