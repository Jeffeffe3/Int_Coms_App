Create database CRM_DB;

Create Table tbl_Company(
Created_By_ID INT,
Create_Date datetime,
Last_Updated datetime,
Company_ID INT NOT NULL PRIMARY KEY,
Company_Name varchar(25),
Address varchar,
Phone_Num varchar,
DP_Name varchar
);

Create Table tbl_Contact(
Created_By INT,
Create_Date datetime,
Last_Updated datetime,
User_ID INT NOT NULL PRIMARY KEY,
Name varchar,
Position varchar,
Company_ID int foreign key references tbl_Company (Company_ID)
);

Create Table tbl_Staff(
S_User_ID INT NOT NULL PRIMARY KEY,
Name varchar,
Phone_Number varchar,
Department varchar,
Email varchar,
username varchar,
password varchar
);

Drop Table tbl_Company;
Drop Table tbl_Contact;
Drop Table tbl_Staff;