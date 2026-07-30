# REST API Exercise

ASP.NET Core Web API implementing health check and item management endpoints.

## Prerequisites

- .NET 8 SDK or later

## Run the Application

```bash
dotnet run
```

The application will start on:

```text
http://localhost:5014
```

## Endpoints

### Health Check

```http
GET /health
```

Example:

```bash
curl http://localhost:5014/health
```

Response:

```json
{
  "status": "Healthy",
  "name": "Harshini Supriya J"
}
```

---

### Get Items

```http
GET /api/items
```

Example:

```bash
curl http://localhost:5014/api/items
```

---

### Get Item By Id

```http
GET /api/items/1
```

Example:

```bash
curl http://localhost:5014/api/items/1
```

---

### Create Item

```http
POST /api/items
```

Example:

```bash
curl -X POST http://localhost:5014/api/items \
-H "Content-Type: application/json" \
-d "{\"name\":\"Monitor\"}"
```

Request Body:

```json
{
  "name": "Monitor"
}
```

Successful Response:

```json
{
  "id": 4,
  "name": "Monitor"
}
```