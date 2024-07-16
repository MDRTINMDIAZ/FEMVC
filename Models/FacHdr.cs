using System;
using System.Collections.Generic;

namespace FE.models;

public partial class FacHdr
{
    public string Numfac { get; set; } = null!;

    public string Numfacpaso { get; set; } = null!;

    public DateTime? Fecha { get; set; }

    public string Seriefac { get; set; } = null!;

    public string Idempresa { get; set; } = null!;

    public string? Nombreempresa { get; set; }

    public string? Domempresa { get; set; }

    public string? Idcertificado { get; set; }

    public string? Idfolios { get; set; }

    public string Idcliente { get; set; } = null!;

    public string? Nomcliente { get; set; }

    public string? Domcliente { get; set; }

    public string? Formapago { get; set; }

    public string? Metodopago { get; set; }

    public string? Condipago { get; set; }

    public string Idtipcomprob { get; set; } = null!;

    public string? Nomtipcomprob { get; set; }

    public string? Idmoneda { get; set; }

    public string? Nommoneda { get; set; }

    public decimal? Tipcambio { get; set; }

    public string? Idiva { get; set; }

    public string? Nomiva { get; set; }

    public decimal? Porciva { get; set; }

    public string? Idret { get; set; }

    public string? Nomret { get; set; }

    public decimal? Porcret { get; set; }

    public string? Idisr { get; set; }

    public string? Nomisr { get; set; }

    public decimal? Porcisr { get; set; }

    public string? Idieps { get; set; }

    public string? Nomieps { get; set; }

    public decimal? Porcieps { get; set; }

    public string? Iddescuento { get; set; }

    public string? Nomdes { get; set; }

    public decimal? Porcdes { get; set; }

    public string? Observaciones { get; set; }

    public decimal? Honorarios { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Ieps { get; set; }

    public decimal? Retiva { get; set; }

    public decimal? Retisr { get; set; }

    public decimal? Total { get; set; }

    public string? Cadoriginal { get; set; }

    public string? Sellodigital { get; set; }

    public string? Cancelada { get; set; }

    public string? Ticket { get; set; }

    public string? Impletra { get; set; }

    public string? Idclige { get; set; }

    public string? Previo { get; set; }

    public string? Docadu { get; set; }

    public string? Nodocadu { get; set; }

    public string? Fecdocadu { get; set; }

    public string? Aduana { get; set; }

    public string? Txtnoped { get; set; }

    public string? Txtcampo1 { get; set; }

    public string? Txtcampo2 { get; set; }

    public string? Cadoricom { get; set; }

    public string? Fehorcerti { get; set; }

    public string? Cfdiversion { get; set; }

    public string? Cfdifechatimbrado { get; set; }

    public string? Cfdisellcfd { get; set; }

    public string? Cfdinocertificadosat { get; set; }

    public string? Cfdisellosat { get; set; }

    public string? Cfdiuuid { get; set; }

    public string? Comentario { get; set; }

    public byte[]? Imagen { get; set; }

    public string? Desobra { get; set; }

    public decimal? Deduc { get; set; }

    public string? UuidsRel { get; set; }

    public string? Tiporel { get; set; }

    public string? Idccp { get; set; }

    public byte[]? Imagenccp { get; set; }
}
