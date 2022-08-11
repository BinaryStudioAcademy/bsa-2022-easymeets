using EasyMeets.Core.Common.DTO.User;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IUserService
    {
        public Task<UserDto> GetCurrentUserAsync(int id);
    }
}
