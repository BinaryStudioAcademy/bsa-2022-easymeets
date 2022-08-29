using AutoMapper;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles;

public sealed class QuestionProfile : Profile
{
    public QuestionProfile()
    {
        CreateMap<Question, QuestionDto>();
        CreateMap<QuestionDto, Question>();
    }
}