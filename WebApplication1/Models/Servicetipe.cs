using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Servicetipe
{
    public int Id { get; set; }

    public string? Nameservice { get; set; }

    public decimal? Cost { get; set; }

    public DateTime? Datasave { get; set; }

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
