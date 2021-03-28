using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicShopMVC.Data.Migrations
{
    public partial class ModelosConImagen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bajos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false),
                    MarcaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    OrientacionMano = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    CantidadCuerdas = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadTrastes = table.Column<int>(type: "INTEGER", nullable: false),
                    CAntidadMics = table.Column<int>(type: "INTEGER", nullable: false),
                    Origen = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    MaderaMastil = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    MaderaCuerpo = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    NombreImagen = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bajos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bajos_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bajos_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Baterias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false),
                    MarcaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Linea = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Cuerpo = table.Column<string>(type: "TEXT", nullable: false),
                    Platillos = table.Column<string>(type: "TEXT", nullable: false),
                    PedalBombo = table.Column<bool>(type: "INTEGER", nullable: false),
                    Banqueta = table.Column<bool>(type: "INTEGER", nullable: false),
                    NombreImagen = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baterias", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Baterias_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Baterias_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Flautas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false),
                    MarcaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Material = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Digitacion = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    NombreImagen = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flautas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Flautas_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Flautas_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuitarrasAcusticas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false),
                    MarcaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Linea = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    OrientacionMano = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    CantidadCuerdas = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadTrastes = table.Column<int>(type: "INTEGER", nullable: false),
                    Origen = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    MaderaCuerpo = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    ElectroAcustica = table.Column<bool>(type: "INTEGER", nullable: false),
                    NombreImagen = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuitarrasAcusticas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GuitarrasAcusticas_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuitarrasAcusticas_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuitarrasCriollas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false),
                    MarcaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Linea = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    OrientacionMano = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    CantidadCuerdas = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadTrastes = table.Column<int>(type: "INTEGER", nullable: false),
                    Origen = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    MaderaCuerpo = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    NombreImagen = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuitarrasCriollas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GuitarrasCriollas_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuitarrasCriollas_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuitarrasElectricas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false),
                    MarcaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Linea = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    OrientacionMano = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    CantidadCuerdas = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadTrastes = table.Column<int>(type: "INTEGER", nullable: false),
                    CAntidadMics = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoMics = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Origen = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    MaderaMastil = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    MaderaCuerpo = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    TipoPuente = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    NombreImagen = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuitarrasElectricas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GuitarrasElectricas_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuitarrasElectricas_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PianosDigitales",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false),
                    MarcaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    CantidadTeclas = table.Column<int>(type: "INTEGER", nullable: false),
                    NombreImagen = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PianosDigitales", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PianosDigitales_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PianosDigitales_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Saxofones",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false),
                    MarcaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Material = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    NombreImagen = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Saxofones", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Saxofones_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Saxofones_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teclados",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false),
                    MarcaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    CantidadTeclas = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadRitmos = table.Column<int>(type: "INTEGER", nullable: false),
                    NombreImagen = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teclados", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Teclados_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teclados_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trompetas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false),
                    MarcaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Material = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Afinacion = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    NombreImagen = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trompetas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Trompetas_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trompetas_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Violines",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false),
                    MarcaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Tamaño = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Digitacion = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    NombreImagen = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Violines", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Violines_Categorias_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categorias",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Violines_Marcas_MarcaID",
                        column: x => x.MarcaID,
                        principalTable: "Marcas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bajos_CategoriaID",
                table: "Bajos",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Bajos_MarcaID",
                table: "Bajos",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_Baterias_CategoriaID",
                table: "Baterias",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Baterias_MarcaID",
                table: "Baterias",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_Flautas_CategoriaID",
                table: "Flautas",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Flautas_MarcaID",
                table: "Flautas",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_GuitarrasAcusticas_CategoriaID",
                table: "GuitarrasAcusticas",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_GuitarrasAcusticas_MarcaID",
                table: "GuitarrasAcusticas",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_GuitarrasCriollas_CategoriaID",
                table: "GuitarrasCriollas",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_GuitarrasCriollas_MarcaID",
                table: "GuitarrasCriollas",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_GuitarrasElectricas_CategoriaID",
                table: "GuitarrasElectricas",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_GuitarrasElectricas_MarcaID",
                table: "GuitarrasElectricas",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_PianosDigitales_CategoriaID",
                table: "PianosDigitales",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_PianosDigitales_MarcaID",
                table: "PianosDigitales",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_Saxofones_CategoriaID",
                table: "Saxofones",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Saxofones_MarcaID",
                table: "Saxofones",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_Teclados_CategoriaID",
                table: "Teclados",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Teclados_MarcaID",
                table: "Teclados",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_Trompetas_CategoriaID",
                table: "Trompetas",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Trompetas_MarcaID",
                table: "Trompetas",
                column: "MarcaID");

            migrationBuilder.CreateIndex(
                name: "IX_Violines_CategoriaID",
                table: "Violines",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Violines_MarcaID",
                table: "Violines",
                column: "MarcaID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bajos");

            migrationBuilder.DropTable(
                name: "Baterias");

            migrationBuilder.DropTable(
                name: "Flautas");

            migrationBuilder.DropTable(
                name: "GuitarrasAcusticas");

            migrationBuilder.DropTable(
                name: "GuitarrasCriollas");

            migrationBuilder.DropTable(
                name: "GuitarrasElectricas");

            migrationBuilder.DropTable(
                name: "PianosDigitales");

            migrationBuilder.DropTable(
                name: "Saxofones");

            migrationBuilder.DropTable(
                name: "Teclados");

            migrationBuilder.DropTable(
                name: "Trompetas");

            migrationBuilder.DropTable(
                name: "Violines");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Marcas");
        }
    }
}
