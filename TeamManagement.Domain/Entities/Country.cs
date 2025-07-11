using TeamManagement.Domain.SeedWork;

namespace TeamManagement.Domain.Entities;

public class Country : Entity
{
    public Country(string name, bool isActive)
    {
        Name = name;
        IsActive = isActive;
    }
    public string Name { get; private set; }
    public bool IsActive { get; private set; }
    
}