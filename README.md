# User Management API

## Overview
The User Management API is a RESTful API designed to facilitate user management for internal tools at TechHive Solutions. It provides endpoints for creating, updating, retrieving, and deleting user records, enabling efficient management by the HR and IT departments.

## Project Structure
The project consists of the following key components:

- **Controllers**
  - `UsersController.cs`: Manages user-related API endpoints, handling GET, POST, PUT, and DELETE requests.

- **Models**
  - `User.cs`: Defines the User entity with properties such as Id, Name, Email, and other relevant attributes.

- **Services**
  - `UserService.cs`: Encapsulates the business logic for user management, providing methods for user operations and interacting with the data layer.

- **Program.cs**: The entry point of the application, setting up the web host and configuring services and middleware.

- **Startup.cs**: Configures the application's services and request pipeline, including dependency injection and middleware setup.

- **appsettings.json**: Contains configuration settings for the application, such as connection strings and application-specific settings.

- **appsettings.Development.json**: Contains development-specific configuration settings that override those in appsettings.json when running in the Development environment.

- **UserManagementAPI.csproj**: The project file containing metadata about the project, including dependencies and build settings.

## Setup Instructions
1. Clone the repository:
   ```
   git clone <repository-url>
   ```

2. Navigate to the project directory:
   ```
   cd UserManagementAPI
   ```

3. Restore the project dependencies:
   ```
   dotnet restore
   ```

4. Run the application:
   ```
   dotnet run
   ```

## API Usage
### Endpoints
- **GET /api/users**: Retrieve a list of users.
- **GET /api/users/{id}**: Retrieve a specific user by ID.
- **POST /api/users**: Add a new user.
- **PUT /api/users/{id}**: Update an existing user's details.
- **DELETE /api/users/{id}**: Remove a user by ID.

## Testing the API
You can use Postman or any similar tool to test the API endpoints. Ensure that the application is running before making requests.

## Contributions
Contributions to enhance the API functionality are welcome. Please submit a pull request for any changes or improvements.

## License
This project is licensed under the MIT License. See the LICENSE file for more details.