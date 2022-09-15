namespace EasyMeets.Core.DAL.Entities
{
    public class SyncGoogleCalendar : Entity<long>
    {
        public string Email { get; set; } = string.Empty;
        public DateTime ExpiredDate { get; set; }
    }
}
