# Build env
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Runtime env
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .
# ENTRYPOINT ["dotnet", "test-submodules-backend-netcore.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet test-submodules-backend-netcore.dll