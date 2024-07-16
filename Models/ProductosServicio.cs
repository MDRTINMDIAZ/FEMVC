using System;
using System.Collections.Generic;

namespace FE.models;

public partial class ProductosServicio
{
    public string Id { get; set; } = null!;

    public string? Um { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Pu { get; set; }

    public string? Idsat { get; set; }

    public string? Umsat { get; set; }

    public string? Idobjetoimp { get; set; }
}
