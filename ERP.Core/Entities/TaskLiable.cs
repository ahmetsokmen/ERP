using System;
using System.Collections.Generic;

namespace ERP.Core.Entities;

public partial class TaskLiable
{
    public int EmployeeId { get; set; }

    public int TaskId { get; set; }

	public virtual Task Task { get; set; }

	public virtual Employee Employee { get; set; }
}