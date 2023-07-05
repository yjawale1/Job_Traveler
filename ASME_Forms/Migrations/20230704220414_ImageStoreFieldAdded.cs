using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASME_Forms.Migrations
{
    /// <inheritdoc />
    public partial class ImageStoreFieldAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "PRODUCT_NUMBER",
                table: "ASME_CBI",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377919,
                column: "PRODUCT_NUMBER",
                value: null);

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377920,
                column: "PRODUCT_NUMBER",
                value: null);

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377921,
                column: "PRODUCT_NUMBER",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PRODUCT_NUMBER",
                table: "ASME_CBI");
        }
    }
}
