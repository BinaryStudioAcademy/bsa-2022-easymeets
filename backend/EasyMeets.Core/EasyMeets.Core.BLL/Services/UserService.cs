using AutoMapper;
using EasyMeets.Core.BLL.Extentions;
using EasyMeets.Core.BLL.Interfaces;
using EasyMeets.Core.Common.DTO.Credentials.Zoom;
using EasyMeets.Core.Common.DTO.User;
using EasyMeets.Core.Common.Enums;
using EasyMeets.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;
using EasyMeets.Core.DAL.Entities;
using Microsoft.AspNetCore.Http;
using EasyMeets.Core.Common.DTO.UploadImage;

namespace EasyMeets.Core.BLL.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IZoomService _zoomService;
        private readonly IUploadFileService _uploadFileService;
        public UserService(EasyMeetsCoreContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor,
            IUploadFileService uploadFileService, IZoomService zoomService) : base(context, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _zoomService = zoomService;
            _uploadFileService = uploadFileService;
        }

        public async Task<UserDto> GetCurrentUserAsync()
        {
            var currentUser = await GetCurrentUserInternalAsync();

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

        public async Task CreateZoomCredentials(NewCredentialsRequestDto newCredentialsRequestDto)
        {
            var user = await _context.Users.Include(u => u.Credentials)
                .FirstOrDefaultAsync(u => u.Uid == GetCurrentUserId());
            var credentialsDto = await _zoomService.GetNewCredentials(newCredentialsRequestDto);
            if (user!.Credentials.Any(cr => cr.Type == CredentialsType.Zoom))
            {
                var credentials = user.Credentials.First(cr => cr.Type == CredentialsType.Zoom);
                _mapper.Map(credentialsDto, credentials);
            }
            else
            {
                var credentials = _mapper.Map<Credentials>(credentialsDto, opts => opts.AfterMap((_, dest) =>
                {
                    dest.Type = CredentialsType.Zoom;
                    dest.UserId = user.Id;
                }));
                await _context.Credentials.AddAsync(credentials);
            }
            await _context.SaveChangesAsync();
        }

        private async Task<User> GetCurrentUserInternalAsync()
        {
            var currentUser = await _context.Users.FirstOrDefaultAsync(u => u.Uid == GetCurrentUserId());

            if (currentUser is null)
            {
                throw new KeyNotFoundException("User doesn't exist");
            }

            return currentUser;
        }
    }
}
