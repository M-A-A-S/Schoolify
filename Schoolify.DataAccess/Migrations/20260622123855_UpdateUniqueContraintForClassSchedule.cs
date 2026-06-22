using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schoolify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUniqueContraintForClassSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ClassSchedules_ClassroomId_PeriodId_DayOfWeek",
                table: "ClassSchedules");

            migrationBuilder.DropIndex(
                name: "IX_ClassSchedules_SubjectClassTeacherId_PeriodId_SectionId_DayOfWeek",
                table: "ClassSchedules");

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2832), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2834), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2835), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2836), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2838), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2839), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2477), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2479), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2480), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2481), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2482), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2442), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2443), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2445), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2446), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2447), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2448), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(1845), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(1856), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(1857), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(1859), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2698), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2700), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2701), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2867), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2869), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2922), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2924), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2893), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2894), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2408), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2410), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2411), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2637), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2639), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2641), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2951), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2953), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2954) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2980), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2359), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2362), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2364), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2365), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2367), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2369), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2376), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2200), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2202), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2203), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2774), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2776), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2735), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2737), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2738), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2740), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2741), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2236), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2238), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "StudentAcademicRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(3005), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2597), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2599), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2600), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2602), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2603), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2605), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(3030), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(3032), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2667), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2669), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2670), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2671), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2558), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2566), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2568), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2804), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2805), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2806), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2512), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2513) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2522), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2524), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2123), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2124), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2126), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2127), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2129), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2130), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2131), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2165), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2167), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2321), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2326), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2269), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2271), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2273), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2275), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2276), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2278), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2280), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2281), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2283), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2285), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2286), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2288), new DateTime(2026, 6, 22, 12, 38, 53, 313, DateTimeKind.Utc).AddTicks(2288) });

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_ClassroomId_PeriodId_DayOfWeek_SectionId",
                table: "ClassSchedules",
                columns: new[] { "ClassroomId", "PeriodId", "DayOfWeek", "SectionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_SubjectClassTeacherId_PeriodId_DayOfWeek",
                table: "ClassSchedules",
                columns: new[] { "SubjectClassTeacherId", "PeriodId", "DayOfWeek" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ClassSchedules_ClassroomId_PeriodId_DayOfWeek_SectionId",
                table: "ClassSchedules");

            migrationBuilder.DropIndex(
                name: "IX_ClassSchedules_SubjectClassTeacherId_PeriodId_DayOfWeek",
                table: "ClassSchedules");

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8158), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8160), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8161), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8163), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8164), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8165), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7837), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7838), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7839), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7840), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7841), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7800), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7802), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7804), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7805), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7806), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7807), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7372), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7376), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7377), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7378), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8040), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8041), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8043), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8190), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8192), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8245), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8247), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8212), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8213), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7774), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7775), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7776), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7988), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7990), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7992), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8271), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8273), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8296), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7735), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7738), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7739), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7741), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7743), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7744), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7746), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7588), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7589), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7590), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8100), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8103), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8065), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8070), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8071), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8071) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8072), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8074), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7622), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7624), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "StudentAcademicRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8325), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7954), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7955), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7957), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7958), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7960), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7961), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8347), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8348), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8015), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8016), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8017), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8019), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7905), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7917), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7919), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8128), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8129), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8130), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7869), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7873), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7875), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7524), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7525), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7526), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7528), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7529), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7530), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7532), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7562), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7564), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7705), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7709), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7649), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7652), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7653), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7655), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7657), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7666), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7667) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7668), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7670), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7671), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7673), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7675), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7676), new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(7677) });

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_ClassroomId_PeriodId_DayOfWeek",
                table: "ClassSchedules",
                columns: new[] { "ClassroomId", "PeriodId", "DayOfWeek" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_SubjectClassTeacherId_PeriodId_SectionId_DayOfWeek",
                table: "ClassSchedules",
                columns: new[] { "SubjectClassTeacherId", "PeriodId", "SectionId", "DayOfWeek" },
                unique: true);
        }
    }
}
