using System.Linq;
using System.Security.Claims;
using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.DAL.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.BLL.Services
{
    public class TeamService : BaseService, ITeamService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public TeamService(EasyMeetsCoreContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(context, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<TeamDto>> GetCurrentUserTeams()
        {
            var currentUserEmail = GetCurrentUserEmail();
            var currentUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == currentUserEmail);
            var teams = _context.TeamMembers.Where(el => el.UserId == currentUser!.Id)
                .Include(el => el.Team)
                .Select(el => el.Team)
                .ToList();

            return _mapper.Map<List<TeamDto>>(teams);
        }
        
        public string GetCurrentUserEmail()
        {
            var claimsList = _httpContextAccessor.HttpContext!.User.Claims.ToList();
            var email = claimsList.Find(el => el.Type == ClaimTypes.Email);
            return email!.Value;
        }
    }
}