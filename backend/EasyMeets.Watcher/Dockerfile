FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["EasyMeets.Watcher/EasyMeets.Watcher.WebAPI/EasyMeets.Watcher.WebAPI.csproj", "EasyMeets.Watcher/EasyMeets.Watcher.WebAPI/"]
COPY ["EasyMeets.Watcher/EasyMeets.Watcher.BLL/EasyMeets.Watcher.BLL.csproj", "EasyMeets.Watcher/EasyMeets.Watcher.BLL/"]
COPY ["EasyMeets.RabbitMQ/EasyMeets.RabbitMQ.csproj", "EasyMeets.RabbitMQ/"]

RUN dotnet restore "EasyMeets.Watcher/EasyMeets.Watcher.WebAPI/EasyMeets.Watcher.WebAPI.csproj"
COPY . .
WORKDIR "/src/EasyMeets.Watcher/EasyMeets.Watcher.WebAPI"
RUN dotnet build "EasyMeets.Watcher.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EasyMeets.Watcher.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5060
ENTRYPOINT ["dotnet", "EasyMeets.Watcher.WebAPI.dll"]