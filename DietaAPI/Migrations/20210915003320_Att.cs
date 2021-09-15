using Microsoft.EntityFrameworkCore.Migrations;

namespace DietaAPI.Migrations
{
    public partial class Att : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    FibraAlimentar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaNutricional", x => x.TabelaNutricionalId);
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
                    TabelaNutricionalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receita", x => x.ReceitaId);
                    table.ForeignKey(
                        name: "FK_Receita_TabelaNutricional_TabelaNutricionalId",
                        column: x => x.TabelaNutricionalId,
                        principalTable: "TabelaNutricional",
                        principalColumn: "TabelaNutricionalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Alimento",
                columns: table => new
                {
                    AlimentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<int>(type: "int", nullable: false),
                    Origem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceitaId = table.Column<int>(type: "int", nullable: false),
                    TabelaNutricionalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alimento", x => x.AlimentoId);
                    table.ForeignKey(
                        name: "FK_Alimento_Receita_ReceitaId",
                        column: x => x.ReceitaId,
                        principalTable: "Receita",
                        principalColumn: "ReceitaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alimento_TabelaNutricional_TabelaNutricionalId",
                        column: x => x.TabelaNutricionalId,
                        principalTable: "TabelaNutricional",
                        principalColumn: "TabelaNutricionalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alimento_ReceitaId",
                table: "Alimento",
                column: "ReceitaId");

            migrationBuilder.CreateIndex(
                name: "IX_Alimento_TabelaNutricionalId",
                table: "Alimento",
                column: "TabelaNutricionalId");

            migrationBuilder.CreateIndex(
                name: "IX_Receita_TabelaNutricionalId",
                table: "Receita",
                column: "TabelaNutricionalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alimento");

            migrationBuilder.DropTable(
                name: "Receita");

            migrationBuilder.DropTable(
                name: "TabelaNutricional");
        }
    }
}
