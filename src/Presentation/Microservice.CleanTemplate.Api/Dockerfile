FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Presentation/Microservice.CleanTemplate.Api/Microservice.CleanTemplate.Api.csproj", "src/Presentation/Microservice.CleanTemplate.Api/"]
RUN dotnet restore "src/Presentation/Microservice.CleanTemplate.Api/Microservice.CleanTemplate.Api.csproj"
COPY . .
WORKDIR "/src/src/Presentation/Microservice.CleanTemplate.Api"
RUN dotnet build "./Microservice.CleanTemplate.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Microservice.CleanTemplate.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Microservice.CleanTemplate.Api.dll"]
