using System;
using System.Collections.Generic;

namespace FE.models;

public partial class ZVfoliosSeries
{
    public string Idfolios { get; set; } = null!;

    public string? Idempresa { get; set; }

    public string? Razonsocial { get; set; }

    public string? Idcertificado { get; set; }

    public string? Nocertificado { get; set; }

    public string? Serie { get; set; }

    public decimal? Finicial { get; set; }

    public decimal? Ffinal { get; set; }

    public decimal? Folioactual { get; set; }

    public string? Idcomprobante { get; set; }

    public string? Descripcion { get; set; }

    public int? Activo { get; set; }
}
