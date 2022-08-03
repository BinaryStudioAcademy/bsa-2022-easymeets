using AutoMapper;
using EasyMeets.Core.DAL.Context;

namespace EasyMeets.Core.BLL.Services
{
    public abstract class BaseService
    {
        private protected readonly EasyMeetsCoreContext _context;
        private protected readonly IMapper _mapper;

        public BaseService(EasyMeetsCoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
