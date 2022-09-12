using EasyMeets.Core.Common.DTO.Availability.Schedule.ExclusionDate.DayTimeRange;

namespace EasyMeets.Core.Common.DTO.Availability.Schedule.ExclusionDate;

public class ExclusionDateDto
{
    public long Id { get; set; }
    public DateTime SelectedDate { get; set; }
    public List<DayTimeRangeDto> DayTimeRanges { get; set; } = new();
}