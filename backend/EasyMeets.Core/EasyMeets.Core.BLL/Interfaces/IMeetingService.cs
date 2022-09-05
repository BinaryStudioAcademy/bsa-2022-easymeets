﻿using EasyMeets.Core.Common.DTO.Meeting;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IMeetingService
    { 
        public Task<List<MeetingThreeMembersDTO>> GetThreeMeetingMembersAsync(long? teamId);
        Task<List<UserMeetingDTO>> GetAllMembers(int id);
        Task<SaveMeetingDto> CreateMeeting(SaveMeetingDto meetingDto);
    }
}
