using EasyMeets.Core.Common.DTO.Credentials.Zoom;
using EasyMeets.Core.Common.DTO.UploadImage;
using EasyMeets.Core.Common.DTO.User;
using Microsoft.AspNetCore.Http;
namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IUserService
    {
        Task<bool> CheckExistingUserByEmail(string email);
        Task<UserDto> UpdateUserPreferences(UpdateUserDto userDto, string currentUserEmail);
        Task<UserDto> GetCurrentUserAsync();
        Task<UserDto> CreateUserPreferences(NewUserDto userDto);
        Task<bool> ComparePassedIdAndCurrentUserIdAsync(long id);
        Task<ImagePathDto> UploadImageAsync(IFormFile file);
        Task CreateZoomCredentials(NewCredentialsRequestDto newCredentialsRequestDto);
        Task<long> GetIdFromClaims(string uid);
    }
}
