namespace EasyMeets.Core.DAL.Entities;

public class TeamMemberMeeting
{
    public int UserTeamId { get; set; }
    public int EventId { get; set; }
    public int Priority { get; set; }
    
    public Team UserTeam { get; }
    public Meeting Event { get; set; }
}
