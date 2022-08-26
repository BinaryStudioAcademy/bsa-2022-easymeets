using AutoMapper;
using EasyMeets.Core.BLL.Extentions;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.User;
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;
using EasyMeets.Core.DAL.Entities;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using FirebaseAdmin.Auth;
using EasyMeets.Core.Common.DTO.UploadImage;

namespace EasyMeets.Core.BLL.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly FirebaseAuth _firebaseAuth;
        private readonly IUploadFileService _uploadFileService;

        public UserService(
            EasyMeetsCoreContext context, 
            IMapper mapper, 
            IHttpContextAccessor httpContextAccessor,
            FirebaseAuth firebaseAuth, 
            IUploadFileService uploadFileService) : base(context, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _firebaseAuth = firebaseAuth;
            _uploadFileService = uploadFileService;
        }
        
        public async Task<UserDto> GetCurrentUserAsync()
        {
            var currentUser = await _context.Users.FirstOrDefaultAsync(u => u.Uid == GetCurrentUserId());

            if (currentUser is null)
            {
                throw new KeyNotFoundException("User doesn't exist");
            }

            await AddUserClaims(currentUser.Uid, currentUser.Id);
            
            var currentUserDto = _mapper.Map<UserDto>(currentUser);
            return currentUserDto;
        }

        public async Task<bool> CheckExistingUserByEmail(string email)
        {
            return await _context.Users.AnyAsync(u => u.Email == email);
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

            var addedUser = await _context.Users.FirstOrDefaultAsync(user => user.Email == userDto.Email);

            if (addedUser is null)
            {
                throw new KeyNotFoundException("User has not been added");
            }
            
            await AddUserClaims(addedUser.Uid, addedUser.Id);

            return _mapper.Map<User, UserDto>(addedUser);
        }
        
        private async Task AddUserClaims(string? uid, long? id)
        {
            if (uid is null || id is null)
            {
                return;
            }

            var userRecord = await _firebaseAuth.GetUserAsync(uid);

            if (userRecord.CustomClaims.ContainsKey("id"))
            {
                return;
            }
            
            var userClaims = new Dictionary<string, object>
            {
                { "id", id }
            };

            await _firebaseAuth.SetCustomUserClaimsAsync(uid, userClaims);
        }

        public string GetCurrentUserEmail()
        {
            var claimsList = _httpContextAccessor.HttpContext!.User.Claims.ToList();
            var email = claimsList.Find(el => el.Type == ClaimTypes.Email);
            return email!.Value;
        }

        public async Task<bool> ComparePassedIdAndCurrentUserIdAsync(long id)
        {
            var currentUserId = _httpContextAccessor.HttpContext.User.GetUid();

            var user = await _context.Users.FindAsync(id);

            return user?.Uid == currentUserId;
        }

        public async Task<ImagePathDto> UploadImageAsync(IFormFile file)
        {
            var imagePath = await _uploadFileService.UploadFileBlobAsync(file);

            var currentUser = await _context.Users.FirstOrDefaultAsync(u => u.Uid == GetCurrentUserId());

            if (currentUser is null)
            {
                throw new KeyNotFoundException("User doesn't exist");
            }

            currentUser.ImagePath = imagePath;

            _context.Users.Update(currentUser);
            await _context.SaveChangesAsync();
            return new ImagePathDto() { Path = imagePath };
        }

        private string? GetCurrentUserId()
        {
            var userId = _httpContextAccessor.HttpContext.User.GetUid();
            return userId;
        }
    }
}
