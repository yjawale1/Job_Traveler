using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASME_Forms.Migrations
{
    /// <inheritdoc />
    public partial class New_Tables_CBI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ASME_CBI",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JOB_TRAVELER_NUMBER = table.Column<int>(type: "int", nullable: false),
                    NATL_BD_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PART_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BASIC_TANK_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HX_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DWG_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MVP_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PLATE_ROLLS_WELDER_1 = table.Column<int>(type: "int", nullable: true),
                    PLATE_ROLLS_WELDER_2 = table.Column<int>(type: "int", nullable: true),
                    PLATE_ROLLS_LOT_NUMBER_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PLATE_ROLLS_LOT_NUMBER_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PLATE_ROLLS_MFG_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PLATE_ROLLS_MFG_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LONGSEAM_WELD_WELDER = table.Column<int>(type: "int", nullable: true),
                    LONGSEAM_WELD_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JOGGLE_WELDER = table.Column<int>(type: "int", nullable: true),
                    JOGGLE_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TOP_HEAD_WELDER = table.Column<int>(type: "int", nullable: true),
                    TOP_HEAD_LOT_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TOP_HEAD_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TUBE_VERIFICATION_HX_INSTALLATION_WELDER = table.Column<int>(type: "int", nullable: true),
                    TUBE_VERIFICATION_HX_INSTALLATION_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHAMBER_HEAD_WELDER = table.Column<int>(type: "int", nullable: true),
                    CHAMBER_HEAD_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BOTTOM_HEAD_WELDER = table.Column<int>(type: "int", nullable: true),
                    BOTTOM_HEAD_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHAMBER_SHELL_WELDER = table.Column<int>(type: "int", nullable: true),
                    CHAMBER_SHELL_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ATTACHMENTS_WELDER = table.Column<int>(type: "int", nullable: true),
                    ATTACHMENTS_LOT_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ATTACHMENTS_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERW_STUD_WELDER = table.Column<int>(type: "int", nullable: true),
                    ERW_STUD_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MFG_HYDRO_TEST_WELDER = table.Column<int>(type: "int", nullable: true),
                    MFG_HYDRO_TEST_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MFG_NATL_BD_NUMBER_WELDER = table.Column<int>(type: "int", nullable: true),
                    MFG_NATL_BD_NUMBER_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    QA_NATL_BD_NUMBER_WELDER = table.Column<int>(type: "int", nullable: true),
                    QA_NATL_BD_NUMBER_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    QA_HYDRO_TEST_WELDER = table.Column<int>(type: "int", nullable: true),
                    QA_HYDRO_TEST_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    QA_HYDRO_TEST_PSI = table.Column<int>(type: "int", nullable: true),
                    QA_HYDRO_TEST_GAUGE = table.Column<int>(type: "int", nullable: true),
                    AI_HYDRO_TEST_WELDER = table.Column<int>(type: "int", nullable: true),
                    AI_HYDRO_TEST_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CONDENSATE_PAN_WELDER = table.Column<int>(type: "int", nullable: true),
                    CONDENSATE_PAN_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FLUE_ASSEMBLY_WELDER = table.Column<int>(type: "int", nullable: true),
                    FLUE_ASSEMBLY_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BASE_CLEAT_WELDER = table.Column<int>(type: "int", nullable: true),
                    BASE_CLEAT_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MFG_FINAL_INSP_WELDER = table.Column<int>(type: "int", nullable: true),
                    MFG_FINAL_INSP_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EMP_NUMBER = table.Column<int>(type: "int", nullable: true),
                    CAPTURE_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PRODUCT_NUMBER = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASME_CBI", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ASME_CBI_HX",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JOB_TRAVELER_NUMBER_HX = table.Column<int>(type: "int", nullable: false),
                    PART_NUMBER_HX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HX_NUMBER_HX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DESCRIPTION_HX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DWG_NUMBER_HX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MVP_NUMBER_HX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHAMBER_HEAD_FITUP_EMP_NUMBER = table.Column<int>(type: "int", nullable: true),
                    CHAMER_HEAD_PVI_LOT_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHAMBER_HEAD_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BOTTOM_HEAD_FITUP_EMP_NUMBER = table.Column<int>(type: "int", nullable: true),
                    BOTTOM_HEAD_PVI_LOT_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BOTTOM_HEAD_PVI_LOT_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TUBE_INSTALL_FITUP_EMP_NUMBER = table.Column<int>(type: "int", nullable: true),
                    TUBE_INSTALL_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TUBE_VERIFICATION_1_FITUP_EMP_NUMBER = table.Column<int>(type: "int", nullable: true),
                    TUBE_VERIFICATION_1_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TUBE_TACK_WELD_FITUP_EMP_NUMBER = table.Column<int>(type: "int", nullable: true),
                    TUBE_TACK_WELD_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TUBE_ROLL_FITUP_EMP_NUMBER = table.Column<int>(type: "int", nullable: true),
                    TUBE_ROLL_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TUBE_VERIFICATION_2_FITUP_EMP_NUMBER = table.Column<int>(type: "int", nullable: true),
                    TUBE_VERIFICATION_2_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROBOT_TUBE_WELD_FITUP_EMP_NUMBER = table.Column<int>(type: "int", nullable: true),
                    ROBOT_TUBE_WELD_WELD_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROBOT_TUBE_WELD_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHAMBER_SHELL_FITUP_EMP_NUMBER = table.Column<int>(type: "int", nullable: true),
                    CHAMBER_SHELL_WELD_ID = table.Column<int>(type: "int", nullable: true),
                    CHAMBER_SHELL_PVI_LOT_NUMBER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHAMBER_SHELL_PVI_MFG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QA_FINAL_INSP_FITUP_EMP_NUMBER = table.Column<int>(type: "int", nullable: true),
                    QA_FINAL_INSP_DATE = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CBI_HX_NOTES = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASME_CBI_HX", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ASME_CBI");

            migrationBuilder.DropTable(
                name: "ASME_CBI_HX");
        }
    }
}
