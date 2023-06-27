using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASME_Forms.Migrations
{
    /// <inheritdoc />
    public partial class SeedValuesASME : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ASME_CBI",
                columns: new[] { "JOB_TRAVELER_NUMBER", "BASIC_TANK_NUMBER", "DESCRIPTION", "DWG_NUMBER", "HX_NUMBER", "MVP_NUMBER", "NATL_BD_NUMBER", "PART_NUMBER" },
                values: new object[,]
                {
                    { 377919, "XB012115", "Tank VT 225", "BUG32-C", "", "", "", "151609" },
                    { 377920, "XB012116", "Tank VT 325", "BUG33-C", "", "", "", "151610" },
                    { 377921, "XB012117", "Tank VT 425", "BUG34-C", "", "", "", "151611" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377919);

            migrationBuilder.DeleteData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377920);

            migrationBuilder.DeleteData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377921);
        }
    }
}
