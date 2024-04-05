```
cd D:\Source\Youtube-SourceCode\Development\006- Clean Architecture\Librarian\Session 08\Infrastructure\Librarian.Persistence

dotnet tool install dotnet-ef -g

dotnet ef migrations add init --help

dotnet ef migrations add init -s ..\..\API\Librarian.api\Librarian.api.csproj

dotnet ef database update -s ..\..\API\Librarian.api\Librarian.api.csproj
```