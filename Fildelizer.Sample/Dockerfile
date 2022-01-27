FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Fildelizer.Sample/Fildelizer.Sample.csproj", "Fildelizer.Sample/"]
RUN dotnet restore "Fildelizer.Sample/Fildelizer.Sample.csproj"
COPY . .
WORKDIR "/src/Fildelizer.Sample"
RUN dotnet build "Fildelizer.Sample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Fildelizer.Sample.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fildelizer.Sample.dll"]
