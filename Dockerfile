# Use the official .NET Core SDK image as the build environment
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

# Copy the .csproj file and restore dependencies
COPY dotnet-hello-world.csproj ./
RUN dotnet restore

# Copy the remaining files and build the project
COPY . ./
RUN dotnet publish -c Release -o out

# Use the official ASP.NET Core runtime image as the runtime environment
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app

# Copy the built files from the previous stage
COPY --from=build-env /app/out .

# Expose the port that the app will listen on
EXPOSE 80

# Start the app
ENTRYPOINT ["dotnet", "dotnet-hello-world.dll"]
