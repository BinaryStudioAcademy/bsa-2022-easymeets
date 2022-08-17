using EasyMeets.Core.Common.DTO.User; 
namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IUserService
    {
        Task<UserDto?> GetUserPreferences(long userId, string currentUserEmail);
        Task UpdateUserPreferences(UserDto userDto, string currentUserEmail);
        Task<UserDto> GetCurrentUserAsync(string currentUserEmail);
    }
}
