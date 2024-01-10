using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Serviseaccountant
{
    public int Id { get; set; }

    public string? Nameservise { get; set; }

    public DateTime? Datasave { get; set; }

    public virtual ICollection<Accountant> Accountants { get; set; } = new List<Accountant>();
}
