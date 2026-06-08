using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Schoolify.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddIntialModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClassroomTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassroomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guardians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ThirdName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ForthName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guardians", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GuardianTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuardianTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SchoolStages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolStages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SchoolYears",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolYears", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScoreRanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MinScore = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    MaxScore = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreRanges", x => x.Id);
                    table.CheckConstraint("CK_ScoreRange_MinMax", "[MinScore] <= [MaxScore]");
                    table.CheckConstraint("CK_ScoreRange_ValidRange", "[MinScore] >= 0 AND [MaxScore] <= 100");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ThirdName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ForthName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    EnrolmentDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ThirdName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ForthName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    HireDate = table.Column<DateOnly>(type: "date", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    NameEn = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classrooms_ClassroomTypes_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "ClassroomTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    NameEn = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "YearLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LevelOrder = table.Column<int>(type: "int", nullable: false),
                    SchoolStageId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearLevels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YearLevels_SchoolStages_SchoolStageId",
                        column: x => x.SchoolStageId,
                        principalTable: "SchoolStages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolYearId = table.Column<int>(type: "int", nullable: false),
                    NameEn = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Periods_SchoolYears_SchoolYearId",
                        column: x => x.SchoolYearId,
                        principalTable: "SchoolYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Terms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolYearId = table.Column<int>(type: "int", nullable: false),
                    TermNumber = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Terms_SchoolYears_SchoolYearId",
                        column: x => x.SchoolYearId,
                        principalTable: "SchoolYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentGuardians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuardianTypeId = table.Column<int>(type: "int", nullable: false),
                    GuardianId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGuardians", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentGuardians_GuardianTypes_GuardianTypeId",
                        column: x => x.GuardianTypeId,
                        principalTable: "GuardianTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentGuardians_Guardians_GuardianId",
                        column: x => x.GuardianId,
                        principalTable: "Guardians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentGuardians_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentYearLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    YearLevelId = table.Column<int>(type: "int", nullable: false),
                    SchoolYearId = table.Column<int>(type: "int", nullable: false),
                    FinalYearScore = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
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

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    TermId = table.Column<int>(type: "int", nullable: false),
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
                name: "ClassSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    PeriodId = table.Column<int>(type: "int", nullable: false),
                    ClassroomId = table.Column<int>(type: "int", nullable: false),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassSchedules_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSchedules_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassSchedules_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    MarksObtained = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentClasses", x => x.Id);
                    table.CheckConstraint("CK_StudentClass_Marks", "[MarksObtained] IS NULL OR ([MarksObtained] >= 0 AND [MarksObtained] <= 100)");
                    table.ForeignKey(
                        name: "FK_StudentClasses_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentClasses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ClassroomTypes",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "NameAr", "NameEn", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7203), null, false, "فصل دراسي", "Regular Classroom", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7204) },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7207), null, false, "معمل علوم", "Science Laboratory", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7208) },
                    { 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7210), null, false, "معمل حاسوب", "Computer Lab", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7211) },
                    { 4, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7213), null, false, "مكتبة", "Library Room", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7214) },
                    { 5, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7217), null, false, "قاعة متعددة الاستخدام", "Auditorium", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7217) }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "NameAr", "NameEn", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(5548), null, false, "العلوم", "Science", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(5552) },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(5556), null, false, "اللغات", "Languages", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(5557) },
                    { 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(5560), null, false, "الدراسات الاجتماعية", "Social Studies", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(5561) },
                    { 4, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(5773), null, false, "الرياضيات", "Mathematics", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(5774) }
                });

            migrationBuilder.InsertData(
                table: "GuardianTypes",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "NameAr", "NameEn", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6980), null, false, "الأب", "Father", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6981) },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6984), null, false, "الأم", "Mother", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6985) },
                    { 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6987), null, false, "ولي أمر", "Guardian", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6988) }
                });

            migrationBuilder.InsertData(
                table: "Guardians",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "EmailAddress", "FirstName", "ForthName", "IsDeleted", "PhoneNumber", "SecondName", "ThirdName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7740), null, "mohamed.ali@email.com", "Mohamed", "Ahmed", false, "0911111111", "Ali", "Hassan", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7741) },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7746), null, "fatima.ibrahim@email.com", "Fatima", "Youssef", false, "0922222222", "Ibrahim", "Omar", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7747) },
                    { 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7750), null, "abdullah.mahmoud@email.com", "Abdullah", "Ali", false, "0933333333", "Mahmoud", "Hassan", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7751) }
                });

            migrationBuilder.InsertData(
                table: "SchoolStages",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "NameAr", "NameEn", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6392), null, false, "الابتدائية", "Primary", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6392) },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6396), null, false, "المتوسطة", "Middle", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6396) },
                    { 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6399), null, false, "الثانوية", "Secondary", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6400) }
                });

            migrationBuilder.InsertData(
                table: "SchoolYears",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "EndDate", "IsDeleted", "NameAr", "NameEn", "StartDate", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8194), null, new DateOnly(2025, 6, 30), false, "العام الدراسي 2024-2025", "2024-2025", new DateOnly(2024, 9, 1), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8195) },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8200), null, new DateOnly(2026, 6, 30), false, "العام الدراسي 2025-2026", "2025-2026", new DateOnly(2025, 9, 1), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8201) }
                });

            migrationBuilder.InsertData(
                table: "ScoreRanges",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Grade", "IsDeleted", "MaxScore", "MinScore", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8095), null, "A", false, 100m, 90m, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8095) },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8101), null, "B", false, 89.99m, 80m, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8102) },
                    { 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8105), null, "C", false, 79.99m, 70m, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8106) },
                    { 4, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8109), null, "D", false, 69.99m, 60m, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8110) },
                    { 5, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8113), null, "F", false, 59.99m, 0m, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8114) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "DeletedAt", "EnrolmentDate", "FirstName", "ForthName", "Gender", "IsDeleted", "SecondName", "ThirdName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7524), new DateOnly(2010, 5, 10), null, new DateOnly(2025, 9, 1), "Ali", "Ahmed", 1, false, "Mohamed", "Hassan", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7525) },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7539), new DateOnly(2011, 8, 15), null, new DateOnly(2025, 9, 1), "Sara", "Youssef", 2, false, "Ibrahim", "Omar", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7540) },
                    { 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7545), new DateOnly(2009, 12, 20), null, new DateOnly(2024, 9, 1), "Omar", "Hassan", 1, false, "Ali", "Mahmoud", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7545) }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "EmailAddress", "FirstName", "ForthName", "Gender", "HireDate", "IsDeleted", "PhoneNumber", "SecondName", "ThirdName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7920), null, "ahmed.ali@schoolify.com", "Ahmed", "Mohamed", 0, new DateOnly(1, 1, 1), false, "0912345678", "Ali", "Hassan", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7921) },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7926), null, "sara.ibrahim@schoolify.com", "Sara", "Yusuf", 0, new DateOnly(1, 1, 1), false, "0923456789", "Ibrahim", "Omar", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7927) }
                });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "Id", "Capacity", "CreatedAt", "DeletedAt", "IsDeleted", "NameAr", "NameEn", "RoomTypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 30, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7083), null, false, "الفصل A1", "Classroom A1", 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7084) },
                    { 2, 30, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7088), null, false, "الفصل A2", "Classroom A2", 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7089) },
                    { 3, 25, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7091), null, false, "معمل العلوم 1", "Science Lab 1", 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7092) },
                    { 4, 25, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7095), null, false, "معمل الحاسوب 1", "Computer Lab 1", 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7096) },
                    { 5, 40, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7099), null, false, "المكتبة", "Library Room", 4, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7100) },
                    { 6, 100, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7103), null, false, "القاعة الكبرى", "Auditorium", 5, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7104) }
                });

            migrationBuilder.InsertData(
                table: "Periods",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "EndTime", "IsDeleted", "NameAr", "NameEn", "SchoolYearId", "StartTime", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6842), null, new TimeSpan(0, 8, 45, 0, 0), false, "الحصة الأولى", "Period 1", 1, new TimeSpan(0, 8, 0, 0, 0), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6843) },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6851), null, new TimeSpan(0, 9, 30, 0, 0), false, "الحصة الثانية", "Period 2", 1, new TimeSpan(0, 8, 45, 0, 0), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6852) },
                    { 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6855), null, new TimeSpan(0, 10, 15, 0, 0), false, "الحصة الثالثة", "Period 3", 1, new TimeSpan(0, 9, 30, 0, 0), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6856) },
                    { 4, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6860), null, new TimeSpan(0, 10, 45, 0, 0), false, "الفسحة", "Break", 1, new TimeSpan(0, 10, 15, 0, 0), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6861) },
                    { 5, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6864), null, new TimeSpan(0, 11, 30, 0, 0), false, "الحصة الرابعة", "Period 4", 1, new TimeSpan(0, 10, 45, 0, 0), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6865) },
                    { 6, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6869), null, new TimeSpan(0, 12, 15, 0, 0), false, "الحصة الخامسة", "Period 5", 1, new TimeSpan(0, 11, 30, 0, 0), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6870) },
                    { 7, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6874), null, new TimeSpan(0, 13, 0, 0, 0), false, "الحصة السادسة", "Period 6", 1, new TimeSpan(0, 12, 15, 0, 0), new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6875) }
                });

            migrationBuilder.InsertData(
                table: "StudentGuardians",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "GuardianId", "GuardianTypeId", "IsDeleted", "StudentId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7835), null, 1, 1, false, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7835) },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7838), null, 2, 2, false, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7839) },
                    { 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7842), null, 1, 1, false, 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7843) },
                    { 4, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7845), null, 2, 2, false, 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7846) }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "DepartmentId", "IsDeleted", "NameAr", "NameEn", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6287), null, 1, false, "الرياضيات", "Mathematics", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6288) },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6291), null, 1, false, "الفيزياء", "Physics", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6292) },
                    { 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6295), null, 1, false, "الكيمياء", "Chemistry", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6296) },
                    { 4, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6298), null, 2, false, "اللغة الإنجليزية", "English", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6299) },
                    { 5, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6302), null, 2, false, "اللغة العربية", "Arabic", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6302) },
                    { 6, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6305), null, 3, false, "التاريخ", "History", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6306) },
                    { 7, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6308), null, 3, false, "الجغرافيا", "Geography", new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6309) }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "EndDate", "IsDeleted", "SchoolYearId", "StartDate", "TermNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6757), null, new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6758) },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6766), null, new DateTime(2026, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 1, new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6767) }
                });

            migrationBuilder.InsertData(
                table: "YearLevels",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "LevelOrder", "NameAr", "NameEn", "SchoolStageId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6507), null, false, 1, "الصف الأول", "Grade 1", 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6617) },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6622), null, false, 2, "الصف الثاني", "Grade 2", 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6623) },
                    { 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6626), null, false, 3, "الصف الثالث", "Grade 3", 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6627) },
                    { 4, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6630), null, false, 4, "الصف الرابع", "Grade 4", 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6631) },
                    { 5, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6634), null, false, 5, "الصف الخامس", "Grade 5", 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6635) },
                    { 6, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6638), null, false, 6, "الصف السادس", "Grade 6", 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6639) },
                    { 7, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6642), null, false, 1, "الصف السابع", "Grade 7", 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6643) },
                    { 8, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6646), null, false, 2, "الصف الثامن", "Grade 8", 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6647) },
                    { 9, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6650), null, false, 3, "الصف التاسع", "Grade 9", 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6651) },
                    { 10, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6654), null, false, 1, "الصف العاشر", "Grade 10", 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6655) },
                    { 11, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6657), null, false, 2, "الصف الحادي عشر", "Grade 11", 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6658) },
                    { 12, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6661), null, false, 3, "الصف الثاني عشر", "Grade 12", 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(6662) }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "IsDeleted", "MaxScore", "NameAr", "NameEn", "SubjectId", "TeacherId", "TermId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7313), null, false, 100.00m, "رياضيات - الصف العاشر أ", "Math - Grade 10 A", 1, 1, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7314) },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7440), null, false, 100.00m, "فيزياء - الصف العاشر أ", "Physics - Grade 10 A", 2, 1, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7440) },
                    { 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7445), null, false, 100.00m, "إنجليزي - الصف العاشر أ", "English - Grade 10 A", 3, 2, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7446) }
                });

            migrationBuilder.InsertData(
                table: "StudentYearLevels",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "FinalYearScore", "IsDeleted", "SchoolYearId", "StudentId", "UpdatedAt", "YearLevelId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8016), null, 85.50m, false, 1, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8016), 10 },
                    { 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8021), null, 92.00m, false, 1, 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8021), 10 },
                    { 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8025), null, null, false, 2, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8026), 11 }
                });

            migrationBuilder.InsertData(
                table: "ClassSchedules",
                columns: new[] { "Id", "ClassId", "ClassroomId", "CreatedAt", "DayOfWeek", "DeletedAt", "IsDeleted", "PeriodId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8284), 0, null, false, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8285) },
                    { 2, 2, 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8288), 0, null, false, 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8289) },
                    { 3, 1, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8292), 1, null, false, 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8293) },
                    { 4, 2, 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8295), 1, null, false, 4, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8296) },
                    { 5, 1, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8299), 2, null, false, 5, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8300) },
                    { 6, 2, 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8303), 2, null, false, 6, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(8304) }
                });

            migrationBuilder.InsertData(
                table: "StudentClasses",
                columns: new[] { "Id", "ClassId", "CreatedAt", "DeletedAt", "IsDeleted", "MarksObtained", "StudentId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7629), null, false, 85.50m, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7630) },
                    { 2, 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7635), null, false, 78.00m, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7636) },
                    { 3, 1, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7639), null, false, 92.00m, 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7640) },
                    { 4, 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7643), null, false, 88.50m, 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7644) },
                    { 5, 2, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7647), null, false, 74.00m, 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7648) },
                    { 6, 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7651), null, false, null, 3, new DateTime(2026, 6, 8, 20, 11, 2, 666, DateTimeKind.Utc).AddTicks(7652) }
                });

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
                name: "IX_Classrooms_RoomTypeId",
                table: "Classrooms",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_ClassId_PeriodId_DayOfWeek",
                table: "ClassSchedules",
                columns: new[] { "ClassId", "PeriodId", "DayOfWeek" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_ClassroomId_PeriodId_DayOfWeek",
                table: "ClassSchedules",
                columns: new[] { "ClassroomId", "PeriodId", "DayOfWeek" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClassSchedules_PeriodId",
                table: "ClassSchedules",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Periods_SchoolYearId",
                table: "Periods",
                column: "SchoolYearId");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreRanges_Grade",
                table: "ScoreRanges",
                column: "Grade",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentClasses_ClassId",
                table: "StudentClasses",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentClasses_StudentId_ClassId",
                table: "StudentClasses",
                columns: new[] { "StudentId", "ClassId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentGuardians_GuardianId",
                table: "StudentGuardians",
                column: "GuardianId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGuardians_GuardianTypeId",
                table: "StudentGuardians",
                column: "GuardianTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGuardians_StudentId_GuardianId_GuardianTypeId",
                table: "StudentGuardians",
                columns: new[] { "StudentId", "GuardianId", "GuardianTypeId" },
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_DepartmentId",
                table: "Subjects",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Terms_SchoolYearId",
                table: "Terms",
                column: "SchoolYearId");

            migrationBuilder.CreateIndex(
                name: "IX_YearLevels_SchoolStageId",
                table: "YearLevels",
                column: "SchoolStageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassSchedules");

            migrationBuilder.DropTable(
                name: "ScoreRanges");

            migrationBuilder.DropTable(
                name: "StudentClasses");

            migrationBuilder.DropTable(
                name: "StudentGuardians");

            migrationBuilder.DropTable(
                name: "StudentYearLevels");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "Periods");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "GuardianTypes");

            migrationBuilder.DropTable(
                name: "Guardians");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "YearLevels");

            migrationBuilder.DropTable(
                name: "ClassroomTypes");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Terms");

            migrationBuilder.DropTable(
                name: "SchoolStages");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "SchoolYears");
        }
    }
}
