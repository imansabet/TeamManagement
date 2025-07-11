using TeamManagement.Domain.SeedWork;

namespace TeamManagement.Domain.Entities;

public class TeamLead : Entity
{
    public TeamLead
        (int countryId ,
        string email ,
        string firstname ,
        string lastname ,
        string password)
    {
        CountryId = countryId ;
        Email = email ;
        FirstName = firstname ;
        LastName = lastname ;
        Password = password ;
    }

    public int CountryId { get; private set; }
    public string Email { get;private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Password { get; private set; }
    public bool IsActive { get; private set; } = true;
    public DateTime DateCreated { get; private set; } = DateTime.Now;
    public string Role { get; private set; } = "TEAMLEAD";
}
