using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Schoolify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntitiesAndRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassSchedules_Classes_ClassId",
                table: "ClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentClasses_Classes_ClassId",
                table: "StudentClasses");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "StudentYearLevels");

            migrationBuilder.RenameColumn(
                name: "MarksObtained",
                table: "StudentClasses",
                newName: "FinalScore");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "StudentClasses",
                newName: "SubjectClassId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentClasses_StudentId_ClassId",
                table: "StudentClasses",
                newName: "IX_StudentClasses_StudentId_SubjectClassId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentClasses_ClassId",
                table: "StudentClasses",
                newName: "IX_StudentClasses_SubjectClassId");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "ClassSchedules",
                newName: "SubjectClassTeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassSchedules_ClassId_PeriodId_DayOfWeek",
                table: "ClassSchedules",
                newName: "IX_ClassSchedules_SubjectClassTeacherId_PeriodId_DayOfWeek");

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "Terms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "Terms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SubjectClassId",
                table: "ClassSchedules",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FeeStructures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolYearId = table.Column<int>(type: "int", nullable: false),
                    YearLevelId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeStructures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeeStructures_SchoolYears_SchoolYearId",
                        column: x => x.SchoolYearId,
                        principalTable: "SchoolYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FeeStructures_YearLevels_YearLevelId",
                        column: x => x.YearLevelId,
                        principalTable: "YearLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearLevelId = table.Column<int>(type: "int", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_YearLevels_YearLevelId",
                        column: x => x.YearLevelId,
                        principalTable: "YearLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeeItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeeStructureId = table.Column<int>(type: "int", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeeItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeeItems_FeeStructures_FeeStructureId",
                        column: x => x.FeeStructureId,
                        principalTable: "FeeStructures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    YearLevelId = table.Column<int>(type: "int", nullable: false),
                    SchoolYearId = table.Column<int>(type: "int", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    TotalFees = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetFees = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.Id);
                    table.CheckConstraint("CK_StudentYearLevel_Score", "[FinalYearScore] IS NULL OR ([FinalYearScore] >= 0 AND [FinalYearScore] <= 100)");
                    table.ForeignKey(
                        name: "FK_Enrollments_SchoolYears_SchoolYearId",
                        column: x => x.SchoolYearId,
                        principalTable: "SchoolYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_YearLevels_YearLevelId",
                        column: x => x.YearLevelId,
                        principalTable: "YearLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubjectClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    TermId = table.Column<int>(type: "int", nullable: false),
                    SectionId = table.Column<int>(type: "int", nullable: false),
                    NameEn = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaxScore = table.Column<decimal>(type: "decimal(5,2)", nullable: false, defaultValue: 100m),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectClasses_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubjectClasses_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubjectClasses_Terms_TermId",
                        column: x => x.TermId,
                        principalTable: "Terms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Installments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnrollmentId = table.Column<int>(type: "int", nullable: false),
                    InstallmentNumber = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DueDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Installments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Installments_Enrollments_EnrollmentId",
                        column: x => x.EnrollmentId,
                        principalTable: "Enrollments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentAcademicRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnrollmentId = table.Column<int>(type: "int", nullable: false),
                    TotalMarks = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxMarks = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GradeLetter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPassed = table.Column<bool>(type: "bit", nullable: false),
                    CalculatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAcademicRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentAcademicRecords_Enrollments_EnrollmentId",
                        column: x => x.EnrollmentId,
                        principalTable: "Enrollments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectClassId = table.Column<int>(type: "int", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exams_SubjectClasses_SubjectClassId",
                        column: x => x.SubjectClassId,
                        principalTable: "SubjectClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubjectClassTeachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectClassId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    IsMainTeacher = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectClassTeachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectClassTeachers_SubjectClasses_SubjectClassId",
                        column: x => x.SubjectClassId,
                        principalTable: "SubjectClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubjectClassTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstallmentId = table.Column<int>(type: "int", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    ReceiptNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Installments_InstallmentId",
                        column: x => x.InstallmentId,
                        principalTable: "Installments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentExamResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    MarksObtained = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentExamResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentExamResults_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentExamResults_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "SubjectClassId", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(1), null, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "SubjectClassId", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(2), null, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "SubjectClassId", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(3), null, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "SubjectClassId", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(5), null, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "SubjectClassId", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(6), null, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "SubjectClassId", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(7), null, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9678), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9680), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9681), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9682), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9682) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9683), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9642), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9644), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9645), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9647), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9648), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9649), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9282), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9285), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9286), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9287), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9288) });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Discount", "IsDeleted", "NetFees", "SchoolYearId", "SectionId", "Status", "StudentId", "TotalFees", "UpdatedAt", "YearLevelId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9907), null, 0m, false, 0m, 1, 0, 0, 1, 0m, new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9908), 10 },
                    { 2, new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9909), null, 0m, false, 0m, 1, 0, 0, 2, 0m, new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9909), 10 },
                    { 3, new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9910), null, 0m, false, 0m, 2, 0, 0, 1, 0m, new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9910), 11 }
                });

            migrationBuilder.InsertData(
                table: "FeeStructures",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "SchoolYearId", "UpdatedAt", "YearLevelId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(55), null, false, 1, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(55), 1 },
                    { 2, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(56), null, false, 1, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(56), 2 }
                });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9616), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9617), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9619), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9830), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9832), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9833), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9574), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9577), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9579), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9580), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9582), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9583), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9585), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9461), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9462), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9464), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9967), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9968) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9970), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9934), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9936), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9938), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9939), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9941), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9941) });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "NameAr", "NameEn", "UpdatedAt", "YearLevelId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(155), null, false, "أ", "A", new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(155), 1 },
                    { 2, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(157), null, false, "ب", "B", new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(157), 1 }
                });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9796), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9797), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9798) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9799), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9800), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9801), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9803), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9856), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9858), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9859), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9860), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9759), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9766), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9768), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9769) });

            migrationBuilder.InsertData(
                table: "SubjectClasses",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "MaxScore", "NameAr", "NameEn", "SectionId", "SubjectId", "TermId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9721), null, false, 100.00m, "رياضيات - الصف العاشر أ", "Math - Grade 10 A", 0, 1, 1, new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9721) },
                    { 2, new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9725), null, false, 100.00m, "فيزياء - الصف العاشر أ", "Physics - Grade 10 A", 0, 2, 1, new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9725) },
                    { 3, new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9727), null, false, 100.00m, "إنجليزي - الصف العاشر أ", "English - Grade 10 A", 0, 3, 1, new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9727) }
                });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9415), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9417), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9419), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9420), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9421), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9423), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9430), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9882), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9884), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "NameAr", "NameEn", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9541), "الفصل الدراسي الأول", "Term 1", new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "NameAr", "NameEn", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9545), "الفصل الدراسي الثاني", "Term 2", new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9494), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9497), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9498), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9500), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9502), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9504), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9505), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9507), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9509), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9510), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9512), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9514), new DateTime(2026, 6, 18, 16, 27, 46, 329, DateTimeKind.Utc).AddTicks(9514) });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "CreatedAt", "Date", "DeletedAt", "IsDeleted", "MaxScore", "NameAr", "NameEn", "SubjectClassId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(31), new DateTime(2026, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 30m, "منتصف الفصل", "Midterm", 1, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(31) },
                    { 2, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(33), new DateTime(2026, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 70m, "النهائي", "Final", 1, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(33) }
                });

            migrationBuilder.InsertData(
                table: "FeeItems",
                columns: new[] { "Id", "Amount", "CreatedAt", "DeletedAt", "FeeStructureId", "IsDeleted", "NameAr", "NameEn", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 500m, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(78), null, 1, false, "الرسوم الدراسية", "Tuition Fee", new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(79) },
                    { 2, 100m, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(80), null, 1, false, "الكتب", "Books", new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(80) }
                });

            migrationBuilder.InsertData(
                table: "Installments",
                columns: new[] { "Id", "Amount", "CreatedAt", "DeletedAt", "DueDate", "EnrollmentId", "InstallmentNumber", "IsDeleted", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 300m, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(105), null, new DateOnly(2026, 1, 1), 1, 1, false, 1, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(105) },
                    { 2, 300m, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(107), null, new DateOnly(2026, 3, 1), 1, 2, false, 1, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(107) }
                });

            migrationBuilder.InsertData(
                table: "StudentAcademicRecords",
                columns: new[] { "Id", "CalculatedAt", "CreatedAt", "DeletedAt", "EnrollmentId", "GradeLetter", "IsDeleted", "IsPassed", "MaxMarks", "TotalMarks", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2026, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(178), null, 1, "A", false, true, 100m, 85m, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(178) });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "AmountPaid", "CreatedAt", "DeletedAt", "InstallmentId", "IsDeleted", "PaymentDate", "PaymentMethod", "ReceiptNumber", "TransactionReference", "UpdatedAt" },
                values: new object[] { 1, 300m, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(129), null, 1, false, new DateTime(2026, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "R-1001", null, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(129) });

            migrationBuilder.InsertData(
                table: "StudentExamResults",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ExamId", "IsDeleted", "MarksObtained", "StudentId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(202), null, 1, false, 25m, 1, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(202) },
                    { 2, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(204), null, 2, false, 60m, 1, new DateTime(2026, 6, 18, 16, 27, 46, 330, DateTimeKind.Utc).AddTicks(204) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_SubjectClassId",
                table: "ClassSchedules",
                column: "SubjectClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_SchoolYearId",
                table: "Enrollments",
                column: "SchoolYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_SectionId",
                table: "Enrollments",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentId_YearLevelId_SchoolYearId_SectionId",
                table: "Enrollments",
                columns: new[] { "StudentId", "YearLevelId", "SchoolYearId", "SectionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_YearLevelId",
                table: "Enrollments",
                column: "YearLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_SubjectClassId",
                table: "Exams",
                column: "SubjectClassId");

            migrationBuilder.CreateIndex(
                name: "IX_FeeItems_FeeStructureId",
                table: "FeeItems",
                column: "FeeStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_FeeStructures_SchoolYearId",
                table: "FeeStructures",
                column: "SchoolYearId");

            migrationBuilder.CreateIndex(
                name: "IX_FeeStructures_YearLevelId",
                table: "FeeStructures",
                column: "YearLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Installments_EnrollmentId",
                table: "Installments",
                column: "EnrollmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_InstallmentId",
                table: "Payments",
                column: "InstallmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_YearLevelId",
                table: "Sections",
                column: "YearLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAcademicRecords_EnrollmentId",
                table: "StudentAcademicRecords",
                column: "EnrollmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentExamResults_ExamId",
                table: "StudentExamResults",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentExamResults_StudentId",
                table: "StudentExamResults",
                column: "StudentId");

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
                name: "IX_SubjectClasses_TermId",
                table: "SubjectClasses",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectClassTeachers_SubjectClassId",
                table: "SubjectClassTeachers",
                column: "SubjectClassId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectClassTeachers_TeacherId",
                table: "SubjectClassTeachers",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSchedules_SubjectClassTeachers_SubjectClassTeacherId",
                table: "ClassSchedules",
                column: "SubjectClassTeacherId",
                principalTable: "SubjectClassTeachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSchedules_SubjectClasses_SubjectClassId",
                table: "ClassSchedules",
                column: "SubjectClassId",
                principalTable: "SubjectClasses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentClasses_SubjectClasses_SubjectClassId",
                table: "StudentClasses",
                column: "SubjectClassId",
                principalTable: "SubjectClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassSchedules_SubjectClassTeachers_SubjectClassTeacherId",
                table: "ClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassSchedules_SubjectClasses_SubjectClassId",
                table: "ClassSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentClasses_SubjectClasses_SubjectClassId",
                table: "StudentClasses");

            migrationBuilder.DropTable(
                name: "FeeItems");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "StudentAcademicRecords");

            migrationBuilder.DropTable(
                name: "StudentExamResults");

            migrationBuilder.DropTable(
                name: "SubjectClassTeachers");

            migrationBuilder.DropTable(
                name: "FeeStructures");

            migrationBuilder.DropTable(
                name: "Installments");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "SubjectClasses");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_ClassSchedules_SubjectClassId",
                table: "ClassSchedules");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "Terms");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "Terms");

            migrationBuilder.DropColumn(
                name: "SubjectClassId",
                table: "ClassSchedules");

            migrationBuilder.RenameColumn(
                name: "SubjectClassId",
                table: "StudentClasses",
                newName: "ClassId");

            migrationBuilder.RenameColumn(
                name: "FinalScore",
                table: "StudentClasses",
                newName: "MarksObtained");

            migrationBuilder.RenameIndex(
                name: "IX_StudentClasses_SubjectClassId",
                table: "StudentClasses",
                newName: "IX_StudentClasses_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentClasses_StudentId_SubjectClassId",
                table: "StudentClasses",
                newName: "IX_StudentClasses_StudentId_ClassId");

            migrationBuilder.RenameColumn(
                name: "SubjectClassTeacherId",
                table: "ClassSchedules",
                newName: "ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassSchedules_SubjectClassTeacherId_PeriodId_DayOfWeek",
                table: "ClassSchedules",
                newName: "IX_ClassSchedules_ClassId_PeriodId_DayOfWeek");

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    TermId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    MaxScore = table.Column<decimal>(type: "decimal(5,2)", nullable: false, defaultValue: 100m),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameEn = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Classes_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Classes_Terms_TermId",
                        column: x => x.TermId,
                        principalTable: "Terms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentYearLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolYearId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    YearLevelId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinalYearScore = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentYearLevels", x => x.Id);
                    table.CheckConstraint("CK_StudentYearLevel_Score", "[FinalYearScore] IS NULL OR ([FinalYearScore] >= 0 AND [FinalYearScore] <= 100)");
                    table.ForeignKey(
                        name: "FK_StudentYearLevels_SchoolYears_SchoolYearId",
                        column: x => x.SchoolYearId,
                        principalTable: "SchoolYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentYearLevels_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentYearLevels_YearLevels_YearLevelId",
                        column: x => x.YearLevelId,
                        principalTable: "YearLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8284), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8288), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8292), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8293) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8295), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8299), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "ClassSchedules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8303), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8304) });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "MaxScore", "NameAr", "NameEn", "SubjectId", "TeacherId", "TermId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7313), null, false, 100.00m, "رياضيات - الصف العاشر أ", "Math - Grade 10 A", 1, 1, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7314) },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7440), null, false, 100.00m, "فيزياء - الصف العاشر أ", "Physics - Grade 10 A", 2, 1, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7440) },
                    { 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7445), null, false, 100.00m, "إنجليزي - الصف العاشر أ", "English - Grade 10 A", 3, 2, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7446) }
                });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7203), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7207), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7210), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7213), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "ClassroomTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7217), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7217) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7083), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7088), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7091), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7095), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7099), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Classrooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7103), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(5548), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(5556), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(5560), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(5773), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6980), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6984), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "GuardianTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6987), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7740), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7746), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Guardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7750), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6842), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6851), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6855), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6860), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6864), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6869), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Periods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6874), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6392), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6396), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6396) });

            migrationBuilder.UpdateData(
                table: "SchoolStages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6399), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8194), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8200), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8095), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8101), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8105), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8109), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "ScoreRanges",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8113), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7629), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7635), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7639), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7643), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7647), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "StudentClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7651), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7835), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7838), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7842), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "StudentGuardians",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7845), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.InsertData(
                table: "StudentYearLevels",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "FinalYearScore", "IsDeleted", "SchoolYearId", "StudentId", "UpdatedAt", "YearLevelId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8016), null, 85.50m, false, 1, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8016), 10 },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8021), null, 92.00m, false, 1, 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8021), 10 },
                    { 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8025), null, null, false, 2, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8026), 11 }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7524), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7539), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7545), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6287), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6291), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6295), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6296) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6298), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6299) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6302), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6305), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6308), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7920), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7926), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6757), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6766), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6507), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6622), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6626), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6630), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6634), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6635) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6638), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6642), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6646), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6650), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6654), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6657), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "YearLevels",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6661), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6662) });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SubjectId",
                table: "Classes",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TeacherId",
                table: "Classes",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TermId",
                table: "Classes",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentYearLevels_SchoolYearId",
                table: "StudentYearLevels",
                column: "SchoolYearId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentYearLevels_StudentId_YearLevelId_SchoolYearId",
                table: "StudentYearLevels",
                columns: new[] { "StudentId", "YearLevelId", "SchoolYearId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentYearLevels_YearLevelId",
                table: "StudentYearLevels",
                column: "YearLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSchedules_Classes_ClassId",
                table: "ClassSchedules",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentClasses_Classes_ClassId",
                table: "StudentClasses",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
