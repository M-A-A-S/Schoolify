using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schoolify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFilteredUniqueIndexToStudentClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StudentClasses_StudentId_SubjectClassId",
                table: "StudentClasses");

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
                name: "IX_StudentClasses_StudentId_SubjectClassId",
                table: "StudentClasses",
                columns: new[] { "StudentId", "SubjectClassId" },
                unique: true,
                filter: "[IsDeleted] = 0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StudentClasses_StudentId_SubjectClassId",
                table: "StudentClasses");

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
                name: "IX_StudentClasses_StudentId_SubjectClassId",
                table: "StudentClasses",
                columns: new[] { "StudentId", "SubjectClassId" },
                unique: true);
        }
    }
}
