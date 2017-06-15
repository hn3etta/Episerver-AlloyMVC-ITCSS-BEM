# Episerver-AlloyMVC-ITCSS-BEM
Episerver Alloy MVC project using ITCSS and BEM

This example project was created for the Aware Web Solutions Episerver Blog.  You can read the full [blog post here](http://www.awareweb.com/awareblog/).

## How to run the project

1. Clone this repo
1. Create an empty MS SQL 2016 database (I used MS SQL 2016 Express)
1. Depending on your workstation credentials you can either create a SQL Server user or use your Windows Authentication credentials to access the new database.  If you choose the SQL Server user route, make sure to give the user DBO access
1. Open the project solution in Visual Studio 2015 or 2017 (I used 2017)
1. Change the MS SQL connection string in the project root's Web.config file
1. Open the Nuget Package Manager Console and click the "Restore" button in the yellow warning message heading
1. Close Visual Studio and reopen the solution in Visual Studio
1. Bring up the Nuget Package Manager Console and enter `Initialize-EPiDatabase`
1. Run the project (control + f5)
1. Create an administrator account
