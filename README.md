# Episerver-AlloyMVC-ITCSS-BEM
Episerver Alloy MVC project using ITCSS and BEM

This example project was created for the Aware Web Solutions Episerver Blob.  You can read the full blog post [blog post here](http://www.awareweb.com/awareblog/).

## How to run the project

1. Clone this repo
1. Create an empty MS SQL 2016 database (I used MS SQL 2016 Express)
1. Depending on your workstation credentials you can either create a SQL Server user or use your Windows Authentication credentials to access the new database.  If you choose the SQL Server user route, make sure to give the user DBO access.
1. Open the project solution in Visual Studio 2015 or 2017 (I used 2017).
1. Change the MS SQL connection string in the project root's Web.config file. See below for example Mine looks like this (I used Windows Authentication) 
1. Run the project (control + f5)

## My Connection String (I used Windows Authentication)
    <add name="EPiServerDB" connectionString="Data Source=.\SQL2016EXPRESS;Initial Catalog=AlloyMVC;Connection Timeout=60;Integrated Security=True;MultipleActiveResultSets=True" providerName="System.Data.SqlClient" />