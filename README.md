# EBikeRental_Web_App_System

Importing data and tables into web application.

Make sure to clone the repositery first.

1. Under MSSQLLocalDB (SQL SERVER), right click on the database folder and add a new database. Name the database 'EBikeRental_Web_App_System' to match the connection string.
2. Create the tables which are in the sqlServerDataTables folder (in the solution explorer), click on one, execute it. In the connect menu, click local and then click MSSQLLocalDb, then select the correct database ('EBikeRental_Web_App_System') at the bottem under database name to add it to, and repeat for all.
3. Please note that not all tables will be added as some will fail to create due to them containing foreign keys. Simply check under the tables folder which ones were created and which ones weren't. For the ones that aren't there, simply execute them again from the sqlServerDataTables folder.
4. Add the data. The scripts are in the sqlServerData folder, click on one, execute it, and repeat for all.
5. The database should now be populated. Run the program and see the different pages filled with data.
