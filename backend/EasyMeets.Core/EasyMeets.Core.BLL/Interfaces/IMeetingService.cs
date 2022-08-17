using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IMeetingService
    {
        public Task<List<Meeting>> GetMeetingsAsync();
    }
}
