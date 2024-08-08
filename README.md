# C# GraphQL Implementation 🎯

**This repository is a test project** that implements a GraphQL API using the HotChocolate library and the EntityFramework ORM with the Postgres database.
* GraphQL: https://graphql.org/
* HotChocolate: https://chillicream.com/docs/hotchocolate/v13
* EntityFramework: https://learn.microsoft.com/ef/

## Running the application 🏃‍♂️
To run the application we need to install some dependencies. Follow the instructions below.

### .NET 8 💻
This project runs on the .Net Core 8 compiler, you can follow the installation instructions here: https://dotnet.microsoft.com/download/dotnet/8.0

### EF Core ⚒️
As mentioned above, the application uses the EntityFramework ORM to communicate with the database. You need to have dotnet-ef installed on your machine. To do this, use the following command:
```ps1
dotnet tool install --global dotnet-ef
```
To check that the tool has been installed, run the command `dotnet ef`.

For more information, you can read the official EF Core documentation: https://learn.microsoft.com/ef/core/get-started/overview/install#get-the-net-core-cli-tools

### Docker 🐳
This repository offers a way to test the application with a Postgres database running in a Docker container. 
If you prefer to run the application on a Postgres instance without the need for a Docker container, you must change the Connection String to the correct instance 
[here](https://github.com/vithortinti/csharp-graphql-impl/blob/8f865c3bace4e05f5586fdc1f1937398f02d831b/Study.GraphQL/appsettings.json#L9).

To create the Docker container, in the root of the project there is a [`docker-compose`](https://github.com/vithortinti/csharp-graphql-impl/blob/main/docker-compose.yaml) file.

Run the `docker compose up -d` command pointing to the root of the project to create a container of a postgres instance.

After creating the container, we'll move on to creating the database.

### Create Database 🎲
To create the database, we will use the EF Core tool to update our database, creating the tables with their respective test data to use the API.

Run the following command in the root of the project:
```ps1
dotnet ef database update --project Study.GraphQL.Data/Study.GraphQL.Data.csproj --startup-project Study.GraphQL/Study.GraphQL.csproj --context Study.GraphQL.Data.Context.AppDbContext --configuration Debug 20240709071224_InitialMigration
```
If a "Build succeeded" message appears on your CLI, the database has been created successfully!

### Run 💨
Running the application is simple. In the root of the project run the command
```ps1
dotnet run --project ./Study.GraphQL/Study.GraphQL.csproj
```
to start the application or the `dotnet run` command with the CLI pointing to the project `Study.GraphQL`.

> To test the requests, the local link to be accessed is: `http://localhost:5139/graphql`.
