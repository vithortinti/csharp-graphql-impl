using Study.GraphQL.Commons.Bases;
using Study.GraphQL.Commons.Bases.Entities;

namespace Study.GraphQL.Commons.Entities;

public class Address : EntityBase
{
    public required string City { get; set; }
    public required string State { get; set; }
    public required string Country { get; set; }
    public required string Street { get; set; }
    public string? Complement { get; set; }
    public required string ZipCode { get; set; }
    
    public virtual ICollection<Person> Persons { get; set; }
}