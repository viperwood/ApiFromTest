using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Image
{
    public int Id { get; set; }

    public string? Imagename { get; set; }

    public DateTime? Datasave { get; set; }
}
