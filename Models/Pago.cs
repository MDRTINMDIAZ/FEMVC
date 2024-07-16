using System;
using System.Collections.Generic;

namespace FE.models;

public partial class Pago
{
    public string Numfac { get; set; } = null!;

    public string Numfacpaso { get; set; } = null!;

    public string Seriefac { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string Idtipcomprob { get; set; } = null!;

    public string Uuid { get; set; } = null!;

    public DateTime? Fechapago { get; set; }

    public string? Serie { get; set; }

    public string? Folio { get; set; }

    public decimal? Saldoanterior { get; set; }

    public decimal? Montopago { get; set; }

    public decimal? Saldoinsoluto { get; set; }

    public string? Tipo { get; set; }

    public decimal? Pago1 { get; set; }

    public string? Idmoneda { get; set; }

    public decimal? Tipcambio { get; set; }

    public string? Metododepago { get; set; }

    public int? Parcialidad { get; set; }
}
