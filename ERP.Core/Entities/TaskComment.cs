using System;
using System.Collections.Generic;

namespace ERP.Core.Entities;

public partial class TaskComment
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public int TaskId { get; set; }

    public virtual Task Task { get; set; }

    public virtual ICollection<CommentMedia> CommentMedias { get; } = new List<CommentMedia>();

    public virtual Employee Employee { get; set; }
}