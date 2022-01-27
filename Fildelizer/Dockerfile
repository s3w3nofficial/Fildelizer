FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Fildelizer/Fildelizer.csproj", "Fildelizer/"]
RUN dotnet restore "Fildelizer/Fildelizer.csproj"
COPY . .
WORKDIR "/src/Fildelizer"
RUN dotnet build "Fildelizer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Fildelizer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Fildelizer.dll"]
