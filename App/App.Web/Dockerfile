#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see http://aka.ms/containercompat 

FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-nanoserver-1803 AS build
WORKDIR /src
COPY ["App/App.Web/App.Web.csproj", "App/App.Web/"]
RUN dotnet restore "App/App.Web/App.Web.csproj"
COPY . .
WORKDIR "/src/App/App.Web"
RUN dotnet build "App.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "App.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "App.Web.dll"]
