using AutoMapper;
using EasyMeets.Core.BLL.Extentions;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.User;
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;
using EasyMeets.Core.DAL.Entities;
using Microsoft.AspNetCore.Http;
using EasyMeets.Core.Common.DTO.UploadImage;
using FirebaseAdmin.Auth;

namespace EasyMeets.Core.BLL.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUploadFileService _uploadFileService;
        private readonly ITeamSharedService _teamSharedService;
        private readonly FirebaseAuth _firebaseAuth;

        public UserService(EasyMeetsCoreContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor,
            IUploadFileService uploadFileService, ITeamSharedService teamSharedService, FirebaseAuth firebaseAuth) : base(context, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _uploadFileService = uploadFileService;
            _teamSharedService = teamSharedService;
            _firebaseAuth = firebaseAuth;
        }

        public async Task<UserDto> GetCurrentUserAsync()
        {
            var currentUser = await GetCurrentUserInternalAsync();

            await AddUserClaims(currentUser.Uid, currentUser.Id);

            var currentUserDto = _mapper.Map<UserDto>(currentUser);
            return currentUserDto;
        }

        public async Task<bool> CheckExistingUserByEmail(string email)
        {
            return await _context.Users.AnyAsync(u => u.Email == email);
        }

        public async Task<UserDto> UpdateUserPreferences(UpdateUserDto userDto, string currentUserEmail)
        {
            var userEntity = await GetUserById(userDto.Id);
            userEntity = _mapper.Map(userDto, userEntity);

            if (userEntity.Email != currentUserEmail)
            {
                throw new ArgumentException("You don't have access to data of other users");
            }

            _context.Users.Update(userEntity);
            await _context.SaveChangesAsync();

            return _mapper.Map<UserDto>(userEntity);
        }

        public async Task<UserDto> GetUserByPersonalLink(string link)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.PersonalUrl == link) ?? throw new KeyNotFoundException("User doesn't exist");

            return _mapper.Map<UserDto>(user);
        }

        private async Task<User> GetUserById(long id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id) ?? throw new KeyNotFoundException("User doesn't exist");
        }

        public async Task<UserDto> CreateUserPreferences(NewUserDto userDto)
        {
            if (userDto is null)
            {
                throw new ArgumentNullException(nameof(userDto), "New user cannot be null");
            }

            var userEntity = await _context.Users.FirstOrDefaultAsync(u => u.Email.Equals(userDto.Email));
            if (userEntity is not null)
            {
                return _mapper.Map<UserDto>(userEntity);
            }

            var newUser = _mapper.Map<NewUserDto, User>(userDto);
            var user = _context.Users.Add(newUser).Entity;
            await _context.SaveChangesAsync();

            await _teamSharedService.CreateDefaultUsersTeamAsync(user);

            await AddUserClaims(user.Uid, user.Id);

            return _mapper.Map<User, UserDto>(user);
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

        public string? GetCurrentUserId()
        {
            var userId = _httpContextAccessor.HttpContext.User.GetUid();
            return userId;
        }

        private Task<User> GetCurrentUserInternalAsync()
            => (_context.Users.FirstOrDefaultAsync(u => u.Uid == GetCurrentUserId())
                ?? throw new KeyNotFoundException("User doesn't exist"))!;
    }
}
