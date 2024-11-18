using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotasApp.Migrations
{
    /// <inheritdoc />
    public partial class MigracionNotas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nota1 = table.Column<int>(type: "int", nullable: false),
                    Nota2 = table.Column<int>(type: "int", nullable: false),
                    Nota3 = table.Column<int>(type: "int", nullable: false),
                    Promedio = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notas");
        }
    }
}
