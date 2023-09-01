using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Investigation.API.Migrations
{
    /// <inheritdoc />
    public partial class Migracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateInitial = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateFinal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameLider = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AreaWork = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scientists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameCientifico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    afiliacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    especializacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    rolproyecto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scientists", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_NameProject",
                table: "Projects",
                column: "NameProject",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Scientists_nameCientifico",
                table: "Scientists",
                column: "nameCientifico",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Scientists");
        }
    }
}
