using EasyMeets.Core.Common.DTO.Calendar;
using EasyMeets.Core.Common.DTO.Meeting;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IMeetingService
    { 
        public Task<List<MeetingThreeMembersDTO>> GetThreeMeetingMembersAsync(long? teamId);
        Task<List<UserMeetingDTO>> GetAllMembers(int id);
        Task CreateMeeting(SaveMeetingDto meetingDto);
        Task DeleteGoogleCalendarMeetings(long teamId);
        Task AddGoogleCalendarMeetings(long teamId, List<EventItemDTO> eventItemDTOs, long userId);
    }
}
