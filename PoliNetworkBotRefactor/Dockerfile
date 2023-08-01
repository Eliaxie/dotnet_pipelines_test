FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["PoliNetworkBotRefactor/PoliNetworkBotRefactor.csproj", "PoliNetworkBotRefactor/"]
RUN dotnet restore "PoliNetworkBotRefactor/PoliNetworkBotRefactor.csproj"
COPY . .
WORKDIR "/src/PoliNetworkBotRefactor"
RUN dotnet build "PoliNetworkBotRefactor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PoliNetworkBotRefactor.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PoliNetworkBotRefactor.dll"]
