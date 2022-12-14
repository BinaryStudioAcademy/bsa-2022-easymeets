using AutoMapper;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.DTO.User;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles
{
    public sealed class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(dest => dest.Image, src => src.MapFrom(s => s.ImagePath))
                .ForMember(dest => dest.UserName, src => src.MapFrom(s => s.Name))
                .ForMember(dest => dest.Phone, src => src.MapFrom(s => s.PhoneNumber));

            CreateMap<UserDto, User>()
                .ForMember(dest => dest.ImagePath, src => src.MapFrom(s => s.Image))
                .ForMember(dest => dest.Name, src => src.MapFrom(s => s.UserName))
                .ForMember(dest => dest.PhoneNumber, src => src.MapFrom(s => s.Phone));

            CreateMap<NewUserDto, User>()
                .ForMember(dest => dest.ImagePath, src => src.MapFrom(s => s.Image))
                .ForMember(dest => dest.Name, src => src.MapFrom(s => s.UserName))
                .ForMember(dest => dest.PhoneNumber, src => src.MapFrom(s => s.Phone));

            CreateMap<SlotMember, AvailabilitySlotMemberDto>()
                .ForMember(dest => dest.MemberImage, src => src.MapFrom(s => s.User.ImagePath));

            CreateMap<User, NewMeetingMemberDto>()
                .ForMember(dest => dest.Name, src => src.MapFrom(s => s.Name));

            CreateMap<User, ExternalUserDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(s => s.Id))
                .ForMember(dest => dest.UserName, src => src.MapFrom(s => s.Name))
                .ForMember(dest => dest.Image, src => src.MapFrom(s => s.ImagePath))
                .ForMember(dest => dest.PersonalLink, src => src.MapFrom(s => s.PersonalUrl));

            CreateMap<UpdateUserDto, User>()
                .ForMember(dest => dest.Name, src => src.MapFrom(s => s.UserName))
                .ForMember(dest => dest.PhoneNumber, src => src.MapFrom(s => s.Phone));
        }
    }
}
