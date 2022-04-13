# BalanceManager

BalanceManager is a .NET Web API developed as a solution for the .NET Test Task.

## Installation

Clone the repo
```bash
git clone https://github.com/SaraEnnciso/BalanceManager.git
```

## Usage

To use the provided endpoints in a local environment, follow the next steps: 

1. Run the project
2. Navigate to http://localhost:58972/swagger
3. Click on User
4. Select the method to 

## REST API

The REST API is described bellow.

### Login
### Update

## Notes

I couldn't connect to SQLite database, so I created a Mock Repository that doesn't persist changes. A Repository file intented to work with SQLite db is available in the solution.

To do list:
- Connect to SQLite database file.
- Relocate database file to relative path in solution and change it in connectionString.
- Implement sessions to avoid entering user credentials on each HTTP request.
- Encrypt password field.
