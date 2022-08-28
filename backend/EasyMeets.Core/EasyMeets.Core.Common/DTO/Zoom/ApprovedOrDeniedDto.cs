namespace EasyMeets.Core.Common.DTO.Zoom;

public class ApprovedOrDeniedDto
{
    public string[] ApprovedList { get; set; } = Array.Empty<string>();
    public string[] DeniedList { get; set; } = { "RU" };
    public bool Enable { get; set; } = true;
    public string Method { get; set; } = "deny";
}