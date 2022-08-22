﻿// <auto-generated />
using System;
using LearningManagementSystem.Domain.Contextes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LearningManagementSystem.Domain.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CourseSubject", b =>
                {
                    b.Property<Guid>("CoursesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CoursesId", "SubjectsId");

                    b.HasIndex("SubjectsId");

                    b.ToTable("CourseSubject");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Answer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Certificate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfExpiration")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime2");

                    b.Property<int>("DocumentType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Grade", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Group", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndEducation")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartEducation")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.GroupChatMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SenderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("SenderId");

                    b.ToTable("GroupChatMessages");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.HomeTask", b =>
                {
                    b.Property<Guid>("TopicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfExpiration")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatePlannedStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicId");

                    b.ToTable("HomeTasks");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TestId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.StaffChatMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SenderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SenderId");

                    b.ToTable("StaffChatMessages");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContractNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.StudentAnswer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AnswerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TestId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AnswerId")
                        .IsUnique();

                    b.HasIndex("TestId");

                    b.ToTable("StudentAnswers");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TestId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TestId")
                        .IsUnique()
                        .HasFilter("[TestId] IS NOT NULL");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.TaskAnswer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfAnswer")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("HomeTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HomeTaskId");

                    b.HasIndex("StudentId");

                    b.ToTable("TaskAnswers");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Test", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfExpiration")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DurationInMinutes")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.TestResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CorrectAnswers")
                        .HasColumnType("int");

                    b.Property<DateTime>("PassingDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TotalAnswers")
                        .HasColumnType("int");

                    b.Property<int>("TotalQuestions")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TestId");

                    b.ToTable("TestResults");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Topic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CourseSubject", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearningManagementSystem.Domain.Entities.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Answer", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Certificate", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearningManagementSystem.Domain.Entities.Student", "Student")
                        .WithMany("Certificates")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Document", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.User", "User")
                        .WithMany("Document")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Grade", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.TaskAnswer", "TaskAnswer")
                        .WithOne("Grade")
                        .HasForeignKey("LearningManagementSystem.Domain.Entities.Grade", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaskAnswer");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Group", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.GroupChatMessage", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.Group", "Group")
                        .WithMany("ChatMessages")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearningManagementSystem.Domain.Entities.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.HomeTask", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.Topic", "Topic")
                        .WithOne("HomeTask")
                        .HasForeignKey("LearningManagementSystem.Domain.Entities.HomeTask", "TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Question", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.Test", "Test")
                        .WithMany("Questions")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.StaffChatMessage", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Student", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupId");

                    b.HasOne("LearningManagementSystem.Domain.Entities.User", "User")
                        .WithOne()
                        .HasForeignKey("LearningManagementSystem.Domain.Entities.Student", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.StudentAnswer", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.Answer", "Answer")
                        .WithOne()
                        .HasForeignKey("LearningManagementSystem.Domain.Entities.StudentAnswer", "AnswerId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("LearningManagementSystem.Domain.Entities.Test", null)
                        .WithMany("StudentAnswers")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Answer");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Subject", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.Test", "Test")
                        .WithOne("Subject")
                        .HasForeignKey("LearningManagementSystem.Domain.Entities.Subject", "TestId");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.TaskAnswer", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.HomeTask", "HomeTask")
                        .WithMany("TaskAnswers")
                        .HasForeignKey("HomeTaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearningManagementSystem.Domain.Entities.Student", "Student")
                        .WithMany("TaskAnswers")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HomeTask");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Teacher", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.User", "User")
                        .WithOne()
                        .HasForeignKey("LearningManagementSystem.Domain.Entities.Teacher", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearningManagementSystem.Domain.Entities.Subject", "Subject")
                        .WithMany("Teachers")
                        .HasForeignKey("SubjectId");

                    b.Navigation("Subject");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.TestResult", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearningManagementSystem.Domain.Entities.Test", "Test")
                        .WithMany()
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Topic", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.Subject", "Subject")
                        .WithMany("Topics")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.User", b =>
                {
                    b.HasOne("LearningManagementSystem.Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.OwnsMany("LearningManagementSystem.Domain.Entities.RefreshToken", "RefreshTokens", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uniqueidentifier");

                            b1.Property<DateTime>("Created")
                                .HasColumnType("datetime2");

                            b1.Property<string>("CreatedByIp")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime>("Expires")
                                .HasColumnType("datetime2");

                            b1.Property<string>("ReasonRevoked")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ReplacedByToken")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<DateTime?>("Revoked")
                                .HasColumnType("datetime2");

                            b1.Property<string>("RevokedByIp")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Token")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("UserId", "Id");

                            b1.ToTable("RefreshToken");

                            b1.WithOwner("User")
                                .HasForeignKey("UserId");

                            b1.Navigation("User");
                        });

                    b.Navigation("RefreshTokens");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Group", b =>
                {
                    b.Navigation("ChatMessages");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.HomeTask", b =>
                {
                    b.Navigation("TaskAnswers");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Student", b =>
                {
                    b.Navigation("Certificates");

                    b.Navigation("TaskAnswers");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Subject", b =>
                {
                    b.Navigation("Teachers");

                    b.Navigation("Topics");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.TaskAnswer", b =>
                {
                    b.Navigation("Grade");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Test", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("StudentAnswers");

                    b.Navigation("Subject")
                        .IsRequired();
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.Topic", b =>
                {
                    b.Navigation("HomeTask");
                });

            modelBuilder.Entity("LearningManagementSystem.Domain.Entities.User", b =>
                {
                    b.Navigation("Document");
                });
#pragma warning restore 612, 618
        }
    }
}
