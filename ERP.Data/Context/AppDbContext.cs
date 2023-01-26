using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ERP.Core.Entities;

namespace ERP.Core.Entities.asdasd;

public class AppDbContext : IdentityDbContext<Employee, AppRole, int>
{
	public AppDbContext(DbContextOptions<AppDbContext> options)
		: base(options)
	{

	}

	public virtual DbSet<Announcement> Announcements { get; set; }
	public virtual DbSet<Company> Companies { get; set; }
	public virtual DbSet<CompanyToDepartment> CompaniesToDepartments { get; set; }
	public virtual DbSet<DailyWork> DailyWorks { get; set; }
	public virtual DbSet<Department> Departments { get; set; }
	public virtual DbSet<EmployeeToCompany> EmployeesToCompanies { get; set; }
	public virtual DbSet<Message> Messages { get; set; }
	public virtual DbSet<MessagingGroup> MessagingGroups { get; set; }
	public virtual DbSet<Meeting> Meetings { get; set; }
	public virtual DbSet<MeetingToCompany> MeetingsToCompanies{ get; set; }
	public virtual DbSet<MeetingToEmployee> MeetingsToEmployees { get; set; }
	public virtual DbSet<TaskComment> TaskComments { get; set; }
	public virtual DbSet<TaskEvaluation> TaskEvaluations { get; set; }
	public virtual DbSet<TaskLiable> TaskLiables { get; set; }
	public virtual DbSet<CommentMedia> CommentMedias { get; set; }
	public virtual DbSet<TaskNotification> TaskNotifications { get; set; }
	public virtual DbSet<Task> Tasks { get; set; }
	public virtual DbSet<TaskMedia> TaskMedias { get; set; }
	public virtual DbSet<EmployeeToDepartment> EmployeesToDepartments { get; set; }
	public virtual DbSet<EmployeeToMessagingGroup> EmployeesToMessagingGroups { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<Announcement>(entity =>
		{

		});

		modelBuilder.Entity<Employee>(entity =>
		{
			entity.ToTable("Employees");
		});



		modelBuilder.Entity<Company>(entity =>
		{

		});

		modelBuilder.Entity<CompanyToDepartment>(entity =>
		{
			entity.HasKey(e => new { e.CompanyId, e.DepartmentId });

			entity.HasOne(d => d.Company).WithMany(p => p.CompaniesToDepartments)
				.HasForeignKey(d => d.CompanyId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_CompaniesToDepartments_Companies");

			entity.HasOne(d => d.Department).WithMany(p => p.CompaniesToDepartments)
				.HasForeignKey(d => d.DepartmentId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_CompaniesToDepartments_Departments");

			
		});

		modelBuilder.Entity<DailyWork>(entity =>
		{
			entity.HasOne(d => d.Employee).WithMany(p => p.DailyWorks)
				.HasForeignKey(d => d.EmployeeId)
				.HasConstraintName("FK_DailyWorks_Employees");

			entity.HasOne(d => d.Task).WithMany(p => p.DailyWorks)
			 .HasForeignKey(d => d.TaskId)
			 .IsRequired(false)
			 .HasConstraintName("FK_DailyWorks_Tasks");
		});

		modelBuilder.Entity<Department>(entity =>
		{

		});


		modelBuilder.Entity<EmployeeToCompany>(entity =>
		{
			entity.HasKey(e => new { e.EmployeeId, e.CompanyId });

			entity.HasOne(d => d.Employee).WithMany(p => p.EmployeesToCompaines)
			   .HasForeignKey(d => d.EmployeeId)
			   .HasConstraintName("FK_EmployeesToCompaines_Employees");


			entity.HasOne(d => d.Company).WithMany(p => p.EmployeesToCompaines)
			   .HasForeignKey(d => d.CompanyId)
			   .HasConstraintName("FK_EmployeesToCompaines_Compaines");
		});

		modelBuilder.Entity<Message>(entity =>
		{
			entity.HasOne(d => d.MessagingGroup).WithMany(p => p.Messages)
				.HasForeignKey(d => d.MessagingGroupId)
				.HasConstraintName("FK_Messages_MessagingGroups");

			entity.HasOne(d => d.Sender).WithMany(p => p.Messages)
				.HasForeignKey(d => d.SenderEmployeeId)
				.HasConstraintName("FK_Messages_Employees");
		});



		modelBuilder.Entity<Meeting>(entity =>
		{

		});


		modelBuilder.Entity<MeetingToCompany>(entity =>
		{
			entity.HasKey(e => new { e.MeetingId, e.CompanyId });

			entity.HasOne(d => d.Meeting).WithMany(p => p.MeetingsToCompanies)
				.HasForeignKey(d => d.MeetingId)
				.HasConstraintName("FK_MeetingsToCompaines_Meetings");


			entity.HasOne(d => d.Company).WithMany(p => p.MeetingsToCompanies)
				.HasForeignKey(d => d.CompanyId)
				.HasConstraintName("FK_MeetingsToCompaines_Companies");
		});

		modelBuilder.Entity<MeetingToEmployee>(entity =>
		{
			entity.HasKey(e => new { e.MeetingId, e.EmployeeId });

			entity.HasOne(d => d.Meeting).WithMany(p => p.MeetingsToEmployees)
			   .HasForeignKey(d => d.MeetingId)
			   .HasConstraintName("FK_MeetingsToEmployees_Meetings");


			entity.HasOne(d => d.Employee).WithMany(p => p.MeetingsToEmployees)
			   .HasForeignKey(d => d.EmployeeId)
			   .HasConstraintName("FK_MeetingsToEmployees_Employees");
		});

		modelBuilder.Entity<MessagingGroup>(entity =>
		{

		});



		modelBuilder.Entity<TaskComment>(entity =>
		{
			entity.HasOne(d => d.Task).WithMany(p => p.TaskComments)
				.HasForeignKey(d => d.TaskId)
				.HasConstraintName("FK_TaskComments_Tasks");

			entity.HasOne(d => d.Employee).WithMany(p => p.TaskComments)
				.HasForeignKey(d => d.EmployeeId)
				.HasConstraintName("FK_TaskComments_Employees");

			entity.HasMany(d => d.CommentMedias).WithOne(p => p.TaskComment)
			  .HasForeignKey(d => d.TaskCommentId)
			  .HasConstraintName("FK_TaskComments_CommentMedias");
		});

		modelBuilder.Entity<TaskEvaluation>(entity =>
		{
			entity.HasKey(e => new { e.TaskId, e.EmployeeId });



			entity.HasOne(d => d.Task).WithMany(p => p.TaskEvaluations)
				.HasForeignKey(d => d.TaskId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_TaskEvaluators_Tasks");

			entity.HasOne(d => d.Employee).WithMany(p => p.TaskEvaluations)
				.HasForeignKey(d => d.EmployeeId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_TaskEvaluators_Employees");
		});

		modelBuilder.Entity<TaskLiable>(entity =>
		{

			entity.HasKey(e => new { e.TaskId, e.EmployeeId });

			entity.HasOne(d => d.Task).WithMany(p => p.TaskLiables)
				.HasForeignKey(d => d.TaskId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_TaskLiables_Tasks");

			entity.HasOne(d => d.Employee).WithMany(p => p.TaskLiables)
				.HasForeignKey(d => d.EmployeeId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_TaskLiables_Employees");

		});
		modelBuilder.Entity<CommentMedia>(entity =>
		{

		});

		modelBuilder.Entity<TaskNotification>(entity =>
		{
			

			entity.HasOne(d => d.Task).WithMany(p => p.TaskNotifications)
				.HasForeignKey(d => d.TaskId)
				.HasConstraintName("FK_TaskNotifications_Tasks");
		});

		modelBuilder.Entity<Task>(entity =>
		{

			entity.HasOne(d => d.CompanyToDepartment).WithMany(p => p.Tasks)
			.HasForeignKey(d => new { d.CompanyId, d.DepartmentId })
	
			.HasConstraintName("FK_CompaniesToDepartments_Tasks");

			entity.HasOne(d => d.Owner).WithMany(p => p.OwnedTasks)
				.HasForeignKey(d => d.OwnerId)
				.OnDelete(DeleteBehavior.NoAction)
				.HasConstraintName("FK_OwnedTasks_Employees");

			entity.HasMany(d => d.TaskMedias).WithOne(p => p.Task)
				.HasForeignKey(d => d.TaskId)

				.HasConstraintName("FK_Tasks_TaskMedias");
		});

		modelBuilder.Entity<EmployeeToDepartment>(entity =>
		{

			entity.HasOne(d => d.Employee).WithMany(p => p.EmployeesToDepartments)
			.HasForeignKey(d => d.DeparmentId)
			  .OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_EmployeesToDepartments_Employees");
		});

		modelBuilder.Entity<EmployeeToMessagingGroup>(entity =>
		{
			entity.HasKey(e => new { e.MessagingGroupId, e.EmployeeId });

			entity.HasOne(d => d.MessagingGroup).WithMany(p => p.EmployeesToMessagingGroups)
				.HasForeignKey(d => d.MessagingGroupId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_EmployeesToMessagingGroups_MessagingGroups");

			entity.HasOne(d => d.Employee).WithMany(p => p.EmployeesToMessagingGroups)
				.HasForeignKey(d => d.EmployeeId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_EmployeesToMessagingGroups_Employees");
		});


	}


}