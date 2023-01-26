﻿// <auto-generated />
using System;
using ERP.Core.Entities.asdasd;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ERP.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ERP.Core.Entities.Announcement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("ERP.Core.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("ERP.Core.Entities.CommentMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("TaskCommentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TaskCommentId");

                    b.ToTable("CommentMedias");
                });

            modelBuilder.Entity("ERP.Core.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("ERP.Core.Entities.CompanyToDepartment", b =>
                {
                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("CompanyId", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("CompaniesToDepartments");
                });

            modelBuilder.Entity("ERP.Core.Entities.DailyWork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TaskId");

                    b.ToTable("DailyWorks");
                });

            modelBuilder.Entity("ERP.Core.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ERP.Core.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("EmployeeStatus")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastSeen")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime?>("WorkEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WorkStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Employees", (string)null);
                });

            modelBuilder.Entity("ERP.Core.Entities.EmployeeToCompany", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "CompanyId");

                    b.HasIndex("CompanyId");

                    b.ToTable("EmployeesToCompanies");
                });

            modelBuilder.Entity("ERP.Core.Entities.EmployeeToDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DeparmentId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeparmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("EmployeesToDepartments");
                });

            modelBuilder.Entity("ERP.Core.Entities.EmployeeToMessagingGroup", b =>
                {
                    b.Property<int>("MessagingGroupId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsOwner")
                        .HasColumnType("bit");

                    b.HasKey("MessagingGroupId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeesToMessagingGroups");
                });

            modelBuilder.Entity("ERP.Core.Entities.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("MeetingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("ERP.Core.Entities.MeetingToCompany", b =>
                {
                    b.Property<int>("MeetingId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("MeetingId", "CompanyId");

                    b.HasIndex("CompanyId");

                    b.ToTable("MeetingsToCompanies");
                });

            modelBuilder.Entity("ERP.Core.Entities.MeetingToEmployee", b =>
                {
                    b.Property<int>("MeetingId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("MeetingId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("MeetingsToEmployees");
                });

            modelBuilder.Entity("ERP.Core.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MessagingGroupId")
                        .HasColumnType("int");

                    b.Property<int>("SenderEmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MessagingGroupId");

                    b.HasIndex("SenderEmployeeId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("ERP.Core.Entities.MessagingGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("MessagingGroups");
                });

            modelBuilder.Entity("ERP.Core.Entities.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnerId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("PlannedEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PlannedStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RealEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("RealStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TaskStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("CompanyId", "DepartmentId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("ERP.Core.Entities.TaskComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskComments");
                });

            modelBuilder.Entity("ERP.Core.Entities.TaskEvaluation", b =>
                {
                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("EvaluationDescription")
                        .HasColumnType("int");

                    b.Property<int>("EvaluationOrder")
                        .HasColumnType("int");

                    b.Property<string>("EvaluationStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("TaskEvaluations");
                });

            modelBuilder.Entity("ERP.Core.Entities.TaskLiable", b =>
                {
                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("TaskId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("TaskLiables");
                });

            modelBuilder.Entity("ERP.Core.Entities.TaskMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskMedias");
                });

            modelBuilder.Entity("ERP.Core.Entities.TaskNotification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TaskForEnum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskNotifications");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ERP.Core.Entities.CommentMedia", b =>
                {
                    b.HasOne("ERP.Core.Entities.TaskComment", "TaskComment")
                        .WithMany("CommentMedias")
                        .HasForeignKey("TaskCommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TaskComments_CommentMedias");

                    b.Navigation("TaskComment");
                });

            modelBuilder.Entity("ERP.Core.Entities.CompanyToDepartment", b =>
                {
                    b.HasOne("ERP.Core.Entities.Company", "Company")
                        .WithMany("CompaniesToDepartments")
                        .HasForeignKey("CompanyId")
                        .IsRequired()
                        .HasConstraintName("FK_CompaniesToDepartments_Companies");

                    b.HasOne("ERP.Core.Entities.Department", "Department")
                        .WithMany("CompaniesToDepartments")
                        .HasForeignKey("DepartmentId")
                        .IsRequired()
                        .HasConstraintName("FK_CompaniesToDepartments_Departments");

                    b.Navigation("Company");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ERP.Core.Entities.DailyWork", b =>
                {
                    b.HasOne("ERP.Core.Entities.Employee", "Employee")
                        .WithMany("DailyWorks")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DailyWorks_Employees");

                    b.HasOne("ERP.Core.Entities.Task", "Task")
                        .WithMany("DailyWorks")
                        .HasForeignKey("TaskId")
                        .HasConstraintName("FK_DailyWorks_Tasks");

                    b.Navigation("Employee");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("ERP.Core.Entities.EmployeeToCompany", b =>
                {
                    b.HasOne("ERP.Core.Entities.Company", "Company")
                        .WithMany("EmployeesToCompaines")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_EmployeesToCompaines_Compaines");

                    b.HasOne("ERP.Core.Entities.Employee", "Employee")
                        .WithMany("EmployeesToCompaines")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_EmployeesToCompaines_Employees");

                    b.Navigation("Company");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("ERP.Core.Entities.EmployeeToDepartment", b =>
                {
                    b.HasOne("ERP.Core.Entities.Employee", "Employee")
                        .WithMany("EmployeesToDepartments")
                        .HasForeignKey("DeparmentId")
                        .IsRequired()
                        .HasConstraintName("FK_EmployeesToDepartments_Employees");

                    b.HasOne("ERP.Core.Entities.Department", "Department")
                        .WithMany("EmployeessToDepartments")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("ERP.Core.Entities.EmployeeToMessagingGroup", b =>
                {
                    b.HasOne("ERP.Core.Entities.Employee", "Employee")
                        .WithMany("EmployeesToMessagingGroups")
                        .HasForeignKey("EmployeeId")
                        .IsRequired()
                        .HasConstraintName("FK_EmployeesToMessagingGroups_Employees");

                    b.HasOne("ERP.Core.Entities.MessagingGroup", "MessagingGroup")
                        .WithMany("EmployeesToMessagingGroups")
                        .HasForeignKey("MessagingGroupId")
                        .IsRequired()
                        .HasConstraintName("FK_EmployeesToMessagingGroups_MessagingGroups");

                    b.Navigation("Employee");

                    b.Navigation("MessagingGroup");
                });

            modelBuilder.Entity("ERP.Core.Entities.MeetingToCompany", b =>
                {
                    b.HasOne("ERP.Core.Entities.Company", "Company")
                        .WithMany("MeetingsToCompanies")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_MeetingsToCompaines_Companies");

                    b.HasOne("ERP.Core.Entities.Meeting", "Meeting")
                        .WithMany("MeetingsToCompanies")
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_MeetingsToCompaines_Meetings");

                    b.Navigation("Company");

                    b.Navigation("Meeting");
                });

            modelBuilder.Entity("ERP.Core.Entities.MeetingToEmployee", b =>
                {
                    b.HasOne("ERP.Core.Entities.Employee", "Employee")
                        .WithMany("MeetingsToEmployees")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_MeetingsToEmployees_Employees");

                    b.HasOne("ERP.Core.Entities.Meeting", "Meeting")
                        .WithMany("MeetingsToEmployees")
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_MeetingsToEmployees_Meetings");

                    b.Navigation("Employee");

                    b.Navigation("Meeting");
                });

            modelBuilder.Entity("ERP.Core.Entities.Message", b =>
                {
                    b.HasOne("ERP.Core.Entities.MessagingGroup", "MessagingGroup")
                        .WithMany("Messages")
                        .HasForeignKey("MessagingGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Messages_MessagingGroups");

                    b.HasOne("ERP.Core.Entities.Employee", "Sender")
                        .WithMany("Messages")
                        .HasForeignKey("SenderEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Messages_Employees");

                    b.Navigation("MessagingGroup");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("ERP.Core.Entities.Task", b =>
                {
                    b.HasOne("ERP.Core.Entities.Employee", "Owner")
                        .WithMany("OwnedTasks")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_OwnedTasks_Employees");

                    b.HasOne("ERP.Core.Entities.CompanyToDepartment", "CompanyToDepartment")
                        .WithMany("Tasks")
                        .HasForeignKey("CompanyId", "DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_CompaniesToDepartments_Tasks");

                    b.Navigation("CompanyToDepartment");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("ERP.Core.Entities.TaskComment", b =>
                {
                    b.HasOne("ERP.Core.Entities.Employee", "Employee")
                        .WithMany("TaskComments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TaskComments_Employees");

                    b.HasOne("ERP.Core.Entities.Task", "Task")
                        .WithMany("TaskComments")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TaskComments_Tasks");

                    b.Navigation("Employee");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("ERP.Core.Entities.TaskEvaluation", b =>
                {
                    b.HasOne("ERP.Core.Entities.Employee", "Employee")
                        .WithMany("TaskEvaluations")
                        .HasForeignKey("EmployeeId")
                        .IsRequired()
                        .HasConstraintName("FK_TaskEvaluators_Employees");

                    b.HasOne("ERP.Core.Entities.Task", "Task")
                        .WithMany("TaskEvaluations")
                        .HasForeignKey("TaskId")
                        .IsRequired()
                        .HasConstraintName("FK_TaskEvaluators_Tasks");

                    b.Navigation("Employee");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("ERP.Core.Entities.TaskLiable", b =>
                {
                    b.HasOne("ERP.Core.Entities.Employee", "Employee")
                        .WithMany("TaskLiables")
                        .HasForeignKey("EmployeeId")
                        .IsRequired()
                        .HasConstraintName("FK_TaskLiables_Employees");

                    b.HasOne("ERP.Core.Entities.Task", "Task")
                        .WithMany("TaskLiables")
                        .HasForeignKey("TaskId")
                        .IsRequired()
                        .HasConstraintName("FK_TaskLiables_Tasks");

                    b.Navigation("Employee");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("ERP.Core.Entities.TaskMedia", b =>
                {
                    b.HasOne("ERP.Core.Entities.Task", "Task")
                        .WithMany("TaskMedias")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Tasks_TaskMedias");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("ERP.Core.Entities.TaskNotification", b =>
                {
                    b.HasOne("ERP.Core.Entities.Task", "Task")
                        .WithMany("TaskNotifications")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TaskNotifications_Tasks");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("ERP.Core.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("ERP.Core.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("ERP.Core.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("ERP.Core.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Core.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("ERP.Core.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ERP.Core.Entities.Company", b =>
                {
                    b.Navigation("CompaniesToDepartments");

                    b.Navigation("EmployeesToCompaines");

                    b.Navigation("MeetingsToCompanies");
                });

            modelBuilder.Entity("ERP.Core.Entities.CompanyToDepartment", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("ERP.Core.Entities.Department", b =>
                {
                    b.Navigation("CompaniesToDepartments");

                    b.Navigation("EmployeessToDepartments");
                });

            modelBuilder.Entity("ERP.Core.Entities.Employee", b =>
                {
                    b.Navigation("DailyWorks");

                    b.Navigation("EmployeesToCompaines");

                    b.Navigation("EmployeesToDepartments");

                    b.Navigation("EmployeesToMessagingGroups");

                    b.Navigation("MeetingsToEmployees");

                    b.Navigation("Messages");

                    b.Navigation("OwnedTasks");

                    b.Navigation("TaskComments");

                    b.Navigation("TaskEvaluations");

                    b.Navigation("TaskLiables");
                });

            modelBuilder.Entity("ERP.Core.Entities.Meeting", b =>
                {
                    b.Navigation("MeetingsToCompanies");

                    b.Navigation("MeetingsToEmployees");
                });

            modelBuilder.Entity("ERP.Core.Entities.MessagingGroup", b =>
                {
                    b.Navigation("EmployeesToMessagingGroups");

                    b.Navigation("Messages");
                });

            modelBuilder.Entity("ERP.Core.Entities.Task", b =>
                {
                    b.Navigation("DailyWorks");

                    b.Navigation("TaskComments");

                    b.Navigation("TaskEvaluations");

                    b.Navigation("TaskLiables");

                    b.Navigation("TaskMedias");

                    b.Navigation("TaskNotifications");
                });

            modelBuilder.Entity("ERP.Core.Entities.TaskComment", b =>
                {
                    b.Navigation("CommentMedias");
                });
#pragma warning restore 612, 618
        }
    }
}
