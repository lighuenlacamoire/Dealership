#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see http://aka.ms/containercompat 

FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-nanoserver-1803 AS build
WORKDIR /src
COPY ["App/App.Api/App.Api.csproj", "App/App.Api/"]
RUN dotnet restore "App/App.Api/App.Api.csproj"
COPY . .
WORKDIR "/src/App/App.Api"
RUN dotnet build "App.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "App.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "App.Api.dll"]