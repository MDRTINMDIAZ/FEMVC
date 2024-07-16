using System;
using System.Collections.Generic;

namespace FE.models;

public partial class CCp
{
    public long Id { get; set; }

    public string Cp { get; set; } = null!;

    public string? Estado { get; set; }

    public string? Municipio { get; set; }

    public string? Localidad { get; set; }
}
