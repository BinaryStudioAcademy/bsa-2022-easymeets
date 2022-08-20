using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.Common.DTO.User;
using EasyMeets.Core.DAL.Context; 

namespace EasyMeets.Core.BLL.Services
{
    public class TeamService : BaseService, ITeamService
    {
        public TeamService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<ICollection<NewMeetingTeamMemberDto>> GetTeamMembersOfCurrentUserAsync(long userId)  
        {
            
            return null;
        }
    }
}
