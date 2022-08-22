using AutoMapper;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles
{
    public class TeamMemberProfile : Profile
    {
        public TeamMemberProfile()
        {
            CreateMap<TeamMember, NewMeetingTeamMemberDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.User.Name)); 
        }
    }
}
