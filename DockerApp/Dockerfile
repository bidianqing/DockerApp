FROM mcr.microsoft.com/dotnet/aspnet:8.0
COPY . /app
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:5077
EXPOSE 5077
ENTRYPOINT ["dotnet", "DockerApp.dll"]