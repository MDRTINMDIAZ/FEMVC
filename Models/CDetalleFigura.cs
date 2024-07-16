using System;
using System.Collections.Generic;

namespace FE.models;

public partial class CDetalleFigura
{
    public decimal Id { get; set; }

    public string Tipocfdi { get; set; } = null!;

    public string Numfac { get; set; } = null!;

    public string Idemisor { get; set; } = null!;

    public string Idcliente { get; set; } = null!;

    public string? Tipofigura { get; set; }

    public string? Tipofiguranombre { get; set; }

    public string? Rfc { get; set; }

    public string? Nombrechofer { get; set; }

    public string? Nolicencia { get; set; }
}
