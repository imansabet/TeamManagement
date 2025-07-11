using TeamManagement.Domain.SeedWork;

namespace TeamManagement.Domain.Entities;

public class Notification : Entity
{
    public Notification(int userId, string role, string title, string description)
    {
        UserId = userId;
        Role = role;
        Title = title;
        Description = description;
    }
    public int UserId { get; private set; }

    public string Role { get; set; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateTime DateCreated { get; private set; } = DateTime.Now;
}
