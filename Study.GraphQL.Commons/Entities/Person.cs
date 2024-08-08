using Study.GraphQL.Commons.Bases;
using Study.GraphQL.Commons.Bases.Entities;

namespace Study.GraphQL.Commons.Entities;

public class Person : EntityBase
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required DateTime BirthDate { get; set; }
    
    public Guid AddressId { get; set; }
    public virtual Address Address { get; set; }
}