using EasyMeets.Core.Common.DTO.User; 
namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IUserService
    {
        Task<UserDto?> GetUserPreferences(long userId, string currentUserEmail);
        Task UpdateUserPreferences(UserDto userDto, string requestedEmail);
        Task<UserDto> GetCurrentUserAsync(long id, string currentUserEmail);
    }
}
