using System;
using System.Collections.Generic;

namespace FE.models;

public partial class Empresa
{
    public string Id { get; set; } = null!;

    public string? Rfc { get; set; }

    public string? Razonsocial { get; set; }

    public string? Pais { get; set; }

    public string? Calle { get; set; }

    public string? Numext { get; set; }

    public string? Numint { get; set; }

    public string? Colonia { get; set; }

    public string? Localidad { get; set; }

    public string? Municipio { get; set; }

    public string? Referencia { get; set; }

    public string? Estado { get; set; }

    public string? Cp { get; set; }

    public string? Contacto { get; set; }

    public string? Email { get; set; }

    public string? Telefonos { get; set; }

    public string? Consultafacturas { get; set; }

    public string? Idclige { get; set; }

    public string? Regimen { get; set; }
}
