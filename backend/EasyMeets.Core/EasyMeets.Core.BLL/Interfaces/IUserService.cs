using EasyMeets.Core.Common.DTO.User; 
namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IUserService
    {
        Task UpdateUserPreferences(UserDto userDto, string currentUserEmail); 
        Task<UserDto> GetCurrentUserAsync(string currentUserEmail);
    }
}
