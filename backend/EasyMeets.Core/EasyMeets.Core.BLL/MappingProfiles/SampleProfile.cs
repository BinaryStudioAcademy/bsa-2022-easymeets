using AutoMapper;
using EasyMeets.Core.Common.DTO;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles
{
    public sealed class SampleProfile : Profile
    {
        public SampleProfile()
        {
            CreateMap<Sample, SampleDto>();
            CreateMap<SampleDto, Sample>();
            CreateMap<NewSampleDto, Sample>();
        }
    }
}
