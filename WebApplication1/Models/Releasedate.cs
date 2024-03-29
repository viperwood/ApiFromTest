﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Releasedate
{
    public int Id { get; set; }

    public int? Userid { get; set; }

    public string? Loginuser { get; set; }

    public DateTime? Datalogin { get; set; }

    public bool? Loginverification { get; set; }

    public DateTime? Datasave { get; set; }

    public virtual Usertable? User { get; set; }
}
