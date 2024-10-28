FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory inside the container
WORKDIR /app

# Copy the solution and restore any dependencies
COPY *.sln .
COPY src/ ./src/
COPY tests/ ./tests

# Restore dependencies
RUN dotnet restore

# Copy the rest of the application source code
COPY . .

# Build the application in Release mode
RUN dotnet publish src/Presentation/CarBrands.Presentation.WebService -c Release -o /app/out

# Use the official .NET 8 ASP.NET runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Set the working directory for the runtime environment
WORKDIR /app

# Copy the published application from the build stage
COPY --from=build /app/out/ .

# Expose the port your application will run on
EXPOSE 8080

# Start the application
ENTRYPOINT ["dotnet", "CarBrands.Presentation.WebService.dll"]
