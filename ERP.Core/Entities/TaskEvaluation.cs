using System;
using System.Collections.Generic;

namespace ERP.Core.Entities;

public partial class TaskEvaluation
{
    public int TaskId { get; set; }

    public int EmployeeId { get; set; }

    public string? EvaluationStatus { get; set; }

    public int EvaluationOrder { get; set; }

	public int EvaluationDescription { get; set; }

	public virtual Task Task { get; set; }

    public virtual Employee Employee { get; set; }
}