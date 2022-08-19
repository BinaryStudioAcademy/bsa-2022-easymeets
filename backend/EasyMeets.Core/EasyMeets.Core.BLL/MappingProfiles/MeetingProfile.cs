using AutoMapper;
using EasyMeets.Core.Common.DTO.Meeting;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles
{
    public sealed class MeetingProfile : Profile
    {
        public MeetingProfile()
        {
            CreateMap<Meeting, MeetingBookingsDTO>()
                    .ForMember(dest => dest.MeetingTime, src => src.MapFrom(meeting => $"{meeting.StartTime.Hour}:{meeting.StartTime.Minute} - " +
                    $"{meeting.StartTime.AddMinutes(meeting.Duration).Hour}:{meeting.StartTime.AddMinutes(meeting.Duration).Minute}"))
                    .ForMember(dest => dest.MeetingTitle, src => src.MapFrom(s => s.Name))
                    .ForMember(dest => dest.MeetingDuration, src => src.MapFrom(s => $"{s.Duration} min"))
                    .ForMember(dest => dest.MembersTitle, src => src.MapFrom(s => CreateMemberTitle(s)))
                    .ForMember(dest => dest.MeetingMembers, src => src.MapFrom(s => s.SlotMembers.
                    Select(x => new UserMeetingDTO { Name = x.User.Name, Email = x.User.Email, TimeZone = x.User.TimeZone.ToString() }).ToList().Take(3)))
                    .ForMember(dest => dest.MeetingCount, src => src.MapFrom(s => s.SlotMembers.
                    Select(x => new UserMeetingDTO { Name = x.User.Name, Email = x.User.Email, TimeZone = x.User.TimeZone.ToString() }).ToList().Count()))
                    .ForMember(dest => dest.Location, src => src.MapFrom(s => s.LocationType.ToString()));
        }

        private string CreateMemberTitle(Meeting meeting)
        {
            switch(meeting.SlotMembers.Count())
            {
                case 0:
                    return "Empty meeting.";
                case 1:
                    return meeting.SlotMembers.FirstOrDefault().User.Name;
                default:
                    return $"{meeting.SlotMembers.Count()} + Team Members";
            }
        }
    }
}
