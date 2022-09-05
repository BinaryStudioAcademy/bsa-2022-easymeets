using AutoMapper;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles
{
    public class MeetingMemberProfile : Profile
    {
        public MeetingMemberProfile()
        {
            CreateMap<NewMeetingMemberDto, MeetingMember>()
                .ForMember(dest => dest.TeamMemberId, s => s.MapFrom(s => s.Id));
            CreateMap<MeetingMember, NewMeetingMemberDto>()
                .ForMember(dest => dest.Id, s => s.MapFrom(s => s.TeamMember.UserId))
                .ForMember(dest => dest.Name, s => s.MapFrom(s => s.TeamMember.User.Name));
        }
    }
}
