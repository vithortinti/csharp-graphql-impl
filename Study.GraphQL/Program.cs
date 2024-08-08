using Study.GraphQL.Data.IoC;
using Study.GraphQL.Persons.IoC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDataService();
builder.Services.AddPersonServices();

var app = builder.Build();

app.MapGraphQL();

app.Run();