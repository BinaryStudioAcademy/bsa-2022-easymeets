using EasyMeets.Core.Common.DTO;

namespace EasyMeets.Core.BLL.Interfaces;

public interface IEmailSenderService
{
    void Send(EmailDto email);
}