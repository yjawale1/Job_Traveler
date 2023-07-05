using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASME_Forms.Migrations
{
    /// <inheritdoc />
    public partial class DateTimeAddedFinally : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "QA_NATL_BD_NUMBER_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "QA_HYDRO_TEST_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MFG_NATL_BD_NUMBER_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MFG_HYDRO_TEST_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MFG_FINAL_INSP_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AI_HYDRO_TEST_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377919,
                columns: new[] { "AI_HYDRO_TEST_DATE", "MFG_FINAL_INSP_DATE", "MFG_HYDRO_TEST_DATE", "MFG_NATL_BD_NUMBER_DATE", "QA_HYDRO_TEST_DATE", "QA_NATL_BD_NUMBER_DATE" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377920,
                columns: new[] { "AI_HYDRO_TEST_DATE", "MFG_FINAL_INSP_DATE", "MFG_HYDRO_TEST_DATE", "MFG_NATL_BD_NUMBER_DATE", "QA_HYDRO_TEST_DATE", "QA_NATL_BD_NUMBER_DATE" },
                values: new object[] { null, null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377921,
                columns: new[] { "AI_HYDRO_TEST_DATE", "MFG_FINAL_INSP_DATE", "MFG_HYDRO_TEST_DATE", "MFG_NATL_BD_NUMBER_DATE", "QA_HYDRO_TEST_DATE", "QA_NATL_BD_NUMBER_DATE" },
                values: new object[] { null, null, null, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "QA_NATL_BD_NUMBER_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "QA_HYDRO_TEST_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MFG_NATL_BD_NUMBER_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MFG_HYDRO_TEST_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "MFG_FINAL_INSP_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AI_HYDRO_TEST_DATE",
                table: "ASME_CBI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377919,
                columns: new[] { "AI_HYDRO_TEST_DATE", "MFG_FINAL_INSP_DATE", "MFG_HYDRO_TEST_DATE", "MFG_NATL_BD_NUMBER_DATE", "QA_HYDRO_TEST_DATE", "QA_NATL_BD_NUMBER_DATE" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377920,
                columns: new[] { "AI_HYDRO_TEST_DATE", "MFG_FINAL_INSP_DATE", "MFG_HYDRO_TEST_DATE", "MFG_NATL_BD_NUMBER_DATE", "QA_HYDRO_TEST_DATE", "QA_NATL_BD_NUMBER_DATE" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ASME_CBI",
                keyColumn: "JOB_TRAVELER_NUMBER",
                keyValue: 377921,
                columns: new[] { "AI_HYDRO_TEST_DATE", "MFG_FINAL_INSP_DATE", "MFG_HYDRO_TEST_DATE", "MFG_NATL_BD_NUMBER_DATE", "QA_HYDRO_TEST_DATE", "QA_NATL_BD_NUMBER_DATE" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
