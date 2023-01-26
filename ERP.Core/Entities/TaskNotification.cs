using System;
using System.Collections.Generic;

namespace ERP.Core.Entities;

public partial class TaskNotification
{
    public int Id { get; set; }

    public int TaskId { get; set; }

    public string? TaskForEnum { get; set; }

    public virtual Task Task { get; set; }
}