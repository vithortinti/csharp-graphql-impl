using AutoMapper;
using Study.GraphQL.Commons.Entities;
using Study.GraphQL.Persons.Queries.Dtos;

namespace Study.GraphQL.Persons.Configuration;

public class PersonProfile : Profile
{
    public PersonProfile()
    {
        CreateMap<Person, PersonDto>();
        CreateMap<Address, AddressDto>();
    }
}