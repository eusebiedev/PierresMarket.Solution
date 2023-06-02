# _Pierre's Market_

#### By _**Eusebie Siebenberg**_

#### Indpendent Code Review project:

## Technologies Used

* _C#_
* _Entity Framework Core_
* _MySQL Workbench_
* _Razor_
* _ASP.NET Core MVC_
* _VS Code_
* _.NET6_
* _Command Line_

## Description 



## Setup/Installation Requirements

1. Open your shell of choice (e.g., Terminal or GitBash) and run these commands in order:
2. Clone this repository by running $ `git clone https://github.com/user/examplerepo.git` (replace url with link copied from github)
3. Navigate to the root directory call `PierresMarket.Solution`, Create a `.gitignore` file with $ `touch .gitignore`, copy/paste this into the .gitignore file:
```
obj
bin
appsettings.json
```
4. Navigate to this project's production directory called "Factory" with $ `cd Factory`.
5. Within the production directory create a new file called `appsettings.json` with $ `touch appsettings.json`.
6. Within `appsettings.json`, paste in the following code, replacing `user-id`, and `password` with your own username and password.
(remove square brackets when inputting your details):

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=pierres_market;uid=[user-id];pwd=[password];"
  }
}
```
7. Withing the production directory `PierresMarket`, run `dotnet ef database update` to instantiate the database.
8. Within the production directory, run `dotnet watch run` in the command line to launch the application in development mode in a browser, and interact with the application.

## Known Bugs 

* _No known bugs as of 06/02/2023_

## [MIT](https://opensource.org/license/mit/) License

Copyright (c) 06/02/2023, Eusebie Siebenberg

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

If you have any questions, comments, or concerns, please reach out to me at: siebenee@gmail.com