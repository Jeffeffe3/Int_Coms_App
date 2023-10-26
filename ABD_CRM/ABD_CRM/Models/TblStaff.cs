using System;
using System.Collections.Generic;

namespace ABD_CRM.Models;

public partial class TblStaff
{
    public int SUserId { get; set; }

    public string Name { get; set; }

    public string PhoneNumber { get; set; }

    public string Department { get; set; }

    public string Email { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }
}
