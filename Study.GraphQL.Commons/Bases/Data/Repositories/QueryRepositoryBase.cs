using Microsoft.EntityFrameworkCore;
using Study.GraphQL.Commons.Bases.Entities;

namespace Study.GraphQL.Commons.Bases.Data.Repositories;

public interface IQueryRepositoryBase<TEntity>
    where TEntity : EntityBase
{
    List<TEntity> GetAll(int skip, int take);
    TEntity? GetById(Guid id);
}

public abstract class QueryRepositoryBase<TEntity>(DbContextBase context) : IQueryRepositoryBase<TEntity>
    where TEntity : EntityBase
{
    public virtual List<TEntity> GetAll(int skip, int take)
    {
        return context.Set<TEntity>()
            .AsNoTracking()
            .Skip(skip)
            .Take(take)
            .ToList();
    }

    public virtual TEntity? GetById(Guid id)
    {
        return context.Set<TEntity>()
            .AsNoTracking()
            .FirstOrDefault(e => e.Id == id);
    }
}