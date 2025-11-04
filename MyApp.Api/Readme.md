name: Clean Architecture CRUD App
description: >
  A simple yet structured CRUD (Create, Read, Update, Delete) application built with .NET, 
  following the principles of Clean Architecture. 
  It uses SQL Server as the database and demonstrates proper separation of concerns 
  through Core, Application, Infrastructure, and API layers.

architecture:
  structure: |
    src/
    │
    ├── MyApp.Core/              → Contains Entities & Interfaces
    │   ├── Entities/            → Domain models (e.g., EmployeeEntity)
    │   └── Interfaces/          → Repository interfaces
    │
    ├── MyApp.Application/       → Business logic layer
    │   ├── Commands/            → Write operations (Create, Update, Delete)
    │   ├── Queries/             → Read operations (Get, List)
    │   └── DependencyInjection/ → Registers application services
    │
    ├── MyApp.Infrastructure/    → Data access & external services
    │   ├── Data/                → DbContext (EF Core)
    │   ├── Repositories/        → Implementation of interfaces
    │   └── DependencyInjection/ → Registers infrastructure dependencies
    │
    └── MyApp.Api/               → Presentation layer
        ├── Controllers/         → API endpoints
        └── Program.cs           → Application entry point

features:
  - Create new records
  - Retrieve all or single records
  - Update existing records
  - Delete records
  - Uses MediatR for CQRS pattern
  - Integrated with SQL Server (Entity Framework Core)
  - Follows Clean Architecture principles

database:
  type: Microsoft SQL Server
  orm: Entity Framework Core
  migrations:
    - dotnet ef migrations add InitialCreate
    - dotnet ef database update

getting_started:
  prerequisites:
    - .NET 8 SDK
    - SQL Server
    - Visual Studio 
    - Entity Framework Tools
  setup_steps:
    - git clone https://github.com/zainabad27/CleanArchitectureCrudApp.git
    - cd CleanArchitectureCrudApp
    - Update connection string in MyApp.Infrastructure/appsettings.json
    - dotnet ef database update
    - dotnet run --project MyApp.Api
  connection_string_example: |
    "ConnectionStrings": {
      "DefaultConnection": "Server=YOUR_SERVER;Database=MyAppDb;Trusted_Connection=True;TrustServerCertificate=True;"
    }

tech_stack:
  api_layer: ASP.NET Core Web API
  application_layer: MediatR
  infrastructure_layer: Entity Framework Core
  database: Microsoft SQL Server
  architecture: Clean Architecture

api_endpoints:
  employee:
    - method: POST
      endpoint: /api/employee
      description: Add a new employee
    - method: GET
      endpoint: /api/GetAllemployees
      description: Get all employees
    - method: GET
      endpoint: /api/GetemployeeById/{id}
      description: Get employee by ID
   

highlights:
  - Modular and testable code structure
  - Implements CQRS pattern via MediatR
  - Follows SOLID principles
  - Easy to extend for new entities or databases
  - Plug-and-play architecture

author:
  name: Zain Abad
  email: zainabad27@gmail.com
  github: https://github.com/zainabad27
  linkedin: https://www.linkedin.com/in/zain-abad-67087a260/
