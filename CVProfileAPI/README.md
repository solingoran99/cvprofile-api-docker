#CVProfile API – Dockerized ASP.NET Core Project

This project is a personal CV Profile API that I previously created using ASP.NET Core.  
For this assignment, I adapted and Dockerized the application by adding:

- A Dockerfile to containerize the backend
- A SQL Server container for the database
- A `docker-compose.yml` to manage both services together

The goal was to make the app portable and easily deployable with Docker.

---

#Technologies Used

- ASP.NET Core 8.0
- Entity Framework Core
- SQL Server (in a Docker container)
- Docker & Docker Compose
- Swagger UI for API testing

---

#Functionality

The API exposes endpoints to manage:
- `Projects` (title, description)
- `Skills` (name, experience years, skill level)

Data is stored in a SQL Server database running inside a container.

---

#How to Run Locally with Docker

 Prerequisites

- [Docker Desktop](https://www.docker.com/products/docker-desktop/)
- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download)

Step-by-Step Guide

1. Clone the repo:

```bash
git clone https://github.com/solingoran99/cvprofile-api-docker.git
cd cvprofile-api-docker

2. Build and run the containers:

docker compose up --build -d

3. Check Swagger UI:

Open http://localhost:5000/swagger
Here, you can test all API endpoints.

To stop the project:

docker compose down


- Technical Decisions
Framework: Chose ASP.NET Core for robust backend API development.

Database: SQL Server via Docker for consistent container-based setup.

ORM: Used EF Core for migrations and DB operations.

Containers: Both the app and DB are isolated and portable.

Docker Compose: Simplifies orchestration of multiple services.


- Additional Notes
Data was originally stored in MongoDB but migrated manually into SQL Server for this Docker-based setup.

API is fully functional via Swagger.

Migrations define tables: Projects, Skills.


