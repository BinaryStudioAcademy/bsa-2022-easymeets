using AutoMapper;
using EasyMeets.Core.Common.DTO.Common;
using EasyMeets.Core.Common.DTO.ExternalAttendee;
using EasyMeets.Core.Common.DTO.Meeting;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles;

public class ExternalAttendeeProfile : Profile
{
    public ExternalAttendeeProfile()
    {
        CreateMap<ExternalAttendeeDto, ExternalAttendee>();
        
        CreateMap<ExternalAttendee, UserMeetingDTO>()
            .AfterMap((src, dest) =>
            {
                dest.TimeZone = new TimeZoneDto
                {
                    NameValue = src.TimeZoneName,
                    TimeValue = src.TimeZoneValue
                };
            });
    }
}