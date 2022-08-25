using AutoMapper;
using EasyMeets.Core.Common.DTO.Credentials;
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
                => opts.MapFrom(_ => DateTime.Now));
    }
}