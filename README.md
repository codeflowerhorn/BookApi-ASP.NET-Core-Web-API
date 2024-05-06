# Add package(s)

```
1. dotnet add package Microsoft.EntityFrameworkCore.Sqlite
1.1 dotnet add package Microsoft.EntityFrameworkCore.SqlServer
1.2 dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
2. dotnet add package Microsoft.EntityFrameworkCore.Design
```

# Create database

```
0. dotnet tool install --global dotnet-ef
1. dotnet ef migrations add InitialCreate
2. dotnet ef database update
```

# Run the project
```
1. dotnet run
```
