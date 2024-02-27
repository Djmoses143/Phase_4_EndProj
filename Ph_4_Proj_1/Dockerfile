#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Ph_4_Proj_1/Ph_4_Proj_1.csproj", "Ph_4_Proj_1/"]
RUN dotnet restore "./Ph_4_Proj_1/./Ph_4_Proj_1.csproj"
COPY . .
WORKDIR "/src/Ph_4_Proj_1"
RUN dotnet build "./Ph_4_Proj_1.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Ph_4_Proj_1.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ph_4_Proj_1.dll"]