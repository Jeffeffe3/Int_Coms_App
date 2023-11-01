using System;
using System.Collections.Generic;

namespace ABD_CRM.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string Make { get; set; }

    public string Model { get; set; }

    public int Year { get; set; }

    public decimal Price { get; set; }

    public DateTime DateLoaded { get; set; }
}
