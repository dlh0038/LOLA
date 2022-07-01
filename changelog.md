# July 1
    dotnet add package Microsoft.EntityFrameworkCore
    dotnet add package Microsoft.EntityFrameworkCore.Sqlite
    dotnet add package Microsoft.EntityFrameworkCore.Design
    dotnet add package Microsoft.EntityFrameworkCore.Tools
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer #used for migration tool

    #create new SQLite DB using migration tool
    dotnet ef migrations add initialCreate
    dotnet ef database update #created database LOLA_DB.db
