# BalanceManager

BalanceManager is a .NET Web API developed as a solution for the .NET Test Task.

## Installation

1. Clone the repo
```bash
git clone https://github.com/your_username_/Project-Name.git 
```

## Usage

## Notes

I couldn't connect to SQLite database, so I created a Mock Repository that doesn't persist changes. A repository file intented to work with SQLite db is available in the solution.

To do list:
- Connect to SQLite database file.
- Relocate database file to relative path in solution and change it in connectionString.
- Implement sessions to avoid entering credentials on each HTTP request.
- Encrypt password field.
