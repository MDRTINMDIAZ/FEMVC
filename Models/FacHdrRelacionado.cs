using System;
using System.Collections.Generic;

namespace FE.models;

public partial class FacHdrRelacionado
{
    public int Id { get; set; }

    public string? Numfac { get; set; }

    public string? Numfacpaso { get; set; }

    public string? Seriefac { get; set; }

    public string? Idempresa { get; set; }

    public string? Idcliente { get; set; }

    public string? Rnumfac { get; set; }

    public string? Rnumfacpaso { get; set; }

    public string? Rserie { get; set; }

    public string? Ridempresa { get; set; }

    public string? Ridcliente { get; set; }

    public string? Cfdiuuid { get; set; }

    public string? Moneda { get; set; }

    public decimal? Total { get; set; }

    public int? Cancelada { get; set; }
}
