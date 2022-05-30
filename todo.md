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
	- _OR_ Set up a remote database
- [x] Organize Classes into multiple files

**Flow**
- [ ] Add loops to menus to re-prompt for incorrectly entered/missing information
- [x] Figure out how to put DB stuff in a Class to clean up overall flow
- [ ] Have a default flow that is triggered if there are no saved dimensions
- [ ] Rework menus to use [`Dictionary<>`](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2) objects with a handler for calling functions and handling invalid input.
	- [`GetMethod()`](https://docs.microsoft.com/en-us/dotnet/api/system.type.getmethod?view=net-6.0)?

**Data Handling Fixes**
- [ ] Handle blank database cells
- [ ] Handle "bed width is less than veg space between rows"
- [ ] Handle "bed width is greater than bed length," either implicitly or with and "Are you sure?" prompt.

**Data Handling Features**
- [x] Make fancier math to figure out number of rows
- [ ] Allow user to check multiple plants at once to compare
	- Either in a single input with commas, or with an "add to compare"
- [ ] Allow user to save/show information for multiple beds
- [ ] Allow user to show history of recent calculations
	- At its simplest, this could just be a long string that is added to and then printed
- [ ] Allow user to input a series of rectangles for oddly-shaped beds
- [ ] Allow user to input new plants into DB
- [ ] Allow user to search DB for a text string. If there are multiple matches, Allow user to select one
- [ ] Allow decimal points or feet/inches in measurements

**UX**
- [ ] Make wording clearer/more user-friendly
- [x] Use `Console.Clear()` and/or other delineation for new "pages"
- [ ] Visually differentiate menus/lists/etc instead of having having a wall of text
- [x] Use functions to enforce consistent layout between similar pages
- [ ] Show current saved dimensions
- [x] Colors!