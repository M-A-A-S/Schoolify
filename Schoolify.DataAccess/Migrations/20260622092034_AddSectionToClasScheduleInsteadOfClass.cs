using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schoolify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSectionToClasScheduleInsteadOfClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectClasses_Sections_SectionId",
                table: "SubjectClasses");

            migrationBuilder.DropIndex(
                name: "IX_SubjectClasses_SectionId",
                table: "SubjectClasses");

            migrationBuilder.DropIndex(
                name: "IX_SubjectClasses_SubjectId_TermId_SectionId",
                table: "SubjectClasses");

            migrationBuilder.DropIndex(
                name: "IX_ClassSchedules_SubjectClassTeacherId_PeriodId_DayOfWeek",
                table: "ClassSchedules");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "SubjectClasses");

            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "ClassSchedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "SectionId", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8158), 1, new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "SectionId", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8160), 1, new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "SectionId", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8161), 1, new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "SectionId", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8163), 1, new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8163) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "SectionId", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8164), 1, new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "SectionId", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8165), 1, new DateTime(2026, 6, 22, 9, 20, 33, 88, DateTimeKind.Utc).AddTicks(8166) });

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
                name: "IX_SubjectClasses_SubjectId_TermId",
                table: "SubjectClasses",
                columns: new[] { "SubjectId", "TermId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_SectionId",
                table: "ClassSchedules",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_SubjectClassTeacherId_PeriodId_SectionId_DayOfWeek",
                table: "ClassSchedules",
                columns: new[] { "SubjectClassTeacherId", "PeriodId", "SectionId", "DayOfWeek" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSchedules_Sections_SectionId",
                table: "ClassSchedules",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassSchedules_Sections_SectionId",
                table: "ClassSchedules");

            migrationBuilder.DropIndex(
                name: "IX_SubjectClasses_SubjectId_TermId",
                table: "SubjectClasses");

            migrationBuilder.DropIndex(
                name: "IX_ClassSchedules_SectionId",
                table: "ClassSchedules");

            migrationBuilder.DropIndex(
                name: "IX_ClassSchedules_SubjectClassTeacherId_PeriodId_SectionId_DayOfWeek",
                table: "ClassSchedules");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "ClassSchedules");

            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "SubjectClasses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3194), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3195), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3196), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3198), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3199), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3200), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2862), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2863) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2864), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2865), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2866), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2867), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2827), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2829), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2830), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2831), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2833), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2834), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2303), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2306), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2307), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2308), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2308) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3072), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3073), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3074), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3227), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3229), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3274), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "FeeItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3276), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3249), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "FeeStructures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3250), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2798), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2800), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2801), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3016), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3018), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3019), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3300), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Installments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3303), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3326), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2751), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2754), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2756), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2758), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2759), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2761), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2762), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2613), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2614), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2615), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3139), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3142), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3104), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3108), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3109), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3111), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3112), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2643), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2644), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "StudentAcademicRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3352), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2979), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2980), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2982), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2983), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2984), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2986), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3375), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "StudentExamResults",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3376), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3045), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3046), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3048), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3049), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2941), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2941) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2949), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2951), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3168), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3171), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "SubjectClassTeachers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3172), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "SectionId", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2901), 1, new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "SectionId", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2905), 1, new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "SubjectClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "SectionId", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2907), 1, new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2542), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2544), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2546), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2547), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2548), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2550), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2551), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2583), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2586), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2720), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2723), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2724) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2673), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2676), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2677), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2678) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2679), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2679) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2681), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2682), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2682) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2684), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2685), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2686) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2687), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2689), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2690), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2692), new DateTime(2026, 6, 18, 21, 43, 47, 197, DateTimeKind.Utc).AddTicks(2692) });

            migrationBuilder.CreateIndex(
                name: "IX_SubjectClasses_SectionId",
                table: "SubjectClasses",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectClasses_SubjectId_TermId_SectionId",
                table: "SubjectClasses",
                columns: new[] { "SubjectId", "TermId", "SectionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_SubjectClassTeacherId_PeriodId_DayOfWeek",
                table: "ClassSchedules",
                columns: new[] { "SubjectClassTeacherId", "PeriodId", "DayOfWeek" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectClasses_Sections_SectionId",
                table: "SubjectClasses",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
