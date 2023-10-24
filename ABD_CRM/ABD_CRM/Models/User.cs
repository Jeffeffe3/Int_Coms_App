namespace ABD_CRM.Models
{
    public class User
    {
        /* S_User_ID INT NOT NULL PRIMARY KEY,
 Name varchar,
 Phone_Number varchar,
 Department varchar,
 Email varchar,
 username varchar,
 password varchar*/
        string staffID;
        int permissionLevel;
        string staffName,staffPhone,staffDepartment,staffEmail,staffUsername,staffPass;



        public User(string staffName, string staffPhone, string staffDepartment,
            string staffEmail, string staffUsername, string staffPass, 
            string staffID)
        {
            this.StaffName = staffName;
            this.StaffPhone = staffPhone;
            this.StaffDepartment = staffDepartment;
            this.StaffEmail = staffEmail;
            this.StaffUsername = staffUsername;
            this.StaffPass = staffPass;
            this.staffID = staffID;
        }

        public string StaffID { get => staffID; set => staffID = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        public string StaffPhone { get => staffPhone; set => staffPhone = value; }
        public string StaffDepartment { get => staffDepartment; set => staffDepartment = value; }
        public string StaffEmail { get => staffEmail; set => staffEmail = value; }
        public string StaffUsername { get => staffUsername; set => staffUsername = value; }
        public string StaffPass { get => staffPass; set => staffPass = value; }
    }
}
