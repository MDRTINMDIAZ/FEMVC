using System;
using System.Collections.Generic;

namespace FE.models;

public partial class VUsuario
{
    public string Usr { get; set; } = null!;

    public string? Pass { get; set; }

    public string? Nombre { get; set; }

    public string Consulta { get; set; } = null!;

    public string? Razonsocial { get; set; }
}
