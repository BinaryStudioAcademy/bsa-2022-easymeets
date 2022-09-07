using AutoMapper;
using EasyMeets.Core.Common.DTO.ExternalAttendee;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles;

public class ExternalAttendeeProfile : Profile
{
    public ExternalAttendeeProfile()
    {
        CreateMap<ExternalAttendeeDto, ExternalAttendee>();
    }
}