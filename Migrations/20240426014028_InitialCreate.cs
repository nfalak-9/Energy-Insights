using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Energy_Insights.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountryModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnergyTypeModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnergyTypeModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EnergyGenerationModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    EnergyTypeId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnergyGenerationModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnergyGenerationModel_CountryModel_CountryId",
                        column: x => x.CountryId,
                        principalTable: "CountryModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnergyGenerationModel_EnergyTypeModel_EnergyTypeId",
                        column: x => x.EnergyTypeId,
                        principalTable: "EnergyTypeModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EnergyGenerationModel_CountryId",
                table: "EnergyGenerationModel",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_EnergyGenerationModel_EnergyTypeId",
                table: "EnergyGenerationModel",
                column: "EnergyTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnergyGenerationModel");

            migrationBuilder.DropTable(
                name: "CountryModel");

            migrationBuilder.DropTable(
                name: "EnergyTypeModel");
        }
    }
}
