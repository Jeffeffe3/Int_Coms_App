Create database CRM_DB;

Create Table tbl_Company(
Created_By_ID INT,
Create_Date datetime,
Last_Updated datetime,
Company_ID INT NOT NULL PRIMARY KEY,
Company_Name varchar(50),
Company_Address varchar(50),
Phone_Num varchar(50),
DP_Name varchar(50)
);

Create Table tbl_Contact(
Created_By INT,
Create_Date datetime,
Last_Updated datetime,
Contact_ID INT NOT NULL PRIMARY KEY,
Contact_Name varchar(50),
Position varchar(50),
Company_ID int foreign key references tbl_Company (Company_ID)
);

Create Table tbl_Staff(
S_User_ID INT NOT NULL PRIMARY KEY,
Staff_Name varchar(50),
Phone_Number varchar(50),
Department varchar(50),
Email varchar(50),
username varchar(50),
Staff_Password varchar
);

Create Table tbl_Tickets(
Ticket_ID varchar(50),
Create_Date datetime,
Last_Updated datetime,
CreatedBy varchar(50),
Assignee varchar(50),
AssigneeDept varchar(50),
Ticket_Description varchar(50),
Resolved varchar(50)
);

Drop Table tbl_Company;
Drop Table tbl_Contact;
Drop Table tbl_Staff;
Drop table tbl_Tickets