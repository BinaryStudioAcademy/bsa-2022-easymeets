namespace EasyMeets.Core.DAL.Entities;

public class Location : AuditEntity<int>
{
    public string Name { get; set; } = string.Empty;
}
