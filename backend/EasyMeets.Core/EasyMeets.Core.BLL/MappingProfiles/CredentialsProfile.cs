using AutoMapper;
using EasyMeets.Core.Common.DTO.Credentials;
using EasyMeets.Core.Common.DTO.Credentials.GoogleMeet;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles;

public class CredentialsProfile : Profile
{
    public CredentialsProfile()
    {
        CreateMap<CredentialsDto, Credentials>()
            .ForMember(dest => dest.LifeCycle, opts
                => opts.MapFrom(src => src.ExpiresIn))
            .ForMember(dest => dest.UpdatedAt, opts
                => opts.MapFrom(_ => DateTimeOffset.UtcNow))
            .ForMember(dest => dest.UserId, opts
                => opts.MapFrom((_, dest) => dest.UserId))
            .ForMember(dest => dest.Type, opts
                => opts.MapFrom((_, dest) => dest.Type));

        CreateMap<MeetCredentialsDto, Credentials>()
            .ForMember(dest => dest.Type, opts 
                => opts.MapFrom(src => CredentialsType.Meet));

        CreateMap<Credentials, MeetCredentialsDto>();
    }
}