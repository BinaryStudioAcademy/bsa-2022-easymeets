using EasyMeets.Core.Common.DTO.User;
using Microsoft.AspNetCore.Http;
namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IUserService
    {
        Task<bool> CheckExistingUserByEmail(string email);
        Task UpdateUserPreferences(UserDto userDto, string currentUserEmail);
        Task<UserDto> GetCurrentUserAsync();
        Task<UserDto> CreateUserPreferences(NewUserDto userDto);
        string GetCurrentUserEmail();
        Task<bool> ComparePassedIdAndCurrentUserIdAsync(long id);
        Task<string> UploadImageAsync(IFormFile file);
    }
}
