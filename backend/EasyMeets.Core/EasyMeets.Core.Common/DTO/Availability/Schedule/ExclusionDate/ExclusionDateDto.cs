using EasyMeets.Core.Common.DTO.Availability.Schedule.ExclusionDate.DayTimeRange;

namespace EasyMeets.Core.Common.DTO.Availability.Schedule.ExclusionDate;

public class ExclusionDateDto
{
    public DateTime SelectedDate { get; set; }
    public List<DayTimeRangeDto> DayTimeRanges { get; set; } = new();
}