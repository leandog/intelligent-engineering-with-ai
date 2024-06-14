# Intelligent Engineering with AI

![LeanDog Logo](/Assets/LeanDog-logo.png)

# Task Management API

A simple Task Management API built with ASP.NET Core and Entity Framework Core using SQLite for persistence. This API allows you to create, read, update, and delete tasks with basic CRUD operations. The tasks have a status represented by an enum to indicate their progress.

### Project Overview

#### Features

- **Create a Task**: Add new tasks with a title, description, due date, and status.
- **Read Tasks**: Retrieve a list of all tasks or a single task by its ID.
- **Update a Task**: Modify task details.
- **Delete a Task**: Remove tasks by their ID.

#### Technologies Used

- **.NET 8.0**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **SQLite**
- **xUnit** for testing
- **Swagger** for API documentation

### Setup Instructions

#### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
- [SQLite](https://www.sqlite.org/download.html)

#### Getting Started

1. **Install Entity Framework Core Tools**:

   ```sh
   dotnet tool install --global dotnet-ef
   ```

2. **Set Up the Database**:
   Apply the migrations:

   ```sh
   dotnet ef database update
   ```

3. **Ensure Development Certificates Are Set Up**:
   Ensure that the development certificate is installed and trusted:

   ```sh
   dotnet dev-certs https --check
   dotnet dev-certs https --trust
   ```

4. **Run the Application**:

   ```sh
   dotnet run
   ```

5. **Access the Swagger UI**:
   Open your web browser and navigate to:
   ```
   https://localhost:5077/swagger/index.html
   ```
   or
   ```
   https://localhost:7015//swagger/index.html
   ```

#### Running Tests

Navigate to the test project directory and run the tests using xUnit:

```sh
cd TaskManagementApi.Tests
dotnet test
```

##### Viewing Coverage

To run coverage with report generator install `dotnet-reportgenerator-globaltool` globally

```sh
dotnet tool install --global dotnet-reportgenerator-globaltool
```

Run the `run-tests-with-coverage` file:

```sh
# mac/linux
./run-tests-with-coverage.sh
# windows
./run-tests-with-coverage.ps1
```
