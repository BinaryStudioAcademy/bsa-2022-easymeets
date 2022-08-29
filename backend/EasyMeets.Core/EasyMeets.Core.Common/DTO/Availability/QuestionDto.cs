namespace EasyMeets.Core.Common.DTO.Availability;

public class QuestionDto
{
    public long Id { get; set; }
    public string QuestionText { get; set; } = string.Empty;
    public bool IsMandatory { get; set; }
}