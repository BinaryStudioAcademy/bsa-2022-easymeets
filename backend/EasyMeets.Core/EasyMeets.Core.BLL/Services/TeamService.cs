using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team; 
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.BLL.Services
{
    public class TeamService : BaseService, ITeamService
    {
        public TeamService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<ICollection<NewMeetingTeamMemberDto>> GetTeamMembersOfCurrentUserAsync(long userId)
        {
            var teamMembers = await _context.Users
                .Include(x=>x.TeamMembers)
                .Where(x => x.Id == userId)
                .Select(x => _mapper.Map<NewMeetingTeamMemberDto>(x))
                .ToListAsync();
            
            return teamMembers;
        }
    }
}
