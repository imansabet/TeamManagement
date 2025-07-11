using TeamManagement.Domain.SeedWork;

namespace TeamManagement.Domain.Entities;

public class ProjectTask  : Entity
{

    public enum PRIORITY 
    {
        High,
        Medium,
        Low
    }

    public ProjectTask(int projectId, string taskDescription, PRIORITY priority, string[] assignedTo, DateTime fromDate, bool isCompleted, DateTime toDate)
    {
        ProjectId = projectId;
        TaskDescription = taskDescription;
        Priority = nameof(priority);
        AssignedTo = assignedTo;
        FromDate = fromDate;
        IsCompleted = isCompleted;
        ToDate = toDate;
    }
    public int ProjectId { get; private set; }

    public string TaskDescription { get; private set; }
    public string Priority { get; private set; }
    public string[] AssignedTo { get; private set; }

    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    public bool IsActive { get; private set; }
    public bool IsCompleted { get; private set; }
    //public int CompletedRate { get; private set; }

    public  DateTime DateCreated { get; private set; } = DateTime.Now;

}
