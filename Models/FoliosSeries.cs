using System;
using System.Collections.Generic;

namespace FE.models;

public partial class FoliosSeries
{
    public string Idfolios { get; set; } = null!;

    public string? Idempresa { get; set; }

    public string? Idcertificado { get; set; }

    public string? Serie { get; set; }

    public decimal? Finicial { get; set; }

    public decimal? Ffinal { get; set; }

    public decimal? Folioactual { get; set; }

    public string? Idcomprobante { get; set; }

    public string? Idmoneda { get; set; }

    public string? Cervigencia { get; set; }

    public string? Fielvigencia { get; set; }

    public int? Activo { get; set; }
}
