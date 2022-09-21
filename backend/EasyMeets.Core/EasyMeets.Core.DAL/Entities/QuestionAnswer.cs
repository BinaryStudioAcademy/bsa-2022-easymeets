namespace EasyMeets.Core.DAL.Entities
{
    public class QuestionAnswer : Entity<long>
    {
        public string Answer { get; set; } = string.Empty;

        public long QuestionId { get; set; }
        public Question Question { get; set; } = null!;

        public long MeetingId { get; set; }
        public Meeting Meeting { get; set; } = null!;
    }
}
