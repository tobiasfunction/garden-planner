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
- [x] Calculate plant spacing
	- [x] Show list of possible plants
	- [x] Get & parse input to choose plant
	- [x] Get spacing information from DB
	- [x] Calculate min & max number of plants
	- [x] Display:
		- [x] plant name
		- [x] plant spacing in inches
		- [x] box area in square feet
		- [x] number of plants that will fit


### Extras
**Files**
- [ ] Figure out how to have a user `.gitignore`-ed config file to store user's connection string

**Flow**
- [ ] Add loops to menus to re-prompt for incorrectly entered information
- [ ] Figure out how to put DB stuff in a Class to clean up overall flow.

**Data Handling**
- [x] Make fancier math to figure out number of rows
- [ ] Handle blank database cells
- [ ] Allow user to check multiple plants at once to compare
	- Either in a single input with commas, to with an "add to compare"
- [ ] Allow user to save/show information for multiple beds
- [ ] Allow user to input new plants into DB
- [ ] Allow user to search for a text string. If there are multiple matches, Allow user to select one
- [ ] Allow decimal points or feet/inches in measurements

**UX**
- [ ] Make wording, flow and layout more human-friendly
	- [ ] Maybe use functions to enforce consistent layout between similar pages
- [ ] Show saved dimensions