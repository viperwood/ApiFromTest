using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Accountant
{
    public int Id { get; set; }

    public int? Serviseaccountantid { get; set; }

    public int? Userid { get; set; }

    public DateTime? Datasave { get; set; }

    public virtual ICollection<Ordertable> Ordertables { get; set; } = new List<Ordertable>();

    public virtual Serviseaccountant? Serviseaccountant { get; set; }

    public virtual Usertable? User { get; set; }
}
