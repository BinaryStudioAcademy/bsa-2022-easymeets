using AutoMapper;
using EasyMeets.Core.Common.DTO.Meeting;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles
{
    public sealed class MeetingProfile : Profile
    {
        public MeetingProfile()
        {
            CreateMap<Meeting, MeetingThreeMembersDTO>()
                .ForMember(dest => dest.MeetingTime, src => src.MapFrom(meeting =>
                    $"{meeting.StartTime.Hour}:{meeting.StartTime.Minute} - " +
                    $"{meeting.StartTime.AddMinutes(meeting.Duration).Hour}:{meeting.StartTime.AddMinutes(meeting.Duration).Minute}"))
                .ForMember(dest => dest.MeetingTitle, src => src.MapFrom(s => s.Name))
                .ForMember(dest => dest.MeetingDuration, src => src.MapFrom(s => $"{s.Duration} min"))
                .ForMember(dest => dest.MembersTitle, src => src.MapFrom(s => CreateMemberTitle(s)))
                .ForMember(dest => dest.MeetingMembers, src => src.MapFrom(s => GetThreeMembersForMeeting(s)))
                .ForMember(dest => dest.MeetingCount,
                    src => src.MapFrom(s => s.SlotMembers.Select(x => new UserMeetingDTO
                            { Name = x.User.Name, Email = x.User.Email, TimeZone = x.User.TimeZone.ToString() })
                        .ToList()
                        .Count()))
                .ForMember(dest => dest.Location, src => src.MapFrom(s => s.LocationType.ToString()));
        }

        private string CreateMemberTitle(Meeting meeting)
        {
            return meeting.SlotMembers.Count() switch
            {
                0 => "Empty meeting.",
                1 => meeting.SlotMembers.First().User.Name,
                _ => $"{meeting.SlotMembers.Count()} + Team Members"
            };
        }

        private List<UserMeetingDTO> GetThreeMembersForMeeting(Meeting meeting)
        {
            var members1 = meeting.SlotMembers
                .Select(x => new UserMeetingDTO
                    { Name = x.User.Name, Email = x.User.Email, TimeZone = x.User.TimeZone.ToString() }).ToList();

            if (meeting.AvailabilitySlot != null)
            {
                var members2 = meeting.AvailabilitySlot.ExternalAttendees
                    .Select(x => new UserMeetingDTO
                        { Name = x.Name, Email = x.Email, TimeZone = x.TimeZone.ToString() }).ToList();

                return members1.Union(members2).Take(3).ToList();
            }

            return members1.Take(3).ToList();
        }
    }
}