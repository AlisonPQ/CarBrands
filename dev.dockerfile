# Use the .NET SDK image
FROM mcr.microsoft.com/dotnet/sdk:8.0 

# Set the working directory
WORKDIR /app

COPY *.sln .
COPY src/ ./src/
COPY tests/ ./tests

RUN dotnet restore

# Copy the rest of the application files
COPY . ./

# Build the application
RUN dotnet build

WORKDIR /app/src/Presentation/CarBrands.Presentation.WebService

# Expose the necessary port
EXPOSE 8080

# Start the application with dotnet watch
CMD ["dotnet", "watch", "--no-hot-reload", "run", "--urls", "http://0.0.0.0:8080"]
