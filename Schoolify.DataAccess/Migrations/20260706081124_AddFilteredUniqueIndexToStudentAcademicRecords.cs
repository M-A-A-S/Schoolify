using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schoolify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFilteredUniqueIndexToStudentAcademicRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StudentAcademicRecords_EnrollmentId",
                table: "StudentAcademicRecords");

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6570), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6572), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6574), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6575), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6577), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6577) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6578), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6164), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6165), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6166), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6167), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6169), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6118), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6120), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6121), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6123), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6124), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6126), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5530), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5533), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5534), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5536), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6415), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6417), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6418), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6612), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6616), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6678), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6681), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6644), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6646), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6081), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6083), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6084), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6341), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6344), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6346), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6719), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6721), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6750), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6022), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6027), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6029), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6030), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6032), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6034), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6044), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5834), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5835), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5837), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6500), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6503), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6457), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6460), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6462), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6463), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6465), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6465) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5877), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5880), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "StudentAcademicRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6782), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6294), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6298), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6299), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6301), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6302), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6304), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6812), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6814), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6378), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6380), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6381), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6383), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6248), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6258), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6261), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6539), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6541), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6542), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6204), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6208), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6210), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5737), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5739), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5741), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5743), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5743) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5744), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5746), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5748), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5791), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5795), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5984), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5989), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5917), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5920), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5922), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5925), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5927), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5928), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5931), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5933), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5935), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5937), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5938), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5940), new DateTime(2026, 7, 6, 8, 11, 20, 393, DateTimeKind.Utc).AddTicks(5941) });

            migrationBuilder.CreateIndex(
                name: "IX_StudentAcademicRecords_EnrollmentId",
                table: "StudentAcademicRecords",
                column: "EnrollmentId",
                unique: true,
                filter: "[IsDeleted] = 0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StudentAcademicRecords_EnrollmentId",
                table: "StudentAcademicRecords");

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(284), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(288), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(292), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(295), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(298), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(301), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9596), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9600), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9603), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9605), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9608), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9517), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9521), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9524), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9527), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9530), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9533), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8450), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8456), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8459), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8461), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(29), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(33), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(37), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(367), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(372), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(372) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(470), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(474), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(419), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(422), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9464), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9467), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9470), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9891), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9896), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9897) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9900), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(527), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(532), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(583), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9375), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9384), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9387), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9391), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9395), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9399), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9402), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9079), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9083), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9085), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(153), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(170), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(83), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(88), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(89) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(91), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(95), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(98), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9146), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9151), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "StudentAcademicRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(631), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9820), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9824), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9828), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9831), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9834), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9838), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(677), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(681), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9971), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9975), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9977), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9980), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9746), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9759), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9764), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9765) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(221), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(224), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(227), new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9669), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9676), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9681), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8918), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8923), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8927), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8930), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8933), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8936), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8940), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9002), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9019), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9314), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9323), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9208), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9213), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9217), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9221), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9225), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9229), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9232), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9236), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9240), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9244), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9248), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9252), new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9252) });

            migrationBuilder.CreateIndex(
                name: "IX_StudentAcademicRecords_EnrollmentId",
                table: "StudentAcademicRecords",
                column: "EnrollmentId",
                unique: true);
        }
    }
}
