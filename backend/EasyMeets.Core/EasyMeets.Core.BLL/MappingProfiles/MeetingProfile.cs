using AutoMapper;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Common;
using EasyMeets.Core.Common.DTO.Meeting;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.DTO.Zoom; 
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles
{
    public sealed class MeetingProfile : Profile
    {
        public MeetingProfile()
        {
            CreateMap<User, UserMeetingDTO>();
            
            CreateMap<SaveMeetingDto, Meeting>()
                .AfterMap((src, dest) =>
                {
                    if (src.TimeZone is not null)
                    {
                        dest.TimeZoneName = src.TimeZone.NameValue;
                        dest.TimeZoneValue = src.TimeZone.TimeValue;
                    }
                    
                });
            CreateMap<Meeting, SaveMeetingDto>()
                .ForMember(dest => dest.MeetingMembers, src => src.MapFrom(s => s.MeetingMembers))
                .AfterMap((src, dest) =>
                {
                    if (src.TimeZoneName is not null && src.TimeZoneValue is not null)
                    {
                        dest.TimeZone = new TimeZoneDto
                        {
                            NameValue = src.TimeZoneName,
                            TimeValue = src.TimeZoneValue
                        };
                    }
                });

            CreateMap<SaveUpdateMeetingDto, Meeting>().ReverseMap();
            
            CreateMap<Meeting, NewZoomMeetingDto>()
                .ForMember(m => m.Agenda, o
                    => o.MapFrom(s => s.Name))
                .ForMember(m => m.ScheduleFor, o =>
                    o.MapFrom(s => s.Author.Email))
                .AfterMap((src, dest) =>
                {
                    dest.Settings.ContactName = src.Author.Name;
                    dest.Settings.ContactEmail = src.Author.Email;
                });

            CreateMap<ExternalAttendeeMeetingDto, Meeting>();

            CreateMap<Meeting, UnavailabilityItemDto>()
                .ForMember(u => u.Start, opts =>
                    opts.MapFrom(src => src.StartTime.DateTime))
                .ForMember(u => u.End, opts =>
                    opts.MapFrom(src => src.StartTime.DateTime.AddMinutes(src.Duration)));
            
            CreateMap<Meeting, MeetingSlotDTO>()
                .ForMember(dest => dest.MeetingTitle, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.MeetingDuration, opt => opt.MapFrom(src => src.Duration))
                .ForMember(dest => dest.MeetingTime, opt => opt.MapFrom(src => src.StartTime))
                .AfterMap((src, dest, context) =>
                {
                    var attendees = context.Mapper.Map<List<UserMeetingDTO>>(src.ExternalAttendees);
                    
                    dest.MeetingMembers = dest.MeetingMembers?
                        .Union(attendees)
                        .Select(dto =>
                        {
                            dto.Booked = src.CreatedAt;

                            return dto;
                        })
                        .ToList();
                    
                    dest.MeetingCount = dest.MeetingMembers?.Count;
                });

            CreateMap<QuestionAnswer, QuestionDto>()
                .ForMember(u => u.QuestionText, opts => 
                    opts.MapFrom(src => src.Question.QuestionText))
                .ForMember(u => u.Order, opts => 
                    opts.MapFrom(src => src.Question.Order))
                .ForMember(u => u.IsMandatory, opts => 
                    opts.MapFrom(src => src.Question.IsMandatory))
                .ForMember(u => u.Id, opts =>
                    opts.MapFrom(src => src.QuestionId));

            CreateMap<MeetingMember, UserMeetingDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.TeamMember.User.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.TeamMember.User.Name))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.TeamMember.User.Email))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.TeamMember.User.ImagePath))
                .AfterMap((src, dest) =>
                {
                    if (src.Meeting.TimeZoneName is not null && src.Meeting.TimeZoneValue is not null)
                    {
                        dest.TimeZone = new TimeZoneDto
                        {
                            NameValue = src.Meeting.TimeZoneName,
                            TimeValue = src.Meeting.TimeZoneValue,
                        };
                    }
                });
        }
    }
}