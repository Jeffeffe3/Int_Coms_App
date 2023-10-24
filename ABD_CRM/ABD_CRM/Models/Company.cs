using Microsoft.VisualBasic;

namespace ABD_CRM.Models
{
    public class Company
    {
        /*
         Created_By_ID INT,
Create_Date datetime,
Last_Updated datetime,
company_ID INT NOT NULL PRIMARY KEY,
company_Name varchar(25),
Address varchar,
Phone_Num varchar,
DP_Name varchar*/
        string companyID, companyName, companyAddress, companyPhoneNum, companyCreateBy, companyDealerName;
        DateAndTime companyCreateDate, companyLastUpdated;

        public Company(string companyID, string companyName, string companyAddress, 
            string companyPhoneNum, string companyCreateBy, string companyDealerName, 
            DateAndTime companyCreateDate, DateAndTime companyLastUpdated)
        {
            this.CompanyID = companyID;
            this.CompanyName = companyName;
            this.CompanyAddress = companyAddress;
            this.CompanyPhoneNum = companyPhoneNum;
            this.CompanyCreateBy = companyCreateBy;
            this.CompanyDealerName = companyDealerName;
            this.CompanyCreateDate = companyCreateDate;
            this.CompanyLastUpdated = companyLastUpdated;
        }

        public string CompanyID { get => companyID; set => companyID = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string CompanyAddress { get => companyAddress; set => companyAddress = value; }
        public string CompanyPhoneNum { get => companyPhoneNum; set => companyPhoneNum = value; }
        public string CompanyCreateBy { get => companyCreateBy; set => companyCreateBy = value; }
        public string CompanyDealerName { get => companyDealerName; set => companyDealerName = value; }
        public DateAndTime CompanyCreateDate { get => companyCreateDate; set => companyCreateDate = value; }
        public DateAndTime CompanyLastUpdated { get => companyLastUpdated; set => companyLastUpdated = value; }
    }
}
