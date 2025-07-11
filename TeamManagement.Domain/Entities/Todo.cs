using TeamManagement.Domain.SeedWork;

namespace TeamManagement.Domain.Entities;

public class Todo : Entity
{
    public Todo(int projecTasktId, int teamMemberId, string title, string description)
    {
        ProjecTasktId = projecTasktId;
        TeamMemberId = teamMemberId;
        Title = title;
        Description = description;
    }
    public int ProjecTasktId { get; private set; }
    public int TeamMemberId { get;  set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public bool IsCompleted { get; private set; } = false;
    public DateTime DateCreated { get; private set; } = DateTime.Now;

}
 