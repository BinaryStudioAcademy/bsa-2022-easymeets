using EasyMeets.Core.Common.DTO.UploadImage;
using EasyMeets.Core.Common.DTO.User;
using EasyMeets.Core.Common.Enums;
using Microsoft.AspNetCore.Http;
namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IUserService
    {
        Task<bool> CheckExistingUserByEmail(string email);
        Task<UserDto> UpdateUserPreferences(UpdateUserDto userDto, string currentUserEmail);
        Task<UserDto> GetCurrentUserAsync();
        Task<UserDto> GetUserByPersonalLink(string link);
        Task<UserDto> CreateUserPreferences(NewUserDto userDto);
        Task<bool> ComparePassedIdAndCurrentUserIdAsync(long id);
        Task<ImagePathDto> UploadImageAsync(IFormFile file);
        Task<List<CredentialsType>> GetUserMeetIntegrations();
        Task<UserDto> GetUsersByEmailOrNameAsync(string searchData);
        string? GetCurrentUserId();
    }
}
