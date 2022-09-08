using AutoMapper;
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
            CreateMap<ExternalAttendee, UserMeetingDTO>();
            CreateMap<SaveMeetingDto, Meeting>();
            CreateMap<Meeting, SaveMeetingDto>()
                .ForMember(dest => dest.MeetingMembers, src => src.MapFrom(s => s.MeetingMembers));

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
        }
    }
}