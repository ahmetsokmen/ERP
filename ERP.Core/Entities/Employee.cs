using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using static ERP.Core.Entities.Enums;

namespace ERP.Core.Entities;

public partial class Employee : IdentityUser<int>
{
	public string Name { get; set; }
	public string Surname { get; set; }
	public EmployeeStatus EmployeeStatus { get; set; }
	public Gender Gender { get; set; }
	public DateTime? BirthDay { get; set; }
	public DateTime RegisterDate { get; set; }
	public DateTime WorkStartDate { get; set; }
	public DateTime? WorkEndDate { get; set; }
	public DateTime LastSeen { get; set; }

	public string? Description { get; set; }
	public string? Information { get; set; }



	public virtual ICollection<Task> OwnedTasks { get; } = new List<Task>();

	public virtual ICollection<MeetingToEmployee> MeetingsToEmployees { get; } = new List<MeetingToEmployee>();

	public virtual ICollection<EmployeeToCompany> EmployeesToCompaines { get; } = new List<EmployeeToCompany>();

	public virtual ICollection<DailyWork> DailyWorks { get; } = new List<DailyWork>();

	public virtual ICollection<Message> Messages { get; } = new List<Message>();

	public virtual ICollection<TaskComment> TaskComments { get; } = new List<TaskComment>();

	public virtual ICollection<TaskEvaluation> TaskEvaluations { get; } = new List<TaskEvaluation>();

	public virtual ICollection<TaskLiable> TaskLiables { get; } = new List<TaskLiable>();

	public virtual ICollection<EmployeeToMessagingGroup> EmployeesToMessagingGroups { get; } = new List<EmployeeToMessagingGroup>();

	public virtual ICollection<EmployeeToDepartment> EmployeesToDepartments { get; } = new List<EmployeeToDepartment>();



}