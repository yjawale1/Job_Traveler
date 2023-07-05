using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASME_Forms.Migrations
{
    /// <inheritdoc />
    public partial class NewDataBaseUsed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ASME_CBI",
                columns: new[] { "JOB_TRAVELER_NUMBER", "AI_HYDRO_TEST_DATE", "AI_HYDRO_TEST_WELDER", "ATTACHMENTS_LOT_NUMBER", "ATTACHMENTS_MFG", "ATTACHMENTS_WELDER", "BASE_CLEAT_MFG", "BASE_CLEAT_WELDER", "BASIC_TANK_NUMBER", "BOTTOM_HEAD_MFG", "BOTTOM_HEAD_WELDER", "CAPTURE_DATE", "CHAMBER_HEAD_MFG", "CHAMBER_HEAD_WELDER", "CHAMBER_SHELL_MFG", "CHAMBER_SHELL_WELDER", "CONDENSATE_PAN_MFG", "CONDENSATE_PAN_WELDER", "DESCRIPTION", "DWG_NUMBER", "EMP_NUMBER", "ERW_STUD_MFG", "ERW_STUD_WELDER", "FLUE_ASSEMBLY_MFG", "FLUE_ASSEMBLY_WELDER", "HX_NUMBER", "JOGGLE_MFG", "JOGGLE_WELDER", "LONGSEAM_WELD_MFG", "LONGSEAM_WELD_WELDER", "MFG_FINAL_INSP_DATE", "MFG_FINAL_INSP_WELDER", "MFG_HYDRO_TEST_DATE", "MFG_HYDRO_TEST_WELDER", "MFG_NATL_BD_NUMBER_DATE", "MFG_NATL_BD_NUMBER_WELDER", "MVP_NUMBER", "NATL_BD_NUMBER", "PART_NUMBER", "PLATE_ROLLS_LOT_NUMBER_1", "PLATE_ROLLS_LOT_NUMBER_2", "PLATE_ROLLS_MFG_1", "PLATE_ROLLS_MFG_2", "PLATE_ROLLS_WELDER_1", "PLATE_ROLLS_WELDER_2", "PRODUCT_NUMBER", "QA_HYDRO_TEST_DATE", "QA_HYDRO_TEST_GAUGE", "QA_HYDRO_TEST_PSI", "QA_HYDRO_TEST_WELDER", "QA_NATL_BD_NUMBER_DATE", "QA_NATL_BD_NUMBER_WELDER", "TOP_HEAD_LOT_NUMBER", "TOP_HEAD_MFG", "TOP_HEAD_WELDER", "TUBE_VERIFICATION_HX_INSTALLATION_MFG", "TUBE_VERIFICATION_HX_INSTALLATION_WELDER" },
                values: new object[,]
                {
                    { 377919, null, null, null, null, null, null, null, "XB012115", null, null, null, null, null, null, null, null, null, "Tank VT 225", "BUG32-C", null, null, null, null, null, "", null, null, null, null, null, null, null, null, null, null, "", "", "151609", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null },
                    { 377920, null, null, null, null, null, null, null, "XB012116", null, null, null, null, null, null, null, null, null, "Tank VT 325", "BUG33-C", null, null, null, null, null, "", null, null, null, null, null, null, null, null, null, null, "", "", "151610", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null },
                    { 377921, null, null, null, null, null, null, null, "XB012117", null, null, null, null, null, null, null, null, null, "Tank VT 425", "BUG34-C", null, null, null, null, null, "", null, null, null, null, null, null, null, null, null, null, "", "", "151611", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }
                });
        }
    }
}
