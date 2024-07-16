using System;
using System.Collections.Generic;

namespace FE.models;

public partial class VFacturasXemisor
{
    public string? Email { get; set; }

    public string? Nomcliente { get; set; }

    public string Seriefac { get; set; } = null!;

    public string Numfac { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public string? Nomtipcomprob { get; set; }

    public string? Nommoneda { get; set; }

    public decimal? Tipcambio { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Retiva { get; set; }

    public string? Can { get; set; }

    public string Idempresa { get; set; } = null!;

    public string Idcliente { get; set; } = null!;

    public decimal? Total { get; set; }

    public string Nf { get; set; } = null!;

    public string? Formapago { get; set; }

    public string? Metodopago { get; set; }

    public decimal? Descuento { get; set; }

    public string? Nombreempresa { get; set; }

    public string? Previo { get; set; }

    public string? Cfdiuuid { get; set; }
}
