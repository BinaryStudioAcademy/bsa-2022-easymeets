namespace EasyMeets.Core.BLL.Interfaces
{
    public interface IInformQueueService : IDisposable
    {
        void InformEveryone(string message);
    }
}
