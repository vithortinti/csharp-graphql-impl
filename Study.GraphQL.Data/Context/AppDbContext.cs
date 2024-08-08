using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Study.GraphQL.Commons.Bases.Data;
using Study.GraphQL.Commons.Entities;

namespace Study.GraphQL.Data.Context;

public class AppDbContext(IConfiguration configuration) : DbContextBase
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Address> Addresses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(configuration["ConnectionStrings:DefaultConnection"]);
        optionsBuilder.UseLazyLoadingProxies();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}