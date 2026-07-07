using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schoolify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSoftDeleteFilterToStudentGuardianIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StudentGuardians_StudentId_GuardianId_GuardianTypeId",
                table: "StudentGuardians");

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(798), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(800), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(801), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(802), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(804), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(805), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(460), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(461), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(462), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(463), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(464), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(417), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(419), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(420), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(423), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(425), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(426), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 326, DateTimeKind.Utc).AddTicks(9931), new DateTime(2026, 7, 7, 10, 57, 11, 326, DateTimeKind.Utc).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 326, DateTimeKind.Utc).AddTicks(9935), new DateTime(2026, 7, 7, 10, 57, 11, 326, DateTimeKind.Utc).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 326, DateTimeKind.Utc).AddTicks(9936), new DateTime(2026, 7, 7, 10, 57, 11, 326, DateTimeKind.Utc).AddTicks(9936) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 326, DateTimeKind.Utc).AddTicks(9937), new DateTime(2026, 7, 7, 10, 57, 11, 326, DateTimeKind.Utc).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(676), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(678), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(679), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(830), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(833), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(883), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(884), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(858), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(859), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(390), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(391), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(392), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(392) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(616), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(619), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(620), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(915), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(917), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(941), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(345), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(350), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(352), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(353), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(354) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(355), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(356), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(358), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(358) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(189), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(190), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(192), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(738), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(746), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(703), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(705), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(706), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(707), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(709), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(225), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(227), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "StudentAcademicRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(966), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(577), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(581), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(582), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(584), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(585), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(586), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(990), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(992), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(647), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(648), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(649), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(649) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(650), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(539), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(546), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(549), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(772), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(774), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(775), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(500), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(504), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(506), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(111), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(112), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(114), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(114) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(115), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(116), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(118), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(119), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(151), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(160), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(307), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(313), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(253), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(255), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(257), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(259), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(260), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(262), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(263), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(265), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(267), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(268), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(270), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(272), new DateTime(2026, 7, 7, 10, 57, 11, 327, DateTimeKind.Utc).AddTicks(272) });

            migrationBuilder.CreateIndex(
                name: "IX_StudentGuardians_StudentId_GuardianId",
                table: "StudentGuardians",
                columns: new[] { "StudentId", "GuardianId" },
                unique: true,
                filter: "[IsDeleted] = 0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StudentGuardians_StudentId_GuardianId",
                table: "StudentGuardians");

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9946), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9948), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9949), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9951), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9952), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9953), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9619), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9620), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9621), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9622), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9624), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9580), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9587), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9588), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9590), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9591), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9592), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9152), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9155), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9156), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9157), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9822), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9824), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9824) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9825), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9979), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9981), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(29), new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(30), new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(3), new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(4), new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9553), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9554), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9556), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9766), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9769), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9770), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(57), new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(57) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(59), new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(82), new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9509), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9512), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9514), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9515), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9517), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9517) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9518), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9520), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9366), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9367), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9368), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9888), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9890), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9848), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9851), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9852), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9853), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9855), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9401), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9403), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "StudentAcademicRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(107), new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9731), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9733), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9734), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9736), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9737), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9738), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(134), new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(136), new DateTime(2026, 7, 6, 15, 46, 34, 893, DateTimeKind.Utc).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9795), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9797), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9798), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9799), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9690), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9701), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9703), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9917), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9917) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9918), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9919) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9919), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9651), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9655), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9657), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9290), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9292), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9293), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9295), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9296), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9297), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9298) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9299), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9336), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9338), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9477), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9482), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9429), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9432), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9433), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9435), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9437), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9438), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9440), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9442), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9444), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9445), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9447), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9448), new DateTime(2026, 7, 6, 15, 46, 34, 892, DateTimeKind.Utc).AddTicks(9449) });

            migrationBuilder.CreateIndex(
                name: "IX_StudentGuardians_StudentId_GuardianId_GuardianTypeId",
                table: "StudentGuardians",
                columns: new[] { "StudentId", "GuardianId", "GuardianTypeId" },
                unique: true);
        }
    }
}
