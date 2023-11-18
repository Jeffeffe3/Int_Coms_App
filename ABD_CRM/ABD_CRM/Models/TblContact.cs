using System;
using System.Collections.Generic;

namespace ABD_CRM.Models;

public partial class TblContact
{
    public int? CreatedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastUpdated { get; set; }

    public int ContactId { get; set; }

    public string ContactName { get; set; }

    public string Position { get; set; }

    public int? CompanyId { get; set; }

    public virtual TblCompany Company { get; set; }
}
