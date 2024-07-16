using System;
using System.Collections.Generic;

namespace FE.models;

public partial class ZVtipoComprobante
{
    public string Id { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Tipo { get; set; }
}
