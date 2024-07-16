using System;
using System.Collections.Generic;

namespace FE.models;

public partial class CUbicacione
{
    public decimal Id { get; set; }

    public string Tipocfdi { get; set; } = null!;

    public string Numfac { get; set; } = null!;

    public string Idemisor { get; set; } = null!;

    public string Idcliente { get; set; } = null!;

    public string? Transinter { get; set; }

    public string? Totdisrec { get; set; }

    public string? Tipo { get; set; }

    public string? Rfcremides { get; set; }

    public string? Fechahorasallle { get; set; }

    public string? Calle { get; set; }

    public string? Numext { get; set; }

    public string? Numint { get; set; }

    public string? Colonia { get; set; }

    public string? Colonianombre { get; set; }

    public string? Localidad { get; set; }

    public string? Localidadnombre { get; set; }

    public string? Referencia { get; set; }

    public string? Municipio { get; set; }

    public string? Municipionombre { get; set; }

    public string? Estado { get; set; }

    public string? Pais { get; set; }

    public string? Cp { get; set; }
}
