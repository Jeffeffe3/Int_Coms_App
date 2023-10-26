using System;
using System.Collections.Generic;

namespace ABD_CRM.Models;

public partial class TblCompany
{
    public int? CreatedById { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastUpdated { get; set; }

    public int CompanyId { get; set; }

    public string CompanyName { get; set; }

    public string Address { get; set; }

    public string PhoneNum { get; set; }

    public string DpName { get; set; }

    public virtual ICollection<TblContact> TblContacts { get; set; } = new List<TblContact>();
}
