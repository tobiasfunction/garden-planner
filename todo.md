# TODO
### Files
- [x] Create C# project
- [x] Create and populate database
- [x] Set up SQLite in VSCode
- [x] Set up connection

### MVP
- [x] Create Main Menu loop
	- [x] Add Size Data
	- [x] Calculate plant spacing
	- [x] View plant database
	- [x] Quit
- [ ] Add Size Data
	- [ ] Input bed length and width
		- [ ] Get & parse input
		- [ ] Convert to square inches
	- [ ] Input bed area
		- [ ] Get & parse input
		- [ ] Convert to square inches
- [ ] Calculate plant spacing
	- [ ] Show list of possible plants
	- [ ] Get & parse input to choose plant
	- [ ] Get spacing information from DB
	- [ ] Calculate min & max number of plants
	- [ ] Display plant name, box area in square feet,
- [ ] Quit

### Extras
- [ ] Figure out how to have a user `.gitignore`-ed config file to store user's connection string
- [ ] Add loops to menus to re-prompt for incorrectly entered information
- [ ] Make wording and layout more user-friendly
	- [ ] Maybe use functions to enforce consistent layout between similar pages
- [ ] Allow user to check multiple plants at once to compare
	- [ ] Either in a single input with commas, to with an "add to compare"
- [ ] Allow user to input new plants
- [ ] Allow user to search for a text string. If there are multiple matches, Allow user to select one.