## Garden Boxes!!!!

Write a program that will take in a users garden box size, then let them pick from a list of plants and tell them how many they can plant in that space.

Please create a database that will hold plants. You don't need to add more than 2 or 3 plants into the database for testing. Please make sure the database or a description of the database is included in your repo.


## To run

Clone this repo then type `ruby program.rb`


## SQLite Table Definition:

```sql
CREATE TABLE Plants (
	Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	Name TEXT,
	SpaceLow INTEGER,
	SpaceHigh INTEGER);
```