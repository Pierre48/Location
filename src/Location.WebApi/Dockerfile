FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["Location.WebApi/Location.WebApi.csproj", "Location.WebApi/"]
RUN dotnet restore "Location.WebApi/Location.WebApi.csproj"
COPY . .
WORKDIR "Location.WebApi"
RUN dotnet build "Location.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Location.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Location.WebApi.dll"]
