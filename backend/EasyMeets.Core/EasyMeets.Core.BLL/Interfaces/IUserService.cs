using EasyMeets.Core.Common.DTO.User; 
namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IUserService
    {
        Task<UserDto?> GetUserPreferences(long userId);
        Task UpdateUserPreferences(UserDto user);
        Task<UserDto> GetCurrentUserAsync(int id);
    }
}
