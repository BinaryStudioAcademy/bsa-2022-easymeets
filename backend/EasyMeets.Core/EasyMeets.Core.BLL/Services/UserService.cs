using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.User;
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace EasyMeets.Core.BLL.Services
{
    public class UserService : BaseService, IUserService
    {
        public UserService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper) {}

        public async Task<UserDto> GetCurrentUserAsync(int id)
        {
            var currentUser = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            var currentUserDto = _mapper.Map<UserDto>(currentUser);
            return currentUserDto;
        }
    }
}
