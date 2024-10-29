# Car Brands

## Overview of the Car Brands API

The Car Brands API is a RESTful service designed to provide comprehensive access to information about various car brands. This API serves as a practical demonstration of how to build a robust API using .NET.

## Technical Implementation

The primary goal is to showcase best practices in software development, including layering, dependency injection, and adherence to SOLID principles. The API is built using PostgreSQL for data storage, XUnit for testing, and Docker Compose to configure both the development and test environments efficiently.

## Features

With this API, users can easily retrieve:

- **A comprehensive list of car brands:** Access a full catalog of available car brands.
- **Specific car brand details by ID:** Retrieve detailed information about a particular car brand using its unique identifier.

## Technologies Used

- ASP.NET Core
- .NET Core 8.0
- Entity Framework Core
- XUnit
- Postgres
- Docker
- Docker compose
- Bash

## Getting Started

To get started with the Car Brands API, follow the commands below to set up your development and testing environments.

### Available commands

Navigate to the project directory:

`cd CarBrands`

### Developer Environment

Start the developer environment with Docker Compose:

`docker-compose -f docker-compose.yml -f docker-compose.override.yml up --build`

### Testing Environment

Start the testing environment with Docker Compose:

`docker-compose up --build`

## Usage

I recommend testing these API endpoints using Postman:

- Get a list of car brands:
  
  `GET http://localhost:8080/api/carbrands`

- Get a specific car brand by ID:
  
  `GET http://localhost:8080/api/carbrands/<Id>`
  
  (Replace <Id> with a GUID. You can obtain a valid ID by executing the first endpoint.)
  
Alternatively, you can visit the API documentation at:
`http://localhost:8080/swagger/index.html`

## Testing

To run tests, navigate to `/tests` folder and run:

`dotnet test`
