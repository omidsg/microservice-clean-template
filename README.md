# Microservice Clean Template

Production-ready .NET microservice template built with Clean Architecture, CQRS, and Rich Domain Model principles.

## Features

* Clean Architecture
* CQRS Pattern
* Rich Domain Model
* Dependency Injection
* Entity Framework Core
* Fluent Validation
* MediatR
* Global Exception Handling
* API Versioning Ready
* OpenAPI / Swagger
* Docker Ready
* Unit & Integration Testing Support

## Solution Structure

```text
src
├── Core
│   ├── Microservice.CleanTemplate.Domain
│   └── Microservice.CleanTemplate.Application
│
├── Infrastructure
│   └── Microservice.CleanTemplate.Infrastructure
│
└── Presentation
    └── Microservice.CleanTemplate.Api

tests
├── Microservice.CleanTemplate.UnitTests
└── Microservice.CleanTemplate.IntegrationTests
```

## Architecture

The solution follows Clean Architecture principles:

* **Domain** contains business rules and domain entities.
* **Application** contains use cases, CQRS handlers, and contracts.
* **Infrastructure** contains data access and external integrations.
* **API** exposes HTTP endpoints and application entry point.

## Getting Started

### Prerequisites

* .NET 9 SDK
* Docker (optional)

### Run

```bash
dotnet restore
dotnet build
dotnet run --project src/Presentation/Microservice.CleanTemplate.Api
```

### Tests

```bash
dotnet test
```

## CQRS Example

```text
Application
├── Features
│   └── Categories
│       ├── Commands
│       ├── Queries
│       └── DTOs
```

## Goals

This template aims to provide a solid foundation for building maintainable and scalable microservices using modern .NET development practices.

## License

MIT
