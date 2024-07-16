using System;
using System.Collections.Generic;

namespace FE.models;

public partial class Certificado
{
    public string Idcertificado { get; set; } = null!;

    public string? Idempresa { get; set; }

    public string? Nocertificado { get; set; }

    public DateTime? Fechacert { get; set; }

    public DateTime? Fechavigencia { get; set; }

    public string? Rutacertificado { get; set; }

    public string? Rutallavepriv { get; set; }

    public string? Contrasenakey { get; set; }

    public int? Activo { get; set; }

    public string? Certificado1 { get; set; }

    public string? Txtkey64 { get; set; }
}
