using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schoolify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEnrollmentUniqueIndexForSoftDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Enrollments_StudentId_YearLevelId_SchoolYearId_SectionId",
                table: "Enrollments");

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1572), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1574), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1575), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1576), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1578), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1579), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1244), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1246), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1247), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1248), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1249), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1210), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1212), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1213), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1213) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1214), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1216), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1217), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1217) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(783), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(785), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(786), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(788), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1458), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1458) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1459), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1461), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1605), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1607), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1655), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1656), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1631), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1632), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1185), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1186), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1187), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1403), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1405), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1406), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1680), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1687), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1709), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1145), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1148), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1150), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1151), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1153), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1154), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1156), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(994), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(996), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(996) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(997), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1520), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1523), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1486), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1488), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1490), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1491), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1492), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1027), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1027) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1029), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "StudentAcademicRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1732), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1363), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1365), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1366), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1373), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1374), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1376), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1755), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1760), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1431), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1432), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1433), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1434) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1435), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1320), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1329), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1331), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1547), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1548), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1549), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1281), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1285), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1287), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(931), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(933), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(933) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(934), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(935), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(937), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(938), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(939), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(966), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(968), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1110), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1115), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1056), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1058), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1060), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1061), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1063), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1063) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1065), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1066), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1068), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1070), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1078), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1080), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1081), new DateTime(2026, 7, 7, 11, 58, 35, 144, DateTimeKind.Utc).AddTicks(1081) });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentId_YearLevelId_SchoolYearId",
                table: "Enrollments",
                columns: new[] { "StudentId", "YearLevelId", "SchoolYearId" },
                unique: true,
                filter: "[IsDeleted] = 0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Enrollments_StudentId_YearLevelId_SchoolYearId",
                table: "Enrollments");

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
                name: "IX_Enrollments_StudentId_YearLevelId_SchoolYearId_SectionId",
                table: "Enrollments",
                columns: new[] { "StudentId", "YearLevelId", "SchoolYearId", "SectionId" },
                unique: true);
        }
    }
}
