using EasyMeets.Core.Common.DTO.Team;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IInvitationService
    {
        Task<string> AcceptInvitationAndReturRedirectionLink(UserInvitationDataDto teamData);
    }
}
