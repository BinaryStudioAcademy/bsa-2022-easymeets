using EasyMeets.Core.DAL.Entities.Interface;

namespace EasyMeets.Core.DAL.Entities
{
    public abstract class Entity<T> : ISoftDeletable where T : struct
    {
        public T Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
