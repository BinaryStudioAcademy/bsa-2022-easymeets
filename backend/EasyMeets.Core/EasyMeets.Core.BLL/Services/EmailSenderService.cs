using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.User;
using EasyMeets.Core.DAL.Entities;
using EasyMeets.RabbitMQ.Interface;
using Newtonsoft.Json;
using EmailDto = EasyMeets.Core.Common.DTO.EmailDto;

namespace EasyMeets.Core.BLL.Services;

public class EmailSenderService : IEmailSenderService
{
    private readonly IProducerService _producerService;

    public EmailSenderService(IProducerService producerService)
    {
        _producerService = producerService;
    }

    public void Send(EmailDto email)
    {
        var message = JsonConvert.SerializeObject(email);

        _producerService.Send(message, "application/json");
    }

    public EmailDto CreateEmailSubjectAndBody(UserDto currentUser, User userToInvite, Team team, string link)
    {
        return new EmailDto
        {
            Subject = $"{currentUser.UserName} wants to add you to the team {team.Name} on Easymeets",
            Body = $"Hi {userToInvite.Name},\r\nUser {currentUser.UserName} would like to add to the team {team.Name}.\r\n" +
                   $"Please follow the link. {link}\r\nIf this was a mistake please ignore this email.",
            Recipient = userToInvite.Email
        };
    }

    public EmailDto CreateEmailSubjectAndBody(UserDto currentUser, string email, Team team, string link)
    {
        return new EmailDto
        {
            Subject = $"{currentUser.UserName} wants to add you to the team {team.Name} on Easymeets",
            Body = $"Hi {email},\r\nUser {currentUser.UserName} would like to add to the team {team.Name}.\r\n" +
                   $"Please follow the link. {link}\r\nIf this was a mistake please ignore this email.",
            Recipient = email
        };
    }
}