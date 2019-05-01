# mikroERP
.Net Core and Angular responsive web app for for managing a database with employees and with charts about this employees.

Created with: .Net Core 2.2, Angular 7, Entity Framework Core, Bootstrap 4, SQLite.

![](https://media.giphy.com/media/1kJXCPaatS2QjPLIhw/giphy.gif)

![](https://media.giphy.com/media/fxedwtu2qjQwS86qBl/giphy.gif)

![](https://media.giphy.com/media/dU53Y0jHo28iEn1MrE/giphy.gif)


## How to download and run with Visual studio Code:
* Download Visual Studio Code: https://code.visualstudio.com/
* Clone repo: git clone https://github.com/MercinQ/mikroERP.git
* Open terminal
* Change directory to mikroERP folder: cd mikroERP
* Open a mikroERP folder in Visual Studio Code: code .
* Change directory to mikroERP.API: cd mikroERP.API
* Build: dotnet build
* Create a database with records from seeding migrations: dotnet ef database update
* Run the back-end: dotnet watch run
* Open another terminal
* Change directory to mikroERP-SPA: cd mikroERP-SPA
* Install packages: npm install
* Run the angular: ng serve -o
* Test the app
