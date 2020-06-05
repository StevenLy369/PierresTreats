 # Pierres Treats

#### Friday Practice

#### By _StevenL June 5, 2020_

## Description

### A program that gathers both a registered users input of treats and flavors and stores in a database. Then User can retreive data and output to html.

## Setup/Installation Requirements

* Clone this repository.
* Open in the text editor of your choice
* Open MySQL workbench and connect
* Open terminal and run to create your database
```
dotnet ef migrations add Initial 
dotnet ef database update
```
* Connect the database to your project file through appsettings.json
* dotnet restore/dotnet build inside Solutions folder
* dotnet watch run



## Specs
| Spec | Input | OutPut |
|:----------- | :-----------------| :---------------|
| User can create a stylist | Name: "Charlie" and Detail: "Works hard" | Output: Name: Charlie Detail: Works hard|
| User can create a client | Name: "John" Stylist: "Charlie" | Output: Name: John Stylist: Charlie



## Known Bugs

No

## Support and contact details

If you have any suggestions or questions please message me on github

## Technologies Used

* C#
* Dotnet
* MySQL
* Entity Framework Core
* MVC

### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_StevenLy_**