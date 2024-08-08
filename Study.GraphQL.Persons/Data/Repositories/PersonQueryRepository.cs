using Study.GraphQL.Commons.Bases.Data;
using Study.GraphQL.Commons.Bases.Data.Repositories;
using Study.GraphQL.Commons.Entities;

namespace Study.GraphQL.Persons.Data.Repositories;

public interface IPersonQueryRepository : IQueryRepositoryBase<Person>;

public class PersonQueryRepository(DbContextBase context)
    : QueryRepositoryBase<Person>(context), IPersonQueryRepository;