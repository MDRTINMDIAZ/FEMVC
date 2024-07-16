using System;
using System.Collections.Generic;

namespace FE.models;

public partial class VCertificado
{
    public string Idcertificado { get; set; } = null!;

    public string? Idempresa { get; set; }

    public string? Razonsocial { get; set; }

    public string? Nocertificado { get; set; }

    public DateTime? Fechacert { get; set; }

    public DateTime? Fechavigencia { get; set; }

    public int? Activo { get; set; }
}
