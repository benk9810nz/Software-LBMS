This folder consists of our Snatch and Go (Self Checkout) Applcation, which is a Windows Form C# Applcation created to allow customers to issue and return books.

The Snatch and Go EXE File in the Root directory of this folder is a shortcut to the application.

The Visual Studio RAW Files Folder contains the Visual Studio C# Solution for this application (the raw C# Files)

When the application first runs it tries to connect to our public MySQL Database. Unfortutaly we are unable to run this on the SIT Eudoroam WiFi Network due to the Port and Domain Filtering.

If the application is unable to connect to the database a Configuration Form will appear allowing the user to alter the configuration parameters such as the connection string values for the SQL Database.

The application allows customers and books to be identified through RFID Tags (using a Phidget RFID Reader). If this is not possible it is possible to allow the user to login and issue/return books via entering the RFID Tag into the Textbox and clicking the appropiate Button.

The RFID_Tag value can be found in the BOOKCOPIES/USERS Tables in our MySQL Database

Due to how I have opened this application to the internet, I have replaced the configuration strings with #### to protect the security of the fields.