FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TurboAzMVC/TurboAzMVC.csproj", "TurboAzMVC/"]
RUN dotnet restore "TurboAzMVC/TurboAzMVC.csproj"
COPY . .
WORKDIR "/src/TurboAzMVC"
RUN dotnet build "TurboAzMVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TurboAzMVC.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TurboAzMVC.dll"]
