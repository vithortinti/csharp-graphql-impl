using AutoMapper;
using Study.GraphQL.Commons.Bases.Queries;
using Study.GraphQL.Commons.Entities;
using Study.GraphQL.Persons.Data.Repositories;
using Study.GraphQL.Persons.Queries.Dtos;

namespace Study.GraphQL.Persons.Queries;

public class PersonQuery(IPersonQueryRepository repository, IMapper mapper) 
    : QueryBase<Person, PersonDto>(repository, mapper);