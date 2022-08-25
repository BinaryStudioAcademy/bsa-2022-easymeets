using EasyMeets.Core.Common.DTO.User;
namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IUserService
    {
        Task<bool> CheckExistingUserByEmail(string email);
        Task UpdateUserPreferences(UserDto userDto, string currentUserEmail);
        Task<UserDto> GetCurrentUserAsync();
        Task<UserDto> CreateUserPreferences(NewUserDto userDto);
        Task<bool> ComparePassedIdAndCurrentUserIdAsync(long id);
    }
}
