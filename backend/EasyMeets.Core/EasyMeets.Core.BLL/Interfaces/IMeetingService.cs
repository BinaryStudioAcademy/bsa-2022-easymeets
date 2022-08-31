using EasyMeets.Core.Common.DTO.Meeting;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IMeetingService
    {
        Task<List<MeetingSlotDTO>> GetMeetingMembersByNumberOfMembersToDisplayAsync(long? teamId, int numberOfMembers);
        Task<List<UserMeetingDTO>> GetAllMembers(int id);
        Task CreateMeeting(SaveMeetingDto meetingDto);
    }
}
