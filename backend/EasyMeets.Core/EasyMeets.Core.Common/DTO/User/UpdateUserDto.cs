using EasyMeets.Core.Common.DTO.Common;
using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.Common.DTO.User;

public class UpdateUserDto : EntityDto<long>
{
    public string UserName { get; set; } = string.Empty;
    public Language Language { get; set; }
    public TimeFormat TimeFormat { get; set; }
    public DateFormat DateFormat { get; set; }
    public Country? Country { get; set; }
    public string? PhoneCode { get; set; }
    public string? Phone { get; set; }
    public TimeZoneDto TimeZone { get; set; } = null!;
}