using System;
using System.Collections.Generic;

namespace FE.models;

public partial class Usuario
{
    public string Usr { get; set; } = null!;

    public string? Pass { get; set; }

    public string? Nombre { get; set; }

    public string? Idcliente { get; set; }

    public string? Idemisor { get; set; }

    public int? Consulta { get; set; }

    public string? Agesuc { get; set; }

    public string? Appacc { get; set; }
}
