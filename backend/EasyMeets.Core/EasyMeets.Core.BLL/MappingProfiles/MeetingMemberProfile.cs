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
        }
    }
}
