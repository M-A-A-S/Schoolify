using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schoolify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddMaxMarksToYearLevelAndModifyStudentAcademicRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalMarks",
                table: "StudentAcademicRecords",
                newName: "Percentage");

            migrationBuilder.AddColumn<decimal>(
                name: "MaxMarks",
                table: "YearLevels",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PassPercentage",
                table: "YearLevels",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ObtainedMarks",
                table: "StudentAcademicRecords",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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
                columns: new[] { "CreatedAt", "ObtainedMarks", "Percentage", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(631), 85m, 0m, new DateTime(2026, 7, 1, 13, 0, 52, 608, DateTimeKind.Utc).AddTicks(632) });

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
                columns: new[] { "CreatedAt", "MaxMarks", "PassPercentage", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9208), 0m, 0m, new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9209) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "MaxMarks", "PassPercentage", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9213), 0m, 0m, new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "MaxMarks", "PassPercentage", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9217), 0m, 0m, new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "MaxMarks", "PassPercentage", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9221), 0m, 0m, new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "MaxMarks", "PassPercentage", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9225), 0m, 0m, new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "MaxMarks", "PassPercentage", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9229), 0m, 0m, new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "MaxMarks", "PassPercentage", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9232), 0m, 0m, new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "MaxMarks", "PassPercentage", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9236), 0m, 0m, new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "MaxMarks", "PassPercentage", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9240), 0m, 0m, new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "MaxMarks", "PassPercentage", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9244), 0m, 0m, new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "MaxMarks", "PassPercentage", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9248), 0m, 0m, new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "MaxMarks", "PassPercentage", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9252), 0m, 0m, new DateTime(2026, 7, 1, 13, 0, 52, 607, DateTimeKind.Utc).AddTicks(9252) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxMarks",
                table: "YearLevels");

            migrationBuilder.DropColumn(
                name: "PassPercentage",
                table: "YearLevels");

            migrationBuilder.DropColumn(
                name: "ObtainedMarks",
                table: "StudentAcademicRecords");

            migrationBuilder.RenameColumn(
                name: "Percentage",
                table: "StudentAcademicRecords",
                newName: "TotalMarks");

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9139), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9143), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9146), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9150), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9153), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9156), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8293), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8297), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8299), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8302), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8305), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8305) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8203), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8207), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8210), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8211) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8213), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8216), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8219), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7076), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7085), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7088), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7091), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8830), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8834), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8837), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9236), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9237) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9241), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9362), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9366), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9298), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9301), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8134), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8137), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8140), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8672), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8678), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8681), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9434), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9438), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9500), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8022), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8030), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8034), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8038), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8042), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8045), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8049), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7617), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7621), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7632), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8990), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8996), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8902), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8906), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8909), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8912), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8916), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7716), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7721), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "StudentAcademicRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TotalMarks", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9566), 85m, new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8578), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8582), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8586), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8589), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8592), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8596), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9624), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9628), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8753), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8757), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8760), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8762), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8488), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8489) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8502), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8507), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9069), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9072), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9075), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8383), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8391), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8406), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7436), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7441), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7444), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7448), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7451), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7454), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7457), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7539), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7545), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7942), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7951), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7809), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7814), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7818), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7822), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7826), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7830), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7834), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7838), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7842), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7846), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7850), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7854), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(7855) });
        }
    }
}
