using System.Text.Json.Serialization;

namespace EasyMeets.Core.Common.DTO.Zoom;

public class NewMeetingSettingsDto
{
    public bool AllowMultipleDevices { get; set; } = true;
    public int ApprovalType { get; set; } = 2;
    public ApprovedOrDeniedDto ApprovedOrDeniedCountiesOrRegions { get; set; } = new();
    public string ContactEmail { get; set; } = string.Empty;
    public string ContactName { get; set; } = string.Empty;
    public string EncryptionType { get; set; } = "enhanced_encryption";
    [JsonPropertyName("jbh_time")] 
    public int JoinBeforeHostTime { get; set; } = 0;
    public bool JoinBeforeHost { get; set; } = true;
    public bool MeetingAuthentication { get; set; } = false;
}