using AutoMapper;
using AutoMapper.Extensions.EnumMapping;
using EasyMeets.Core.Common.DTO.Enum;
using EasyMeets.Core.DAL.Entities.Enums;

namespace EasyMeets.Core.BLL.MappingProfiles
{
    public class SlotTypeProfile : Profile
    {
        public SlotTypeProfile()
        {
            CreateMap<SlotType, SlotTypeDto>()
                .ConvertUsingEnumMapping(opt => opt 
                .MapByName()
            )
            .ReverseMap();
        }
    }
}
