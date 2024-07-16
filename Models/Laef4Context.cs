using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FE.models;

public partial class Laef4Context : DbContext
{
    public Laef4Context()
    {
    }

    public Laef4Context(DbContextOptions<Laef4Context> options)
        : base(options)
    {
    }

    public virtual DbSet<CColonia> CColonias { get; set; }

    public virtual DbSet<CCp> CCps { get; set; }

    public virtual DbSet<CCpcfdi> CCpcfdis { get; set; }

    public virtual DbSet<CDetalleFigura> CDetalleFiguras { get; set; }

    public virtual DbSet<CEstado> CEstados { get; set; }

    public virtual DbSet<CFiguraTransporte> CFiguraTransportes { get; set; }

    public virtual DbSet<CLocalidad> CLocalidads { get; set; }

    public virtual DbSet<CMercancia> CMercancias { get; set; }

    public virtual DbSet<CMunicipio> CMunicipios { get; set; }

    public virtual DbSet<CPaise> CPaises { get; set; }

    public virtual DbSet<CSubTipoRem> CSubTipoRems { get; set; }

    public virtual DbSet<CTipoPermiso> CTipoPermisos { get; set; }

    public virtual DbSet<CTipoVehiculo> CTipoVehiculos { get; set; }

    public virtual DbSet<CUbicacione> CUbicaciones { get; set; }

    public virtual DbSet<CUnidadDePeso> CUnidadDePesos { get; set; }

    public virtual DbSet<Certificado> Certificados { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<EmiCli> EmiClis { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<FacDetalle> FacDetalles { get; set; }

    public virtual DbSet<FacHdr> FacHdrs { get; set; }

    public virtual DbSet<FacHdrRelacionado> FacHdrRelacionados { get; set; }

    public virtual DbSet<FoliosSeries> FoliosSeries { get; set; }

    public virtual DbSet<FormaPago> FormaPagos { get; set; }

    public virtual DbSet<Iva> Ivas { get; set; }

    public virtual DbSet<MetodoPago> MetodoPagos { get; set; }

    public virtual DbSet<Moneda> Monedas { get; set; }

    public virtual DbSet<Objetoimp> Objetoimps { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<ProSerSat> ProSerSats { get; set; }

    public virtual DbSet<ProdServImpuesto> ProdServImpuestos { get; set; }

    public virtual DbSet<ProdServImpuestosPartidaFacHdr> ProdServImpuestosPartidaFacHdrs { get; set; }

    public virtual DbSet<ProdServImpuestosPartidum> ProdServImpuestosPartida { get; set; }

    public virtual DbSet<ProductosServicio> ProductosServicios { get; set; }

    public virtual DbSet<RegimenFiscal> RegimenFiscals { get; set; }

    public virtual DbSet<TipoComprobante> TipoComprobantes { get; set; }

    public virtual DbSet<TipoComprobanteSat> TipoComprobanteSats { get; set; }

    public virtual DbSet<TipoRelacion> TipoRelacions { get; set; }

    public virtual DbSet<Umsat> Umsats { get; set; }

    public virtual DbSet<UsoCfdi> UsoCfdis { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<VCertificado> VCertificados { get; set; }

    public virtual DbSet<VFactura> VFacturas { get; set; }

    public virtual DbSet<VFacturasXemisor> VFacturasXemisors { get; set; }

    public virtual DbSet<VUsuario> VUsuarios { get; set; }

    public virtual DbSet<VemiCliente> VemiClientes { get; set; }

    public virtual DbSet<Vproducto> Vproductos { get; set; }

    public virtual DbSet<ZVcpcfdi> ZVcpcfdis { get; set; }

    public virtual DbSet<ZVcpcfdi1> ZVcpcfdi1s { get; set; }

    public virtual DbSet<ZVcpcfdi2> ZVcpcfdi2s { get; set; }

    public virtual DbSet<ZVcpcfdiok> ZVcpcfdioks { get; set; }

    public virtual DbSet<ZVfoliosSeries> ZVfoliosSeries { get; set; }

    public virtual DbSet<ZVtipoComprobante> ZVtipoComprobantes { get; set; }

    public virtual DbSet<Zperfile> Zperfiles { get; set; }

    public virtual DbSet<Zrecurso> Zrecursos { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseSqlServer("Server=.\\SQLE2019;Database=laef4; user=sa;Password=sa; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<CColonia>(entity =>
        {
            entity.HasKey(e => e.Idpaso).HasName("PK_cColonias_1");

            entity.ToTable("cColonias");

            entity.HasIndex(e => e.Asentamiento, "asentamiento");

            entity.HasIndex(e => e.Cp, "cp");

            entity.HasIndex(e => e.Id, "idcolonia");

            entity.Property(e => e.Idpaso).HasColumnName("idpaso");
            entity.Property(e => e.Asentamiento)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("asentamiento");
            entity.Property(e => e.Cp)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("cp");
            entity.Property(e => e.Id)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("id");
        });

        modelBuilder.Entity<CCp>(entity =>
        {
            entity.ToTable("cCP");

            entity.HasIndex(e => e.Cp, "cp");

            entity.HasIndex(e => e.Estado, "estado");

            entity.HasIndex(e => e.Localidad, "localidad");

            entity.HasIndex(e => e.Municipio, "municipio");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cp)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("cp");
            entity.Property(e => e.Estado)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Localidad)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("localidad");
            entity.Property(e => e.Municipio)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("municipio");
        });

        modelBuilder.Entity<CCpcfdi>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Tipocfdi, e.Numfac, e.Idemisor, e.Idcliente, e.Xtipo }).HasName("PK_cCPCFDI_1");

            entity.ToTable("cCPCFDI");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Tipocfdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipocfdi");
            entity.Property(e => e.Numfac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfac");
            entity.Property(e => e.Idemisor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idemisor");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Xtipo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("xtipo");
            entity.Property(e => e.Anomodelo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("anomodelo");
            entity.Property(e => e.Idpermisosct)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("idpermisosct");
            entity.Property(e => e.Idpermisosctnombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idpermisosctnombre");
            entity.Property(e => e.Idtipovehiculo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("idtipovehiculo");
            entity.Property(e => e.Idtipovehiculonom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idtipovehiculonom");
            entity.Property(e => e.Idtipremolque1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idtipremolque1");
            entity.Property(e => e.Idtipremolque1nom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idtipremolque1nom");
            entity.Property(e => e.Idtipremolque2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idtipremolque2");
            entity.Property(e => e.Idtipremolque2nom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idtipremolque2nom");
            entity.Property(e => e.Idunidaddepeso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("idunidaddepeso");
            entity.Property(e => e.Idunidaddepesonom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idunidaddepesonom");
            entity.Property(e => e.Nodeplaca1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nodeplaca1");
            entity.Property(e => e.Nodeplaca2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nodeplaca2");
            entity.Property(e => e.Nodepoliza)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nodepoliza");
            entity.Property(e => e.Nomaseguradora)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nomaseguradora");
            entity.Property(e => e.Noplaca)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("noplaca");
            entity.Property(e => e.Numpermiso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numpermiso");
            entity.Property(e => e.PesoBrutoVehicular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pesobrutototal)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pesobrutototal");
            entity.Property(e => e.Totalmercancias)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("totalmercancias");
            entity.Property(e => e.Totdisrec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("totdisrec");
            entity.Property(e => e.Transinter)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("transinter");
        });

        modelBuilder.Entity<CDetalleFigura>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Tipocfdi, e.Numfac, e.Idemisor, e.Idcliente });

            entity.ToTable("cDetalleFiguras");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Tipocfdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipocfdi");
            entity.Property(e => e.Numfac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfac");
            entity.Property(e => e.Idemisor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idemisor");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Nolicencia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nolicencia");
            entity.Property(e => e.Nombrechofer)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombrechofer");
            entity.Property(e => e.Rfc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.Tipofigura)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipofigura");
            entity.Property(e => e.Tipofiguranombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("tipofiguranombre");
        });

        modelBuilder.Entity<CEstado>(entity =>
        {
            entity.ToTable("cEstados");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("nombre");
            entity.Property(e => e.Pais)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("pais");
        });

        modelBuilder.Entity<CFiguraTransporte>(entity =>
        {
            entity.ToTable("cFiguraTransporte");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<CLocalidad>(entity =>
        {
            entity.ToTable("cLocalidad");

            entity.HasIndex(e => e.Idestado, "idestado");

            entity.HasIndex(e => e.Idlocalidad, "idlocalidad");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Idestado)
                .HasMaxLength(19)
                .IsUnicode(false)
                .HasColumnName("idestado");
            entity.Property(e => e.Idlocalidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idlocalidad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<CMercancia>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Tipocfdi, e.Numfac, e.Idemisor, e.Idcliente });

            entity.ToTable("cMercancias");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Tipocfdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipocfdi");
            entity.Property(e => e.Numfac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfac");
            entity.Property(e => e.Idemisor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idemisor");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Cantidad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cantidad");
            entity.Property(e => e.Claveum)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("claveum");
            entity.Property(e => e.Claveumdes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("claveumdes");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Idmercasat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idmercasat");
            entity.Property(e => e.Pedimentos)
                .HasColumnType("text")
                .HasColumnName("pedimentos");
            entity.Property(e => e.Pesokg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pesokg");
        });

        modelBuilder.Entity<CMunicipio>(entity =>
        {
            entity.ToTable("cMunicipios");

            entity.HasIndex(e => e.Idestado, "idestado");

            entity.HasIndex(e => e.Idmunicipio, "idmunicipio");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Idestado)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("idestado");
            entity.Property(e => e.Idmunicipio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idmunicipio");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<CPaise>(entity =>
        {
            entity.ToTable("cPaises");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<CSubTipoRem>(entity =>
        {
            entity.ToTable("cSubTipoRem");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<CTipoPermiso>(entity =>
        {
            entity.ToTable("cTipoPermiso");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<CTipoVehiculo>(entity =>
        {
            entity.ToTable("cTipoVehiculo");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<CUbicacione>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Tipocfdi, e.Numfac, e.Idemisor, e.Idcliente });

            entity.ToTable("cUbicaciones");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Tipocfdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipocfdi");
            entity.Property(e => e.Numfac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfac");
            entity.Property(e => e.Idemisor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idemisor");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("calle");
            entity.Property(e => e.Colonia)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("colonia");
            entity.Property(e => e.Colonianombre)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("colonianombre");
            entity.Property(e => e.Cp)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("cp");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Fechahorasallle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fechahorasallle");
            entity.Property(e => e.Localidad)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("localidad");
            entity.Property(e => e.Localidadnombre)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("localidadnombre");
            entity.Property(e => e.Municipio)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("municipio");
            entity.Property(e => e.Municipionombre)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("municipionombre");
            entity.Property(e => e.Numext)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("numext");
            entity.Property(e => e.Numint)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("numint");
            entity.Property(e => e.Pais)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("pais");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("referencia");
            entity.Property(e => e.Rfcremides)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("rfcremides");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Totdisrec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("totdisrec");
            entity.Property(e => e.Transinter)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("transinter");
        });

        modelBuilder.Entity<CUnidadDePeso>(entity =>
        {
            entity.ToTable("cUnidadDePeso");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Certificado>(entity =>
        {
            entity.HasKey(e => e.Idcertificado);

            entity.Property(e => e.Idcertificado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcertificado");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Certificado1)
                .HasColumnType("text")
                .HasColumnName("certificado");
            entity.Property(e => e.Contrasenakey)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contrasenakey");
            entity.Property(e => e.Fechacert)
                .HasColumnType("datetime")
                .HasColumnName("fechacert");
            entity.Property(e => e.Fechavigencia)
                .HasColumnType("datetime")
                .HasColumnName("fechavigencia");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idempresa");
            entity.Property(e => e.Nocertificado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nocertificado");
            entity.Property(e => e.Rutacertificado)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("rutacertificado");
            entity.Property(e => e.Rutallavepriv)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("rutallavepriv");
            entity.Property(e => e.Txtkey64)
                .HasColumnType("text")
                .HasColumnName("txtkey64");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Calle)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.Colonia)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.Consultafacturas)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("consultafacturas");
            entity.Property(e => e.Contacto)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("contacto");
            entity.Property(e => e.Cp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cp");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Estado)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Idclige)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idclige");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idempresa");
            entity.Property(e => e.Idusocfdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idusocfdi");
            entity.Property(e => e.Localidad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("localidad");
            entity.Property(e => e.Municipio)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("municipio");
            entity.Property(e => e.Numcta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("numcta");
            entity.Property(e => e.Numext)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("numext");
            entity.Property(e => e.Numint)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("numint");
            entity.Property(e => e.Pais)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pais");
            entity.Property(e => e.Razonsocial)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("razonsocial");
            entity.Property(e => e.Referencia)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.Regimen)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("regimen");
            entity.Property(e => e.Rfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.Telefonos)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("telefonos");
        });

        modelBuilder.Entity<EmiCli>(entity =>
        {
            entity.HasKey(e => new { e.Idcli, e.Idemi });

            entity.ToTable("EmiCli");

            entity.Property(e => e.Idcli)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcli");
            entity.Property(e => e.Idemi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idemi");
            entity.Property(e => e.Razonsocial)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("razonsocial");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.ToTable("empresas");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Calle)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.Colonia)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.Consultafacturas)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("consultafacturas");
            entity.Property(e => e.Contacto)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("contacto");
            entity.Property(e => e.Cp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cp");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Estado)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Idclige)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idclige");
            entity.Property(e => e.Localidad)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("localidad");
            entity.Property(e => e.Municipio)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("municipio");
            entity.Property(e => e.Numext)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("numext");
            entity.Property(e => e.Numint)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("numint");
            entity.Property(e => e.Pais)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pais");
            entity.Property(e => e.Razonsocial)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("razonsocial");
            entity.Property(e => e.Referencia)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.Regimen)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("regimen");
            entity.Property(e => e.Rfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.Telefonos)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("telefonos");
        });

        modelBuilder.Entity<FacDetalle>(entity =>
        {
            entity.ToTable("FacDetalle");

            entity.HasIndex(e => e.Idobjetoimp, "idobjetoimp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad)
                .HasColumnType("money")
                .HasColumnName("cantidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Descuento)
                .HasColumnType("money")
                .HasColumnName("descuento");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idempresa");
            entity.Property(e => e.Idfolios)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idfolios");
            entity.Property(e => e.Idobjetoimp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idobjetoimp");
            entity.Property(e => e.Idprodsat)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("idprodsat");
            entity.Property(e => e.Idprodserv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idprodserv");
            entity.Property(e => e.Importe)
                .HasColumnType("money")
                .HasColumnName("importe");
            entity.Property(e => e.Nomcliente)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomcliente");
            entity.Property(e => e.Nomempresa)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomempresa");
            entity.Property(e => e.Noped)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("noped");
            entity.Property(e => e.Notas)
                .HasColumnType("text")
                .HasColumnName("notas");
            entity.Property(e => e.Numfac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfac");
            entity.Property(e => e.Numfacpaso)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfacpaso");
            entity.Property(e => e.Paciente)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("paciente");
            entity.Property(e => e.Partida)
                .HasColumnType("money")
                .HasColumnName("partida");
            entity.Property(e => e.Pu)
                .HasColumnType("money")
                .HasColumnName("pu");
            entity.Property(e => e.Seriefac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("seriefac");
            entity.Property(e => e.Totiva)
                .HasColumnType("money")
                .HasColumnName("totiva");
            entity.Property(e => e.Totret)
                .HasColumnType("money")
                .HasColumnName("totret");
            entity.Property(e => e.Um)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("um");
            entity.Property(e => e.Umsat)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("umsat");
        });

        modelBuilder.Entity<FacHdr>(entity =>
        {
            entity.HasKey(e => new { e.Numfac, e.Numfacpaso, e.Seriefac, e.Idempresa, e.Idtipcomprob });

            entity.ToTable("FacHdr");

            entity.Property(e => e.Numfac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfac");
            entity.Property(e => e.Numfacpaso)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfacpaso");
            entity.Property(e => e.Seriefac)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("seriefac");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idempresa");
            entity.Property(e => e.Idtipcomprob)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idtipcomprob");
            entity.Property(e => e.Aduana)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("aduana");
            entity.Property(e => e.Cadoricom)
                .HasColumnType("text")
                .HasColumnName("cadoricom");
            entity.Property(e => e.Cadoriginal)
                .HasColumnType("text")
                .HasColumnName("cadoriginal");
            entity.Property(e => e.Cancelada)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("cancelada");
            entity.Property(e => e.Cfdifechatimbrado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cfdifechatimbrado");
            entity.Property(e => e.Cfdinocertificadosat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cfdinocertificadosat");
            entity.Property(e => e.Cfdisellcfd)
                .HasColumnType("text")
                .HasColumnName("cfdisellcfd");
            entity.Property(e => e.Cfdisellosat)
                .HasColumnType("text")
                .HasColumnName("cfdisellosat");
            entity.Property(e => e.Cfdiuuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cfdiuuid");
            entity.Property(e => e.Cfdiversion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cfdiversion");
            entity.Property(e => e.Comentario)
                .HasColumnType("text")
                .HasColumnName("comentario");
            entity.Property(e => e.Condipago)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("condipago");
            entity.Property(e => e.Deduc)
                .HasColumnType("money")
                .HasColumnName("deduc");
            entity.Property(e => e.Descuento)
                .HasColumnType("money")
                .HasColumnName("descuento");
            entity.Property(e => e.Desobra)
                .HasColumnType("text")
                .HasColumnName("desobra");
            entity.Property(e => e.Docadu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("docadu");
            entity.Property(e => e.Domcliente)
                .HasColumnType("text")
                .HasColumnName("domcliente");
            entity.Property(e => e.Domempresa)
                .HasColumnType("text")
                .HasColumnName("domempresa");
            entity.Property(e => e.Fecdocadu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fecdocadu");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Fehorcerti)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fehorcerti");
            entity.Property(e => e.Formapago)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("formapago");
            entity.Property(e => e.Honorarios)
                .HasColumnType("money")
                .HasColumnName("honorarios");
            entity.Property(e => e.Idccp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idccp");
            entity.Property(e => e.Idcertificado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcertificado");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Idclige)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idclige");
            entity.Property(e => e.Iddescuento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("iddescuento");
            entity.Property(e => e.Idfolios)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idfolios");
            entity.Property(e => e.Idieps)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idieps");
            entity.Property(e => e.Idisr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idisr");
            entity.Property(e => e.Idiva)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idiva");
            entity.Property(e => e.Idmoneda)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idmoneda");
            entity.Property(e => e.Idret)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idret");
            entity.Property(e => e.Ieps)
                .HasColumnType("money")
                .HasColumnName("ieps");
            entity.Property(e => e.Imagen)
                .HasColumnType("image")
                .HasColumnName("imagen");
            entity.Property(e => e.Imagenccp)
                .HasColumnType("image")
                .HasColumnName("imagenccp");
            entity.Property(e => e.Impletra)
                .HasColumnType("text")
                .HasColumnName("impletra");
            entity.Property(e => e.Iva)
                .HasColumnType("money")
                .HasColumnName("iva");
            entity.Property(e => e.Metodopago)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("metodopago");
            entity.Property(e => e.Nodocadu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nodocadu");
            entity.Property(e => e.Nombreempresa)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombreempresa");
            entity.Property(e => e.Nomcliente)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomcliente");
            entity.Property(e => e.Nomdes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomdes");
            entity.Property(e => e.Nomieps)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomieps");
            entity.Property(e => e.Nomisr)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomisr");
            entity.Property(e => e.Nomiva)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomiva");
            entity.Property(e => e.Nommoneda)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nommoneda");
            entity.Property(e => e.Nomret)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomret");
            entity.Property(e => e.Nomtipcomprob)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomtipcomprob");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");
            entity.Property(e => e.Porcdes)
                .HasColumnType("money")
                .HasColumnName("porcdes");
            entity.Property(e => e.Porcieps)
                .HasColumnType("money")
                .HasColumnName("porcieps");
            entity.Property(e => e.Porcisr)
                .HasColumnType("money")
                .HasColumnName("porcisr");
            entity.Property(e => e.Porciva)
                .HasColumnType("money")
                .HasColumnName("porciva");
            entity.Property(e => e.Porcret)
                .HasColumnType("money")
                .HasColumnName("porcret");
            entity.Property(e => e.Previo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("previo");
            entity.Property(e => e.Retisr)
                .HasColumnType("money")
                .HasColumnName("retisr");
            entity.Property(e => e.Retiva)
                .HasColumnType("money")
                .HasColumnName("retiva");
            entity.Property(e => e.Sellodigital)
                .HasColumnType("text")
                .HasColumnName("sellodigital");
            entity.Property(e => e.Subtotal)
                .HasColumnType("money")
                .HasColumnName("subtotal");
            entity.Property(e => e.Ticket)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ticket");
            entity.Property(e => e.Tipcambio)
                .HasColumnType("money")
                .HasColumnName("tipcambio");
            entity.Property(e => e.Tiporel)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("tiporel");
            entity.Property(e => e.Total)
                .HasColumnType("money")
                .HasColumnName("total");
            entity.Property(e => e.Txtcampo1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("txtcampo1");
            entity.Property(e => e.Txtcampo2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("txtcampo2");
            entity.Property(e => e.Txtnoped)
                .HasColumnType("text")
                .HasColumnName("txtnoped");
            entity.Property(e => e.UuidsRel)
                .HasColumnType("text")
                .HasColumnName("UUIDsRel");
        });

        modelBuilder.Entity<FacHdrRelacionado>(entity =>
        {
            entity.HasKey(e => e.Id).IsClustered(false);

            entity.HasIndex(e => e.Idcliente, "idcliente").IsClustered();

            entity.HasIndex(e => e.Idempresa, "idempresa");

            entity.HasIndex(e => e.Numfac, "numfac");

            entity.HasIndex(e => e.Numfacpaso, "numfacpaso");

            entity.HasIndex(e => e.Seriefac, "seriefac");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cancelada).HasColumnName("cancelada");
            entity.Property(e => e.Cfdiuuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cfdiuuid");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idempresa");
            entity.Property(e => e.Moneda)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("moneda");
            entity.Property(e => e.Numfac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfac");
            entity.Property(e => e.Numfacpaso)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfacpaso");
            entity.Property(e => e.Ridcliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ridcliente");
            entity.Property(e => e.Ridempresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ridempresa");
            entity.Property(e => e.Rnumfac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rnumfac");
            entity.Property(e => e.Rnumfacpaso)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rnumfacpaso");
            entity.Property(e => e.Rserie)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rserie");
            entity.Property(e => e.Seriefac)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("seriefac");
            entity.Property(e => e.Total)
                .HasColumnType("money")
                .HasColumnName("total");
        });

        modelBuilder.Entity<FoliosSeries>(entity =>
        {
            entity.HasKey(e => e.Idfolios);

            entity.Property(e => e.Idfolios)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idfolios");
            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Cervigencia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cervigencia");
            entity.Property(e => e.Ffinal)
                .HasColumnType("money")
                .HasColumnName("ffinal");
            entity.Property(e => e.Fielvigencia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fielvigencia");
            entity.Property(e => e.Finicial)
                .HasColumnType("money")
                .HasColumnName("finicial");
            entity.Property(e => e.Folioactual)
                .HasColumnType("money")
                .HasColumnName("folioactual");
            entity.Property(e => e.Idcertificado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcertificado");
            entity.Property(e => e.Idcomprobante)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcomprobante");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idempresa");
            entity.Property(e => e.Idmoneda)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idmoneda");
            entity.Property(e => e.Serie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("serie");
        });

        modelBuilder.Entity<FormaPago>(entity =>
        {
            entity.HasKey(e => e.Idfp);

            entity.ToTable("FormaPago");

            entity.Property(e => e.Idfp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idfp");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Iva>(entity =>
        {
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Iva1)
                .HasColumnType("money")
                .HasColumnName("iva");
        });

        modelBuilder.Entity<MetodoPago>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MetodoPago");

            entity.Property(e => e.Idmp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idmp");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Moneda>(entity =>
        {
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Objetoimp>(entity =>
        {
            entity.ToTable("objetoimp");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => new { e.Numfac, e.Numfacpaso, e.Seriefac, e.Idempresa, e.Idtipcomprob, e.Uuid });

            entity.Property(e => e.Numfac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfac");
            entity.Property(e => e.Numfacpaso)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfacpaso");
            entity.Property(e => e.Seriefac)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("seriefac");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idempresa");
            entity.Property(e => e.Idtipcomprob)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idtipcomprob");
            entity.Property(e => e.Uuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uuid");
            entity.Property(e => e.Fechapago)
                .HasColumnType("datetime")
                .HasColumnName("fechapago");
            entity.Property(e => e.Folio)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("folio");
            entity.Property(e => e.Idmoneda)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idmoneda");
            entity.Property(e => e.Metododepago)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("metododepago");
            entity.Property(e => e.Montopago)
                .HasColumnType("money")
                .HasColumnName("montopago");
            entity.Property(e => e.Pago1)
                .HasColumnType("money")
                .HasColumnName("pago");
            entity.Property(e => e.Parcialidad).HasColumnName("parcialidad");
            entity.Property(e => e.Saldoanterior)
                .HasColumnType("money")
                .HasColumnName("saldoanterior");
            entity.Property(e => e.Saldoinsoluto)
                .HasColumnType("money")
                .HasColumnName("saldoinsoluto");
            entity.Property(e => e.Serie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.Tipcambio)
                .HasColumnType("money")
                .HasColumnName("tipcambio");
            entity.Property(e => e.Tipo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<ProSerSat>(entity =>
        {
            entity.ToTable("ProSerSAT");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<ProdServImpuesto>(entity =>
        {
            entity.HasKey(e => new { e.Idproducto, e.Idtipoimp, e.Idimpuesto });

            entity.Property(e => e.Idproducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idproducto");
            entity.Property(e => e.Idtipoimp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idtipoimp");
            entity.Property(e => e.Idimpuesto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idimpuesto");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Nombre1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre1");
            entity.Property(e => e.Tasa)
                .HasColumnType("money")
                .HasColumnName("tasa");
        });

        modelBuilder.Entity<ProdServImpuestosPartidaFacHdr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProdServImpuestosPartidaFacHdr");

            entity.HasIndex(e => e.Idcliente, "idcliente");

            entity.HasIndex(e => e.Idempresa, "idempresa");

            entity.HasIndex(e => e.Idimpuesto, "idimpuesto");

            entity.HasIndex(e => e.Idproducto, "idproducto");

            entity.HasIndex(e => e.Idtipoimp, "idtipoimp");

            entity.HasIndex(e => e.Numfac, "numfac");

            entity.HasIndex(e => e.Numfacpaso, "numfacpaso");

            entity.HasIndex(e => e.Partida, "partida");

            entity.HasIndex(e => e.Seriefac, "seriefac");

            entity.Property(e => e.Idcliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idempresa");
            entity.Property(e => e.Idimpuesto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idimpuesto");
            entity.Property(e => e.Idproducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idproducto");
            entity.Property(e => e.Idtipoimp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idtipoimp");
            entity.Property(e => e.Importe)
                .HasColumnType("money")
                .HasColumnName("importe");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Nombre1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre1");
            entity.Property(e => e.Numfac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfac");
            entity.Property(e => e.Numfacpaso)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfacpaso");
            entity.Property(e => e.Partida)
                .HasColumnType("money")
                .HasColumnName("partida");
            entity.Property(e => e.Seriefac)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("seriefac");
            entity.Property(e => e.Tasa)
                .HasColumnType("money")
                .HasColumnName("tasa");
        });

        modelBuilder.Entity<ProdServImpuestosPartidum>(entity =>
        {
            entity.HasKey(e => new { e.Idproducto, e.Idtipoimp, e.Idimpuesto });

            entity.Property(e => e.Idproducto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idproducto");
            entity.Property(e => e.Idtipoimp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idtipoimp");
            entity.Property(e => e.Idimpuesto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idimpuesto");
            entity.Property(e => e.Importe)
                .HasColumnType("money")
                .HasColumnName("importe");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Nombre1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre1");
            entity.Property(e => e.Tasa)
                .HasColumnType("money")
                .HasColumnName("tasa");
        });

        modelBuilder.Entity<ProductosServicio>(entity =>
        {
            entity.HasIndex(e => e.Idobjetoimp, "idobjetoimp");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Idobjetoimp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idobjetoimp");
            entity.Property(e => e.Idsat)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("idsat");
            entity.Property(e => e.Pu)
                .HasColumnType("money")
                .HasColumnName("pu");
            entity.Property(e => e.Um)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("um");
            entity.Property(e => e.Umsat)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("umsat");
        });

        modelBuilder.Entity<RegimenFiscal>(entity =>
        {
            entity.HasKey(e => e.Idre);

            entity.ToTable("RegimenFiscal");

            entity.Property(e => e.Idre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idre");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TipoComprobante>(entity =>
        {
            entity.ToTable("TipoComprobante");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Idtipcomsat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idtipcomsat");
        });

        modelBuilder.Entity<TipoComprobanteSat>(entity =>
        {
            entity.ToTable("TipoComprobanteSAT");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TipoRelacion>(entity =>
        {
            entity.ToTable("TipoRelacion");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Umsat>(entity =>
        {
            entity.ToTable("UMSat");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<UsoCfdi>(entity =>
        {
            entity.HasKey(e => e.Iduso);

            entity.ToTable("UsoCFDI");

            entity.Property(e => e.Iduso)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("iduso");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Usr);

            entity.ToTable("usuarios");

            entity.Property(e => e.Usr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usr");
            entity.Property(e => e.Agesuc)
                .HasColumnType("text")
                .HasColumnName("agesuc");
            entity.Property(e => e.Appacc)
                .HasColumnType("text")
                .HasColumnName("appacc");
            entity.Property(e => e.Consulta).HasColumnName("consulta");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Idemisor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idemisor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pass");
        });

        modelBuilder.Entity<VCertificado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vCertificados");

            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Fechacert)
                .HasColumnType("datetime")
                .HasColumnName("fechacert");
            entity.Property(e => e.Fechavigencia)
                .HasColumnType("datetime")
                .HasColumnName("fechavigencia");
            entity.Property(e => e.Idcertificado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcertificado");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idempresa");
            entity.Property(e => e.Nocertificado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nocertificado");
            entity.Property(e => e.Razonsocial)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("razonsocial");
        });

        modelBuilder.Entity<VFactura>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vFactura");

            entity.Property(e => e.Aduana)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("aduana");
            entity.Property(e => e.Cadoricom)
                .HasColumnType("text")
                .HasColumnName("cadoricom");
            entity.Property(e => e.Cadoriginal)
                .HasColumnType("text")
                .HasColumnName("cadoriginal");
            entity.Property(e => e.Cancelada)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("cancelada");
            entity.Property(e => e.Cantidad)
                .HasColumnType("money")
                .HasColumnName("cantidad");
            entity.Property(e => e.Cfdifechatimbrado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cfdifechatimbrado");
            entity.Property(e => e.Cfdinocertificadosat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cfdinocertificadosat");
            entity.Property(e => e.Cfdisellcfd)
                .HasColumnType("text")
                .HasColumnName("cfdisellcfd");
            entity.Property(e => e.Cfdisellosat)
                .HasColumnType("text")
                .HasColumnName("cfdisellosat");
            entity.Property(e => e.Cfdiuuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cfdiuuid");
            entity.Property(e => e.Cfdiversion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cfdiversion");
            entity.Property(e => e.Comentario)
                .HasColumnType("text")
                .HasColumnName("comentario");
            entity.Property(e => e.Condipago)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("condipago");
            entity.Property(e => e.Deduc)
                .HasColumnType("money")
                .HasColumnName("deduc");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Descuento)
                .HasColumnType("money")
                .HasColumnName("descuento");
            entity.Property(e => e.Descuentopartida)
                .HasColumnType("money")
                .HasColumnName("descuentopartida");
            entity.Property(e => e.Descusocfdi)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descusocfdi");
            entity.Property(e => e.Desobra)
                .HasColumnType("text")
                .HasColumnName("desobra");
            entity.Property(e => e.Docadu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("docadu");
            entity.Property(e => e.Domcliente)
                .HasColumnType("text")
                .HasColumnName("domcliente");
            entity.Property(e => e.Domempresa)
                .HasColumnType("text")
                .HasColumnName("domempresa");
            entity.Property(e => e.Fecdocadu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fecdocadu");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Fehorcerti)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fehorcerti");
            entity.Property(e => e.Formapago)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("formapago");
            entity.Property(e => e.Honorarios)
                .HasColumnType("money")
                .HasColumnName("honorarios");
            entity.Property(e => e.Idcertificado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcertificado");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Idclige)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idclige");
            entity.Property(e => e.Iddescuento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("iddescuento");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idempresa");
            entity.Property(e => e.Idfolios)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idfolios");
            entity.Property(e => e.Idieps)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idieps");
            entity.Property(e => e.Idimpuesto)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idimpuesto");
            entity.Property(e => e.Idisr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idisr");
            entity.Property(e => e.Idiva)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idiva");
            entity.Property(e => e.Idmoneda)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idmoneda");
            entity.Property(e => e.Idobjetoimp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idobjetoimp");
            entity.Property(e => e.Idobjetoimpnombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("idobjetoimpnombre");
            entity.Property(e => e.Idprodsat)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("idprodsat");
            entity.Property(e => e.Idprodserv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idprodserv");
            entity.Property(e => e.Idre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idre");
            entity.Property(e => e.Idret)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idret");
            entity.Property(e => e.Idtipcomprob)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idtipcomprob");
            entity.Property(e => e.Iduso)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("iduso");
            entity.Property(e => e.Ieps)
                .HasColumnType("money")
                .HasColumnName("ieps");
            entity.Property(e => e.Imagen)
                .HasColumnType("image")
                .HasColumnName("imagen");
            entity.Property(e => e.Impletra)
                .HasColumnType("text")
                .HasColumnName("impletra");
            entity.Property(e => e.Importe)
                .HasColumnType("money")
                .HasColumnName("importe");
            entity.Property(e => e.Importeimpuestopartida)
                .HasColumnType("money")
                .HasColumnName("importeimpuestopartida");
            entity.Property(e => e.Iva)
                .HasColumnType("money")
                .HasColumnName("iva");
            entity.Property(e => e.Metodopago)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("metodopago");
            entity.Property(e => e.Nocertificado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nocertificado");
            entity.Property(e => e.Nodocadu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nodocadu");
            entity.Property(e => e.Nombreempresa)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombreempresa");
            entity.Property(e => e.Nombreimpuesto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombreimpuesto");
            entity.Property(e => e.Nombreregimen)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombreregimen");
            entity.Property(e => e.Nombretipimp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombretipimp");
            entity.Property(e => e.Nomcliente)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomcliente");
            entity.Property(e => e.Nomdes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomdes");
            entity.Property(e => e.Nomieps)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomieps");
            entity.Property(e => e.Nomisr)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomisr");
            entity.Property(e => e.Nomiva)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomiva");
            entity.Property(e => e.Nommoneda)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nommoneda");
            entity.Property(e => e.Nomret)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomret");
            entity.Property(e => e.Nomtipcomprob)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomtipcomprob");
            entity.Property(e => e.Numfac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfac");
            entity.Property(e => e.Numfacpaso)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfacpaso");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");
            entity.Property(e => e.Partida)
                .HasColumnType("money")
                .HasColumnName("partida");
            entity.Property(e => e.Porcdes)
                .HasColumnType("money")
                .HasColumnName("porcdes");
            entity.Property(e => e.Porcieps)
                .HasColumnType("money")
                .HasColumnName("porcieps");
            entity.Property(e => e.Porcisr)
                .HasColumnType("money")
                .HasColumnName("porcisr");
            entity.Property(e => e.Porciva)
                .HasColumnType("money")
                .HasColumnName("porciva");
            entity.Property(e => e.Porcret)
                .HasColumnType("money")
                .HasColumnName("porcret");
            entity.Property(e => e.Previo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("previo");
            entity.Property(e => e.Pu)
                .HasColumnType("money")
                .HasColumnName("pu");
            entity.Property(e => e.Regimen)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("regimen");
            entity.Property(e => e.Regimencli)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("regimencli");
            entity.Property(e => e.Regimenclinombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("regimenclinombre");
            entity.Property(e => e.Retisr)
                .HasColumnType("money")
                .HasColumnName("retisr");
            entity.Property(e => e.Retiva)
                .HasColumnType("money")
                .HasColumnName("retiva");
            entity.Property(e => e.Sellodigital)
                .HasColumnType("text")
                .HasColumnName("sellodigital");
            entity.Property(e => e.Seriefac)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("seriefac");
            entity.Property(e => e.Subtotal)
                .HasColumnType("money")
                .HasColumnName("subtotal");
            entity.Property(e => e.Tasa)
                .HasColumnType("money")
                .HasColumnName("tasa");
            entity.Property(e => e.Ticket)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ticket");
            entity.Property(e => e.Tipcambio)
                .HasColumnType("money")
                .HasColumnName("tipcambio");
            entity.Property(e => e.Tiporel)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("tiporel");
            entity.Property(e => e.Total)
                .HasColumnType("money")
                .HasColumnName("total");
            entity.Property(e => e.Totiva)
                .HasColumnType("money")
                .HasColumnName("totiva");
            entity.Property(e => e.Totret)
                .HasColumnType("money")
                .HasColumnName("totret");
            entity.Property(e => e.Txtcampo1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("txtcampo1");
            entity.Property(e => e.Txtcampo2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("txtcampo2");
            entity.Property(e => e.Txtnoped)
                .HasColumnType("text")
                .HasColumnName("txtnoped");
            entity.Property(e => e.Um)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("um");
            entity.Property(e => e.Umsat)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("umsat");
            entity.Property(e => e.UuidsRel)
                .HasColumnType("text")
                .HasColumnName("UUIDsRel");
        });

        modelBuilder.Entity<VFacturasXemisor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vFacturasXEmisor");

            entity.Property(e => e.Can)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("can");
            entity.Property(e => e.Cfdiuuid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cfdiuuid");
            entity.Property(e => e.Descuento)
                .HasColumnType("money")
                .HasColumnName("descuento");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Formapago)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("formapago");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idempresa");
            entity.Property(e => e.Iva)
                .HasColumnType("money")
                .HasColumnName("iva");
            entity.Property(e => e.Metodopago)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("metodopago");
            entity.Property(e => e.Nf)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nf");
            entity.Property(e => e.Nombreempresa)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombreempresa");
            entity.Property(e => e.Nomcliente)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomcliente");
            entity.Property(e => e.Nommoneda)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nommoneda");
            entity.Property(e => e.Nomtipcomprob)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomtipcomprob");
            entity.Property(e => e.Numfac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfac");
            entity.Property(e => e.Previo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("previo");
            entity.Property(e => e.Retiva)
                .HasColumnType("money")
                .HasColumnName("retiva");
            entity.Property(e => e.Seriefac)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("seriefac");
            entity.Property(e => e.Subtotal)
                .HasColumnType("money")
                .HasColumnName("subtotal");
            entity.Property(e => e.Tipcambio)
                .HasColumnType("money")
                .HasColumnName("tipcambio");
            entity.Property(e => e.Total)
                .HasColumnType("money")
                .HasColumnName("total");
        });

        modelBuilder.Entity<VUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vUsuarios");

            entity.Property(e => e.Consulta)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("consulta");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pass");
            entity.Property(e => e.Razonsocial)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("razonsocial");
            entity.Property(e => e.Usr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usr");
        });

        modelBuilder.Entity<VemiCliente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VEmiClientes");

            entity.Property(e => e.Idcli)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcli");
            entity.Property(e => e.Idemi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idemi");
            entity.Property(e => e.Nomcli)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomcli");
            entity.Property(e => e.Nomemi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nomemi");
        });

        modelBuilder.Entity<Vproducto>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VProductos");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(4000)
                .HasColumnName("descripcion");
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
        });

        modelBuilder.Entity<ZVcpcfdi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("zVCPCFDI");

            entity.Property(e => e.Anomodelo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("anomodelo");
            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("calle");
            entity.Property(e => e.Cantidad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("cantidad");
            entity.Property(e => e.Claveum)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("claveum");
            entity.Property(e => e.Claveumdes)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("claveumdes");
            entity.Property(e => e.Colonia)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("colonia");
            entity.Property(e => e.Colonianombre)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("colonianombre");
            entity.Property(e => e.Cp)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("cp");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Fechahorasallle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fechahorasallle");
            entity.Property(e => e.Fehorcerti)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fehorcerti");
            entity.Property(e => e.Idccp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idccp");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Idemisor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idemisor");
            entity.Property(e => e.Idmercasat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("idmercasat");
            entity.Property(e => e.Idpermisosct)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("idpermisosct");
            entity.Property(e => e.Idpermisosctnombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idpermisosctnombre");
            entity.Property(e => e.Idtipovehiculo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("idtipovehiculo");
            entity.Property(e => e.Idtipovehiculonom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idtipovehiculonom");
            entity.Property(e => e.Idtipremolque1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idtipremolque1");
            entity.Property(e => e.Idtipremolque1nom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idtipremolque1nom");
            entity.Property(e => e.Idtipremolque2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idtipremolque2");
            entity.Property(e => e.Idtipremolque2nom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idtipremolque2nom");
            entity.Property(e => e.Idunidaddepeso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("idunidaddepeso");
            entity.Property(e => e.Idunidaddepesonom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idunidaddepesonom");
            entity.Property(e => e.Imagenccp)
                .HasColumnType("image")
                .HasColumnName("imagenccp");
            entity.Property(e => e.Localidad)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("localidad");
            entity.Property(e => e.Localidadnombre)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("localidadnombre");
            entity.Property(e => e.Municipio)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("municipio");
            entity.Property(e => e.Municipionombre)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("municipionombre");
            entity.Property(e => e.Nodeplaca1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nodeplaca1");
            entity.Property(e => e.Nodeplaca2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nodeplaca2");
            entity.Property(e => e.Nodepoliza)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nodepoliza");
            entity.Property(e => e.Nolicencia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("nolicencia");
            entity.Property(e => e.Nomaseguradora)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nomaseguradora");
            entity.Property(e => e.Nombrechofer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("nombrechofer");
            entity.Property(e => e.Noplaca)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("noplaca");
            entity.Property(e => e.Numext)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("numext");
            entity.Property(e => e.Numfac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfac");
            entity.Property(e => e.Numint)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("numint");
            entity.Property(e => e.Numpermiso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numpermiso");
            entity.Property(e => e.Pais)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("pais");
            entity.Property(e => e.Pedimentos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pedimentos");
            entity.Property(e => e.PesoBrutoVehicular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pesobrutototal)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pesobrutototal");
            entity.Property(e => e.Pesokg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pesokg");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("referencia");
            entity.Property(e => e.Rfc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.Rfcremides)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("rfcremides");
            entity.Property(e => e.Sep1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sep1");
            entity.Property(e => e.Sep3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sep3");
            entity.Property(e => e.Sep4)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sep4");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipocfdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipocfdi");
            entity.Property(e => e.Tipofigura)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipofigura");
            entity.Property(e => e.Tipofiguranombre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipofiguranombre");
            entity.Property(e => e.Totalmercancias)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("totalmercancias");
            entity.Property(e => e.Totdisrec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("totdisrec");
            entity.Property(e => e.Transinter)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("transinter");
            entity.Property(e => e.Transinter2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("transinter2");
            entity.Property(e => e.Xtipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("xtipo");
        });

        modelBuilder.Entity<ZVcpcfdi1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("zVCPCFDI1");

            entity.Property(e => e.Anomodelo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("anomodelo");
            entity.Property(e => e.Calle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.Cantidad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cantidad");
            entity.Property(e => e.Claveum)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("claveum");
            entity.Property(e => e.Claveumdes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("claveumdes");
            entity.Property(e => e.Colonia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.Colonianombre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("colonianombre");
            entity.Property(e => e.Cp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("cp");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fechahorasallle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("fechahorasallle");
            entity.Property(e => e.Fehorcerti)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fehorcerti");
            entity.Property(e => e.Idccp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idccp");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Idemisor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idemisor");
            entity.Property(e => e.Idmercasat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idmercasat");
            entity.Property(e => e.Idpermisosct)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("idpermisosct");
            entity.Property(e => e.Idpermisosctnombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idpermisosctnombre");
            entity.Property(e => e.Idtipovehiculo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("idtipovehiculo");
            entity.Property(e => e.Idtipovehiculonom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idtipovehiculonom");
            entity.Property(e => e.Idtipremolque1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idtipremolque1");
            entity.Property(e => e.Idtipremolque1nom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idtipremolque1nom");
            entity.Property(e => e.Idtipremolque2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idtipremolque2");
            entity.Property(e => e.Idtipremolque2nom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idtipremolque2nom");
            entity.Property(e => e.Idunidaddepeso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("idunidaddepeso");
            entity.Property(e => e.Idunidaddepesonom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idunidaddepesonom");
            entity.Property(e => e.Imagenccp)
                .HasColumnType("image")
                .HasColumnName("imagenccp");
            entity.Property(e => e.Localidad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("localidad");
            entity.Property(e => e.Localidadnombre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("localidadnombre");
            entity.Property(e => e.Municipio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("municipio");
            entity.Property(e => e.Municipionombre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("municipionombre");
            entity.Property(e => e.Nodeplaca1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nodeplaca1");
            entity.Property(e => e.Nodeplaca2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nodeplaca2");
            entity.Property(e => e.Nodepoliza)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nodepoliza");
            entity.Property(e => e.Nolicencia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("nolicencia");
            entity.Property(e => e.Nomaseguradora)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nomaseguradora");
            entity.Property(e => e.Nombrechofer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("nombrechofer");
            entity.Property(e => e.Noplaca)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("noplaca");
            entity.Property(e => e.Numext)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("numext");
            entity.Property(e => e.Numfac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfac");
            entity.Property(e => e.Numint)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("numint");
            entity.Property(e => e.Numpermiso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numpermiso");
            entity.Property(e => e.Pais)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pais");
            entity.Property(e => e.Pedimentos)
                .HasColumnType("text")
                .HasColumnName("pedimentos");
            entity.Property(e => e.PesoBrutoVehicular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pesobrutototal)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pesobrutototal");
            entity.Property(e => e.Pesokg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pesokg");
            entity.Property(e => e.Referencia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.Rfc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.Rfcremides)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("rfcremides");
            entity.Property(e => e.Sep1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sep1");
            entity.Property(e => e.Sep3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sep3");
            entity.Property(e => e.Sep4)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sep4");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipocfdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipocfdi");
            entity.Property(e => e.Tipofigura)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipofigura");
            entity.Property(e => e.Tipofiguranombre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipofiguranombre");
            entity.Property(e => e.Totalmercancias)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("totalmercancias");
            entity.Property(e => e.Totdisrec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("totdisrec");
            entity.Property(e => e.Transinter)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("transinter");
            entity.Property(e => e.Transinter2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transinter2");
            entity.Property(e => e.Xtipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("xtipo");
        });

        modelBuilder.Entity<ZVcpcfdi2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("zVCPCFDI2");

            entity.Property(e => e.Anomodelo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("anomodelo");
            entity.Property(e => e.Calle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("calle");
            entity.Property(e => e.Cantidad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("cantidad");
            entity.Property(e => e.Claveum)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("claveum");
            entity.Property(e => e.Claveumdes)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("claveumdes");
            entity.Property(e => e.Colonia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("colonia");
            entity.Property(e => e.Colonianombre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("colonianombre");
            entity.Property(e => e.Cp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("cp");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fechahorasallle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("fechahorasallle");
            entity.Property(e => e.Fehorcerti)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fehorcerti");
            entity.Property(e => e.Idccp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idccp");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Idemisor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idemisor");
            entity.Property(e => e.Idmercasat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("idmercasat");
            entity.Property(e => e.Idpermisosct)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("idpermisosct");
            entity.Property(e => e.Idpermisosctnombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idpermisosctnombre");
            entity.Property(e => e.Idtipovehiculo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("idtipovehiculo");
            entity.Property(e => e.Idtipovehiculonom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idtipovehiculonom");
            entity.Property(e => e.Idtipremolque1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idtipremolque1");
            entity.Property(e => e.Idtipremolque1nom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idtipremolque1nom");
            entity.Property(e => e.Idtipremolque2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idtipremolque2");
            entity.Property(e => e.Idtipremolque2nom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idtipremolque2nom");
            entity.Property(e => e.Idunidaddepeso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("idunidaddepeso");
            entity.Property(e => e.Idunidaddepesonom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idunidaddepesonom");
            entity.Property(e => e.Imagenccp)
                .HasColumnType("image")
                .HasColumnName("imagenccp");
            entity.Property(e => e.Localidad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("localidad");
            entity.Property(e => e.Localidadnombre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("localidadnombre");
            entity.Property(e => e.Municipio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("municipio");
            entity.Property(e => e.Municipionombre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("municipionombre");
            entity.Property(e => e.Nodeplaca1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nodeplaca1");
            entity.Property(e => e.Nodeplaca2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nodeplaca2");
            entity.Property(e => e.Nodepoliza)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nodepoliza");
            entity.Property(e => e.Nolicencia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nolicencia");
            entity.Property(e => e.Nomaseguradora)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nomaseguradora");
            entity.Property(e => e.Nombrechofer)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombrechofer");
            entity.Property(e => e.Noplaca)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("noplaca");
            entity.Property(e => e.Numext)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("numext");
            entity.Property(e => e.Numfac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfac");
            entity.Property(e => e.Numint)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("numint");
            entity.Property(e => e.Numpermiso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numpermiso");
            entity.Property(e => e.Pais)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pais");
            entity.Property(e => e.Pedimentos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pedimentos");
            entity.Property(e => e.PesoBrutoVehicular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pesobrutototal)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pesobrutototal");
            entity.Property(e => e.Pesokg)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pesokg");
            entity.Property(e => e.Referencia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("referencia");
            entity.Property(e => e.Rfc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.Rfcremides)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("rfcremides");
            entity.Property(e => e.Sep1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sep1");
            entity.Property(e => e.Sep3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sep3");
            entity.Property(e => e.Sep4)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sep4");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipocfdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipocfdi");
            entity.Property(e => e.Tipofigura)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipofigura");
            entity.Property(e => e.Tipofiguranombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("tipofiguranombre");
            entity.Property(e => e.Totalmercancias)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("totalmercancias");
            entity.Property(e => e.Totdisrec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("totdisrec");
            entity.Property(e => e.Transinter)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("transinter");
            entity.Property(e => e.Transinter2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("transinter2");
            entity.Property(e => e.Xtipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("xtipo");
        });

        modelBuilder.Entity<ZVcpcfdiok>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("zVCPCFDIOK");

            entity.Property(e => e.Anomodelo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("anomodelo");
            entity.Property(e => e.Calle)
                .HasMaxLength(100)
                .HasColumnName("calle");
            entity.Property(e => e.Cantidad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cantidad");
            entity.Property(e => e.Claveum)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("claveum");
            entity.Property(e => e.Claveumdes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("claveumdes");
            entity.Property(e => e.Colonia)
                .HasMaxLength(100)
                .HasColumnName("colonia");
            entity.Property(e => e.Colonianombre)
                .HasMaxLength(100)
                .HasColumnName("colonianombre");
            entity.Property(e => e.Cp)
                .HasMaxLength(5)
                .HasColumnName("cp");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .HasColumnName("estado");
            entity.Property(e => e.Fechahorasallle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fechahorasallle");
            entity.Property(e => e.Fehorcerti)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fehorcerti");
            entity.Property(e => e.Idccp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idccp");
            entity.Property(e => e.Idcliente)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcliente");
            entity.Property(e => e.Idemisor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idemisor");
            entity.Property(e => e.Idmercasat)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idmercasat");
            entity.Property(e => e.Idpermisosct)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("idpermisosct");
            entity.Property(e => e.Idpermisosctnombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idpermisosctnombre");
            entity.Property(e => e.Idtipovehiculo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("idtipovehiculo");
            entity.Property(e => e.Idtipovehiculonom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idtipovehiculonom");
            entity.Property(e => e.Idtipremolque1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idtipremolque1");
            entity.Property(e => e.Idtipremolque1nom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idtipremolque1nom");
            entity.Property(e => e.Idtipremolque2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("idtipremolque2");
            entity.Property(e => e.Idtipremolque2nom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idtipremolque2nom");
            entity.Property(e => e.Idunidaddepeso)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("idunidaddepeso");
            entity.Property(e => e.Idunidaddepesonom)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("idunidaddepesonom");
            entity.Property(e => e.Imagenccp)
                .HasColumnType("image")
                .HasColumnName("imagenccp");
            entity.Property(e => e.Localidad)
                .HasMaxLength(100)
                .HasColumnName("localidad");
            entity.Property(e => e.Localidadnombre)
                .HasMaxLength(100)
                .HasColumnName("localidadnombre");
            entity.Property(e => e.Municipio)
                .HasMaxLength(100)
                .HasColumnName("municipio");
            entity.Property(e => e.Municipionombre)
                .HasMaxLength(100)
                .HasColumnName("municipionombre");
            entity.Property(e => e.Nodeplaca1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nodeplaca1");
            entity.Property(e => e.Nodeplaca2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nodeplaca2");
            entity.Property(e => e.Nodepoliza)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nodepoliza");
            entity.Property(e => e.Nolicencia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nolicencia");
            entity.Property(e => e.Nomaseguradora)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nomaseguradora");
            entity.Property(e => e.Nombrechofer)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombrechofer");
            entity.Property(e => e.Noplaca)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("noplaca");
            entity.Property(e => e.Numext)
                .HasMaxLength(50)
                .HasColumnName("numext");
            entity.Property(e => e.Numfac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("numfac");
            entity.Property(e => e.Numint)
                .HasMaxLength(50)
                .HasColumnName("numint");
            entity.Property(e => e.Numpermiso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numpermiso");
            entity.Property(e => e.Pais)
                .HasMaxLength(10)
                .HasColumnName("pais");
            entity.Property(e => e.Pedimentos)
                .HasColumnType("text")
                .HasColumnName("pedimentos");
            entity.Property(e => e.PesoBrutoVehicular)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pesobrutototal)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pesobrutototal");
            entity.Property(e => e.Pesokg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pesokg");
            entity.Property(e => e.Referencia)
                .HasMaxLength(100)
                .HasColumnName("referencia");
            entity.Property(e => e.Rfc)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.Rfcremides)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("rfcremides");
            entity.Property(e => e.Sep1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sep1");
            entity.Property(e => e.Sep3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sep3");
            entity.Property(e => e.Sep4)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("sep4");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.Tipocfdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipocfdi");
            entity.Property(e => e.Tipofigura)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tipofigura");
            entity.Property(e => e.Tipofiguranombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("tipofiguranombre");
            entity.Property(e => e.Totalmercancias)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("totalmercancias");
            entity.Property(e => e.Totdisrec)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("totdisrec");
            entity.Property(e => e.Transinter)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("transinter");
            entity.Property(e => e.Transinter2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("transinter2");
            entity.Property(e => e.Xtipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("xtipo");
        });

        modelBuilder.Entity<ZVfoliosSeries>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("zVFoliosSeries");

            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Ffinal)
                .HasColumnType("money")
                .HasColumnName("ffinal");
            entity.Property(e => e.Finicial)
                .HasColumnType("money")
                .HasColumnName("finicial");
            entity.Property(e => e.Folioactual)
                .HasColumnType("money")
                .HasColumnName("folioactual");
            entity.Property(e => e.Idcertificado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcertificado");
            entity.Property(e => e.Idcomprobante)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idcomprobante");
            entity.Property(e => e.Idempresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idempresa");
            entity.Property(e => e.Idfolios)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idfolios");
            entity.Property(e => e.Nocertificado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nocertificado");
            entity.Property(e => e.Razonsocial)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("razonsocial");
            entity.Property(e => e.Serie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("serie");
        });

        modelBuilder.Entity<ZVtipoComprobante>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("zVTipoComprobante");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Tipo)
                .HasMaxLength(221)
                .IsUnicode(false)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<Zperfile>(entity =>
        {
            entity.HasKey(e => e.Perfil);

            entity.ToTable("zperfiles");

            entity.Property(e => e.Perfil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("perfil");
            entity.Property(e => e.Agesuc)
                .HasColumnType("text")
                .HasColumnName("agesuc");
            entity.Property(e => e.Appacc)
                .HasColumnType("text")
                .HasColumnName("appacc");
        });

        modelBuilder.Entity<Zrecurso>(entity =>
        {
            entity.ToTable("zrecursos");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Acceso)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("acceso");
            entity.Property(e => e.Recursos)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("recursos");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
