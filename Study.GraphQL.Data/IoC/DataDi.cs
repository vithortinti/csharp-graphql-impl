using Microsoft.Extensions.DependencyInjection;
using Study.GraphQL.Commons.Bases.Data;
using Study.GraphQL.Data.Context;

namespace Study.GraphQL.Data.IoC;

public static class DataDi
{
    public static void AddDataService(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>();
        services.AddSingleton<DbContextBase, AppDbContext>();
    }
}