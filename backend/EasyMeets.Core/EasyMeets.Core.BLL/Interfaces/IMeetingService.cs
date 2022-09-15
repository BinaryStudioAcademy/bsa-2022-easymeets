using EasyMeets.Core.Common.DTO.Calendar;
using EasyMeets.Core.Common.DTO.Meeting;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IMeetingService
    {
        Task<List<MeetingSlotDTO>> GetMeetingsAsync(MeetingMemberRequestDto meetingMemberRequestDto);
        Task<List<UserMeetingDTO>> GetAllMembers(int id);
        Task<List<OrderedMeetingTimesDto>> GetOrderedMeetingTimesAsync(long slotId);
        Task<SaveMeetingDto> CreateMeeting(SaveMeetingDto meetingDto);
        Task<long> CreateExternalAttendeeMeeting(ExternalAttendeeMeetingDto meetingDto);
        Task SendConfirmationEmailsAsync(long meetingId);
        Task DeleteMeeting(long meetingId);
    }
}
