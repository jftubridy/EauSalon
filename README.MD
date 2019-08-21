**Eau Claire's Salon**

#### A program to use a database for Eau Claire. 8/21/19

#### By **Joseph Tubridy**

## Description

This program allows Eau Claire to use a database to keep track of her stylists and their clients. 


### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Adds a Stylist** | Add Stylist | Shows stylists added |
| **Views Stylists** | Displays a particular vendor and any clients they have | Displays the Stylist that the user identifies |
| **View Clients** | Move to a page to add Clients | Takes user to a list of Clients with links to add more |
| **Adds Clients** | Add a Client | Allows user to add a Client to a particular Stylist |

## Setup/Installation Requirements

1. Clone this repository.
2. In your terminal type:
3. CREATE DATABASE joseph_tubridy;
4. USE joseph_tubridy;
5. CREATE TABLE stylists (StylistId PRIMARY KEY, Name VARCHAR(255), Phone VARCHAR(255), rating VARCHAR(255));
6. CREATE TABLE clients (ClientId PRIMARY KEY, Name VARCHAR(255), Phone VARCHAR(255), StylistId INT(11));
7. Type dotnet restore then dotnet run in your console.
8. Use browser to go to localhost:5000.

## Known Bugs
* There are no known bugs at this time.

## Technologies Used
* C#
* .NET
* mysql

## Support and contact details

_Email jftubridy@gmail.com with any questions, comments, or concerns._

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2019 **_Joseph Tubridy_**