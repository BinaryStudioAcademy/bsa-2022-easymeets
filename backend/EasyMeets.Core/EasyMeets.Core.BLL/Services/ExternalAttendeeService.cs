using AutoMapper;
using EasyMeets.Core.DAL.Context;

namespace EasyMeets.Core.BLL.Services;

public class ExternalAttendeeService : BaseService
{
    public ExternalAttendeeService(EasyMeetsCoreContext context, IMapper mapper) : base(context, mapper) { }
    
}