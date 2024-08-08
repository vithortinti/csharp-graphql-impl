using Microsoft.Extensions.DependencyInjection;
using Study.GraphQL.Persons.Configuration;
using Study.GraphQL.Persons.Data.Repositories;
using Study.GraphQL.Persons.Queries;

namespace Study.GraphQL.Persons.IoC;

public static class PersonDi
{
    public static void AddPersonServices(this IServiceCollection services)
    {
        services.AddGraphQLServer()
            .AddQueryType<PersonQuery>()
            .AddType<PersonQueryType>();

        services.AddAutoMapper(typeof(PersonDi).Assembly);
        
        services.AddScoped<IPersonQueryRepository, PersonQueryRepository>();
    }
}