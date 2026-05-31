# Inventory API

A REST API for managing inventory items, project built to get familiar
with the ASP.NET Core backend stack. This is a learning project built over very short time as a first hands-on experience with C# and the .NET ecosystem.

## Stack

- **ASP.NET Core 10** — Web API
- **Entity Framework Core 10** — ORM
- **SQL Server 2022** — Database
- **Docker** — Containerization
- **Scalar** — API documentation UI

## Architecture

The project follows a standard layered architecture with clear separation of concerns:

```
Controllers/   → HTTP layer, request/response handling
Repositories/  → Data access layer (interface + implementation)
Models/        → Domain entities
Data/          → EF Core DbContext
```

The repository is used to separate the data access logic from the controller layer.

Dependency injection is configured in `Program.cs`.

## Getting started

The entire project runs with a single command — no need to install .NET or configure SQL Server manually.

**Prerequisites:** Docker and Docker Compose

```bash
git clone https://github.com/mmilohanic/Inventory-API.git
cd Inventory-API
docker-compose up --build
```

The API will be available at `http://localhost:8080`.

On first run, the application automatically:

- Waits for SQL Server to be ready
- Runs EF Core migrations to create the database schema
- Seeds the database with initial inventory data

## API documentation

Interactive API docs are available via Scalar at:

```
http://localhost:8080/scalar
```

## Endpoints

| Method | Endpoint             | Description                |
| ------ | -------------------- | -------------------------- |
| GET    | `/api/products`      | Get all products           |
| POST   | `/api/products`      | Create a new product       |
| PUT    | `/api/products`      | Update an existing product |
| GET    | `/api/products/{id}` | Get product by ID          |
| DELETE | `/api/products/{id}` | Delete a product           |

### Example POST body

```json
{
    "itemName": "Electric socket",
    "description": "16A single pole",
    "quantity": 30,
    "price": 8.5
}
```

### Example PUT body

```json
{
    "id": 5,
    "itemName": "Electric socket",
    "description": "16A single pole ",
    "quantity": 20,
    "price": 6.5
}
```

## Running locally without Docker

If you prefer to run the API locally against your own SQL Server instance:

1. Install [.NET 10 SDK](https://dotnet.microsoft.com/download)
2. Create `appsettings.Development.json` in the project root:

```json
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost,1433;Database=InventoryDb;User Id=sa;Password=YourPassword;TrustServerCertificate=True;"
    }
}
```

3. Run migrations and start the API:

```bash
dotnet ef database update
dotnet run
```
