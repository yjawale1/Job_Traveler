using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASME_Forms.Migrations
{
    /// <inheritdoc />
    public partial class AddASME_CBITable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ASME_CBI",
                columns: table => new
                {
                    JOB_TRAVELER_NUMBER = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NATL_BD_NUMBER = table.Column<int>(type: "int", nullable: false),
                    PART_NUMBER = table.Column<int>(type: "int", nullable: false),
                    BASIC_TANK_NUMBER = table.Column<int>(type: "int", nullable: false),
                    HX_NUMBER = table.Column<int>(type: "int", nullable: false),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DWG_NUMBER = table.Column<int>(type: "int", nullable: false),
                    MVP_NUMBER = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASME_CBI", x => x.JOB_TRAVELER_NUMBER);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ASME_CBI");
        }
    }
}
