using EasyMeets.Core.Common.DTO.Meeting;
using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IMeetingService
    {
        Task<List<MeetingSlotDTO>> GetMeetingsAsync(MeetingMemberRequestDto meetingMemberRequestDto);
        Task<List<UserMeetingDTO>> GetAllMembers(long id);
        Task<List<OrderedMeetingTimesDto>> GetOrderedMeetingTimesAsync(long slotId);
        Task<SaveMeetingDto> CreateMeeting(SaveMeetingDto meetingDto);
        Task<long> CreateExternalAttendeeMeeting(ExternalAttendeeMeetingDto meetingDto);
        Task SendEmailsAsync(long meetingId, TemplateType type);
        Task DeleteMeeting(long meetingId);
        Task<MeetingSlotDTO> GetMeetingByIdAsync(long id);
        Task<SaveMeetingDto> UpdateMeetingAsync(SaveUpdateMeetingDto updateMeetingDto);
    }
}
