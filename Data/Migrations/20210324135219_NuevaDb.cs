using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicShopMVC.Data.Migrations
{
    public partial class NuevaDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baterias_Categorias_CategoriaID",
                table: "Baterias");

            migrationBuilder.DropForeignKey(
                name: "FK_Baterias_Marcas_MarcaID",
                table: "Baterias");

            migrationBuilder.DropForeignKey(
                name: "FK_Teclados_Categorias_CategoriaID",
                table: "Teclados");

            migrationBuilder.DropForeignKey(
                name: "FK_Teclados_Marcas_MarcaID",
                table: "Teclados");

            migrationBuilder.DropForeignKey(
                name: "FK_Trompetas_Categorias_CategoriaID",
                table: "Trompetas");

            migrationBuilder.DropForeignKey(
                name: "FK_Trompetas_Marcas_MarcaID",
                table: "Trompetas");

            migrationBuilder.DropForeignKey(
                name: "FK_Violines_Categorias_CategoriaID",
                table: "Violines");

            migrationBuilder.DropForeignKey(
                name: "FK_Violines_Marcas_MarcaID",
                table: "Violines");

            migrationBuilder.DropTable(
                name: "Bajos");

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
                name: "Categorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Violines",
                table: "Violines");

            migrationBuilder.DropIndex(
                name: "IX_Violines_CategoriaID",
                table: "Violines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trompetas",
                table: "Trompetas");

            migrationBuilder.DropIndex(
                name: "IX_Trompetas_CategoriaID",
                table: "Trompetas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teclados",
                table: "Teclados");

            migrationBuilder.DropIndex(
                name: "IX_Teclados_CategoriaID",
                table: "Teclados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Baterias",
                table: "Baterias");

            migrationBuilder.DropIndex(
                name: "IX_Baterias_CategoriaID",
                table: "Baterias");

            migrationBuilder.DropColumn(
                name: "CategoriaID",
                table: "Trompetas");

            migrationBuilder.DropColumn(
                name: "CategoriaID",
                table: "Teclados");

            migrationBuilder.DropColumn(
                name: "CategoriaID",
                table: "Baterias");

            migrationBuilder.RenameTable(
                name: "Violines",
                newName: "InstrumentosDeCuerda");

            migrationBuilder.RenameTable(
                name: "Trompetas",
                newName: "InstrumentosDeViento");

            migrationBuilder.RenameTable(
                name: "Teclados",
                newName: "InstrumentosDeTecla");

            migrationBuilder.RenameTable(
                name: "Baterias",
                newName: "InstrumentosDePercusion");

            migrationBuilder.RenameColumn(
                name: "Tamaño",
                table: "InstrumentosDeCuerda",
                newName: "OrientacionMano");

            migrationBuilder.RenameColumn(
                name: "CategoriaID",
                table: "InstrumentosDeCuerda",
                newName: "CantidadCuerdas");

            migrationBuilder.RenameIndex(
                name: "IX_Violines_MarcaID",
                table: "InstrumentosDeCuerda",
                newName: "IX_InstrumentosDeCuerda_MarcaID");

            migrationBuilder.RenameIndex(
                name: "IX_Trompetas_MarcaID",
                table: "InstrumentosDeViento",
                newName: "IX_InstrumentosDeViento_MarcaID");

            migrationBuilder.RenameIndex(
                name: "IX_Teclados_MarcaID",
                table: "InstrumentosDeTecla",
                newName: "IX_InstrumentosDeTecla_MarcaID");

            migrationBuilder.RenameIndex(
                name: "IX_Baterias_MarcaID",
                table: "InstrumentosDePercusion",
                newName: "IX_InstrumentosDePercusion_MarcaID");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "InstrumentosDeCuerda",
                type: "TEXT",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Digitacion",
                table: "InstrumentosDeCuerda",
                type: "TEXT",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<int>(
                name: "Bajo_CAntidadMics",
                table: "InstrumentosDeCuerda",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Bajo_CantidadTrastes",
                table: "InstrumentosDeCuerda",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bajo_MaderaCuerpo",
                table: "InstrumentosDeCuerda",
                type: "TEXT",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bajo_MaderaMastil",
                table: "InstrumentosDeCuerda",
                type: "TEXT",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CAntidadMics",
                table: "InstrumentosDeCuerda",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CantidadTrastes",
                table: "InstrumentosDeCuerda",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "InstrumentosDeCuerda",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ElectroAcustica",
                table: "InstrumentosDeCuerda",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GuitarraAcustica_CantidadTrastes",
                table: "InstrumentosDeCuerda",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GuitarraAcustica_MaderaCuerpo",
                table: "InstrumentosDeCuerda",
                type: "TEXT",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GuitarraCriolla_CantidadTrastes",
                table: "InstrumentosDeCuerda",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GuitarraCriolla_MaderaCuerpo",
                table: "InstrumentosDeCuerda",
                type: "TEXT",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaderaCuerpo",
                table: "InstrumentosDeCuerda",
                type: "TEXT",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaderaMastil",
                table: "InstrumentosDeCuerda",
                type: "TEXT",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Origen",
                table: "InstrumentosDeCuerda",
                type: "TEXT",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipoMics",
                table: "InstrumentosDeCuerda",
                type: "TEXT",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoPuente",
                table: "InstrumentosDeCuerda",
                type: "TEXT",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Afinacion",
                table: "InstrumentosDeViento",
                type: "TEXT",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<string>(
                name: "Digitacion",
                table: "InstrumentosDeViento",
                type: "TEXT",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "InstrumentosDeViento",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "CantidadRitmos",
                table: "InstrumentosDeTecla",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "InstrumentosDeTecla",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Platillos",
                table: "InstrumentosDePercusion",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<bool>(
                name: "PedalBombo",
                table: "InstrumentosDePercusion",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Linea",
                table: "InstrumentosDePercusion",
                type: "TEXT",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Cuerpo",
                table: "InstrumentosDePercusion",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<bool>(
                name: "Banqueta",
                table: "InstrumentosDePercusion",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "InstrumentosDePercusion",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstrumentosDeCuerda",
                table: "InstrumentosDeCuerda",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstrumentosDeViento",
                table: "InstrumentosDeViento",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstrumentosDeTecla",
                table: "InstrumentosDeTecla",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstrumentosDePercusion",
                table: "InstrumentosDePercusion",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_InstrumentosDeCuerda_Marcas_MarcaID",
                table: "InstrumentosDeCuerda",
                column: "MarcaID",
                principalTable: "Marcas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InstrumentosDePercusion_Marcas_MarcaID",
                table: "InstrumentosDePercusion",
                column: "MarcaID",
                principalTable: "Marcas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InstrumentosDeTecla_Marcas_MarcaID",
                table: "InstrumentosDeTecla",
                column: "MarcaID",
                principalTable: "Marcas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InstrumentosDeViento_Marcas_MarcaID",
                table: "InstrumentosDeViento",
                column: "MarcaID",
                principalTable: "Marcas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstrumentosDeCuerda_Marcas_MarcaID",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropForeignKey(
                name: "FK_InstrumentosDePercusion_Marcas_MarcaID",
                table: "InstrumentosDePercusion");

            migrationBuilder.DropForeignKey(
                name: "FK_InstrumentosDeTecla_Marcas_MarcaID",
                table: "InstrumentosDeTecla");

            migrationBuilder.DropForeignKey(
                name: "FK_InstrumentosDeViento_Marcas_MarcaID",
                table: "InstrumentosDeViento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstrumentosDeViento",
                table: "InstrumentosDeViento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstrumentosDeTecla",
                table: "InstrumentosDeTecla");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstrumentosDePercusion",
                table: "InstrumentosDePercusion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstrumentosDeCuerda",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropColumn(
                name: "Digitacion",
                table: "InstrumentosDeViento");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "InstrumentosDeViento");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "InstrumentosDeTecla");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "InstrumentosDePercusion");

            migrationBuilder.DropColumn(
                name: "Bajo_CAntidadMics",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropColumn(
                name: "Bajo_CantidadTrastes",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropColumn(
                name: "Bajo_MaderaCuerpo",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropColumn(
                name: "Bajo_MaderaMastil",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropColumn(
                name: "CAntidadMics",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropColumn(
                name: "CantidadTrastes",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropColumn(
                name: "ElectroAcustica",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropColumn(
                name: "GuitarraAcustica_CantidadTrastes",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropColumn(
                name: "GuitarraAcustica_MaderaCuerpo",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropColumn(
                name: "GuitarraCriolla_CantidadTrastes",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropColumn(
                name: "GuitarraCriolla_MaderaCuerpo",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropColumn(
                name: "MaderaCuerpo",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropColumn(
                name: "MaderaMastil",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropColumn(
                name: "Origen",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropColumn(
                name: "TipoMics",
                table: "InstrumentosDeCuerda");

            migrationBuilder.DropColumn(
                name: "TipoPuente",
                table: "InstrumentosDeCuerda");

            migrationBuilder.RenameTable(
                name: "InstrumentosDeViento",
                newName: "Trompetas");

            migrationBuilder.RenameTable(
                name: "InstrumentosDeTecla",
                newName: "Teclados");

            migrationBuilder.RenameTable(
                name: "InstrumentosDePercusion",
                newName: "Baterias");

            migrationBuilder.RenameTable(
                name: "InstrumentosDeCuerda",
                newName: "Violines");

            migrationBuilder.RenameIndex(
                name: "IX_InstrumentosDeViento_MarcaID",
                table: "Trompetas",
                newName: "IX_Trompetas_MarcaID");

            migrationBuilder.RenameIndex(
                name: "IX_InstrumentosDeTecla_MarcaID",
                table: "Teclados",
                newName: "IX_Teclados_MarcaID");

            migrationBuilder.RenameIndex(
                name: "IX_InstrumentosDePercusion_MarcaID",
                table: "Baterias",
                newName: "IX_Baterias_MarcaID");

            migrationBuilder.RenameColumn(
                name: "OrientacionMano",
                table: "Violines",
                newName: "Tamaño");

            migrationBuilder.RenameColumn(
                name: "CantidadCuerdas",
                table: "Violines",
                newName: "CategoriaID");

            migrationBuilder.RenameIndex(
                name: "IX_InstrumentosDeCuerda_MarcaID",
                table: "Violines",
                newName: "IX_Violines_MarcaID");

            migrationBuilder.AlterColumn<string>(
                name: "Afinacion",
                table: "Trompetas",
                type: "TEXT",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaID",
                table: "Trompetas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CantidadRitmos",
                table: "Teclados",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaID",
                table: "Teclados",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Platillos",
                table: "Baterias",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "PedalBombo",
                table: "Baterias",
                type: "INTEGER",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Linea",
                table: "Baterias",
                type: "TEXT",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cuerpo",
                table: "Baterias",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Banqueta",
                table: "Baterias",
                type: "INTEGER",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriaID",
                table: "Baterias",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Violines",
                type: "TEXT",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Digitacion",
                table: "Violines",
                type: "TEXT",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trompetas",
                table: "Trompetas",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teclados",
                table: "Teclados",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Baterias",
                table: "Baterias",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Violines",
                table: "Violines",
                column: "ID");

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
                name: "Bajos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CAntidadMics = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadCuerdas = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadTrastes = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false),
                    MaderaCuerpo = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    MaderaMastil = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    MarcaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    NombreImagen = table.Column<string>(type: "TEXT", nullable: true),
                    OrientacionMano = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Origen = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
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
                name: "Flautas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Digitacion = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    MarcaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Material = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    NombreImagen = table.Column<string>(type: "TEXT", nullable: true),
                    Tipo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
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
                    CantidadCuerdas = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadTrastes = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false),
                    ElectroAcustica = table.Column<bool>(type: "INTEGER", nullable: false),
                    Linea = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    MaderaCuerpo = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    MarcaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    NombreImagen = table.Column<string>(type: "TEXT", nullable: true),
                    OrientacionMano = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Origen = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
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
                    CantidadCuerdas = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadTrastes = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Linea = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    MaderaCuerpo = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    MarcaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    NombreImagen = table.Column<string>(type: "TEXT", nullable: true),
                    OrientacionMano = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Origen = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
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
                    CAntidadMics = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadCuerdas = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadTrastes = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Linea = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    MaderaCuerpo = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    MaderaMastil = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    MarcaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    NombreImagen = table.Column<string>(type: "TEXT", nullable: true),
                    OrientacionMano = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Origen = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    TipoMics = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    TipoPuente = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
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
                    CantidadTeclas = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoriaID = table.Column<int>(type: "INTEGER", nullable: false),
                    MarcaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
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
                    Material = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    NombreImagen = table.Column<string>(type: "TEXT", nullable: true),
                    Tipo = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Trompetas_CategoriaID",
                table: "Trompetas",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Teclados_CategoriaID",
                table: "Teclados",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Baterias_CategoriaID",
                table: "Baterias",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Violines_CategoriaID",
                table: "Violines",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Bajos_CategoriaID",
                table: "Bajos",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Bajos_MarcaID",
                table: "Bajos",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Baterias_Categorias_CategoriaID",
                table: "Baterias",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Baterias_Marcas_MarcaID",
                table: "Baterias",
                column: "MarcaID",
                principalTable: "Marcas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teclados_Categorias_CategoriaID",
                table: "Teclados",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teclados_Marcas_MarcaID",
                table: "Teclados",
                column: "MarcaID",
                principalTable: "Marcas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trompetas_Categorias_CategoriaID",
                table: "Trompetas",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trompetas_Marcas_MarcaID",
                table: "Trompetas",
                column: "MarcaID",
                principalTable: "Marcas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Violines_Categorias_CategoriaID",
                table: "Violines",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Violines_Marcas_MarcaID",
                table: "Violines",
                column: "MarcaID",
                principalTable: "Marcas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
