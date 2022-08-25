using EasyMeets.Core.Common.DTO.Meeting;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IMeetingService
    {
        Task<List<MeetingThreeMembersDTO>> GetThreeMeetingMembersAsync();
        Task<List<UserMeetingDTO>> GetAllMembers(int id);
        Task CreateMeeting(SaveMeetingDto meetingDto);
    }
}
