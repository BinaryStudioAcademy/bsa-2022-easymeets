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
            .ForMember(u => u.MeetingName, opts =>
                opts.MapFrom(src => src.Meeting.Name))
            .ForMember(u => u.MeetingDate, opts =>
                opts.MapFrom(src => src.Meeting.StartTime))
            .ForMember(u => u.MeetingDuration, opts =>
                opts.MapFrom(src => src.Meeting.Duration))
            .ForMember(u => u.Questions, opts =>
                opts.MapFrom(src => src.Meeting.QuestionAnswers))
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