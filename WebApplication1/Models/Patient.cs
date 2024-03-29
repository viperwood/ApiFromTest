﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Patient
{
    public int Id { get; set; }

    public int? Passportnumber { get; set; }

    public DateTime? Birthday { get; set; }

    public int? Passportseries { get; set; }

    public string? Country { get; set; }

    public int? Userid { get; set; }

    public string? Socialtype { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Insurancepolicynumber { get; set; }

    public int? Insurancecompanyid { get; set; }

    public DateTime? Datasave { get; set; }

    public virtual Insurancecompany? Insurancecompany { get; set; }

    public virtual ICollection<Ordertable> Ordertables { get; set; } = new List<Ordertable>();

    public virtual Usertable? User { get; set; }
}
