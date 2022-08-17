using AutoMapper;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.User;
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.Services
{
    public class UserService : BaseService, IUserService
    {
        public UserService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper) {}

        public async Task<UserDto> GetCurrentUserAsync(long id, string currentUserEmail)
        {
            var currentUser = await GetUserById(id);
            
            if (currentUser.Email != currentUserEmail)
            {
                throw new FieldAccessException("You don't have access to data of other users");
            }
            
            var currentUserDto = _mapper.Map<UserDto>(currentUser);
            return currentUserDto;
        }

        public async Task<UserDto?> GetUserPreferences(long userId, string currentUserEmail)
        {
            var user = await GetUserById(userId);
            
            if (user.Email != currentUserEmail)
            {
                throw new FieldAccessException("You don't have access to data of other users");
            }
            
            if (user is null)
            {
                throw new KeyNotFoundException("User doesn't exist");
            }
            return _mapper.Map<UserDto>(user);
        }

        public async Task UpdateUserPreferences(UserDto userDto, string currentUserEmail)
        {
            var userEntity = await GetUserById(userDto.Id);
            userEntity = _mapper.Map(userDto, userEntity);
            
            if (userEntity.Email != currentUserEmail)
            {
                throw new FieldAccessException("You don't have access to data of other users");
            }
            
            _context.Users.Update(userEntity);
            await _context.SaveChangesAsync();
        }
        private async Task<User> GetUserById(long id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id) ?? throw new KeyNotFoundException("User doesn't exist");
        }
    }
}
