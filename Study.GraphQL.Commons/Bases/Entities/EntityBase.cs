using System.ComponentModel.DataAnnotations;

namespace Study.GraphQL.Commons.Bases.Entities;

public abstract class EntityBase
{
    [Key]
    public Guid Id { get; set; }
}