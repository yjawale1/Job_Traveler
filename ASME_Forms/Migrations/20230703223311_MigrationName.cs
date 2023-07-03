using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASME_Forms.Migrations
{
    /// <inheritdoc />
    public partial class MigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PART_NUMBER",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NATL_BD_NUMBER",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "MVP_NUMBER",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HX_NUMBER",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DWG_NUMBER",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRIPTION",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BASIC_TANK_NUMBER",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "AI_HYDRO_TEST_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "AI_HYDRO_TEST_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ATTACHMENTS_LOT_NUMBER",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ATTACHMENTS_MFG",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ATTACHMENTS_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BASE_CLEAT_MFG",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BASE_CLEAT_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BOTTOM_HEAD_MFG",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BOTTOM_HEAD_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CHAMBER_HEAD_MFG",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CHAMBER_HEAD_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CHAMBER_SHELL_MFG",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CHAMBER_SHELL_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONDENSATE_PAN_MFG",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CONDENSATE_PAN_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ERW_STUD_LOT_NUMBER",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ERW_STUD_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FLUE_ASSEMBLY_MFG",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FLUE_ASSEMBLY_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JOGGLE_MFG",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JOGGLE_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LONGSEAM_WELD_MFG",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LONGSEAM_WELD_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "MFG_FINAL_INSP_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MFG_FINAL_INSP_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "MFG_HYDRO_TEST_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MFG_HYDRO_TEST_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "MFG_NATL_BD_NUMBER_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MFG_NATL_BD_NUMBER_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PLATE_ROLLS_LOT_NUMBER_1",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PLATE_ROLLS_LOT_NUMBER_2",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PLATE_ROLLS_MFG_1",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PLATE_ROLLS_MFG_2",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PLATE_ROLLS_WELDER_1",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PLATE_ROLLS_WELDER_2",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "QA_HYDRO_TEST_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "QA_HYDRO_TEST_GAUGE",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QA_HYDRO_TEST_PSI",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QA_HYDRO_TEST_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "QA_NATL_BD_NUMBER_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "QA_NATL_BD_NUMBER_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TOP_HEAD_LOT_NUMBER",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TOP_HEAD_MFG",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TOP_HEAD_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TUBE_VERIFICATION_HX_INSTALLATION_MFG",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TUBE_VERIFICATION_HX_INSTALLATION_WELDER",
                table: "ASME_CBI",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377919,
                columns: new[] { "AI_HYDRO_TEST_DATE", "AI_HYDRO_TEST_WELDER", "ATTACHMENTS_LOT_NUMBER", "ATTACHMENTS_MFG", "ATTACHMENTS_WELDER", "BASE_CLEAT_MFG", "BASE_CLEAT_WELDER", "BOTTOM_HEAD_MFG", "BOTTOM_HEAD_WELDER", "CHAMBER_HEAD_MFG", "CHAMBER_HEAD_WELDER", "CHAMBER_SHELL_MFG", "CHAMBER_SHELL_WELDER", "CONDENSATE_PAN_MFG", "CONDENSATE_PAN_WELDER", "ERW_STUD_LOT_NUMBER", "ERW_STUD_WELDER", "FLUE_ASSEMBLY_MFG", "FLUE_ASSEMBLY_WELDER", "JOGGLE_MFG", "JOGGLE_WELDER", "LONGSEAM_WELD_MFG", "LONGSEAM_WELD_WELDER", "MFG_FINAL_INSP_DATE", "MFG_FINAL_INSP_WELDER", "MFG_HYDRO_TEST_DATE", "MFG_HYDRO_TEST_WELDER", "MFG_NATL_BD_NUMBER_DATE", "MFG_NATL_BD_NUMBER_WELDER", "PLATE_ROLLS_LOT_NUMBER_1", "PLATE_ROLLS_LOT_NUMBER_2", "PLATE_ROLLS_MFG_1", "PLATE_ROLLS_MFG_2", "PLATE_ROLLS_WELDER_1", "PLATE_ROLLS_WELDER_2", "QA_HYDRO_TEST_DATE", "QA_HYDRO_TEST_GAUGE", "QA_HYDRO_TEST_PSI", "QA_HYDRO_TEST_WELDER", "QA_NATL_BD_NUMBER_DATE", "QA_NATL_BD_NUMBER_WELDER", "TOP_HEAD_LOT_NUMBER", "TOP_HEAD_MFG", "TOP_HEAD_WELDER", "TUBE_VERIFICATION_HX_INSTALLATION_MFG", "TUBE_VERIFICATION_HX_INSTALLATION_WELDER" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377920,
                columns: new[] { "AI_HYDRO_TEST_DATE", "AI_HYDRO_TEST_WELDER", "ATTACHMENTS_LOT_NUMBER", "ATTACHMENTS_MFG", "ATTACHMENTS_WELDER", "BASE_CLEAT_MFG", "BASE_CLEAT_WELDER", "BOTTOM_HEAD_MFG", "BOTTOM_HEAD_WELDER", "CHAMBER_HEAD_MFG", "CHAMBER_HEAD_WELDER", "CHAMBER_SHELL_MFG", "CHAMBER_SHELL_WELDER", "CONDENSATE_PAN_MFG", "CONDENSATE_PAN_WELDER", "ERW_STUD_LOT_NUMBER", "ERW_STUD_WELDER", "FLUE_ASSEMBLY_MFG", "FLUE_ASSEMBLY_WELDER", "JOGGLE_MFG", "JOGGLE_WELDER", "LONGSEAM_WELD_MFG", "LONGSEAM_WELD_WELDER", "MFG_FINAL_INSP_DATE", "MFG_FINAL_INSP_WELDER", "MFG_HYDRO_TEST_DATE", "MFG_HYDRO_TEST_WELDER", "MFG_NATL_BD_NUMBER_DATE", "MFG_NATL_BD_NUMBER_WELDER", "PLATE_ROLLS_LOT_NUMBER_1", "PLATE_ROLLS_LOT_NUMBER_2", "PLATE_ROLLS_MFG_1", "PLATE_ROLLS_MFG_2", "PLATE_ROLLS_WELDER_1", "PLATE_ROLLS_WELDER_2", "QA_HYDRO_TEST_DATE", "QA_HYDRO_TEST_GAUGE", "QA_HYDRO_TEST_PSI", "QA_HYDRO_TEST_WELDER", "QA_NATL_BD_NUMBER_DATE", "QA_NATL_BD_NUMBER_WELDER", "TOP_HEAD_LOT_NUMBER", "TOP_HEAD_MFG", "TOP_HEAD_WELDER", "TUBE_VERIFICATION_HX_INSTALLATION_MFG", "TUBE_VERIFICATION_HX_INSTALLATION_WELDER" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377921,
                columns: new[] { "AI_HYDRO_TEST_DATE", "AI_HYDRO_TEST_WELDER", "ATTACHMENTS_LOT_NUMBER", "ATTACHMENTS_MFG", "ATTACHMENTS_WELDER", "BASE_CLEAT_MFG", "BASE_CLEAT_WELDER", "BOTTOM_HEAD_MFG", "BOTTOM_HEAD_WELDER", "CHAMBER_HEAD_MFG", "CHAMBER_HEAD_WELDER", "CHAMBER_SHELL_MFG", "CHAMBER_SHELL_WELDER", "CONDENSATE_PAN_MFG", "CONDENSATE_PAN_WELDER", "ERW_STUD_LOT_NUMBER", "ERW_STUD_WELDER", "FLUE_ASSEMBLY_MFG", "FLUE_ASSEMBLY_WELDER", "JOGGLE_MFG", "JOGGLE_WELDER", "LONGSEAM_WELD_MFG", "LONGSEAM_WELD_WELDER", "MFG_FINAL_INSP_DATE", "MFG_FINAL_INSP_WELDER", "MFG_HYDRO_TEST_DATE", "MFG_HYDRO_TEST_WELDER", "MFG_NATL_BD_NUMBER_DATE", "MFG_NATL_BD_NUMBER_WELDER", "PLATE_ROLLS_LOT_NUMBER_1", "PLATE_ROLLS_LOT_NUMBER_2", "PLATE_ROLLS_MFG_1", "PLATE_ROLLS_MFG_2", "PLATE_ROLLS_WELDER_1", "PLATE_ROLLS_WELDER_2", "QA_HYDRO_TEST_DATE", "QA_HYDRO_TEST_GAUGE", "QA_HYDRO_TEST_PSI", "QA_HYDRO_TEST_WELDER", "QA_NATL_BD_NUMBER_DATE", "QA_NATL_BD_NUMBER_WELDER", "TOP_HEAD_LOT_NUMBER", "TOP_HEAD_MFG", "TOP_HEAD_WELDER", "TUBE_VERIFICATION_HX_INSTALLATION_MFG", "TUBE_VERIFICATION_HX_INSTALLATION_WELDER" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AI_HYDRO_TEST_DATE",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "AI_HYDRO_TEST_WELDER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "ATTACHMENTS_LOT_NUMBER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "ATTACHMENTS_MFG",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "ATTACHMENTS_WELDER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "BASE_CLEAT_MFG",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "BASE_CLEAT_WELDER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "BOTTOM_HEAD_MFG",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "BOTTOM_HEAD_WELDER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "CHAMBER_HEAD_MFG",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "CHAMBER_HEAD_WELDER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "CHAMBER_SHELL_MFG",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "CHAMBER_SHELL_WELDER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "CONDENSATE_PAN_MFG",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "CONDENSATE_PAN_WELDER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "ERW_STUD_LOT_NUMBER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "ERW_STUD_WELDER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "FLUE_ASSEMBLY_MFG",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "FLUE_ASSEMBLY_WELDER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "JOGGLE_MFG",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "JOGGLE_WELDER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "LONGSEAM_WELD_MFG",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "LONGSEAM_WELD_WELDER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "MFG_FINAL_INSP_DATE",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "MFG_FINAL_INSP_WELDER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "MFG_HYDRO_TEST_DATE",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "MFG_HYDRO_TEST_WELDER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "MFG_NATL_BD_NUMBER_DATE",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "MFG_NATL_BD_NUMBER_WELDER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "PLATE_ROLLS_LOT_NUMBER_1",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "PLATE_ROLLS_LOT_NUMBER_2",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "PLATE_ROLLS_MFG_1",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "PLATE_ROLLS_MFG_2",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "PLATE_ROLLS_WELDER_1",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "PLATE_ROLLS_WELDER_2",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "QA_HYDRO_TEST_DATE",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "QA_HYDRO_TEST_GAUGE",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "QA_HYDRO_TEST_PSI",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "QA_HYDRO_TEST_WELDER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "QA_NATL_BD_NUMBER_DATE",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "QA_NATL_BD_NUMBER_WELDER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "TOP_HEAD_LOT_NUMBER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "TOP_HEAD_MFG",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "TOP_HEAD_WELDER",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "TUBE_VERIFICATION_HX_INSTALLATION_MFG",
                table: "ASME_CBI");

            migrationBuilder.DropColumn(
                name: "TUBE_VERIFICATION_HX_INSTALLATION_WELDER",
                table: "ASME_CBI");

            migrationBuilder.AlterColumn<string>(
                name: "PART_NUMBER",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NATL_BD_NUMBER",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MVP_NUMBER",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HX_NUMBER",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DWG_NUMBER",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DESCRIPTION",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BASIC_TANK_NUMBER",
                table: "ASME_CBI",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
