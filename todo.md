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
- [x] Add Size Data
	- [x] Input bed length and width
		- [x] Get & parse input
		- [x] Convert to square feet
	- [x] Input bed area
		- [x] Get & parse input
- [ ] Calculate plant spacing
	- [ ] Show list of possible plants
	- [ ] Get & parse input to choose plant
	- [ ] Get spacing information from DB
	- [ ] Calculate min & max number of plants
	- [ ] Display:
		- plant name
		- plant spacing in inches
		- box area in square feet
		- number of plants that will fit


### Extras
- [ ] Figure out how to have a user `.gitignore`-ed config file to store user's connection string
- [ ] Add loops to menus to re-prompt for incorrectly entered information
- [ ] Handle decimal points in user inputs?
- [ ] Make wording and layout more user-friendly
	- [ ] Maybe use functions to enforce consistent layout between similar pages
- [ ] Allow user to check multiple plants at once to compare
	- Either in a single input with commas, to with an "add to compare"
- [ ] Allow user to save/show information for multiple beds
- [ ] Allow user to input new plants
- [ ] Allow user to search for a text string. If there are multiple matches, Allow user to select one.