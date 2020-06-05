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
| Logged in User can create/delete a treat | Name: "Ice Cream" and Flavor: "Chocolate" | Output: Name: Ice Cream Flavor:Chocolate|
| Logged in User can create/delete a flavor | Flavor: "Chocolate | Flavor: Chocolate |
| Logged in User can edit a treat | Name: "Ice Cream" and Flavor: "Strawberry" | Output: Name: Ice Cream Flavor:Strawberry|
| NonLogged in User cannot edit a treat | Name: "Ice Cream" and Flavor: "Strawberry" | Output: Please Login|
| Nonlogged in users cannot create/delete a treat | Name: Donuts and Flavor: "Strawberry | Output: Please Login|
| Nonlogged in users cannot create/delete a flavor | Flavor: "Strawberry | Output: Please Login|




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
* Core Identity


### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_StevenLy_**