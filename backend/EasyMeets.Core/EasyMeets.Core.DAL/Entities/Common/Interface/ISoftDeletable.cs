namespace EasyMeets.Core.DAL.Entities.Interface;

public interface ISoftDeletable
{
    bool IsDeleted { get; set; }
}