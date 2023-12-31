#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Microservices/Stadium/Api/Socca.Stadium.Api/Socca.Stadium.Api.csproj", "src/Microservices/Stadium/Api/Socca.Stadium.Api/"]
COPY ["src/Infrastructure/Socca.Infrastructure/Socca.Infrastructure.csproj", "src/Infrastructure/Socca.Infrastructure/"]
COPY ["src/Domain/Socca.Domain.Core/Socca.Domain.Core.csproj", "src/Domain/Socca.Domain.Core/"]
COPY ["src/Microservices/Stadium/Data/Socca.Stadium.Data/Socca.Stadium.Data.csproj", "src/Microservices/Stadium/Data/Socca.Stadium.Data/"]
COPY ["src/Microservices/Stadium/Domain/Socca.Stadium.Domain/Socca.Stadium.Domain.csproj", "src/Microservices/Stadium/Domain/Socca.Stadium.Domain/"]
RUN dotnet restore "src/Microservices/Stadium/Api/Socca.Stadium.Api/Socca.Stadium.Api.csproj"
COPY . .
WORKDIR "/src/src/Microservices/Stadium/Api/Socca.Stadium.Api"
RUN dotnet build "Socca.Stadium.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Socca.Stadium.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Socca.Stadium.Api.dll"]
