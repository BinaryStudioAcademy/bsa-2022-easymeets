using EasyMeets.Core.Common.DTO.Common;

namespace EasyMeets.Core.Common.DTO.User;

public class ExternalUserDto : EntityDto<long>
{
    public string UserName { get; set; } = string.Empty;
    public string? Image { get; set; }
    public string PersonalLink { get; set; } = string.Empty;
}