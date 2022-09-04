using EasyMeets.Core.Common.DTO.ExternalAttendee;

namespace EasyMeets.Core.BLL.Interfaces;

public interface IExternalAttendeeService
{
    Task SaveExternalAttendeeAsync(ExternalAttendeeDto externalAttendeeDto);
}