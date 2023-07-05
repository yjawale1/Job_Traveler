using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASME_Forms.Migrations
{
    /// <inheritdoc />
    public partial class NewDataBaseUsedForJT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ASME_CBI",
                table: "ASME_CBI");

            migrationBuilder.AlterColumn<int>(
                name: "JOB_TRAVELER_NUMBER",
                table: "ASME_CBI",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "JOBId",
                table: "ASME_CBI",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ASME_CBI",
                table: "ASME_CBI",
                column: "JOBId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ASME_CBI",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "JOBId",
                table: "ASME_CBI");

            migrationBuilder.AlterColumn<int>(
                name: "JOB_TRAVELER_NUMBER",
                table: "ASME_CBI",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ASME_CBI",
                table: "ASME_CBI",
                column: "JOB_TRAVELER_NUMBER");
        }
    }
}
