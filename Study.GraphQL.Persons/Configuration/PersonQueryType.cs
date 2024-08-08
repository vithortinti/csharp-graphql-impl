using HotChocolate.Types;
using Study.GraphQL.Persons.Queries;

namespace Study.GraphQL.Persons.Configuration;

public class PersonQueryType : ObjectType<PersonQuery>
{
    protected override void Configure(IObjectTypeDescriptor<PersonQuery> descriptor)
    {
        descriptor.Field(x => x.Get(default)).Name("person");
        descriptor.Field(x => x.GetAll(default, default)).Name("persons");
    }
}