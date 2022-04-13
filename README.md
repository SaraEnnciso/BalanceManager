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
4. Select the method to run

## REST API

The REST API is described bellow.

### Login
`POST`

#### Request URL
http://localhost:58972/api/User

#### Request Body
{
  "Login": "string",
  "Password": "string",
}

#### Response Body
{
  "Login": "string",
  "USD_balance": 0,
  "Role": "string"
  }
}

### Update
`PUT`

#### Request URL
http://localhost:58972/api/User

#### Request Body
{
  "Login": "string",
  "Password": "string",
  "USD_balance": 0,
}

## Notes

I couldn't connect to the SQLite database, so I created a Mock Repository that doesn't persist changes. A Repository file intended to work with SQLite DB is available in the solution.

I had problems integrating DI and SQLite libraries. Maybe if I had used the .NET Core framework I wouldn't have had this issue.

To do list:
- Connect to SQLite database file.
- Relocate database file to a relative path in solution and change it in connectionString.
- Implement sessions to avoid entering user credentials on each HTTP request.
- Encrypt the password field.
- Provide better instructions at README.md
