using TeamManagement.Domain.SeedWork;

namespace TeamManagement.Domain.Entities;

public class ProjectTask  : Entity
{
    public int ProjectId { get; private set; }

    public ProjectTask(int projectId, string taskDescription, string priority, string[] assignedTo, DateTime fromDate)
    {
        ProjectId = projectId;
        TaskDescription = taskDescription;
        Priority = priority;
        AssignedTo = assignedTo;
        FromDate = fromDate;
    }

    public string TaskDescription { get; private set; }
    public string Priority { get; private set; }
    public string[] AssignedTo { get; private set; }

    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    public bool IsActive { get; private set; }
    public bool IsCompleted { get; private set; }
    public int CompletedRate { get; private set; }

    public  DateTime DateCreated { get; private set; } = DateTime.Now;

}
