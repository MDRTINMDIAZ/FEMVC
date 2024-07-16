using System;
using System.Collections.Generic;

namespace FE.models;

public partial class CMercancia
{
    public decimal Id { get; set; }

    public string Tipocfdi { get; set; } = null!;

    public string Numfac { get; set; } = null!;

    public string Idemisor { get; set; } = null!;

    public string Idcliente { get; set; } = null!;

    public string? Idmercasat { get; set; }

    public string? Descripcion { get; set; }

    public string? Claveum { get; set; }

    public string? Claveumdes { get; set; }

    public string? Cantidad { get; set; }

    public string? Pesokg { get; set; }

    public string? Pedimentos { get; set; }
}
