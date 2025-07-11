using TeamManagement.Domain.SeedWork;

namespace TeamManagement.Domain.Entities;

public class Project : Entity
{
    public Project(int name, int teamLeadId, string[] assignedTeamMemberIds)
    {
        Name = name;
        TeamLeadId = teamLeadId;
        AssignedTeamMemberIds = assignedTeamMemberIds;
    }

    public int Name { get; private set; }
    public int TeamLeadId { get; private set; }
    public bool IsActive { get; private set; } = true;
    public DateTime DateCreated { get; private set; } = DateTime.Now;
    public string[] AssignedTeamMemberIds { get; set; }

}
 