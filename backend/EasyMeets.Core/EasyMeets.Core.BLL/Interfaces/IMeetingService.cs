using EasyMeets.Core.Common.DTO.Meeting;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IMeetingService
    {
        public Task<List<MeetingBookingsDTO>> GetThreeMeetingsForBookingsAsync();
    }
}
