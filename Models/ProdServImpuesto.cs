using System;
using System.Collections.Generic;

namespace FE.models;

public partial class ProdServImpuesto
{
    public string Idproducto { get; set; } = null!;

    public string Idtipoimp { get; set; } = null!;

    public string? Nombre { get; set; }

    public string Idimpuesto { get; set; } = null!;

    public string? Nombre1 { get; set; }

    public decimal? Tasa { get; set; }
}
