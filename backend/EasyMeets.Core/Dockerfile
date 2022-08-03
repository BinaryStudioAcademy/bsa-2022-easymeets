FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
ARG PROJECT_PORT
WORKDIR /app
EXPOSE $PROJECT_PORT

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["EasyMeets.Core/EasyMeets.Core.WebAPI/EasyMeets.Core.WebAPI.csproj", "EasyMeets.Core/EasyMeets.Core.WebAPI/"]
COPY ["EasyMeets.Core/EasyMeets.Core.BLL/EasyMeets.Core.BLL.csproj", "EasyMeets.Core/EasyMeets.Core.BLL/"]
COPY ["EasyMeets.Core/EasyMeets.Core.DAL/EasyMeets.Core.DAL.csproj", "EasyMeets.Core/EasyMeets.Core.DAL/"]
COPY ["EasyMeets.Core/EasyMeets.Core.Common/EasyMeets.Core.Common.csproj", "EasyMeets.Core/EasyMeets.Core.Common/"]

RUN dotnet restore "EasyMeets.Core/EasyMeets.Core.WebAPI/EasyMeets.Core.WebAPI.csproj"
COPY . .
WORKDIR "/src/EasyMeets.Core/EasyMeets.Core.WebAPI"
RUN dotnet build "EasyMeets.Core.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EasyMeets.Core.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5050
ENTRYPOINT ["dotnet", "EasyMeets.Core.WebAPI.dll"]