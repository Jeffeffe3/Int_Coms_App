using System;
using System.Collections.Generic;

namespace ABD_CRM.Models;

public partial class UserTable
{
    public int UserId { get; set; }

    public string Username { get; set; }

    public string PasswordDetails { get; set; }
}
