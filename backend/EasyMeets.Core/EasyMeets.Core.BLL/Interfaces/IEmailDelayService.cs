using EasyMeets.Core.Common.Enums;

namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IEmailDelayService
    {
        public Task CheckForNotify(TemplateType templateType, DateTime lastSentTime);
    }
}
