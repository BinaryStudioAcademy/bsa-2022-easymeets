FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["EasyMeets.Notifier/EasyMeets.Notifier.WebAPI/EasyMeets.Notifier.WebAPI.csproj", "EasyMeets.Notifier/EasyMeets.Notifier.WebAPI/"]
COPY ["EasyMeets.Core/EasyMeets.Core.Common/EasyMeets.Core.Common.csproj", "EasyMeets.Core/EasyMeets.Core.Common/"]

RUN dotnet restore "EasyMeets.Notifier/EasyMeets.Notifier.WebAPI/EasyMeets.Notifier.WebAPI.csproj"
COPY . .
WORKDIR "/src/EasyMeets.Notifier/EasyMeets.Notifier.WebAPI"
RUN dotnet build "EasyMeets.Notifier.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EasyMeets.Notifier.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5070
ENTRYPOINT ["dotnet", "EasyMeets.Notifier.WebAPI.dll"]