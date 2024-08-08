namespace Study.GraphQL.Persons.Queries.Dtos;

public class AddressDto
{
    public required string City { get; set; }
    public required string State { get; set; }
    public required string Country { get; set; }
    public required string Street { get; set; }
    public string? Complement { get; set; }
    public required string ZipCode { get; set; }
}