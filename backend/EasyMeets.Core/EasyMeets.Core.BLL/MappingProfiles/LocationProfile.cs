using AutoMapper;
using EasyMeets.Core.Common.DTO;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles;

public class LocationProfile : Profile
{
    public LocationProfile()
    {
        CreateMap<LocationDto, Location>();
        CreateMap<Location, LocationDto>();
    }
}