FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Admin.Tab/Admin.Tab.csproj", "Admin.Tab/"]
RUN dotnet restore "Admin.Tab/Admin.Tab.csproj"
COPY . .
WORKDIR "/src/Admin.Tab"
RUN dotnet build "Admin.Tab.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Admin.Tab.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Admin.Tab.dll"]
