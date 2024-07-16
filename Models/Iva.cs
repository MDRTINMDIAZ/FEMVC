using System;
using System.Collections.Generic;

namespace FE.models;

public partial class Iva
{
    public string Id { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal? Iva1 { get; set; }
}
