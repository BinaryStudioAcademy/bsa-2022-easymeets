using EasyMeets.Core.Common.DTO.User;
using EasyMeets.Core.DAL.Entities;
using EmailDto = EasyMeets.Core.Common.DTO.EmailDto;

namespace EasyMeets.Core.BLL.Interfaces;

public interface IEmailSenderService
{
    void Send(EmailDto email);
    EmailDto CreateEmailSubjectAndBody(UserDto currentUser, string userToInvite, string email, Team team, string link);
}