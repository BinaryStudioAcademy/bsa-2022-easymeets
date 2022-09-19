using AutoMapper;
using EasyMeets.Core.Common.DTO;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Email.EmailTemplate;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles
{
    public class EmailTemplateProfile : Profile
    {
        public EmailTemplateProfile()
        {
            CreateMap<EmailTemplatesSettingsDto, EmailTemplate>()
                .ForMember(s => s.Subject, opt => opt.MapFrom(src => src.EmailSubject))
                .ForMember(s => s.Body, opt => opt.MapFrom(src => src.EmailBody))
                .ForMember(s => s.TemplateType, opt => opt.MapFrom(src => src.Type))
                .ForMember(s => s.IsSend, opt => opt.MapFrom(src => src.AllowToSend));

            CreateMap<EmailTemplate, EmailTemplatesSettingsDto>()
                .ForMember(s => s.EmailSubject, opt => opt.MapFrom(src => src.Subject))
                .ForMember(s => s.EmailBody, opt => opt.MapFrom(src => src.Body))
                .ForMember(s => s.Type, opt => opt.MapFrom(src => src.TemplateType))
                .ForMember(s => s.AllowToSend, opt => opt.MapFrom(src => src.IsSend));

            CreateMap<EmailTemplate, EmailDto>();

            CreateMap<Meeting, MeetingConfirmationEmailDto>()
                .ForMember(s => s.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(s => s.StartTime, opt => opt.MapFrom(src => src.StartTime))
                .ForMember(s => s.LocationType, opt => opt.MapFrom(src => src.LocationType))
                .ForMember(s => s.AuthorName, opt => opt.MapFrom(src => src.Author.Name))
                .ForMember(s => s.AuthorEmail, opt => opt.MapFrom(src => src.Author.Email))
                .ForMember(s => s.MeetingLink, opt => opt.MapFrom(src => src.MeetingLink));
        }
    }
}
