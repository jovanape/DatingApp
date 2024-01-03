namespace API.Entities;

public class AppUser
{
    // moramo jedno polje da nazovemo Id ili da dodamo [Key] iznad - Entity ga koristi kao PK u bazi
    public int Id { get; set; } // Entity framework needs it to be public - get and set
    public string UserName { get; set; } // C# is case sensitive

}
