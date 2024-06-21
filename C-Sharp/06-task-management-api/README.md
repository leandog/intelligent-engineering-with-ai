# Intelligent Engineering with AI

![LeanDog Logo](/Assets/LeanDog-logo.png)

# Task Management API

A simple Task Management API built with ASP.NET Core and Entity Framework Core using SQLite for persistence. This API allows you to create, read, update, and delete tasks with basic CRUD operations. The tasks have a status represented by an enum to indicate their progress.

## Adding a New Feature: Task Priority

### Feature Description

The Task Application needs to be enhanced by adding a new feature that allows tasks to be assigned a priority level. The priority levels will be represented as an enumeration with values "Low", "Medium", and "High". This feature will also require updating the API to return the text values for priority instead of numeric values and ensure tasks are ordered by priority and due date.

### Requirements

1. **Add Priority Field to Task Model**

   - Add a new field named `Priority` to the Task model.
   - The `Priority` field should be an enumeration with the following values:
     - `Low`
     - `Medium`
     - `High`

2. **Update API to Return Text Values for Priority**

   - Modify the API to return the text values (`Low`, `Medium`, `High`) for the `Priority` field instead of numeric values.
   - Ensure that when tasks are retrieved through the API, the priority is displayed as a string value.

3. **Order Tasks by Priority and Due Date**
   - Implement sorting logic to order tasks by their priority, with `High` priority tasks appearing first, followed by `Medium` and `Low` priority tasks.
   - Within each priority level, tasks should be ordered by their due date, with the most recent due date appearing first.

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
   http://localhost:5077/swagger/index.html
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
