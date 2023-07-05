using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASME_Forms.Migrations
{
    /// <inheritdoc />
    public partial class EERWMFGfieldChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ERW_STUD_LOT_NUMBER",
                table: "ASME_CBI",
                newName: "ERW_STUD_MFG");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ERW_STUD_MFG",
                table: "ASME_CBI",
                newName: "ERW_STUD_LOT_NUMBER");
        }
    }
}
