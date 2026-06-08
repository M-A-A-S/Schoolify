using Microsoft.EntityFrameworkCore;
using Schoolify.Common.Enums;
using Schoolify.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.DataAccess.Configurations
{
    public static class DbSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            SeedDepartments(modelBuilder);
            SeedSubjects(modelBuilder);
            SeedSchoolStages(modelBuilder);
            SeedYearLevels(modelBuilder);
            SeedTerms(modelBuilder);
            SeedPeriods(modelBuilder);
            SeedGuardianTypes(modelBuilder);
            SeedClassrooms(modelBuilder);
            SeedClassroomTypes(modelBuilder);
            SeedClasses(modelBuilder);
            SeedStudents(modelBuilder);
            SeedStudentClasses(modelBuilder);
            SeedGuardians(modelBuilder);
            SeedStudentGuardians(modelBuilder);
            SeedTeachers(modelBuilder);
            SeedStudentYearLevels(modelBuilder);
            SeedScoreRanges(modelBuilder);
            SeedSchoolYears(modelBuilder);
            SeedClassSchedules(modelBuilder);
        }
        
        private static void SeedYearLevels(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<YearLevel>().HasData(
                // Primary (Stage 1)
                new YearLevel { Id = 1, NameEn = "Grade 1", NameAr = "الصف الأول", LevelOrder = 1, SchoolStageId = 1 },
                new YearLevel { Id = 2, NameEn = "Grade 2", NameAr = "الصف الثاني", LevelOrder = 2, SchoolStageId = 1 },
                new YearLevel { Id = 3, NameEn = "Grade 3", NameAr = "الصف الثالث", LevelOrder = 3, SchoolStageId = 1 },
                new YearLevel { Id = 4, NameEn = "Grade 4", NameAr = "الصف الرابع", LevelOrder = 4, SchoolStageId = 1 },
                new YearLevel { Id = 5, NameEn = "Grade 5", NameAr = "الصف الخامس", LevelOrder = 5, SchoolStageId = 1 },
                new YearLevel { Id = 6, NameEn = "Grade 6", NameAr = "الصف السادس", LevelOrder = 6, SchoolStageId = 1 },

                // Middle (Stage 2)
                new YearLevel { Id = 7, NameEn = "Grade 7", NameAr = "الصف السابع", LevelOrder = 1, SchoolStageId = 2 },
                new YearLevel { Id = 8, NameEn = "Grade 8", NameAr = "الصف الثامن", LevelOrder = 2, SchoolStageId = 2 },
                new YearLevel { Id = 9, NameEn = "Grade 9", NameAr = "الصف التاسع", LevelOrder = 3, SchoolStageId = 2 },

                // Secondary (Stage 3)
                new YearLevel { Id = 10, NameEn = "Grade 10", NameAr = "الصف العاشر", LevelOrder = 1, SchoolStageId = 3 },
                new YearLevel { Id = 11, NameEn = "Grade 11", NameAr = "الصف الحادي عشر", LevelOrder = 2, SchoolStageId = 3 },
                new YearLevel { Id = 12, NameEn = "Grade 12", NameAr = "الصف الثاني عشر", LevelOrder = 3, SchoolStageId = 3 }
            );
        }

        private static void SeedTerms(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Term>().HasData(
                // School Year 2025–2026 (Term 1)
                new Term
                {
                    Id = 1,
                    TermNumber = 1,
                    StartDate = new DateTime(2025, 9, 1),
                    EndDate = new DateTime(2025, 12, 31),
                    SchoolYearId = 1
                },

                // School Year 2025–2026 (Term 2)
                new Term
                {
                    Id = 2,
                    TermNumber = 2,
                    StartDate = new DateTime(2026, 1, 15),
                    EndDate = new DateTime(2026, 5, 31),
                    SchoolYearId = 1
                }
            );
        }

        private static void SeedTeachers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher
                {
                    Id = 1,
                    FirstName = "Ahmed",
                    SecondName = "Ali",
                    ThirdName = "Hassan",
                    ForthName = "Mohamed",
                    EmailAddress = "ahmed.ali@schoolify.com",
                    PhoneNumber = "0912345678"
                },

                new Teacher
                {
                    Id = 2,
                    FirstName = "Sara",
                    SecondName = "Ibrahim",
                    ThirdName = "Omar",
                    ForthName = "Yusuf",
                    EmailAddress = "sara.ibrahim@schoolify.com",
                    PhoneNumber = "0923456789"
                }
            );
        }

        private static void SeedSubjects(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>().HasData(
                // Department 1 - Science
                new Subject
                {
                    Id = 1,
                    NameEn = "Mathematics",
                    NameAr = "الرياضيات",
                    DepartmentId = 1
                },
                new Subject
                {
                    Id = 2,
                    NameEn = "Physics",
                    NameAr = "الفيزياء",
                    DepartmentId = 1
                },
                new Subject
                {
                    Id = 3,
                    NameEn = "Chemistry",
                    NameAr = "الكيمياء",
                    DepartmentId = 1
                },

                // Department 2 - Languages
                new Subject
                {
                    Id = 4,
                    NameEn = "English",
                    NameAr = "اللغة الإنجليزية",
                    DepartmentId = 2
                },
                new Subject
                {
                    Id = 5,
                    NameEn = "Arabic",
                    NameAr = "اللغة العربية",
                    DepartmentId = 2
                },

                // Department 3 - Social Studies
                new Subject
                {
                    Id = 6,
                    NameEn = "History",
                    NameAr = "التاريخ",
                    DepartmentId = 3
                },
                new Subject
                {
                    Id = 7,
                    NameEn = "Geography",
                    NameAr = "الجغرافيا",
                    DepartmentId = 3
                }
            );
        }

        private static void SeedStudentYearLevels(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentYearLevel>().HasData(
                new StudentYearLevel
                {
                    Id = 1,
                    StudentId = 1,
                    YearLevelId = 10,   // Grade 10
                    SchoolYearId = 1,
                    FinalYearScore = 85.50m
                },
                new StudentYearLevel
                {
                    Id = 2,
                    StudentId = 2,
                    YearLevelId = 10,
                    SchoolYearId = 1,
                    FinalYearScore = 92.00m
                },
                new StudentYearLevel
                {
                    Id = 3,
                    StudentId = 1,
                    YearLevelId = 11,   // next year example
                    SchoolYearId = 2,
                    FinalYearScore = null // still in progress
                }
            );
        }

        private static void SeedStudentGuardians(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentGuardian>().HasData(
                new StudentGuardian
                {
                    Id = 1,
                    StudentId = 1,
                    GuardianId = 1,
                    GuardianTypeId = 1 // Father
                },
                new StudentGuardian
                {
                    Id = 2,
                    StudentId = 1,
                    GuardianId = 2,
                    GuardianTypeId = 2 // Mother
                },
                new StudentGuardian
                {
                    Id = 3,
                    StudentId = 2,
                    GuardianId = 1,
                    GuardianTypeId = 1 // Father
                },
                new StudentGuardian
                {
                    Id = 4,
                    StudentId = 2,
                    GuardianId = 2,
                    GuardianTypeId = 2 // Mother
                }
            );
        }

        private static void SeedStudents(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                            new Student
                            {
                                Id = 1,
                                FirstName = "Ali",
                                SecondName = "Mohamed",
                                ThirdName = "Hassan",
                                ForthName = "Ahmed",
                                Gender = Gender.Male,
                                DateOfBirth = new DateOnly(2010, 5, 10),
                                EnrolmentDate = new DateOnly(2025, 9, 1)
                            },

            new Student
            {
                Id = 2,
                FirstName = "Sara",
                SecondName = "Ibrahim",
                ThirdName = "Omar",
                ForthName = "Youssef",
                Gender = Gender.Female,
                DateOfBirth = new DateOnly(2011, 8, 15),
                EnrolmentDate = new DateOnly(2025, 9, 1)
            },

            new Student
            {
                Id = 3,
                FirstName = "Omar",
                SecondName = "Ali",
                ThirdName = "Mahmoud",
                ForthName = "Hassan",
                Gender = Gender.Male,
                DateOfBirth = new DateOnly(2009, 12, 20),
                EnrolmentDate = new DateOnly(2024, 9, 1)
            }
            );
        }

        private static void SeedScoreRanges(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ScoreRange>().HasData(
                            new ScoreRange
                            {
                                Id = 1,
                                MinScore = 90,
                                MaxScore = 100,
                                Grade = "A"
                            },
            new ScoreRange
            {
                Id = 2,
                MinScore = 80,
                MaxScore = 89.99m,
                Grade = "B"
            },
            new ScoreRange
            {
                Id = 3,
                MinScore = 70,
                MaxScore = 79.99m,
                Grade = "C"
            },
            new ScoreRange
            {
                Id = 4,
                MinScore = 60,
                MaxScore = 69.99m,
                Grade = "D"
            },
            new ScoreRange
            {
                Id = 5,
                MinScore = 0,
                MaxScore = 59.99m,
                Grade = "F"
            }
            );
        }

        private static void SeedSchoolYears(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolYear>().HasData(
                    new SchoolYear
                    {
                        Id = 1,
                        NameEn = "2024-2025",
                        NameAr = "العام الدراسي 2024-2025",
                        StartDate = new DateOnly(2024, 9, 1),
                        EndDate = new DateOnly(2025, 6, 30)
                    },

    new SchoolYear
    {
        Id = 2,
        NameEn = "2025-2026",
        NameAr = "العام الدراسي 2025-2026",
        StartDate = new DateOnly(2025, 9, 1),
        EndDate = new DateOnly(2026, 6, 30)
    }
            );
        }

        private static void SeedSchoolStages(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolStage>().HasData(
                                new SchoolStage
                                {
                                    Id = 1,
                                    NameEn = "Primary",
                                    NameAr = "الابتدائية"
                                },
                new SchoolStage
                {
                    Id = 2,
                    NameEn = "Middle",
                    NameAr = "المتوسطة"
                },
                new SchoolStage
                {
                    Id = 3,
                    NameEn = "Secondary",
                    NameAr = "الثانوية"
                }
            );
        }

        private static void SeedPeriods(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Period>().HasData(
    // Morning periods (SchoolYearId = 1)
    new Period
    {
        Id = 1,
        NameEn = "Period 1",
        NameAr = "الحصة الأولى",
        StartTime = new TimeSpan(8, 0, 0),
        EndTime = new TimeSpan(8, 45, 0),
        SchoolYearId = 1
    },
    new Period
    {
        Id = 2,
        NameEn = "Period 2",
        NameAr = "الحصة الثانية",
        StartTime = new TimeSpan(8, 45, 0),
        EndTime = new TimeSpan(9, 30, 0),
        SchoolYearId = 1
    },
    new Period
    {
        Id = 3,
        NameEn = "Period 3",
        NameAr = "الحصة الثالثة",
        StartTime = new TimeSpan(9, 30, 0),
        EndTime = new TimeSpan(10, 15, 0),
        SchoolYearId = 1
    },
    new Period
    {
        Id = 4,
        NameEn = "Break",
        NameAr = "الفسحة",
        StartTime = new TimeSpan(10, 15, 0),
        EndTime = new TimeSpan(10, 45, 0),
        SchoolYearId = 1
    },
    new Period
    {
        Id = 5,
        NameEn = "Period 4",
        NameAr = "الحصة الرابعة",
        StartTime = new TimeSpan(10, 45, 0),
        EndTime = new TimeSpan(11, 30, 0),
        SchoolYearId = 1
    },
    new Period
    {
        Id = 6,
        NameEn = "Period 5",
        NameAr = "الحصة الخامسة",
        StartTime = new TimeSpan(11, 30, 0),
        EndTime = new TimeSpan(12, 15, 0),
        SchoolYearId = 1
    },
    new Period
    {
        Id = 7,
        NameEn = "Period 6",
        NameAr = "الحصة السادسة",
        StartTime = new TimeSpan(12, 15, 0),
        EndTime = new TimeSpan(13, 0, 0),
        SchoolYearId = 1
    }
            );
        }

        private static void SeedGuardianTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GuardianType>().HasData(
                                new GuardianType
                                {
                                    Id = 1,
                                    NameEn = "Father",
                                    NameAr = "الأب"
                                },
                new GuardianType
                {
                    Id = 2,
                    NameEn = "Mother",
                    NameAr = "الأم"
                },
                new GuardianType
                {
                    Id = 3,
                    NameEn = "Guardian",
                    NameAr = "ولي أمر"
                }
            );
        }


        private static void SeedGuardians(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guardian>().HasData(
                    new Guardian
                    {
                        Id = 1,
                        FirstName = "Mohamed",
                        SecondName = "Ali",
                        ThirdName = "Hassan",
                        ForthName = "Ahmed",
                        PhoneNumber = "0911111111",
                        EmailAddress = "mohamed.ali@email.com"
                    },

    new Guardian
    {
        Id = 2,
        FirstName = "Fatima",
        SecondName = "Ibrahim",
        ThirdName = "Omar",
        ForthName = "Youssef",
        PhoneNumber = "0922222222",
        EmailAddress = "fatima.ibrahim@email.com"
    },

    new Guardian
    {
        Id = 3,
        FirstName = "Abdullah",
        SecondName = "Mahmoud",
        ThirdName = "Hassan",
        ForthName = "Ali",
        PhoneNumber = "0933333333",
        EmailAddress = "abdullah.mahmoud@email.com"
    }
            );
        }

        private static void SeedDepartments(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                    new Department
                    {
                        Id = 1,
                        NameEn = "Science",
                        NameAr = "العلوم"
                    },
    new Department
    {
        Id = 2,
        NameEn = "Languages",
        NameAr = "اللغات"
    },
    new Department
    {
        Id = 3,
        NameEn = "Social Studies",
        NameAr = "الدراسات الاجتماعية"
    },
    new Department
    {
        Id = 4,
        NameEn = "Mathematics",
        NameAr = "الرياضيات"
    }
            );
        }

        private static void SeedClassSchedules(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassSchedule>().HasData(
    // Sunday
    new ClassSchedule
    {
        Id = 1,
        ClassId = 1,
        PeriodId = 1,
        ClassroomId = 1,
        DayOfWeek = DayOfWeek.Sunday
    },
    new ClassSchedule
    {
        Id = 2,
        ClassId = 2,
        PeriodId = 2,
        ClassroomId = 2,
        DayOfWeek = DayOfWeek.Sunday
    },

    // Monday
    new ClassSchedule
    {
        Id = 3,
        ClassId = 1,
        PeriodId = 3,
        ClassroomId = 1,
        DayOfWeek = DayOfWeek.Monday
    },
    new ClassSchedule
    {
        Id = 4,
        ClassId = 2,
        PeriodId = 4,
        ClassroomId = 2,
        DayOfWeek = DayOfWeek.Monday
    },

    // Tuesday
    new ClassSchedule
    {
        Id = 5,
        ClassId = 1,
        PeriodId = 5,
        ClassroomId = 1,
        DayOfWeek = DayOfWeek.Tuesday
    },
    new ClassSchedule
    {
        Id = 6,
        ClassId = 2,
        PeriodId = 6,
        ClassroomId = 2,
        DayOfWeek = DayOfWeek.Tuesday
    }
            );
        }

        private static void SeedClassroomTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassroomType>().HasData(
                    new ClassroomType
                    {
                        Id = 1,
                        NameEn = "Regular Classroom",
                        NameAr = "فصل دراسي"
                    },
    new ClassroomType
    {
        Id = 2,
        NameEn = "Science Laboratory",
        NameAr = "معمل علوم"
    },
    new ClassroomType
    {
        Id = 3,
        NameEn = "Computer Lab",
        NameAr = "معمل حاسوب"
    },
    new ClassroomType
    {
        Id = 4,
        NameEn = "Library Room",
        NameAr = "مكتبة"
    },
    new ClassroomType
    {
        Id = 5,
        NameEn = "Auditorium",
        NameAr = "قاعة متعددة الاستخدام"
    }
            );
        }

        private static void SeedClassrooms(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classroom>().HasData(
                    new Classroom
                    {
                        Id = 1,
                        NameEn = "Classroom A1",
                        NameAr = "الفصل A1",
                        Capacity = 30,
                        RoomTypeId = 1
                    },
    new Classroom
    {
        Id = 2,
        NameEn = "Classroom A2",
        NameAr = "الفصل A2",
        Capacity = 30,
        RoomTypeId = 1
    },
    new Classroom
    {
        Id = 3,
        NameEn = "Science Lab 1",
        NameAr = "معمل العلوم 1",
        Capacity = 25,
        RoomTypeId = 2
    },
    new Classroom
    {
        Id = 4,
        NameEn = "Computer Lab 1",
        NameAr = "معمل الحاسوب 1",
        Capacity = 25,
        RoomTypeId = 3
    },
    new Classroom
    {
        Id = 5,
        NameEn = "Library Room",
        NameAr = "المكتبة",
        Capacity = 40,
        RoomTypeId = 4
    },
    new Classroom
    {
        Id = 6,
        NameEn = "Auditorium",
        NameAr = "القاعة الكبرى",
        Capacity = 100,
        RoomTypeId = 5
    }
            );
        }

        private static void SeedClasses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>().HasData(
                    new Class
                    {
                        Id = 1,
                        NameEn = "Math - Grade 10 A",
                        NameAr = "رياضيات - الصف العاشر أ",
                        SubjectId = 1,
                        TeacherId = 1,
                        TermId = 1,
                        MaxScore = 100.00m
                    },
    new Class
    {
        Id = 2,
        NameEn = "Physics - Grade 10 A",
        NameAr = "فيزياء - الصف العاشر أ",
        SubjectId = 2,
        TeacherId = 1,
        TermId = 1,
        MaxScore = 100.00m
    },
    new Class
    {
        Id = 3,
        NameEn = "English - Grade 10 A",
        NameAr = "إنجليزي - الصف العاشر أ",
        SubjectId = 3,
        TeacherId = 2,
        TermId = 1,
        MaxScore = 100.00m
    }
            );
        }

        private static void SeedStudentClasses(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentClass>().HasData(
    // Ali enrollments
    new StudentClass
    {
        Id = 1,
        StudentId = 1,
        ClassId = 1,
        MarksObtained = 85.50m
    },
    new StudentClass
    {
        Id = 2,
        StudentId = 1,
        ClassId = 2,
        MarksObtained = 78.00m
    },

    // Sara enrollments
    new StudentClass
    {
        Id = 3,
        StudentId = 2,
        ClassId = 1,
        MarksObtained = 92.00m
    },
    new StudentClass
    {
        Id = 4,
        StudentId = 2,
        ClassId = 3,
        MarksObtained = 88.50m
    },

    // Omar enrollments
    new StudentClass
    {
        Id = 5,
        StudentId = 3,
        ClassId = 2,
        MarksObtained = 74.00m
    },
    new StudentClass
    {
        Id = 6,
        StudentId = 3,
        ClassId = 3,
        MarksObtained = null // not graded yet
    }
            );
        }

    }
}
