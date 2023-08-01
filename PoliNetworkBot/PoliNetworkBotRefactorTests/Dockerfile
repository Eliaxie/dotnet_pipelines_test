FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["PoliNetworkBotRefactorTests/PoliNetworkBotRefactorTests.csproj", "PoliNetworkBotRefactorTests/"]
RUN dotnet restore "PoliNetworkBotRefactorTests/PoliNetworkBotRefactorTests.csproj"
COPY . .
WORKDIR "/src/PoliNetworkBotRefactorTests"
RUN dotnet build "PoliNetworkBotRefactorTests.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PoliNetworkBotRefactorTests.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PoliNetworkBotRefactorTests.dll"]
