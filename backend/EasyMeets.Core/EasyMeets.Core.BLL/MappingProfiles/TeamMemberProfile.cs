using AutoMapper;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles
{
    public class TeamMemberProfile : Profile
    {
        public TeamMemberProfile()
        {
            CreateMap<TeamMember, NewMeetingMemberDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.User.Name))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.User.ImagePath))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<NewMeetingMemberDto, SlotMember>()
               .ForMember(dest => dest.MemberId, opt => opt.MapFrom(src => src.Id)); 
        }
    }
}
