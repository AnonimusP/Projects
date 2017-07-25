# Projects

Known issues:
Unable to load GamesStore.
It's code-first based .NET Core 1.1 application so first you need to go into Tools > NuGet Package Manager > Package Manager Console
and type in console "Install-Package Microsoft.EntityFrameworkCore.Tools" and after that type "Update-Database". After that - it should works
