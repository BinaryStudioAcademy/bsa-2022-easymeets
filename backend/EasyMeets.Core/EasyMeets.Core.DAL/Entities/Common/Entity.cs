namespace EasyMeets.Core.DAL.Entities
{
    public abstract class Entity<T> where T : struct
    {
        public T Id { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
