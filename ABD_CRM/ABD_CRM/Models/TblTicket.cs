using System;
using System.Collections.Generic;

namespace ABD_CRM.Models;

public partial class TblTicket
{
    public string TicketId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string CreatedBy { get; set; }

    public string Assignee { get; set; }

    public string AssigneeDept { get; set; }

    public string TicketDescription { get; set; }

    public string Resolved { get; set; }
}
