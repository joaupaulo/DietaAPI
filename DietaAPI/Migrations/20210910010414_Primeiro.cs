using Microsoft.EntityFrameworkCore.Migrations;

namespace DietaAPI.Migrations
{
    public partial class Primeiro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alimento",
                columns: table => new
                {
                    AlimentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<int>(type: "int", nullable: false),
                    Origem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alimento", x => x.AlimentoId);
                });

            migrationBuilder.CreateTable(
                name: "TabelaNutricional",
                columns: table => new
                {
                    TabelaNutricionalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Energia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carboidrato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Proteinas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gordura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Açucares = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calorias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Colesterol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lípidios = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calcio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ferro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FibraAlimentar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlimentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaNutricional", x => x.TabelaNutricionalId);
                    table.ForeignKey(
                        name: "FK_TabelaNutricional_Alimento_AlimentoId",
                        column: x => x.AlimentoId,
                        principalTable: "Alimento",
                        principalColumn: "AlimentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receita",
                columns: table => new
                {
                    ReceitaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredientes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preparatorio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlimentoId = table.Column<int>(type: "int", nullable: false),
                    TabelaNutricionalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receita", x => x.ReceitaId);
                    table.ForeignKey(
                        name: "FK_Receita_Alimento_AlimentoId",
                        column: x => x.AlimentoId,
                        principalTable: "Alimento",
                        principalColumn: "AlimentoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receita_TabelaNutricional_TabelaNutricionalId",
                        column: x => x.TabelaNutricionalId,
                        principalTable: "TabelaNutricional",
                        principalColumn: "TabelaNutricionalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receita_AlimentoId",
                table: "Receita",
                column: "AlimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Receita_TabelaNutricionalId",
                table: "Receita",
                column: "TabelaNutricionalId");

            migrationBuilder.CreateIndex(
                name: "IX_TabelaNutricional_AlimentoId",
                table: "TabelaNutricional",
                column: "AlimentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receita");

            migrationBuilder.DropTable(
                name: "TabelaNutricional");

            migrationBuilder.DropTable(
                name: "Alimento");
        }
    }
}
