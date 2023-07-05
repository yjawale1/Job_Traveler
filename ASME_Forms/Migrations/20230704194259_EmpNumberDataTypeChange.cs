using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASME_Forms.Migrations
{
    /// <inheritdoc />
    public partial class EmpNumberDataTypeChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EMP_NUMBER",
                table: "ASME_CBI",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377919,
                column: "EMP_NUMBER",
                value: null);

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377920,
                column: "EMP_NUMBER",
                value: null);

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377921,
                column: "EMP_NUMBER",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EMP_NUMBER",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377919,
                column: "EMP_NUMBER",
                value: null);

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377920,
                column: "EMP_NUMBER",
                value: null);

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377921,
                column: "EMP_NUMBER",
                value: null);
        }
    }
}
