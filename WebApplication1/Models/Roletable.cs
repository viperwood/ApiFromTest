using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Roletable
{
    public int Id { get; set; }

    public string? Namerole { get; set; }

    public DateTime? Datasave { get; set; }

    public virtual ICollection<Usertable> Usertables { get; set; } = new List<Usertable>();
}
