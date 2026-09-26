\# Task 03 - Web API with ASP.NET Core



\## Description



This project is a small REST API built using ASP.NET Core Web API.



The API manages products and supports the four standard CRUD operations.



\## API Operations



\- GET - Get all products

\- GET /{id} - Get a product by ID

\- POST - Create a new product

\- PUT /{id} - Update an existing product

\- DELETE /{id} - Delete a product



\## Model Validation



The Product model uses Data Annotations for validation.



\- Product name is required and must contain 2 to 100 characters.

\- Price must be between 1 and 1,000,000.

\- Category is required and can contain up to 200 characters.



\## Status Codes



\- 200 OK - Successful GET request

\- 201 Created - Product successfully created

\- 204 No Content - Product updated or deleted successfully

\- 400 Bad Request - Invalid input

\- 404 Not Found - Product does not exist



\## How to Run



Open Command Prompt in the project folder and run:



```bash

dotnet run

