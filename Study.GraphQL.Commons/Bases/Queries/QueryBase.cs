using AutoMapper;
using Study.GraphQL.Commons.Bases.Data.Repositories;
using Study.GraphQL.Commons.Bases.Entities;

namespace Study.GraphQL.Commons.Bases.Queries;

public interface IQueryBase<TOutput>
{
    TOutput? Get(Guid id);
    List<TOutput>? GetAll(int skip, int take);
}

public abstract class QueryBase<TEntity, TOutput>(IQueryRepositoryBase<TEntity> repository, IMapper mapper) : IQueryBase<TOutput>
    where TEntity : EntityBase
{
    public TOutput? Get(Guid id)
    {
        var model = repository.GetById(id);
        return model != null ? mapper.Map<TOutput>(model) : default;
    }

    public List<TOutput>? GetAll(int skip, int take)
    {
        var models = repository.GetAll(skip, take);
        return mapper.Map<List<TOutput>>(models);
    }
}