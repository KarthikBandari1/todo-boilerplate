FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/todo3.Web.Host/todo3.Web.Host.csproj", "src/todo3.Web.Host/"]
COPY ["src/todo3.Web.Core/todo3.Web.Core.csproj", "src/todo3.Web.Core/"]
COPY ["src/todo3.Application/todo3.Application.csproj", "src/todo3.Application/"]
COPY ["src/todo3.Core/todo3.Core.csproj", "src/todo3.Core/"]
COPY ["src/todo3.EntityFrameworkCore/todo3.EntityFrameworkCore.csproj", "src/todo3.EntityFrameworkCore/"]
WORKDIR "/src/src/todo3.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/todo3.Web.Host", "src/todo3.Web.Host"]
COPY ["src/todo3.Web.Core", "src/todo3.Web.Core"]
COPY ["src/todo3.Application", "src/todo3.Application"]
COPY ["src/todo3.Core", "src/todo3.Core"]
COPY ["src/todo3.EntityFrameworkCore", "src/todo3.EntityFrameworkCore"]
WORKDIR "/src/src/todo3.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "todo3.Web.Host.dll"]
