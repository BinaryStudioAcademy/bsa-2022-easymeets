using EasyMeets.Core.Common.DTO.Meeting;
using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IMeetingService
    {
        Task<List<MeetingSlotDTO>> GetMeetingMembersByNumberOfMembersToDisplayAsync(long? teamId, int numberOfMembers);
        Task<List<UserMeetingDTO>> GetAllMembers(int id);
        Task<List<OrderedMeetingTimesDto>> GetOrderedMeetingTimesAsync(long slotId);
        Task<SaveMeetingDto> CreateMeeting(SaveMeetingDto meetingDto);
        Task<long> CreateExternalAttendeeMeeting(ExternalAttendeeMeetingDto meetingDto);
        Task SendEmailsAsync(long meetingId, TemplateType type);
        Task DeleteMeeting(long meetingId);
    }
}
