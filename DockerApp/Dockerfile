FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim
COPY . /app
WORKDIR /app
EXPOSE 80
ENTRYPOINT ["dotnet", "DockerApp.dll"]