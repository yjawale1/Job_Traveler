using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASME_Forms.Migrations
{
    /// <inheritdoc />
    public partial class Added_New_lines_columns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CBI_HX_NOTES",
                table: "ASME_CBI_HX",
                newName: "CBI_HX_NOTES_LINE_3");

            migrationBuilder.AddColumn<string>(
                name: "CBI_HX_NOTES_LINE_1",
                table: "ASME_CBI_HX",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CBI_HX_NOTES_LINE_2",
                table: "ASME_CBI_HX",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CBI_HX_NOTES_LINE_1",
                table: "ASME_CBI_HX");

            migrationBuilder.DropColumn(
                name: "CBI_HX_NOTES_LINE_2",
                table: "ASME_CBI_HX");

            migrationBuilder.RenameColumn(
                name: "CBI_HX_NOTES_LINE_3",
                table: "ASME_CBI_HX",
                newName: "CBI_HX_NOTES");
        }
    }
}
