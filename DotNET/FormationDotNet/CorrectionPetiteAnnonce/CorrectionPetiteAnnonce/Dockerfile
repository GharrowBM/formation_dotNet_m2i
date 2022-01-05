FROM mcr.microsoft.com/dotnet/sdk:5.0 as build
WORKDIR /app

COPY . .

RUN dotnet restore

RUN dotnet publish -c Release -o bin

FROM mcr.microsoft.com/dotnet/aspnet:5.0

WORKDIR /app

COPY --from=build /app/bin .

ENTRYPOINT ["dotnet", "CorrectionPetiteAnnonce.dll"]