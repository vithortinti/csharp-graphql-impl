namespace Study.GraphQL.Persons.Queries.Dtos;

public class PersonDto
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required DateTime BirthDate { get; set; }
    public required AddressDto Address { get; set; }
}