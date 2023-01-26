using System;
using System.Collections.Generic;
using static ERP.Core.Entities.Enums;

namespace ERP.Core.Entities;

public partial class Task
{
    public int Id { get; set; }

	public string? Name { get; set; }
	public CRMTaskStatus TaskStatus { get; set; }
	public DateTime? PlannedStartDate { get; set; }
	public DateTime? PlannedEndDate { get; set; }
	public DateTime? RealStartDate { get; set; }
	public DateTime? RealEndDate { get; set; }
	public Priority Priority { get; set; }
	public string? Description { get; set; }
	public string? Information { get; set; }


	public int DepartmentId { get; set; }
    public int CompanyId { get; set; }
	public int? OwnerId { get; set; }


	public virtual CompanyToDepartment CompanyToDepartment { get; set; }

	public virtual Employee Owner { get; set; }




	public virtual ICollection<DailyWork> DailyWorks { get; } = new List<DailyWork>();
	public virtual ICollection<TaskComment> TaskComments { get; } = new List<TaskComment>();
	public virtual ICollection<TaskMedia> TaskMedias { get; } = new List<TaskMedia>();
	public virtual ICollection<TaskEvaluation> TaskEvaluations { get; } = new List<TaskEvaluation>();
	public virtual ICollection<TaskLiable> TaskLiables { get; } = new List<TaskLiable>();
    public virtual ICollection<TaskNotification> TaskNotifications { get; } = new List<TaskNotification>();

}