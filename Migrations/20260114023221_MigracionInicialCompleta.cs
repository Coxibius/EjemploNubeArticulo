using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace simple.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicialCompleta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArchivosArchivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "date", nullable: false),
                    TipoDocumento = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchivosArchivos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articulo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Precio = table.Column<decimal>(type: "numeric", nullable: false),
                    Codigo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BecasEstudiantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreCompleto = table.Column<string>(type: "text", nullable: false),
                    CodigoEstudiante = table.Column<string>(type: "text", nullable: false),
                    Carrera = table.Column<string>(type: "text", nullable: false),
                    MontoMensualBeca = table.Column<decimal>(type: "numeric", nullable: false),
                    FechaInicioBeca = table.Column<DateTime>(type: "date", nullable: false),
                    BecaActiva = table.Column<bool>(type: "boolean", nullable: false),
                    TipoBeca = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BecasEstudiantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BibliotecaLibros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    Autor = table.Column<string>(type: "text", nullable: false),
                    Editorial = table.Column<string>(type: "text", nullable: false),
                    AnioPublicacion = table.Column<int>(type: "integer", nullable: false),
                    Disponible = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BibliotecaLibros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CajaFacturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumeroFactura = table.Column<string>(type: "text", nullable: false),
                    FechaFactura = table.Column<DateTime>(type: "date", nullable: false),
                    SubTotal = table.Column<decimal>(type: "numeric", nullable: false),
                    Impuesto = table.Column<decimal>(type: "numeric", nullable: false),
                    Total = table.Column<decimal>(type: "numeric", nullable: false),
                    Observaciones = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CajaFacturas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsistenciaArchivos",
                columns: table => new
                {
                    Id_Archivo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    Fecha_Creacion = table.Column<DateOnly>(type: "date", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsistenciaArchivos", x => x.Id_Archivo);
                });

            migrationBuilder.CreateTable(
                name: "ContabilidadFacturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumeroFactura = table.Column<string>(type: "text", nullable: false),
                    FechaEmision = table.Column<DateTime>(type: "date", nullable: false),
                    MontoTotal = table.Column<decimal>(type: "numeric", nullable: false),
                    Cliente = table.Column<string>(type: "text", nullable: false),
                    Pagada = table.Column<bool>(type: "boolean", nullable: false),
                    Observacion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContabilidadFacturas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContabilidadUsuarios",
                columns: table => new
                {
                    CON_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CON_Nombre = table.Column<string>(type: "text", nullable: false),
                    CON_Email = table.Column<string>(type: "text", nullable: false),
                    CON_Rol = table.Column<string>(type: "text", nullable: false),
                    CON_FechaRegistro = table.Column<DateTime>(type: "date", nullable: false),
                    CON_Departamento = table.Column<string>(type: "text", nullable: false),
                    CON_Telefono = table.Column<string>(type: "text", nullable: false),
                    CON_Activo = table.Column<bool>(type: "boolean", nullable: false),
                    CON_Salario = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContabilidadUsuarios", x => x.CON_Id);
                });

            migrationBuilder.CreateTable(
                name: "ModalidadesGrado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    DuracionMeses = table.Column<int>(type: "integer", nullable: false),
                    RequiereTesis = table.Column<bool>(type: "boolean", nullable: false),
                    Costo = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadesGrado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProduccionContenidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "text", nullable: false),
                    TipoFormato = table.Column<string>(type: "text", nullable: false),
                    DuracionMinutos = table.Column<int>(type: "integer", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "date", nullable: false),
                    EsPublicado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduccionContenidos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RectoradoAutoridades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreCompleto = table.Column<string>(type: "text", nullable: false),
                    Cargo = table.Column<string>(type: "text", nullable: false),
                    TituloAcademico = table.Column<string>(type: "text", nullable: false),
                    EmailInstitucional = table.Column<string>(type: "text", nullable: false),
                    FechaInicioGestion = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RectoradoAutoridades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegistroEstudiantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NombreCompleto = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CodigoEstudiante = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Carrera = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "date", nullable: false),
                    PromedioCalificaciones = table.Column<decimal>(type: "numeric", nullable: false),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroEstudiantes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecretariaGeneralDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumeroDocumento = table.Column<string>(type: "text", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false),
                    FechaEmision = table.Column<DateTime>(type: "date", nullable: false),
                    Responsable = table.Column<string>(type: "text", nullable: false),
                    Vigente = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecretariaGeneralDocumentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SistemasComputadoras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Marca = table.Column<string>(type: "text", nullable: false),
                    Modelo = table.Column<string>(type: "text", nullable: false),
                    MemoriaRamGB = table.Column<int>(type: "integer", nullable: false),
                    Precio = table.Column<decimal>(type: "numeric", nullable: false),
                    TieneGraficaDedicada = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SistemasComputadoras", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArchivosArchivos");

            migrationBuilder.DropTable(
                name: "Articulo");

            migrationBuilder.DropTable(
                name: "BecasEstudiantes");

            migrationBuilder.DropTable(
                name: "BibliotecaLibros");

            migrationBuilder.DropTable(
                name: "CajaFacturas");

            migrationBuilder.DropTable(
                name: "ConsistenciaArchivos");

            migrationBuilder.DropTable(
                name: "ContabilidadFacturas");

            migrationBuilder.DropTable(
                name: "ContabilidadUsuarios");

            migrationBuilder.DropTable(
                name: "ModalidadesGrado");

            migrationBuilder.DropTable(
                name: "ProduccionContenidos");

            migrationBuilder.DropTable(
                name: "RectoradoAutoridades");

            migrationBuilder.DropTable(
                name: "RegistroEstudiantes");

            migrationBuilder.DropTable(
                name: "SecretariaGeneralDocumentos");

            migrationBuilder.DropTable(
                name: "SistemasComputadoras");
        }
    }
}
