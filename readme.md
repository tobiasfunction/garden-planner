## Garden Boxes!!!!

Write a program that will take in a users garden box size, then let them pick from a list of plants and tell them how many they can plant in that space.

Please create a database that will hold plants. You don't need to add more than 2 or 3 plants into the database for testing. Please make sure the database or a description of the database is included in your repo.

## To run

- Clone this repo.
- Create a SQLite database with the below table.
- Do any neccesary C#/dependency-related setup.
- Replace the connection string in `Program.cs`.
- `dotnet run` or :arrow_forward: to run the program.

## SQLite Table Definition:

```sql
CREATE TABLE Plants (
	Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	Name TEXT,
	PlantSpaceFloor INTEGER,
	PlantSpaceCeil INTEGER,
	RowSpaceFloor INTEGER,
	RowSpaceCeil INTEGER);
```