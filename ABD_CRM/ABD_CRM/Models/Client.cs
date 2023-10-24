using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.VisualBasic;
using System.Xml.Linq;

namespace ABD_CRM.Models
{
    public class Client
    {
        /* Created_By INT,
 Create_Date datetime,
 Last_Updated datetime,
         User_ID INT NOT NULL PRIMARY KEY,
 Name varchar,
 Position varchar,
 Company_ID int foreign key references tbl_Company(Company_ID)
        */

        string userID,userName,userPosition,userCompany,userCreateBy;
        DateAndTime userCreateDate,userLastUpdated;

        public Client(string userID, string userName, string userPosition,
            string userCompany, string userCreateBy, DateAndTime userCreateDate, 
            DateAndTime userLastUpdated)
        {
            this.UserID = userID;
            this.UserName = userName;
            this.UserPosition = userPosition;
            this.UserCompany = userCompany;
            this.UserCreateBy = userCreateBy;
            this.UserCreateDate = userCreateDate;
            this.UserLastUpdated = userLastUpdated;
        }

        public string UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserPosition { get => userPosition; set => userPosition = value; }
        public string UserCompany { get => userCompany; set => userCompany = value; }
        public string UserCreateBy { get => userCreateBy; set => userCreateBy = value; }
        public DateAndTime UserCreateDate { get => userCreateDate; set => userCreateDate = value; }
        public DateAndTime UserLastUpdated { get => userLastUpdated; set => userLastUpdated = value; }
    }
}
