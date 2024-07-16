using System;
using System.Collections.Generic;

namespace FE.models;

public partial class ProdServImpuestosPartidaFacHdr
{
    public string? Idempresa { get; set; }

    public string? Idcliente { get; set; }

    public string? Numfac { get; set; }

    public string? Seriefac { get; set; }

    public string? Numfacpaso { get; set; }

    public string Idproducto { get; set; } = null!;

    public string Idtipoimp { get; set; } = null!;

    public string? Nombre { get; set; }

    public string Idimpuesto { get; set; } = null!;

    public string? Nombre1 { get; set; }

    public decimal? Tasa { get; set; }

    public decimal? Importe { get; set; }

    public decimal? Partida { get; set; }
}
