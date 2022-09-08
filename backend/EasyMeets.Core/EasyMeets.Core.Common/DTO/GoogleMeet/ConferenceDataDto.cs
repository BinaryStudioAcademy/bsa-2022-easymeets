namespace EasyMeets.Core.Common.DTO.GoogleMeet;

public class ConferenceDataDto
{
    public CreateRequestDto CreateRequest { get; set; } = new();
    public string RequestId { get; set; } = Guid.NewGuid().ToString();
}