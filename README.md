# Add package(s)

```
# Ubuntu
1. dotnet add package Microsoft.EntityFrameworkCore.Sqlite
2. dotnet add package Microsoft.EntityFrameworkCore.SqlServer
3. dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
4. dotnet add package Microsoft.EntityFrameworkCore.Design

# Windows
# Tools > NuGet Package Manager > Package Manager Console
1. Install-Package package Microsoft.EntityFrameworkCore.Sqlite
2. Install-Package package Microsoft.EntityFrameworkCore.SqlServer
3. Install-Package package Npgsql.EntityFrameworkCore.PostgreSQL
4. Install-Package package Microsoft.EntityFrameworkCore.Design
```

# Create database

```
# Ubuntu
1. dotnet tool install --global dotnet-ef
2. dotnet ef migrations add InitialCreate
3. dotnet ef database update

# Windows
# Tools > NuGet Package Manager > Package Manager Console
1. Install-Package Microsoft.EntityFrameworkCore.Tools
2. Add-Migration InitialCreate
3. Update-Database
```

# Run the project
```
1. dotnet run
```
