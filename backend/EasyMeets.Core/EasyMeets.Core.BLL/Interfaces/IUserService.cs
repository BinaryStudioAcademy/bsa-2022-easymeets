using EasyMeets.Core.Common.DTO;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IUserService
    {
        public Task<UserDto> GetCurrentUserForAvailabilityPageAsync(int id);
    }
}
