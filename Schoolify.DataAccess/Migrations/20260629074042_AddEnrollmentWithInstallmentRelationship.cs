using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schoolify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddEnrollmentWithInstallmentRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Installments_Enrollments_EnrollmentId",
                table: "Installments");

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9566), new DateTime(2026, 6, 29, 7, 40, 36, 340, DateTimeKind.Utc).AddTicks(9567) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Installments_Enrollments_EnrollmentId",
                table: "Installments",
                column: "EnrollmentId",
                principalTable: "Enrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Installments_Enrollments_EnrollmentId",
                table: "Installments");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Installments_Enrollments_EnrollmentId",
                table: "Installments",
                column: "EnrollmentId",
                principalTable: "Enrollments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
