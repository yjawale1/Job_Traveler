using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASME_Forms.Migrations
{
    /// <inheritdoc />
    public partial class AddedDateTimeForCaptureData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CAPTURE_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EMP_NUMBER",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377919,
                columns: new[] { "CAPTURE_DATE", "EMP_NUMBER" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377920,
                columns: new[] { "CAPTURE_DATE", "EMP_NUMBER" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377921,
                columns: new[] { "CAPTURE_DATE", "EMP_NUMBER" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CAPTURE_DATE",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "EMP_NUMBER",
                table: "ASME_CBI");
        }
    }
}
