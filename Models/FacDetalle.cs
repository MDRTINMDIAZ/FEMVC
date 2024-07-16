using System;
using System.Collections.Generic;

namespace FE.models;

public partial class FacDetalle
{
    public int Id { get; set; }

    public string? Idfolios { get; set; }

    public string? Idempresa { get; set; }

    public string? Nomempresa { get; set; }

    public string? Idcliente { get; set; }

    public string? Nomcliente { get; set; }

    public string? Seriefac { get; set; }

    public string? Numfac { get; set; }

    public string? Numfacpaso { get; set; }

    public string? Idprodserv { get; set; }

    public decimal? Cantidad { get; set; }

    public string? Um { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Pu { get; set; }

    public decimal? Importe { get; set; }

    public decimal? Partida { get; set; }

    public string? Noped { get; set; }

    public string? Notas { get; set; }

    public string? Paciente { get; set; }

    public string? Idprodsat { get; set; }

    public string? Umsat { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? Totret { get; set; }

    public decimal? Totiva { get; set; }

    public string? Idobjetoimp { get; set; }
}
