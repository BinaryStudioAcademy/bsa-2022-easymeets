using AutoMapper;
using EasyMeets.Core.BLL.Extentions;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.User;
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;
using EasyMeets.Core.DAL.Entities;
using Microsoft.AspNetCore.Http;

namespace EasyMeets.Core.BLL.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserService(EasyMeetsCoreContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(context, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<UserDto> GetCurrentUserAsync()
        {
            var currentUser = await _context.Users.FirstOrDefaultAsync(u => u.Uid == GetCurrentUserId());

            if (currentUser == null)
            {
                throw new KeyNotFoundException("User doesn't exist");
            }

            var currentUserDto = _mapper.Map<UserDto>(currentUser);
            return currentUserDto;
        }

        public async Task<bool> CheckExistingUserByEmail(string email)
        {
            return await _context.Users.AnyAsync(u => u.Email == email);;
        }

        public async Task UpdateUserPreferences(UserDto userDto, string currentUserEmail)
        {
            var userEntity = await GetUserById(userDto.Id);
            userEntity = _mapper.Map(userDto, userEntity);

            if (userEntity.Email != currentUserEmail)
            {
                throw new ArgumentException("You don't have access to data of other users");
            }

            _context.Users.Update(userEntity);
            await _context.SaveChangesAsync();
        }
        private async Task<User> GetUserById(long id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id) ?? throw new KeyNotFoundException("User doesn't exist");
        }

        public async Task<UserDto> CreateUserPreferences(NewUserDto userDto)
        {
            var newUser = _mapper.Map<NewUserDto, User>(userDto);
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return _mapper.Map<User, UserDto>(newUser);
        }

        public async Task<bool> ComparePassedIdAndCurrentUserIdAsync(long id)
        {
            var currentUserId = _httpContextAccessor.HttpContext.User.GetUid();

            var user = await _context.Users.FindAsync(id);

            return user?.Uid == currentUserId;
        }
        
        private string? GetCurrentUserId()
        {
            var userId = _httpContextAccessor.HttpContext.User.GetUid();
            return userId;
        }
    }
}
