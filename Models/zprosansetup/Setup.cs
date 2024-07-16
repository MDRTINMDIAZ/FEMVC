using System;
using System.Collections.Generic;

namespace FE.Models.zprosansetup;

public partial class Setup
{
    public long Id { get; set; }

    public string? Correoenviafac { get; set; }

    public string? Clave { get; set; }

    public int? Puerto { get; set; }

    public string? Host { get; set; }
}
