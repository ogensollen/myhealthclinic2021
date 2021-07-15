#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
RUN curl -sL https://deb.nodesource.com/setup_10.x |  bash -
RUN apt-get install -y nodejs
WORKDIR /src
COPY ["src/MyHealth.Web/MyHealth.Web.csproj", "src/MyHealth.Web/"]
COPY ["src/MyHealth.Data/MyHealth.Data.csproj", "src/MyHealth.Data/"]
COPY ["src/MyHealth.Model/MyHealth.Model.csproj", "src/MyHealth.Model/"]
COPY ["src/MyHealth.API/MyHealth.API.csproj", "src/MyHealth.API/"]
RUN dotnet restore "src/MyHealth.Web/MyHealth.Web.csproj"
COPY . .
WORKDIR "/src/src/MyHealth.Web"
RUN dotnet build "MyHealth.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyHealth.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyHealth.Web.dll"]
