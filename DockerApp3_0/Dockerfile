FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
COPY . /app
WORKDIR /app
EXPOSE 80
ENTRYPOINT ["dotnet", "DockerApp3_0.dll"]