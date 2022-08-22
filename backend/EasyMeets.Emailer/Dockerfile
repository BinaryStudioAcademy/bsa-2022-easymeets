FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["EasyMeets.Emailer/EasyMeets.Emailer.WebAPI/EasyMeets.Emailer.WebAPI.csproj", "EasyMeets.Emailer/EasyMeets.Emailer.WebAPI/"]
RUN dotnet restore "EasyMeets.Emailer/EasyMeets.Emailer.WebAPI/EasyMeets.Emailer.WebAPI.csproj"
COPY . .
WORKDIR "/src/EasyMeets.Emailer/EasyMeets.Emailer.WebAPI"
RUN dotnet build "EasyMeets.Emailer.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EasyMeets.Emailer.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5090
ENTRYPOINT ["dotnet", "EasyMeets.Emailer.dll"]