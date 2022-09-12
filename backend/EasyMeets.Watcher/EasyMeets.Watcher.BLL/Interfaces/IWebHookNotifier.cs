namespace EasyMeets.Watcher.BLL.Interfaces
{
    public interface IWebHookNotifier
    {
        public void NotifyCalendarChanges(string message);
    }
}
