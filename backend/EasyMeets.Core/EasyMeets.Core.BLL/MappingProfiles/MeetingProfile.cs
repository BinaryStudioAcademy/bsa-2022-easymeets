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
                    .ForMember(dest => dest.MeetingDuration, src => src.MapFrom(s => s.Duration.ToString()))
                    .ForMember(dest => dest.MembersTitle, src => src.MapFrom(s => CreateMemberTitle(s)))
                    .ForMember(dest => dest.MeetingMembers, src => src.MapFrom(s => s.TeamMeetings.
                    Select(x => new UserMeetingDTO { Name = x.User.Name, Email = x.User.Email, TimeZone = x.User.TimeZone.ToString() }).ToList()));
        }

        private string CreateMemberTitle(Meeting meeting)
        {
            if (!meeting.TeamMeetings.Any())
            {
                return "Empty?????????????";
            }

            if (meeting.TeamMeetings.Count == 1)
            {
                return meeting.TeamMeetings.FirstOrDefault().User.Name;
            }

            return $"{meeting.TeamMeetings.Count()} + Team Members";
        }
    }
}
