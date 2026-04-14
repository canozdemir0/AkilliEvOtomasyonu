Smart Home Automation API

This project is a backend application developed using ASP.NET Core Web API. 
The main purpose is to provide a foundational infrastructure for user authentication and device management in smart home systems.

------------

Project Description

In this application, user authentication is implemented using JWT-based security. 
After a successful login, a token is generated and used to access authorized API endpoints.
Device operations and system activities are stored and tracked in a Microsoft SQL Server database.

------------

Key Features

JWT-based authentication system
User login and authorization mechanism
Data management using SQL Server
API endpoints for device operations
Logging of system activities into the database
Testable API structure via Swagger

-------------

Technologies Used

ASP.NET Core Web API (.NET 8)
C#
Microsoft SQL Server
JWT Authentication
Swagger / OpenAPI

--------------

Project Architecture

The project follows a layered architecture approach:
Controllers: Handle incoming API requests
Models: Data models (User, Log, LoginRequest, etc.)
Services: Business logic and JWT token generation
Data Layer: Database operations and SQL Server integration

---------------

How It Works

Users authenticate through the login endpoint. If the credentials are valid, the system generates a JWT token. 
This token is then used for authorization in subsequent requests.
When device operations are performed, all actions are recorded in the database for tracking and auditing purposes.

---------------

API Endpoints

POST /api/auth/login → User authentication and token generation
POST /api/device/action → Device control operations

--------------

Note

This project was developed to practice backend development concepts, including authentication, API design, and database integration.

--------------

Purpose

The purpose of this project is to gain practical experience with ASP.NET Core Web API architecture, 
JWT-based authentication systems, and SQL Server integration in a real-world backend scenario.
